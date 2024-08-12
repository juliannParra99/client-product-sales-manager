<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesManagement
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNewSale = New System.Windows.Forms.Button()
        Me.btnUpdateSale = New System.Windows.Forms.Button()
        Me.btnDeleteSale = New System.Windows.Forms.Button()
        Me.dgvSaleItems = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSaleItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewSale
        '
        Me.btnNewSale.Location = New System.Drawing.Point(71, 267)
        Me.btnNewSale.Name = "btnNewSale"
        Me.btnNewSale.Size = New System.Drawing.Size(75, 23)
        Me.btnNewSale.TabIndex = 0
        Me.btnNewSale.Text = "New Sale"
        Me.btnNewSale.UseVisualStyleBackColor = True
        '
        'btnUpdateSale
        '
        Me.btnUpdateSale.Location = New System.Drawing.Point(221, 267)
        Me.btnUpdateSale.Name = "btnUpdateSale"
        Me.btnUpdateSale.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateSale.TabIndex = 1
        Me.btnUpdateSale.Text = "Update"
        Me.btnUpdateSale.UseVisualStyleBackColor = True
        '
        'btnDeleteSale
        '
        Me.btnDeleteSale.Location = New System.Drawing.Point(391, 267)
        Me.btnDeleteSale.Name = "btnDeleteSale"
        Me.btnDeleteSale.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteSale.TabIndex = 2
        Me.btnDeleteSale.Text = "Delete"
        Me.btnDeleteSale.UseVisualStyleBackColor = True
        '
        'dgvSaleItems
        '
        Me.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaleItems.Location = New System.Drawing.Point(56, 60)
        Me.dgvSaleItems.Name = "dgvSaleItems"
        Me.dgvSaleItems.Size = New System.Drawing.Size(521, 150)
        Me.dgvSaleItems.TabIndex = 3
        '
        'frmSalesManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvSaleItems)
        Me.Controls.Add(Me.btnDeleteSale)
        Me.Controls.Add(Me.btnUpdateSale)
        Me.Controls.Add(Me.btnNewSale)
        Me.Name = "frmSalesManagement"
        Me.Text = "SalesManagement"
        CType(Me.dgvSaleItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewSale As Button
    Friend WithEvents btnUpdateSale As Button
    Friend WithEvents btnDeleteSale As Button
    Friend WithEvents dgvSaleItems As DataGridView
End Class
