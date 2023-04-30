<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales_Form
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
        Me.tbl_sales = New System.Windows.Forms.DataGridView()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.btn_print = New System.Windows.Forms.Button()
        CType(Me.tbl_sales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_sales
        '
        Me.tbl_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbl_sales.Location = New System.Drawing.Point(33, 103)
        Me.tbl_sales.Name = "tbl_sales"
        Me.tbl_sales.RowHeadersWidth = 51
        Me.tbl_sales.RowTemplate.Height = 24
        Me.tbl_sales.Size = New System.Drawing.Size(720, 247)
        Me.tbl_sales.TabIndex = 0
        '
        'btn_show
        '
        Me.btn_show.Location = New System.Drawing.Point(33, 368)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(130, 45)
        Me.btn_show.TabIndex = 1
        Me.btn_show.Text = "Refresh"
        Me.btn_show.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(622, 367)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(131, 48)
        Me.btn_back.TabIndex = 2
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search Product"
        '
        'search_box
        '
        Me.search_box.Location = New System.Drawing.Point(212, 69)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(541, 22)
        Me.search_box.TabIndex = 5
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(328, 368)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(137, 45)
        Me.btn_print.TabIndex = 6
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'Sales_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.tbl_sales)
        Me.Name = "Sales_Form"
        Me.Text = "Sales"
        CType(Me.tbl_sales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbl_sales As DataGridView
    Friend WithEvents btn_show As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents search_box As TextBox
    Friend WithEvents btn_print As Button
End Class
