Imports MySql.Data.MySqlClient

Public Class Vendors_Form

    Dim connection As New MySqlConnection("datasource=localhost;port=3307;username=root;password=edp123;database=sales")

    ' button find 
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        Dim search_command As New MySqlCommand("SELECT * FROM `vendors` WHERE `ven_id` = @ven_id", connection)
        search_command.Parameters.Add("@ven_id", MySqlDbType.Int64).Value = ven_id.Text

        Dim adapter As New MySqlDataAdapter(search_command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                ven_name.Text = table(0)(1)
                ven_password.Text = table(0)(2)

                MessageBox.Show("Employee " + ven_name.Text + " is here!!!")
            Else

                ven_name.Text = ""
                ven_password.Text = ""
                MessageBox.Show("No Data Found")

            End If

        Catch ex As Exception

            MessageBox.Show("ERROR")

        End Try

    End Sub

    ' function to execute the insert update delete commands 
    Function execCommand(ByVal cmd As MySqlCommand) As Boolean

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

            MessageBox.Show("ERROR")
            Return False

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Function

    ' button add 
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim insert_command As New MySqlCommand("INSERT INTO `vendors`(`ven_id`, `ven_name`, `ven_password`) VALUES (@ven_id,@ven_name,@ven_password)", connection)
        insert_command.Parameters.Add("@ven_id", MySqlDbType.Int16).Value = ven_id.Text
        insert_command.Parameters.Add("@ven_name", MySqlDbType.VarChar).Value = ven_name.Text
        insert_command.Parameters.Add("@ven_password", MySqlDbType.VarChar).Value = ven_password.Text

        If execCommand(insert_command) Then
            MessageBox.Show("New Vendor Added")

        Else
            MessageBox.Show("Adding Failed")
        End If

    End Sub

    ' button edit 
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Dim update_command As New MySqlCommand("UPDATE `vendors` SET `ven_name`=@ven_name,`ven_password`=@ven_password WHERE `ven_id` = @ven_id", connection)
        update_command.Parameters.Add("@ven_id", MySqlDbType.Int64).Value = ven_id.Text
        update_command.Parameters.Add("@ven_name", MySqlDbType.VarChar).Value = ven_name.Text
        update_command.Parameters.Add("@ven_password", MySqlDbType.VarChar).Value = ven_password.Text

        If execCommand(update_command) Then
            MessageBox.Show("Data Updated")

        Else
            MessageBox.Show("Data NOT Updated")
        End If

    End Sub

    ' button remove 
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_command As New MySqlCommand("DELETE FROM `vendors` WHERE `ven_id` = @ven_id", connection)
        delete_command.Parameters.Add("@ven_id", MySqlDbType.Int64).Value = ven_id.Text

        If execCommand(delete_command) Then
            MessageBox.Show("Data Deleted")

        Else
            MessageBox.Show("Data NOT Deleted")
        End If

    End Sub
    Private Sub checkbox_password_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_password.CheckedChanged

        If ven_password.UseSystemPasswordChar = True Then

            ' show password
            ven_password.UseSystemPasswordChar = False

        Else

            ' hide password
            ven_password.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Main_Menu.Show()
    End Sub
End Class