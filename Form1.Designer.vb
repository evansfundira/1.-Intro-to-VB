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
        btnClickHere = New Button()
        txtName = New TextBox()
        txtSurname = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btnClickHere
        ' 
        btnClickHere.Location = New Point(290, 316)
        btnClickHere.Name = "btnClickHere"
        btnClickHere.Size = New Size(106, 56)
        btnClickHere.TabIndex = 0
        btnClickHere.Text = "Click Here"
        btnClickHere.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(336, 106)
        txtName.Name = "txtName"
        txtName.Size = New Size(181, 27)
        txtName.TabIndex = 1
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(336, 171)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(181, 27)
        txtSurname.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(200, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 2
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(200, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 2
        Label2.Text = "Surname"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(369, 284)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 24)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Sign Me Up"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(369, 254)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(95, 24)
        CheckBox2.TabIndex = 4
        CheckBox2.Text = "Subscribe"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(642, 106)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(63, 24)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(642, 136)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(78, 24)
        RadioButton2.TabIndex = 6
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(642, 166)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(67, 24)
        RadioButton3.TabIndex = 7
        RadioButton3.TabStop = True
        RadioButton3.Text = "Other"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Student", "Teacher", "Professional", "Manager"})
        ComboBox1.Location = New Point(336, 220)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(200, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 9
        Label3.Text = "Profession"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe Print", 20F, FontStyle.Underline, GraphicsUnit.Point)
        Label4.Location = New Point(108, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(572, 59)
        Label4.TabIndex = 10
        Label4.Text = "Sign Up for the MindWorx LMS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSurname)
        Controls.Add(txtName)
        Controls.Add(btnClickHere)
        Name = "Form1"
        Text = "Intro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickHere As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
