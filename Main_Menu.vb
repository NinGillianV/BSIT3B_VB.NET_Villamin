Public Class Main_Menu
    Private Sub brn_logout_Click(sender As Object, e As EventArgs) Handles brn_logout.Click
        Me.Close()
        Main_Form.Show()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        Me.Close()
        Customer_Form.Show()
    End Sub

    Private Sub btn_sales_Click(sender As Object, e As EventArgs) Handles btn_sales.Click
        Me.Close()
        Sales_Form.Show()
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        Me.Close()
        Products_Form.Show()
    End Sub

    Private Sub btn_vendors_Click(sender As Object, e As EventArgs) Handles btn_vendors.Click
        Me.Close()
        Vendors_Form.Show()
    End Sub

    Private Sub btn_viewer_Click(sender As Object, e As EventArgs) Handles btn_viewer.Click
        Me.Hide()
        Excel_editor.Show()
    End Sub
End Class