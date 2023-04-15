Imports MySql.Data.MySqlClient

Public Class Products_Form
    Dim connection As New MySqlConnection("server=localhost;port=3307;username=root;password=edp123;database=sales")
    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        Dim adapter As New MySqlDataAdapter("SELECT * FROM sales.products", connection)
        Dim table As New DataTable()

        adapter.Fill(table)

        tbl_prod.DataSource = table
        tbl_prod.AllowUserToAddRows = False
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim command As New MySqlCommand("INSERT INTO `products`(`product_id`, `prod_name`, `price`, `manufacturer`, `stock`) VALUES (@product_id,@prod_name,@price,@manufacturer, @stock)", connection)

        ' add Parameters to the command
        command.Parameters.Add("@product_id", MySqlDbType.Int16).Value = 0
        command.Parameters.Add("@prod_name", MySqlDbType.VarChar).Value = prod_name.Text
        command.Parameters.Add("@price", MySqlDbType.Float).Value = price.Value
        command.Parameters.Add("@manufacturer", MySqlDbType.VarChar).Value = manufacturer.Text
        command.Parameters.Add("@stock", MySqlDbType.Float).Value = stock.Value

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Data Inserted")

        Else

            MessageBox.Show("ERROR")

        End If

        connection.Close()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.CLose()
        Main_Menu.Show()
    End Sub
End Class