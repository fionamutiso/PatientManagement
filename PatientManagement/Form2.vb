Public Class Dashboard
    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)

        Dim bgImagePath As String = "C:\Users\User\Desktop\PatientManagement\PatientManagement\Images\dashboardbg.jpeg"
        If IO.File.Exists(bgImagePath) Then
            Me.BackgroundImage = Image.FromFile(bgImagePath)
            Me.BackgroundImageLayout = ImageLayout.Stretch ' Fit image to form
        Else
            Me.BackColor = Color.Pink
        End If

        For Each btn As Button In Me.Controls.OfType(Of Button)()
            btn.BackColor = Color.LightPink
            btn.FlatStyle = FlatStyle.Flat
            btn.ForeColor = Color.Black
            btn.Font = New Font("Arial", 12, FontStyle.Bold)
            btn.FlatAppearance.BorderSize = 0
        Next
        AdjustButtonSizes()

    End Sub

    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Adjust button sizes when form is resized
        AdjustButtonSizes()
    End Sub

    Private Sub AdjustButtonSizes()
        ' Set button width to 30% of the form width and height to 10%
        Dim buttonWidth As Integer = Me.ClientSize.Width * 0.3
        Dim buttonHeight As Integer = Me.ClientSize.Height * 0.1
        Dim spacing As Integer = 20 ' Space between buttons

        ' Get all buttons and order them correctly
        Dim buttons As List(Of Button) = Me.Controls.OfType(Of Button)().ToList()

        ' Start positioning from the top
        Dim startY As Integer = (Me.ClientSize.Height - ((buttonHeight + spacing) * buttons.Count)) \ 2

        For i As Integer = 0 To buttons.Count - 1
            Dim btn As Button = buttons(i)
            btn.Width = buttonWidth
            btn.Height = buttonHeight
            btn.Left = (Me.ClientSize.Width - btn.Width) \ 2 ' Center align
            btn.Top = startY + (i * (buttonHeight + spacing)) ' Arrange vertically
        Next
    End Sub

    Private Sub btnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        patientsForm.Show()
        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class