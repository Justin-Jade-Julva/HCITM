Public Class Form1
    Dim gender As String
    Dim genderBind As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        MsgBox("Connected!")
        con.Close()
        loadtable()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radmale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radfemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles save.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO account(`NAME`,`AGE`,`GENDER`,`BDAY`,`BRANCH`,`QCU_COURSE`) VALUES('" & txtname.Text & "', '" & txtage.Text & "','" & gender & "', '" & dtbirthday.Value.Date & "','" & cmbqcub.SelectedItem & "','" & cmbqcuc.SelectedItem & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Succesfully Added Record!")
            con.Close()
            txtname.Clear()
            txtage.Clear()
            radmale.Checked = False
            radfemale.Checked = False
            cmbqcub.Text = ""
            cmbqcuc.Text = ""
            loadtable()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM account WHERE ID= '" & txtID.Text & "' "
            adapter.SelectCommand = cmd
            data.Clear()
            adapter.Fill(data, "List")

            txtname.DataBindings.Add("Text", data, "List.NAME")
            txtname.DataBindings.Clear()

            txtage.DataBindings.Add("Text", data, "List.AGE")
            txtage.DataBindings.Clear()

            txtgenderbind.DataBindings.Add("Text", data, "List.GENDER")
            txtgenderbind.DataBindings.Clear()
            genderBind = txtgenderbind.Text

            If genderbind = "male" Then
                radfemale.Checked = True

            ElseIf genderbind = "Female" Then
                radfemale.Checked = True

            End If

            dtbirthday.DataBindings.Add("Value", data, "List.BDAY")
            dtbirthday.DataBindings.Clear()

            cmbqcub.DataBindings.Add("Text", data, "List.BRANCH")
            cmbqcub.DataBindings.Clear()

            cmbqcuc.DataBindings.Add("Text", data, "List.QCU_COURSE")
            cmbqcuc.DataBindings.Clear()


            If txtID.Text = "" Then
                txtname.Clear()
                txtage.Clear()
                txtgenderbind.Clear()
                radmale.Checked = False
                radfemale.Checked = False
                cmbqcub.Text = ""
                cmbqcuc.Text = ""
            End If


            con.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub loadtable()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = " SELECT * FROM account"
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    
  
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtID.Text = DataGridView1.Item("ID", DataGridView1.CurrentRow.Index).Value
        txtname.Text = DataGridView1.Item("NAME", DataGridView1.CurrentRow.Index).Value
        txtage.Text = DataGridView1.Item("AGE", DataGridView1.CurrentRow.Index).Value

        Dim gen As String
        gen = DataGridView1.Item("GENDER", DataGridView1.CurrentRow.Index).Value

        If gen = "Male" Then
            radmale.Checked = True
        ElseIf gen = "Female" Then
            radfemale.Checked = True
        End If

        dtbirthday.Value = DataGridView1.Item("BDAY", DataGridView1.CurrentRow.Index).Value
        cmbqcub.Text = DataGridView1.Item("BRANCH", DataGridView1.CurrentRow.Index).Value
        cmbqcuc.Text = DataGridView1.Item("QCU_COURSE", DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles update.Click
        openCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE account SET NAME = '" & txtname.Text & "', AGE = '" & txtage.Text & "', GENDER ='" & gender & "', BDAY = '" & dtbirthday.Value.Date & "', BRANCH = '" & cmbqcub.SelectedItem & "', QCU_COURSE = '" & cmbqcuc.SelectedItem & "'  WHERE ID = '" & txtID.Text & "'"

            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Succesfully Updated Record!")
            Call loadtable()
            txtname.Clear()
            txtage.Clear()
            radfemale.Checked = False
            radmale.Checked = False
            cmbqcub.Text = ""
            cmbqcuc.Text = ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles delete.Click
        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM account WHERE ID = '" & txtID.Text & "'"

            If MessageBox.Show("Are You Sure?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Succesfully Deleted!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.CommandText = "INSERT INTO archive (`NAME`,`AGE`,`GENDER`,`BDAY`,`BRANCH`,`QCU_COURSE`) VALUES('" & txtname.Text & "', '" & txtage.Text & "','" & gender & "', '" & dtbirthday.Value.Date & "','" & cmbqcub.SelectedItem & "','" & cmbqcuc.SelectedItem & "')"
                cmd.ExecuteNonQuery()
                con.Close()

            Else
                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
