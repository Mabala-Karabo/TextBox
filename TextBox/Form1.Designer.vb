<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtGreetMe = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtFirstName = New Windows.Forms.TextBox()
        txtSurname = New Windows.Forms.TextBox()
        txtGender = New Windows.Forms.TextBox()
        SuspendLayout()
        ' 
        ' txtGreetMe
        ' 
        txtGreetMe.Location = New Point(426, 292)
        txtGreetMe.Name = "txtGreetMe"
        txtGreetMe.Size = New Size(180, 87)
        txtGreetMe.TabIndex = 3
        txtGreetMe.Text = "Greet Me"
        txtGreetMe.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(210, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 4
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(201, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 5
        Label2.Text = "Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(210, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 25)
        Label3.TabIndex = 6
        Label3.Text = "Gender"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(305, 50)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(150, 31)
        txtFirstName.TabIndex = 7
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(305, 103)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(150, 31)
        txtSurname.TabIndex = 8
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(305, 168)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(150, 31)
        txtGender.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtGender)
        Controls.Add(txtSurname)
        Controls.Add(txtFirstName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGreetMe)
        Name = "Form1"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtGreetMe As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As Windows.Forms.TextBox
    Friend WithEvents txtSurname As Windows.Forms.TextBox
    Friend WithEvents txtGender As Windows.Forms.TextBox
End Class
