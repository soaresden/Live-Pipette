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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Live.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.R1.Location = New System.Drawing.Point(240, 18)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(33, 22)
        Me.R1.TabIndex = 1
        Me.R1.Text = "255"
        '
        'G1
        '
        Me.G1.Location = New System.Drawing.Point(240, 44)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(33, 22)
        Me.G1.TabIndex = 2
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(240, 69)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(33, 22)
        Me.B1.TabIndex = 3
        '
        'SavePixel
        '
        Me.SavePixel.Location = New System.Drawing.Point(82, 207)
        Me.SavePixel.Name = "SavePixel"
        Me.SavePixel.Size = New System.Drawing.Size(163, 23)
        Me.SavePixel.TabIndex = 4
        Me.SavePixel.Text = "Save : CTRL+ALT+P"
        Me.SavePixel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Green"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 69)
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
        Me.X1.Location = New System.Drawing.Point(92, 21)
        Me.X1.Name = "X1"
        Me.X1.Size = New System.Drawing.Size(66, 22)
        Me.X1.TabIndex = 8
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
        Me.Y1.Location = New System.Drawing.Point(92, 49)
        Me.Y1.Name = "Y1"
        Me.Y1.Size = New System.Drawing.Size(66, 22)
        Me.Y1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Web"
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
        Me.Color1.Location = New System.Drawing.Point(43, 263)
        Me.Color1.Multiline = True
        Me.Color1.Name = "Color1"
        Me.Color1.Size = New System.Drawing.Size(49, 39)
        Me.Color1.TabIndex = 13
        '
        'Live
        '
        Me.Live.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Live.Controls.Add(Me.WEB1)
        Me.Live.Controls.Add(Me.SaveColor)
        Me.Live.Controls.Add(Me.Label6)
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
        Me.Live.Location = New System.Drawing.Point(29, 79)
        Me.Live.Name = "Live"
        Me.Live.Size = New System.Drawing.Size(279, 122)
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
        Me.SaveWeb.Location = New System.Drawing.Point(121, 280)
        Me.SaveWeb.Name = "SaveWeb"
        Me.SaveWeb.Size = New System.Drawing.Size(187, 22)
        Me.SaveWeb.TabIndex = 16
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(178, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Saved Color"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(72, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 45)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "LIVE PIPETTE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PictureBox1.Image = Global.PipetteLive.My.Resources.Resources.pipette
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
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
        Me.GroupBox1.Size = New System.Drawing.Size(335, 66)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(336, 315)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Color1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SaveWeb)
        Me.Controls.Add(Me.Live)
        Me.Controls.Add(Me.SavePixel)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Live Pipette v1"
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
