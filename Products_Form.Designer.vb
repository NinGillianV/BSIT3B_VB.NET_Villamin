<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prod_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbl_prod = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.manufacturer = New System.Windows.Forms.TextBox()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.stock = New System.Windows.Forms.NumericUpDown()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.price, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(35, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Product"
        '
        'prod_name
        '
        Me.prod_name.Location = New System.Drawing.Point(40, 116)
        Me.prod_name.Name = "prod_name"
        Me.prod_name.Size = New System.Drawing.Size(175, 22)
        Me.prod_name.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name"
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(61, 177)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(154, 22)
        Me.price.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "₱"
        '
        'tbl_prod
        '
        Me.tbl_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbl_prod.Location = New System.Drawing.Point(274, 97)
        Me.tbl_prod.Name = "tbl_prod"
        Me.tbl_prod.RowHeadersWidth = 51
        Me.tbl_prod.RowTemplate.Height = 24
        Me.tbl_prod.Size = New System.Drawing.Size(443, 251)
        Me.tbl_prod.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Manufacturer"
        '
        'manufacturer
        '
        Me.manufacturer.Location = New System.Drawing.Point(40, 255)
        Me.manufacturer.Name = "manufacturer"
        Me.manufacturer.Size = New System.Drawing.Size(175, 22)
        Me.manufacturer.TabIndex = 8
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Location = New System.Drawing.Point(37, 299)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(41, 16)
        Me.Label0.TabIndex = 9
        Me.Label0.Text = "Stock"
        '
        'stock
        '
        Me.stock.Location = New System.Drawing.Point(40, 318)
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(175, 22)
        Me.stock.TabIndex = 10
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(40, 362)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(175, 34)
        Me.btn_add.TabIndex = 11
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_show
        '
        Me.btn_show.Location = New System.Drawing.Point(274, 362)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(137, 34)
        Me.btn_show.TabIndex = 12
        Me.btn_show.Text = "Refresh"
        Me.btn_show.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(578, 362)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(139, 34)
        Me.btn_back.TabIndex = 13
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Products_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.stock)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.manufacturer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbl_prod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.prod_name)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Products_Form"
        Me.Text = "Products"
        CType(Me.price, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents prod_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents price As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbl_prod As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents manufacturer As TextBox
    Friend WithEvents Label0 As Label
    Friend WithEvents stock As NumericUpDown
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_show As Button
    Friend WithEvents btn_back As Button
End Class
