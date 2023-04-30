<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.prod_name = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.quantity = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.NumericUpDown()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.tbl_customers = New System.Windows.Forms.DataGridView()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prod_name
        '
        Me.prod_name.FormattingEnabled = True
        Me.prod_name.Location = New System.Drawing.Point(49, 122)
        Me.prod_name.Name = "prod_name"
        Me.prod_name.Size = New System.Drawing.Size(168, 24)
        Me.prod_name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity"
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(49, 194)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(168, 22)
        Me.quantity.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Price"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(72, 269)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(145, 22)
        Me.total.TabIndex = 5
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(53, 320)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(164, 38)
        Me.btn_add.TabIndex = 6
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'tbl_customers
        '
        Me.tbl_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbl_customers.Location = New System.Drawing.Point(254, 116)
        Me.tbl_customers.Name = "tbl_customers"
        Me.tbl_customers.RowHeadersWidth = 51
        Me.tbl_customers.RowTemplate.Height = 24
        Me.tbl_customers.Size = New System.Drawing.Size(487, 195)
        Me.tbl_customers.TabIndex = 7
        '
        'btn_show
        '
        Me.btn_show.Location = New System.Drawing.Point(254, 318)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(111, 44)
        Me.btn_show.TabIndex = 8
        Me.btn_show.Text = "Show Table"
        Me.btn_show.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "₱"
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(636, 319)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(105, 44)
        Me.btn_back.TabIndex = 11
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 29)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Add Customer"
        '
        'search_box
        '
        Me.search_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_box.Location = New System.Drawing.Point(323, 73)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(418, 27)
        Me.search_box.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(250, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Search"
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(436, 320)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(114, 43)
        Me.btn_print.TabIndex = 18
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'Customer_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.tbl_customers)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prod_name)
        Me.Name = "Customer_Form"
        Me.Text = "Customer"
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prod_name As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents quantity As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents total As NumericUpDown
    Friend WithEvents btn_add As Button
    Friend WithEvents tbl_customers As DataGridView
    Friend WithEvents btn_show As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents search_box As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_print As Button
End Class
