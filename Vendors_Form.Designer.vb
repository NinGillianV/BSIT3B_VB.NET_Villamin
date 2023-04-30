<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vendors_Form
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
        Me.ven_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ven_name = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ven_password = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.checkbox_password = New System.Windows.Forms.CheckBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ven_id
        '
        Me.ven_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ven_id.Location = New System.Drawing.Point(258, 105)
        Me.ven_id.Name = "ven_id"
        Me.ven_id.Size = New System.Drawing.Size(371, 32)
        Me.ven_id.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vendor ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vendor Name"
        '
        'ven_name
        '
        Me.ven_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ven_name.Location = New System.Drawing.Point(258, 152)
        Me.ven_name.Name = "ven_name"
        Me.ven_name.Size = New System.Drawing.Size(371, 32)
        Me.ven_name.TabIndex = 2
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(237, 281)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(115, 43)
        Me.btn_add.TabIndex = 4
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(237, 330)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(115, 43)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(393, 281)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(115, 43)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Vendor Password"
        '
        'ven_password
        '
        Me.ven_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ven_password.Location = New System.Drawing.Point(258, 199)
        Me.ven_password.Name = "ven_password"
        Me.ven_password.Size = New System.Drawing.Size(371, 32)
        Me.ven_password.TabIndex = 6
        Me.ven_password.UseSystemPasswordChar = True
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(393, 330)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(115, 43)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Vendors"
        '
        'checkbox_password
        '
        Me.checkbox_password.AutoSize = True
        Me.checkbox_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_password.Location = New System.Drawing.Point(241, 244)
        Me.checkbox_password.Name = "checkbox_password"
        Me.checkbox_password.Size = New System.Drawing.Size(177, 30)
        Me.checkbox_password.TabIndex = 11
        Me.checkbox_password.Text = "Show Password"
        Me.checkbox_password.UseCompatibleTextRendering = True
        Me.checkbox_password.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_back.Location = New System.Drawing.Point(677, 400)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(111, 38)
        Me.btn_back.TabIndex = 12
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Vendors_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.checkbox_password)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ven_password)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ven_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ven_id)
        Me.Name = "Vendors_Form"
        Me.Text = "Vendors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ven_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ven_name As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ven_password As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents checkbox_password As CheckBox
    Friend WithEvents btn_back As Button
End Class
