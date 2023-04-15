<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_sales = New System.Windows.Forms.Button()
        Me.brn_logout = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_vendors = New System.Windows.Forms.Button()
        Me.btn_viewer = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(354, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu"
        '
        'btn_customer
        '
        Me.btn_customer.Location = New System.Drawing.Point(192, 261)
        Me.btn_customer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(118, 43)
        Me.btn_customer.TabIndex = 1
        Me.btn_customer.Text = "Add Customer"
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_sales
        '
        Me.btn_sales.Location = New System.Drawing.Point(399, 197)
        Me.btn_sales.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_sales.Name = "btn_sales"
        Me.btn_sales.Size = New System.Drawing.Size(116, 44)
        Me.btn_sales.TabIndex = 2
        Me.btn_sales.Text = "View Sales"
        Me.btn_sales.UseVisualStyleBackColor = True
        '
        'brn_logout
        '
        Me.brn_logout.Location = New System.Drawing.Point(447, 262)
        Me.brn_logout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.brn_logout.Name = "brn_logout"
        Me.brn_logout.Size = New System.Drawing.Size(129, 42)
        Me.brn_logout.TabIndex = 3
        Me.brn_logout.Text = "Log Out"
        Me.brn_logout.UseVisualStyleBackColor = True
        '
        'btn_product
        '
        Me.btn_product.Location = New System.Drawing.Point(260, 197)
        Me.btn_product.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(118, 44)
        Me.btn_product.TabIndex = 4
        Me.btn_product.Text = "Add Product"
        Me.btn_product.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(317, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btn_vendors
        '
        Me.btn_vendors.Location = New System.Drawing.Point(260, 319)
        Me.btn_vendors.Name = "btn_vendors"
        Me.btn_vendors.Size = New System.Drawing.Size(255, 54)
        Me.btn_vendors.TabIndex = 6
        Me.btn_vendors.Text = "Vendors"
        Me.btn_vendors.UseVisualStyleBackColor = True
        '
        'btn_viewer
        '
        Me.btn_viewer.Location = New System.Drawing.Point(317, 261)
        Me.btn_viewer.Name = "btn_viewer"
        Me.btn_viewer.Size = New System.Drawing.Size(122, 43)
        Me.btn_viewer.TabIndex = 7
        Me.btn_viewer.Text = "Excel Viewer"
        Me.btn_viewer.UseVisualStyleBackColor = True
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_viewer)
        Me.Controls.Add(Me.btn_vendors)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_product)
        Me.Controls.Add(Me.brn_logout)
        Me.Controls.Add(Me.btn_sales)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Main_Menu"
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_sales As Button
    Friend WithEvents brn_logout As Button
    Friend WithEvents btn_product As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_vendors As Button
    Friend WithEvents btn_viewer As Button
End Class
