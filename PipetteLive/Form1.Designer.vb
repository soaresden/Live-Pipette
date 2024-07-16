<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.WEB1 = New System.Windows.Forms.TextBox()
        Me.R1 = New System.Windows.Forms.TextBox()
        Me.G1 = New System.Windows.Forms.TextBox()
        Me.B1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.X1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Y1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Color1 = New System.Windows.Forms.TextBox()
        Me.Live = New System.Windows.Forms.GroupBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CopyToClipboard = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DeleteListview = New System.Windows.Forms.Button()
        Me.Live.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WEB1
        '
        Me.WEB1.Location = New System.Drawing.Point(2, 264)
        Me.WEB1.Margin = New System.Windows.Forms.Padding(2)
        Me.WEB1.Name = "WEB1"
        Me.WEB1.Size = New System.Drawing.Size(143, 20)
        Me.WEB1.TabIndex = 0
        Me.WEB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R1
        '
        Me.R1.Location = New System.Drawing.Point(66, 124)
        Me.R1.Margin = New System.Windows.Forms.Padding(2)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(26, 20)
        Me.R1.TabIndex = 1
        Me.R1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G1
        '
        Me.G1.Location = New System.Drawing.Point(66, 148)
        Me.G1.Margin = New System.Windows.Forms.Padding(2)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(26, 20)
        Me.G1.TabIndex = 2
        Me.G1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(66, 172)
        Me.B1.Margin = New System.Windows.Forms.Padding(2)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(26, 20)
        Me.B1.TabIndex = 3
        Me.B1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 126)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(28, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Green"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(37, 172)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Blue"
        '
        'Timer1
        '
        '
        'X1
        '
        Me.X1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.X1.Location = New System.Drawing.Point(95, 22)
        Me.X1.Margin = New System.Windows.Forms.Padding(2)
        Me.X1.Name = "X1"
        Me.X1.Size = New System.Drawing.Size(50, 20)
        Me.X1.TabIndex = 8
        Me.X1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "X"
        '
        'Y1
        '
        Me.Y1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Y1.Location = New System.Drawing.Point(95, 46)
        Me.Y1.Margin = New System.Windows.Forms.Padding(2)
        Me.Y1.Name = "Y1"
        Me.Y1.Size = New System.Drawing.Size(50, 20)
        Me.Y1.TabIndex = 10
        Me.Y1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "WebCode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 45)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Y"
        '
        'Color1
        '
        Me.Color1.Location = New System.Drawing.Point(10, 20)
        Me.Color1.Margin = New System.Windows.Forms.Padding(2)
        Me.Color1.Multiline = True
        Me.Color1.Name = "Color1"
        Me.Color1.Size = New System.Drawing.Size(61, 56)
        Me.Color1.TabIndex = 13
        '
        'Live
        '
        Me.Live.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Live.Controls.Add(Me.WEB1)
        Me.Live.Controls.Add(Me.Label6)
        Me.Live.Controls.Add(Me.Color1)
        Me.Live.Controls.Add(Me.R1)
        Me.Live.Controls.Add(Me.Label5)
        Me.Live.Controls.Add(Me.G1)
        Me.Live.Controls.Add(Me.Y1)
        Me.Live.Controls.Add(Me.B1)
        Me.Live.Controls.Add(Me.Label4)
        Me.Live.Controls.Add(Me.Label1)
        Me.Live.Controls.Add(Me.X1)
        Me.Live.Controls.Add(Me.Label2)
        Me.Live.Controls.Add(Me.Label3)
        Me.Live.Location = New System.Drawing.Point(9, 64)
        Me.Live.Margin = New System.Windows.Forms.Padding(2)
        Me.Live.Name = "Live"
        Me.Live.Padding = New System.Windows.Forms.Padding(2)
        Me.Live.Size = New System.Drawing.Size(153, 288)
        Me.Live.TabIndex = 14
        Me.Live.TabStop = False
        Me.Live.Text = "Actual Mouse Values"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(62, 10)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(206, 31)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "LIVE PIPETTE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PictureBox1.Image = Global.LivePipette.My.Resources.Resources.pipette
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(293, 54)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(300, 6)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(190, 354)
        Me.ListView1.TabIndex = 25
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "R"
        Me.ColumnHeader1.Width = 35
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "G"
        Me.ColumnHeader2.Width = 35
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "B"
        Me.ColumnHeader3.Width = 35
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "WEB"
        Me.ColumnHeader4.Width = 69
        '
        'CopyToClipboard
        '
        Me.CopyToClipboard.Location = New System.Drawing.Point(178, 104)
        Me.CopyToClipboard.Name = "CopyToClipboard"
        Me.CopyToClipboard.Size = New System.Drawing.Size(116, 53)
        Me.CopyToClipboard.TabIndex = 26
        Me.CopyToClipboard.Text = "Copy Selection To ClipBoard"
        Me.CopyToClipboard.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(183, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "CTRL+ALT+P to REC"
        '
        'DeleteListview
        '
        Me.DeleteListview.Location = New System.Drawing.Point(178, 220)
        Me.DeleteListview.Name = "DeleteListview"
        Me.DeleteListview.Size = New System.Drawing.Size(116, 51)
        Me.DeleteListview.TabIndex = 27
        Me.DeleteListview.Text = "Delete Selected"
        Me.DeleteListview.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(495, 363)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DeleteListview)
        Me.Controls.Add(Me.CopyToClipboard)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Live)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Live Pipette v1.2"
        Me.Live.ResumeLayout(False)
        Me.Live.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WEB1 As TextBox
    Friend WithEvents R1 As TextBox
    Friend WithEvents G1 As TextBox
    Friend WithEvents B1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents X1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Y1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Color1 As TextBox
    Friend WithEvents Live As GroupBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CopyToClipboard As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Private WithEvents ListView1 As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents DeleteListview As Button
End Class
