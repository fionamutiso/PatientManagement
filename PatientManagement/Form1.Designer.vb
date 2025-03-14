<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnlogin = New Button()
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' btnlogin
        ' 
        btnlogin.Anchor = AnchorStyles.None
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.Location = New Point(301, 205)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(159, 53)
        btnlogin.TabIndex = 0
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Showcard Gothic", 32.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(81, 73)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(647, 53)
        lblTitle.TabIndex = 1
        lblTitle.Text = "PATIENT MANAGEMENT SYSTEM"
        lblTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTitle)
        Controls.Add(btnlogin)
        Name = "HomePage"
        Text = "Home"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnlogin As Button
    Friend WithEvents lblTitle As Label

End Class
