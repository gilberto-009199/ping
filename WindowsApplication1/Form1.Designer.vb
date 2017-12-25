<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ip = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MASC4 = New System.Windows.Forms.TextBox()
        Me.MASC3 = New System.Windows.Forms.TextBox()
        Me.MASC2 = New System.Windows.Forms.TextBox()
        Me.MASC1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AltIPDaMaguinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExibirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltfonteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltcorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiretosAutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.White
        Me.ImageList1.Images.SetKeyName(0, "computer_add.png")
        Me.ImageList1.Images.SetKeyName(1, "stop-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "arrow_right.png")
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(76, 3)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(32, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IP DA REDE"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(236, 30)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(284, 342)
        Me.ListBox1.TabIndex = 5
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(5, 108)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(225, 264)
        Me.ListBox2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "EM USO:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ip)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.MASC4)
        Me.Panel1.Controls.Add(Me.MASC3)
        Me.Panel1.Controls.Add(Me.MASC2)
        Me.Panel1.Controls.Add(Me.MASC1)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ListBox2)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(523, 382)
        Me.Panel1.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageIndex = 1
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(76, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 39)
        Me.Button2.TabIndex = 21
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ip
        '
        Me.ip.Location = New System.Drawing.Point(142, 100)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(100, 20)
        Me.ip.TabIndex = 20
        Me.ip.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(150, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 39)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Mascara"
        '
        'MASC4
        '
        Me.MASC4.Location = New System.Drawing.Point(190, 29)
        Me.MASC4.MaxLength = 3
        Me.MASC4.Name = "MASC4"
        Me.MASC4.Size = New System.Drawing.Size(32, 20)
        Me.MASC4.TabIndex = 17
        '
        'MASC3
        '
        Me.MASC3.Location = New System.Drawing.Point(152, 29)
        Me.MASC3.MaxLength = 3
        Me.MASC3.Name = "MASC3"
        Me.MASC3.Size = New System.Drawing.Size(32, 20)
        Me.MASC3.TabIndex = 16
        '
        'MASC2
        '
        Me.MASC2.Location = New System.Drawing.Point(114, 29)
        Me.MASC2.MaxLength = 3
        Me.MASC2.Name = "MASC2"
        Me.MASC2.Size = New System.Drawing.Size(32, 20)
        Me.MASC2.TabIndex = 15
        '
        'MASC1
        '
        Me.MASC1.Location = New System.Drawing.Point(76, 29)
        Me.MASC1.MaxLength = 3
        Me.MASC1.Name = "MASC1"
        Me.MASC1.Size = New System.Drawing.Size(32, 20)
        Me.MASC1.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(190, 3)
        Me.TextBox4.MaxLength = 3
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(32, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(152, 3)
        Me.TextBox3.MaxLength = 3
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(32, 20)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 3)
        Me.TextBox2.MaxLength = 3
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(32, 20)
        Me.TextBox2.TabIndex = 11
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(236, 3)
        Me.ProgressBar1.Maximum = 429496729
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(284, 20)
        Me.ProgressBar1.TabIndex = 8
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "#PING"
        Me.NotifyIcon1.Visible = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltIPDaMaguinaToolStripMenuItem, Me.ExibirToolStripMenuItem, Me.DiretosAutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(544, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltIPDaMaguinaToolStripMenuItem
        '
        Me.AltIPDaMaguinaToolStripMenuItem.Name = "AltIPDaMaguinaToolStripMenuItem"
        Me.AltIPDaMaguinaToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.AltIPDaMaguinaToolStripMenuItem.Text = "Alt.IP da maquina"
        '
        'ExibirToolStripMenuItem
        '
        Me.ExibirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltfonteToolStripMenuItem, Me.AltcorToolStripMenuItem})
        Me.ExibirToolStripMenuItem.Name = "ExibirToolStripMenuItem"
        Me.ExibirToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ExibirToolStripMenuItem.Text = "Exibir"
        '
        'AltfonteToolStripMenuItem
        '
        Me.AltfonteToolStripMenuItem.Name = "AltfonteToolStripMenuItem"
        Me.AltfonteToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AltfonteToolStripMenuItem.Text = "Alt.fonte"
        '
        'AltcorToolStripMenuItem
        '
        Me.AltcorToolStripMenuItem.Name = "AltcorToolStripMenuItem"
        Me.AltcorToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AltcorToolStripMenuItem.Text = "Alt.cor"
        '
        'DiretosAutToolStripMenuItem
        '
        Me.DiretosAutToolStripMenuItem.Name = "DiretosAutToolStripMenuItem"
        Me.DiretosAutToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.DiretosAutToolStripMenuItem.Text = "Diretos Aut."
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(544, 414)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#PING"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltIPDaMaguinaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MASC4 As System.Windows.Forms.TextBox
    Friend WithEvents MASC3 As System.Windows.Forms.TextBox
    Friend WithEvents MASC2 As System.Windows.Forms.TextBox
    Friend WithEvents MASC1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ip As System.Windows.Forms.TextBox
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ExibirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiretosAutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltfonteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltcorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog

End Class
