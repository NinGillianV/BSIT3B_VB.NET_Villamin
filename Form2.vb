Public Class Form2
    Private Sub brn_logout_Click(sender As Object, e As EventArgs) Handles brn_logout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub btn_sales_Click(sender As Object, e As EventArgs) Handles btn_sales.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub btn_vendors_Click(sender As Object, e As EventArgs) Handles btn_vendors.Click
        Me.Close()
        Form6.Show()
    End Sub
End Class