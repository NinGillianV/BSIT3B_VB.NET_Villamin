Imports System.Data.OleDb
Imports System.IO

Public Class Excel_editor
    Private Sub Excel_editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Try
            Dim conn As OleDbConnection
            Dim dta As OleDbDataAdapter
            Dim dts As DataSet
            Dim excel As String
            Dim OpenFileDialog As New OpenFileDialog
            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx"
            If OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim fi As New IO.FileInfo(OpenFileDialog.FileName)
                Dim FileName As String = OpenFileDialog.FileName
                excel = fi.FullName

                If fi.Extension = ".csv" Then
                    conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + IO.Path.GetDirectoryName(excel) + ";Extended Properties='text;HDR=YES;FMT=Delimited';")
                    dta = New OleDbDataAdapter("select * from " + fi.Name, conn)
                ElseIf fi.Extension = ".xls" Then
                    conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excel + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1';")
                    dta = New OleDbDataAdapter("select * from [Sheet1$]", conn)
                ElseIf fi.Extension = ".xlsx" Then
                    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1';")
                    dta = New OleDbDataAdapter("select * from [Sheet1$]", conn)
                Else
                    MsgBox("Invalid file format.")
                    Exit Sub
                End If

                dts = New DataSet
                dta.Fill(dts, "Table1")
                DataGridView1.DataSource = dts.Tables("Table1")
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        Dim OpenFileDialog2 As New OpenFileDialog()
        OpenFileDialog2.Filter = "Batch Files (*.bat)|*.bat|All Files (*.*)|*.*"
        OpenFileDialog2.FilterIndex = 1
        OpenFileDialog2.RestoreDirectory = True

        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*"
            saveFileDialog1.FilterIndex = 1
            saveFileDialog1.RestoreDirectory = True

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim process As New Process()
                process.StartInfo.FileName = OpenFileDialog2.FileName
                process.StartInfo.Arguments = saveFileDialog1.FileName
                process.StartInfo.CreateNoWindow = True
                process.Start()
                process.WaitForExit()

                If process.ExitCode = 0 Then
                    MessageBox.Show("Backup created successfully.")
                Else
                    MessageBox.Show("Error creating backup.")
                End If
            End If
        End If


    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Main_Menu.Show()
        Me.Close()
    End Sub
End Class