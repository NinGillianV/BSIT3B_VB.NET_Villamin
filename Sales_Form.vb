Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class Sales_Form
    Public currentdate As DateTime = DateTime.Now
    Public xlsPath As String = System.IO.Directory.GetCurrentDirectory & "\dataXls\TEMPLATE\"
    Public xlsFiles As String = System.IO.Directory.GetCurrentDirectory & "\dataXls\TEMPLATE\"
    Dim connection As New MySqlConnection("server=localhost;port=3307;username=root;password=edp123;database=sales")
    Dim table As New DataTable()
    Dim adapter As New MySqlDataAdapter("SELECT * FROM sales.sales", connection)


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

        adapter.Fill(table)
        tbl_sales.DataSource = table
        tbl_sales.AllowUserToAddRows = False
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        Main_Menu.Show()
    End Sub

    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        Dim DV As New DataView(table)
        DV.RowFilter = String.Format("prod_name Like '%{0}%'", search_box.Text)
        tbl_sales.DataSource = DV

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call importToExcel(Me.tbl_sales, "samplereport.xlsx")
    End Sub
End Class