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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.radmale = New System.Windows.Forms.RadioButton()
        Me.radfemale = New System.Windows.Forms.RadioButton()
        Me.dtbirthday = New System.Windows.Forms.DateTimePicker()
        Me.cmbqcub = New System.Windows.Forms.ComboBox()
        Me.save = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtgenderbind = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbqcuc = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(12, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Birthday:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(12, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "QCU Branch:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(97, 32)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(206, 29)
        Me.txtname.TabIndex = 5
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(97, 67)
        Me.txtage.Multiline = True
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(206, 29)
        Me.txtage.TabIndex = 6
        '
        'radmale
        '
        Me.radmale.AutoSize = True
        Me.radmale.Location = New System.Drawing.Point(97, 102)
        Me.radmale.Name = "radmale"
        Me.radmale.Size = New System.Drawing.Size(48, 17)
        Me.radmale.TabIndex = 7
        Me.radmale.TabStop = True
        Me.radmale.Text = "Male"
        Me.radmale.UseVisualStyleBackColor = True
        '
        'radfemale
        '
        Me.radfemale.AutoSize = True
        Me.radfemale.Location = New System.Drawing.Point(202, 102)
        Me.radfemale.Name = "radfemale"
        Me.radfemale.Size = New System.Drawing.Size(59, 17)
        Me.radfemale.TabIndex = 8
        Me.radfemale.TabStop = True
        Me.radfemale.Text = "Female"
        Me.radfemale.UseVisualStyleBackColor = True
        '
        'dtbirthday
        '
        Me.dtbirthday.Location = New System.Drawing.Point(97, 152)
        Me.dtbirthday.Name = "dtbirthday"
        Me.dtbirthday.Size = New System.Drawing.Size(206, 20)
        Me.dtbirthday.TabIndex = 9
        '
        'cmbqcub
        '
        Me.cmbqcub.FormattingEnabled = True
        Me.cmbqcub.Items.AddRange(New Object() {"QCU-SAN BARTOLOME", "QCU-SAN FRANCISCO", "QCU-BATASAN"})
        Me.cmbqcub.Location = New System.Drawing.Point(115, 182)
        Me.cmbqcub.Name = "cmbqcub"
        Me.cmbqcub.Size = New System.Drawing.Size(188, 21)
        Me.cmbqcub.TabIndex = 10
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(228, 268)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 11
        Me.save.Text = "SAVE"
        Me.save.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(390, 67)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(358, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ID:"
        '
        'txtgenderbind
        '
        Me.txtgenderbind.Location = New System.Drawing.Point(128, 125)
        Me.txtgenderbind.Name = "txtgenderbind"
        Me.txtgenderbind.Size = New System.Drawing.Size(100, 20)
        Me.txtgenderbind.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(342, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(429, 259)
        Me.DataGridView1.TabIndex = 15
        '
        'cmbqcuc
        '
        Me.cmbqcuc.FormattingEnabled = True
        Me.cmbqcuc.Items.AddRange(New Object() {"BS INFORMATION TECHNOLOGY", "BS ENTREPRENEURSHIP", "BS ACCOUNTANCY", "BS INDUSTRIAL ENGENEERING", "BS ELECTRONICS ENGENEERING"})
        Me.cmbqcuc.Location = New System.Drawing.Point(115, 237)
        Me.cmbqcuc.Name = "cmbqcuc"
        Me.cmbqcuc.Size = New System.Drawing.Size(188, 21)
        Me.cmbqcuc.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(14, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 36)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "QCU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COURSE:"
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(122, 268)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(75, 23)
        Me.update.TabIndex = 18
        Me.update.Text = "UPDATE"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(17, 268)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 23)
        Me.delete.TabIndex = 19
        Me.delete.Text = "DELETE"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 366)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbqcuc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtgenderbind)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.cmbqcub)
        Me.Controls.Add(Me.dtbirthday)
        Me.Controls.Add(Me.radfemale)
        Me.Controls.Add(Me.radmale)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents radmale As System.Windows.Forms.RadioButton
    Friend WithEvents radfemale As System.Windows.Forms.RadioButton
    Friend WithEvents dtbirthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbqcub As System.Windows.Forms.ComboBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtgenderbind As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbqcuc As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button

End Class
