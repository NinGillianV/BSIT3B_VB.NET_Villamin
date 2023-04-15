<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Excel_editor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.OpenFileBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_backup = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Excel"
        '
        'btn_browse
        '
        Me.btn_browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Location = New System.Drawing.Point(1169, 76)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(126, 36)
        Me.btn_browse.TabIndex = 1
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1265, 361)
        Me.DataGridView1.TabIndex = 2
        '
        'btn_backup
        '
        Me.btn_backup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backup.Location = New System.Drawing.Point(30, 501)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(199, 39)
        Me.btn_backup.TabIndex = 3
        Me.btn_backup.Text = "Back up database"
        Me.btn_backup.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_back.Location = New System.Drawing.Point(1157, 501)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(138, 33)
        Me.btn_back.TabIndex = 4
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Excel_editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 602)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Excel_editor"
        Me.Text = "Excel_editor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_browse As Button
    Friend WithEvents OpenFileBrowse As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_backup As Button
    Friend WithEvents btn_back As Button
End Class
