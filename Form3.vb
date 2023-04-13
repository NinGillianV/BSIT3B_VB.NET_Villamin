Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Form3
    Dim connection As New MySqlConnection("server=localhost;port=3307;username=root;password=edp123;database=sales")
    Dim index As Integer
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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adapter As New MySqlDataAdapter("SELECT `prod_name` FROM sales.products", connection)
        Dim table As New DataTable()

        adapter.Fill(table)

        prod_name.DataSource = table

        prod_name.ValueMember = "prod_name"
        prod_name.DisplayMember = "prod_name"


    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim insert_command As New MySqlCommand("INSERT INTO `customers`(`customer_id`, `prod_name`, `quantity`, `total`) VALUES (@customer_id,@prod_name,@quantity,@total)", connection)

        insert_command.Parameters.Add("@customer_id", MySqlDbType.Int16).Value = 0
        insert_command.Parameters.Add("@prod_name", MySqlDbType.VarChar).Value = prod_name.SelectedValue
        insert_command.Parameters.Add("@quantity", MySqlDbType.Float).Value = quantity.Value
        insert_command.Parameters.Add("@total", MySqlDbType.Float).Value = total.Value

        connection.Open()

        If execCommand(insert_command) Then
            MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If


    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM sales.customers", connection)

        adapter.Fill(table)

        tbl_customers.DataSource = table
        tbl_customers.AllowUserToAddRows = False


    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs)
        Dim search_command As New MySqlCommand("SELECT * FROM `customers` WHERE `prod_name` = @prod_name", connection)

        search_command.Parameters.Add("@prod_name", MySqlDbType.VarChar).Value = prod_name.SelectedValue

        Dim adapter As New MySqlDataAdapter(search_command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                prod_name.SelectedValue = table(0)(1)
                quantity.Value = table(0)(2)
                total.Value = table(0)(3)
            Else

                prod_name.SelectedValue = ""
                quantity.Value = ""
                total.Value = ""
                MessageBox.Show("No Data Found")

            End If

        Catch ex As Exception

            MessageBox.Show("ERROR")

        End Try
    End Sub

    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM sales.customers", connection)
        adapter.Fill(table)
        Dim DV As New DataView(Table)
        DV.RowFilter = String.Format("prod_name Like '%{0}%'", search_box.Text)
        tbl_customers.DataSource = DV

    End Sub

End Class