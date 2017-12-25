Imports System.Net.NetworkInformation
Imports System.Security.Principal
Public Class Form1


    Dim i As Integer = 0


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.TopMost = True
        Me.TopMost = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Public Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If TextBox1.Text = Nothing Then
            TextBox1.Text = 1
        End If


        If TextBox2.Text = Nothing Then
            TextBox2.Text = 0
        End If


        If TextBox3.Text = Nothing Then
            TextBox3.Text = 0
        End If
        If TextBox4.Text = Nothing Then
            TextBox4.Text = 0
        End If

        If TextBox4.Text = "255" And MASC3.Text = "255" Then
            MsgBox("hosts pingados")
            Timer1.Enabled = False
        Else
            ip.Text += TextBox1.Text & "." & TextBox2.Text & "." & TextBox3.Text & "." & TextBox4.Text
            Dim MEUPing As New Ping
            Dim PING As PingReply = MEUPing.Send(ip.Text)
            If PING.Status = IPStatus.Success Then
                ListBox2.Items.Add(ip.Text & " Host ativo ")
            Else
                ListBox1.Items.Add(ip.Text & " Host inativo ")
            End If




            'proximo endereço
            If TextBox4.Text = "255" And MASC3.Text = "0" Then
                If TextBox3.Text <= 254 Then
                    TextBox4.Text = "0"
                    TextBox3.Text = TextBox3.Text + 1
                Else

                End If
            Else
                If ProgressBar1.Value <= "254" Then
                    TextBox4.Text = TextBox4.Text + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                Else
                    MsgBox("Hosts pingados")
                    Timer1.Enabled = False
                End If
            End If

            End If
            ip.Text = Nothing


    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub ProgrampingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mPrincipal As WindowsPrincipal = New WindowsPrincipal(WindowsIdentity.GetCurrent)
        If mPrincipal.IsInRole(WindowsBuiltInRole.Administrator) = False Then
            MessageBox.Show("Você precisa executar a aplicação com direitos de administrador para usar todas as opções ")
        Else

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ProgressBar1.Value = 0
        If TextBox1.Text = Nothing Then
            TextBox1.Text = "1"
        End If


        If TextBox2.Text = Nothing Then
            TextBox2.Text = "0"
        End If


        If TextBox3.Text = Nothing Then
            TextBox3.Text = "0"
        End If

        If TextBox4.Text = Nothing Then
            TextBox4.Text = "0"
        End If




        ip.Text += TextBox1.Text & "." & TextBox2.Text & "." & TextBox3.Text & "." & TextBox4.Text
        Dim MEUPing As New Ping
        Dim PING As PingReply = MEUPing.Send(ip.Text)
        If PING.Status = IPStatus.Success Then
            ListBox2.Items.Add(ip.Text & " Host ativo ")
        Else
            ListBox1.Items.Add(ip.Text & " Host inativo ")
        End If
        If TextBox4.Text = "255" And MASC3.Text = "0" Then
            If TextBox3.Text = "255" And MASC4.Text = "0" Then
                TextBox2.Text = TextBox2.Text + 1
            Else
                TextBox3.Text = TextBox3.Text + 1
            End If
        Else
            TextBox4.Text = TextBox4.Text + 1
        End If
        ip.Text = Nothing

        Timer1.Start()

        If MASC1.Text = Nothing Then
            MsgBox("Mascara não declarada, " & 2 ^ 32 & " Possibilidades ")

        Else
            ProgressBar1.Maximum = ((255 - MASC1.Text) + (255 - MASC2.Text) + (255 - MASC3.Text) + (255 - MASC4.Text))
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("sdsdsd")
    End Sub

    Private Sub AltIPDaMaguinaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltIPDaMaguinaToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.ImageIndex = 1 Then
            Timer1.Stop()
            Button2.ImageIndex = 2
        Else
            Button2.ImageIndex = 1
            Timer1.Start()
        End If
    End Sub

    Private Sub DiretosAutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiretosAutToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub AltfonteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltfonteToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        Button1.Font = FontDialog1.Font
        Button2.Font = FontDialog1.Font
        Label1.Font = FontDialog1.Font
        Label2.Font = FontDialog1.Font
        Label3.Font = FontDialog1.Font
        ListBox1.Font = FontDialog1.Font
        ListBox2.Font = FontDialog1.Font
        Form2.TextBox1.Font = FontDialog1.Font
        Form2.TextBox2.Font = FontDialog1.Font
        Form2.TextBox3.Font = FontDialog1.Font
        Form2.Label1.Font = FontDialog1.Font
        Form2.Label2.Font = FontDialog1.Font
        Form2.Label3.Font = FontDialog1.Font
        Form2.Button1.Font = FontDialog1.Font

    End Sub

    Private Sub AltcorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltcorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Button1.ForeColor = ColorDialog1.Color
        Button2.ForeColor = ColorDialog1.Color
        Label1.ForeColor = ColorDialog1.Color
        Label2.ForeColor = ColorDialog1.Color
        Label3.ForeColor = ColorDialog1.Color
        ListBox1.ForeColor = ColorDialog1.Color
        ListBox2.ForeColor = ColorDialog1.Color
        Form2.TextBox1.ForeColor = ColorDialog1.Color
        Form2.TextBox2.ForeColor = ColorDialog1.Color
        Form2.TextBox3.ForeColor = ColorDialog1.Color
        Form2.Label1.ForeColor = ColorDialog1.Color
        Form2.Label2.ForeColor = ColorDialog1.Color
        Form2.Label3.ForeColor = ColorDialog1.Color
        Form2.Button1.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub NotifyIcon1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click
        Me.TopMost = True
        Me.TopMost = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Dim stringw As Integer
            stringw = TextBox1.Text * 1
        Catch ex As Exception
            MsgBox("Os campos só devem conter numeros inteiros")
        End Try
        If TextBox1.TextLength = 3 Then
            TextBox2.Focus()
        Else

        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Try
            Dim stringw As Integer
            stringw = TextBox2.Text * 1
        Catch ex As Exception
            MsgBox("Os campos só devem conter numeros inteiros")
        End Try
        If TextBox2.TextLength = 3 Then
            TextBox3.Focus()


        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Try
            Dim stringw As Integer
            stringw = TextBox3.Text * 1
        Catch ex As Exception
            MsgBox("Os campos só devem conter numeros inteiros")
        End Try
        If TextBox3.TextLength = 3 Then
            TextBox4.Focus()

        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Try
            Dim stringw As Integer
            stringw = TextBox4.Text * 1
        Catch ex As Exception
            MsgBox("Os campos só devem conter numeros inteiros")
        End Try
        If TextBox4.TextLength = 3 Then
            MASC1.Focus()

        End If
    End Sub

    Private Sub MASC1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MASC1.TextChanged
        Try
            Dim stringw As Integer
            stringw = MASC1.Text * 1
        Catch ex As Exception
            MsgBox("Os campos só devem conter numeros inteiros")
        End Try
        If MASC1.TextLength = 3 Then
            MASC2.Focus()

        End If
    End Sub

    Private Sub MASC2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MASC2.TextChanged
        Try
            Dim stringw As Integer
            stringw = MASC2.Text * 1
        Catch ex As Exception
            MsgBox("Os campos só devem conter numeros inteiros")
        End Try
        If MASC2.TextLength = 3 Then
            MASC3.Focus()

        End If
    End Sub

    Private Sub MASC3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MASC3.TextChanged
        Try
            Dim stringw As Integer
            stringw = MASC3.Text * 1
        Catch ex As Exception
            MsgBox("Os campos só devem conter numeros inteiros")

        End Try
        If MASC3.TextLength = 3 Then
            MASC4.Focus()

        End If
    End Sub

    Private Sub MASC4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MASC4.TextChanged
        Try
            Dim stringw As Integer
            stringw = MASC4.Text * 1
        Catch ex As Exception
            MsgBox("Os campos só devem conter numeros inteiros")

        End Try
    End Sub
End Class
