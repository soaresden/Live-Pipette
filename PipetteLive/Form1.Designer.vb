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
        Me.SavePixel = New System.Windows.Forms.Button()
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
        Me.SaveColor = New System.Windows.Forms.TextBox()
        Me.SaveWeb = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SavedR = New System.Windows.Forms.TextBox()
        Me.SavedG = New System.Windows.Forms.TextBox()
        Me.SavedB = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Live.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'WEB1
        '
        Me.WEB1.Location = New System.Drawing.Point(92, 92)
        Me.WEB1.Name = "WEB1"
        Me.WEB1.Size = New System.Drawing.Size(181, 22)
        Me.WEB1.TabIndex = 0
        '
        'R1
        '
        Me.R1.Location = New System.Drawing.Point(332, 18)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(33, 22)
        Me.R1.TabIndex = 1
        Me.R1.Text = "255"
        Me.R1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'G1
        '
        Me.G1.Location = New System.Drawing.Point(332, 44)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(33, 22)
        Me.G1.TabIndex = 2
        Me.G1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(332, 69)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(33, 22)
        Me.B1.TabIndex = 3
        Me.B1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SavePixel
        '
        Me.SavePixel.Location = New System.Drawing.Point(123, 207)
        Me.SavePixel.Name = "SavePixel"
        Me.SavePixel.Size = New System.Drawing.Size(173, 50)
        Me.SavePixel.TabIndex = 4
        Me.SavePixel.Text = "Save Color " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CTRL+ALT+P"
        Me.SavePixel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(295, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(281, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Green"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(293, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Blue"
        '
        'Timer1
        '
        '
        'X1
        '
        Me.X1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.X1.Location = New System.Drawing.Point(92, 21)
        Me.X1.Name = "X1"
        Me.X1.Size = New System.Drawing.Size(66, 22)
        Me.X1.TabIndex = 8
        Me.X1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "X"
        '
        'Y1
        '
        Me.Y1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Y1.Location = New System.Drawing.Point(92, 49)
        Me.Y1.Name = "Y1"
        Me.Y1.Size = New System.Drawing.Size(66, 22)
        Me.Y1.TabIndex = 10
        Me.Y1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "WebCode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Y"
        '
        'Color1
        '
        Me.Color1.Location = New System.Drawing.Point(14, 24)
        Me.Color1.Multiline = True
        Me.Color1.Name = "Color1"
        Me.Color1.Size = New System.Drawing.Size(49, 39)
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
        Me.Live.Location = New System.Drawing.Point(12, 79)
        Me.Live.Name = "Live"
        Me.Live.Size = New System.Drawing.Size(381, 122)
        Me.Live.TabIndex = 14
        Me.Live.TabStop = False
        Me.Live.Text = "Actual Mouse Values"
        '
        'SaveColor
        '
        Me.SaveColor.Location = New System.Drawing.Point(14, 21)
        Me.SaveColor.Multiline = True
        Me.SaveColor.Name = "SaveColor"
        Me.SaveColor.Size = New System.Drawing.Size(49, 39)
        Me.SaveColor.TabIndex = 15
        '
        'SaveWeb
        '
        Me.SaveWeb.BackColor = System.Drawing.SystemColors.Info
        Me.SaveWeb.Location = New System.Drawing.Point(72, 38)
        Me.SaveWeb.Name = "SaveWeb"
        Me.SaveWeb.Size = New System.Drawing.Size(173, 22)
        Me.SaveWeb.TabIndex = 16
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
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(129, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 45)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "LIVE PIPETTE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PictureBox1.Image = Global.LivePipette.My.Resources.Resources.pipette
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 66)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'SavedR
        '
        Me.SavedR.BackColor = System.Drawing.SystemColors.Info
        Me.SavedR.Location = New System.Drawing.Point(332, 15)
        Me.SavedR.Name = "SavedR"
        Me.SavedR.Size = New System.Drawing.Size(33, 22)
        Me.SavedR.TabIndex = 21
        '
        'SavedG
        '
        Me.SavedG.BackColor = System.Drawing.SystemColors.Info
        Me.SavedG.Location = New System.Drawing.Point(332, 43)
        Me.SavedG.Name = "SavedG"
        Me.SavedG.Size = New System.Drawing.Size(33, 22)
        Me.SavedG.TabIndex = 22
        '
        'SavedB
        '
        Me.SavedB.BackColor = System.Drawing.SystemColors.Info
        Me.SavedB.Location = New System.Drawing.Point(332, 67)
        Me.SavedB.Name = "SavedB"
        Me.SavedB.Size = New System.Drawing.Size(33, 22)
        Me.SavedB.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.SavedB)
        Me.GroupBox2.Controls.Add(Me.SaveColor)
        Me.GroupBox2.Controls.Add(Me.SaveWeb)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.SavedG)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.SavedR)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 94)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saved Color"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(295, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Red"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Lime
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(281, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Green"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Blue
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(293, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Blue"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(413, 366)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Live)
        Me.Controls.Add(Me.SavePixel)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Live Pipette v1.2"
        Me.Live.ResumeLayout(False)
        Me.Live.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WEB1 As TextBox
    Friend WithEvents R1 As TextBox
    Friend WithEvents G1 As TextBox
    Friend WithEvents B1 As TextBox
    Friend WithEvents SavePixel As Button
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
    Friend WithEvents SaveColor As TextBox
    Friend WithEvents SaveWeb As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SavedR As TextBox
    Friend WithEvents SavedG As TextBox
    Friend WithEvents SavedB As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
