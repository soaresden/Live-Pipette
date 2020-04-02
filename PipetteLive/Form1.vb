Public Class Form1
    Private Const DESKTOPVERTRES As Integer = &H75
    Private Const DESKTOPHORZRES As Integer = &H76
    <Runtime.InteropServices.DllImport("gdi32.dll")> Private Shared Function GetDeviceCaps(ByVal hdc As IntPtr, ByVal nIndex As Integer) As Integer
    End Function


    'enumération définissant l'état des touches CTRL, SHIFT, ALT et WIN
    Enum FsModifiers
        None = 0 'aucune touche
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
        No_Repeat = 16384 'indisponible sous Vista/XP/2000
    End Enum
    'Déclaration des API
    'handle = handle de la fenêtre qui gérera le raccourci
    'id = identifiant qu'on se choisit pour notre hotkey
    'fsModifier : un type FsModifiers (enum)
    'vk : le code clé correspondant à la touche
    Declare Auto Function RegisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Integer, ByVal fsModifier As FsModifiers, ByVal vk As Keys) As Boolean

    'handle : handle de l'application qui gère le raccourci
    'id : l'identifiant du raccourci
    Declare Auto Function UnregisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Integer) As Integer

    'on définit deux raccourcis :
    Private Const HOTKEY_ID1 As Integer = 571584 'numéros aléatoires
    Private Const HOTKEY_ID2 As Integer = 571585

    'la constante WM_HOTKEY fournir par Microsoft
    Private Const WM_HOTKEY As Integer = 786


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Always on top
        Me.TopMost = True
        Me.Opacity = 1

        'On lance la Pipette 
        Timer1.Start()

        'On définit les HotKeys
        RegisterHotKey(Me.Handle, HOTKEY_ID1, FsModifiers.Alt_Ctrl, Keys.P)
        RegisterHotKey(Me.Handle, HOTKEY_ID2, FsModifiers.Alt_Ctrl, Keys.O)
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Opacity = 0.1
            NotifyIcon1.Visible = True

            'Generating Last Color text Balloon
            Dim Lastcolor As String = "Last Color :" & SaveWeb.Text

            NotifyIcon1.Text = Lastcolor
            NotifyIcon1.Icon = My.Resources.pipette1
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "PipetteLive"
            NotifyIcon1.BalloonTipText = Lastcolor
            NotifyIcon1.ShowBalloonTip(30000)

            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Getting DPI and resolution
        Dim g As Graphics = Graphics.FromHwnd(IntPtr.Zero)
        Dim hdc As IntPtr = g.GetHdc
        Dim TrueScreenSize As New Size(GetDeviceCaps(hdc, DESKTOPHORZRES), GetDeviceCaps(hdc, DESKTOPVERTRES))
        Dim sclX As Single = CSng(Math.Round((TrueScreenSize.Width / Screen.FromControl(Me).Bounds.Width), 2))
        Dim sclY As Single = CSng(Math.Round((TrueScreenSize.Height / Screen.FromControl(Me).Bounds.Height), 2))
        g.ReleaseHdc(hdc)

            'Calculating the Real ScreenSize
            Dim RealHoriz As Integer = TrueScreenSize.Width.ToString
            Dim RealVerti As Integer = TrueScreenSize.Height.ToString

            Dim DPI As String = RealHoriz / Screen.PrimaryScreen.Bounds.Width

            'Showing Variables
            Dim myBmp As New Bitmap(RealHoriz, RealVerti)
            Dim h As Graphics = Graphics.FromImage(myBmp)
            h.CopyFromScreen(Point.Empty, Point.Empty, myBmp.Size)
            h.Dispose()


            X1.Text = Format((MousePosition.X.ToString * DPI), "0000.00")
            Y1.Text = Format((MousePosition.Y.ToString * DPI), "0000.00")
            Color1.BackColor = myBmp.GetPixel((MousePosition.X * DPI), (MousePosition.Y * DPI))
            myBmp.Dispose()

        R1.Text = Format(Color1.BackColor.R, "000")
        G1.Text = Format(Color1.BackColor.G, "000")
        B1.Text = Format(Color1.BackColor.B, "000")

        Dim Re As Integer = Integer.Parse(R1.Text)
        Dim Gr As Integer = Integer.Parse(G1.Text)
        Dim Bl As Integer = Integer.Parse(B1.Text)
        Dim hexValue As String = String.Format("{0}{1}{2}", Re.ToString("X").PadLeft(2, "0"), Gr.ToString("X").PadLeft(2, "0"), Bl.ToString("X").PadLeft(2, "0"))


        WEB1.Text = "#" & hexValue

    End Sub
    Private Sub SavePixel_Click(sender As Object, e As EventArgs) Handles SavePixel.Click
        SaveColor.BackColor = Color1.BackColor
        SaveWeb.Text = WEB1.Text
        Clipboard.SetText(WEB1.Text)
    End Sub


    'WndProc nous permettra de traiter les messages windows
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg 'on va tester le message reçu à chaque appel de cette fonction
            Case WM_HOTKEY 'si il s'agit du message WM_HOTKEY (si l'utilisateur a appuyé sur les touches)

                If m.WParam = HOTKEY_ID1 Then 'on cherche quelle hotkey a déclenché l'évènement
                    Me.SavePixel.PerformClick()


                ElseIf m.WParam = HOTKEY_ID2 Then


                End If
        End Select
        MyBase.WndProc(m)
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        On Error Resume Next
        Me.Opacity = 0.2
        On Error GoTo 0
    End Sub

End Class
