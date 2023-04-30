Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Customer_Form
    Public currentdate As DateTime = DateTime.Now
    Public xlsPath As String = System.IO.Directory.GetCurrentDirectory & "\dataXls\TEMPLATE\"
    Public xlsFiles As String = System.IO.Directory.GetCurrentDirectory & "\dataXls\TEMPLATE\"
    Dim connection As New MySqlConnection("server=localhost;port=3307;username=root;password=edp123;database=sales")
    Dim index As Integer

    Public Function convertToLetters(ByVal number As Integer) As String
        number -= 1
        Dim result As String = String.Empty

        If (26 > number) Then
            result = Chr(number + 65)
        Else
            Dim column As Integer

            Do
                column = number Mod 26
                number = (number \ 26) - 1
                result = Chr(column + 65) + result
            Loop Until (number < 0)
        End If

        Return result

    End Function

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub importToExcel(ByVal mydg As DataGridView, ByVal templatefilename As String)
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(xlsPath & templatefilename)

        xlsSheet = xlsWB.Worksheets(1)
        'xlsCell = xlsSheet.Range("A1")
        'xlsSheet.Cells(3, 1) = strfilter
        Dim x, y As Integer
        For x = 0 To mydg.RowCount - 1
            For y = 0 To mydg.ColumnCount - 1
                xlsSheet.Cells(x + 5, y + 1) = mydg.Rows(x).Cells(y).Value
            Next
        Next
        With xlsSheet.Range(convertToLetters(1) & 5, convertToLetters(mydg.ColumnCount) & x + 4)
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        End With

        templatefilename = templatefilename.Replace(".xlsx", "")
        templatefilename = templatefilename.Replace(".xls", "")
        Dim myfilename As String = templatefilename & " " & currentdate.ToString("mm-dd-yy hh-mm-ss") & ".xlsx"
        MsgBox(myfilename)
        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False
        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()
        releaseObject(xlsApp)
        releaseObject(xlsWB)
        releaseObject(xlsSheet)
        System.Diagnostics.Process.Start("excel.exe", """" & xlsFiles & myfilename & """")
    End Sub

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
        Main_Menu.Show()
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
        Dim DV As New DataView(table)
        DV.RowFilter = String.Format("prod_name Like '%{0}%'", search_box.Text)
        tbl_customers.DataSource = DV

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call importToExcel(Me.tbl_customers, "samplereport.xlsx")
    End Sub
End Class