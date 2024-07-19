Public Class Form1
    Private Const DESKTOPVERTRES As Integer = &H75
    Private Const DESKTOPHORZRES As Integer = &H76

    <Runtime.InteropServices.DllImport("gdi32.dll")>
    Private Shared Function GetDeviceCaps(ByVal hdc As IntPtr, ByVal nIndex As Integer) As Integer
    End Function

    ' Enumération définissant l'état des touches CTRL, SHIFT, ALT et WIN
    Enum FsModifiers
        None = 0 ' Aucune touche
        Alt = 1
        Control = 2
        Shift = 4
        Windows = 8
        Alt_Ctrl = 3
        Alt_Shift = 5
        Alt_Windows = 9
        Ctrl_Shift = 6
        Ctrl_Windows = 10
        Shift_Windows = 12
        No_Repeat = 16384 ' Indisponible sous Vista/XP/2000
    End Enum

    ' Déclaration des API
    ' handle = handle de la fenêtre qui gérera le raccourci
    ' id = identifiant qu'on se choisit pour notre hotkey
    ' fsModifier : un type FsModifiers (enum)
    ' vk : le code clé correspondant à la touche
    Declare Auto Function RegisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Integer, ByVal fsModifier As FsModifiers, ByVal vk As Keys) As Boolean

    ' handle : handle de l'application qui gère le raccourci
    ' id : l'identifiant du raccourci
    Declare Auto Function UnregisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Integer) As Integer

    ' On définit deux raccourcis :
    Private Const HOTKEY_ID1 As Integer = 571584 ' Numéros aléatoires
    Private Const HOTKEY_ID2 As Integer = 571585

    ' La constante WM_HOTKEY fournie par Microsoft
    Private Const WM_HOTKEY As Integer = 786

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OnTopAndShortcut()
    End Sub

    Private Sub OnTopAndShortcut()
        ' Always on top
        Me.TopMost = True
        Me.Opacity = 1

        ' On lance la Pipette 
        Timer1.Start()

        ' On définit les HotKeys
        RegisterHotKey(Me.Handle, HOTKEY_ID1, FsModifiers.Alt_Ctrl, Keys.P)
        RegisterHotKey(Me.Handle, HOTKEY_ID2, FsModifiers.Alt_Ctrl, Keys.O)
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Opacity = 0.3
            NotifyIcon1.Visible = True

            ' Generating Last Color text Balloon
            NotifyIcon1.Text = ""
            NotifyIcon1.Icon = My.Resources.pipette1
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "PipetteLive"

            ' Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        ' Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
        Call Me.OnTopAndShortcut()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Getting DPI and resolution
        Dim g As Graphics = Graphics.FromHwnd(IntPtr.Zero)
        Dim hdc As IntPtr = g.GetHdc
        Dim dpiX As Integer = GetDeviceCaps(hdc, DESKTOPHORZRES)
        Dim dpiY As Integer = GetDeviceCaps(hdc, DESKTOPVERTRES)
        g.ReleaseHdc(hdc)

        ' Calculating the Real ScreenSize
        Dim RealHoriz As Integer = dpiX
        Dim RealVerti As Integer = dpiY

        ' Showing Variables
        Dim myBmp As New Bitmap(RealHoriz, RealVerti)
        Dim h As Graphics = Graphics.FromImage(myBmp)
        h.CopyFromScreen(Point.Empty, Point.Empty, myBmp.Size)
        h.Dispose()

        ' Adjust mouse coordinates for DPI
        Dim mouseX As Integer = CInt(MousePosition.X * (RealHoriz / Screen.PrimaryScreen.Bounds.Width))
        Dim mouseY As Integer = CInt(MousePosition.Y * (RealVerti / Screen.PrimaryScreen.Bounds.Height))

        ' Ensure coordinates are within bounds
        mouseX = Math.Max(0, Math.Min(mouseX, RealHoriz - 1))
        mouseY = Math.Max(0, Math.Min(mouseY, RealVerti - 1))

        ' Get pixel color
        Color1.BackColor = myBmp.GetPixel(mouseX, mouseY)
        myBmp.Dispose()

        R1.Text = Format(Color1.BackColor.R, "000")
        G1.Text = Format(Color1.BackColor.G, "000")
        B1.Text = Format(Color1.BackColor.B, "000")

        Dim Re As Integer = Integer.Parse(R1.Text)
        Dim Gr As Integer = Integer.Parse(G1.Text)
        Dim Bl As Integer = Integer.Parse(B1.Text)
        Dim hexValue As String = String.Format("{0}{1}{2}", Re.ToString("X2"), Gr.ToString("X2"), Bl.ToString("X2"))

        WEB1.Text = "#" & hexValue
    End Sub

    Private Sub SavePixel()
        ' Ajouter la couleur à la ListView
        AddColorToListView(R1.Text, G1.Text, B1.Text, WEB1.Text)

        ' Copier la valeur hexadécimale dans le presse-papiers
        Clipboard.SetText(WEB1.Text)
    End Sub

    Private Sub AddColorToListView(ByVal r As String, ByVal g As String, ByVal b As String, ByVal hex As String)
        Dim lvi As New ListViewItem(r)
        lvi.SubItems.Add(g)
        lvi.SubItems.Add(b)
        lvi.SubItems.Add(hex)
        ListView1.Items.Add(lvi)
    End Sub

    'WndProc nous permettra de traiter les messages windows
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg ' On va tester le message reçu à chaque appel de cette fonction
            Case WM_HOTKEY ' Si il s'agit du message WM_HOTKEY (si l'utilisateur a appuyé sur les touches)
                If m.WParam = HOTKEY_ID1 Then ' On cherche quelle hotkey a déclenché l'évènement
                    SavePixel()
                ElseIf m.WParam = HOTKEY_ID2 Then
                    ' Ajouter ici d'autres actions si nécessaire
                End If
        End Select
        MyBase.WndProc(m)
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        On Error Resume Next
        Me.Opacity = 0.3
        On Error GoTo 0
    End Sub

    Private Sub CopySelectedItemsToClipboard()
        Dim sb As New System.Text.StringBuilder()

        ' Parcourir tous les éléments sélectionnés de la ListView
        For Each item As ListViewItem In ListView1.SelectedItems
            sb.AppendLine(String.Join(vbTab, item.SubItems.Cast(Of ListViewItem.ListViewSubItem).Select(Function(subItem) subItem.Text)))
        Next

        ' Copier les données dans le presse-papiers
        Clipboard.SetText(sb.ToString())
    End Sub

    Private Sub DeleteListview_Click(sender As Object, e As EventArgs) Handles DeleteListview.Click
        ' Supprimer les éléments sélectionnés
        For Each item As ListViewItem In ListView1.SelectedItems
            ListView1.Items.Remove(item)
        Next
    End Sub

    Private Sub CopyToClipboard_Click(sender As Object, e As EventArgs) Handles CopyToClipboard.Click
        CopySelectedItemsToClipboard()
    End Sub
End Class
