Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop


Public Class Products_Form
    Public currentdate As DateTime = DateTime.Now
    Public xlsPath As String = System.IO.Directory.GetCurrentDirectory & "\dataXls\TEMPLATE\"
    Public xlsFiles As String = System.IO.Directory.GetCurrentDirectory & "\dataXls\TEMPLATE\"
    Public sqlColumns As String = "prod_name as Product_Name, price as Price, stock as Stock"
    Dim connection As New MySqlConnection("server=localhost;port=3307;username=root;password=edp123;database=sales")
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
        Me.Close()
        Main_Menu.Show()
    End Sub


    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call importToExcel(Me.tbl_prod, "samplereport.xlsx")
    End Sub
End Class