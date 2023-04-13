Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connection As New MySqlConnection("server=localhost;port=3307;username=root;password=edp123;database=sales")

    ' show/hide password text 
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If ven_password.UseSystemPasswordChar = True Then

            ' show password
            ven_password.UseSystemPasswordChar = False

        Else

            ' hide password
            ven_password.UseSystemPasswordChar = True

        End If

    End Sub

    ' button close form 
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        Me.Close()

    End Sub

    'button log in 
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click


        Dim command As New MySqlCommand("SELECT * FROM sales.vendors WHERE ven_name = @ven_name AND ven_password = @ven_password", connection)

        command.Parameters.Add("@ven_name", MySqlDbType.VarChar).Value = ven_name.Text
        command.Parameters.Add("@ven_password", MySqlDbType.VarChar).Value = ven_password.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username Or Password")

        Else

            Me.Hide()
            Form2.Show()
            ven_name.Text = ""
            ven_password.Text = ""
        End If

    End Sub


End Class

