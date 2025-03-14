Public Class HomePage
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Patient Management System"
        Dim bgImagePath As String = "C:\\Users\\User\\Desktop\\PatientManagement\\Images\\background.jpeg"
        If IO.File.Exists(bgImagePath) Then
            Me.BackgroundImage = Image.FromFile(bgImagePath)
            Me.BackgroundImageLayout = ImageLayout.Stretch ' Fit image to form
        Else
            Me.BackColor = Color.Pink
        End If
        btnlogin.BackColor = Color.LightPink
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.FlatAppearance.BorderSize = 2  ' Border thickness
        btnlogin.FlatAppearance.BorderColor = Color.Pink ' Border color
        btnlogin.ForeColor = Color.Black ' Text color
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim loginForm As New LoginForm()
        loginForm.ShowDialog() ' Show login form as a dialog
    End Sub

End Class
