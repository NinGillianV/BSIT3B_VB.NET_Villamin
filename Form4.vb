Imports MySql.Data.MySqlClient

Public Class Form4
    Dim connection As New MySqlConnection("server=localhost;port=3307;username=root;password=edp123;database=sales")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT * FROM sales.sales", connection)

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click

        adapter.Fill(table)
        tbl_sales.DataSource = table
        tbl_sales.AllowUserToAddRows = False
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        Dim DV As New DataView(table)
        DV.RowFilter = String.Format("prod_name Like '%{0}%'", search_box.Text)
        tbl_sales.DataSource = DV

    End Sub
End Class