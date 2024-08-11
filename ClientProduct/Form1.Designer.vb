<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvClients = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDeleteClient = New System.Windows.Forms.Button()
        Me.btnUpdateClient = New System.Windows.Forms.Button()
        Me.btnNewClient = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnNewProduct = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClients
        '
        Me.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClients.Location = New System.Drawing.Point(24, 19)
        Me.dgvClients.Name = "dgvClients"
        Me.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClients.Size = New System.Drawing.Size(769, 230)
        Me.dgvClients.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvClients)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(875, 382)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clients And Products"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDeleteClient)
        Me.GroupBox3.Controls.Add(Me.btnUpdateClient)
        Me.GroupBox3.Controls.Add(Me.btnNewClient)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 266)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clients management"
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.Location = New System.Drawing.Point(263, 49)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteClient.TabIndex = 2
        Me.btnDeleteClient.Text = "Delete"
        Me.btnDeleteClient.UseVisualStyleBackColor = True
        '
        'btnUpdateClient
        '
        Me.btnUpdateClient.Location = New System.Drawing.Point(140, 49)
        Me.btnUpdateClient.Name = "btnUpdateClient"
        Me.btnUpdateClient.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateClient.TabIndex = 1
        Me.btnUpdateClient.Text = "Update"
        Me.btnUpdateClient.UseVisualStyleBackColor = True
        '
        'btnNewClient
        '
        Me.btnNewClient.Location = New System.Drawing.Point(28, 49)
        Me.btnNewClient.Name = "btnNewClient"
        Me.btnNewClient.Size = New System.Drawing.Size(75, 23)
        Me.btnNewClient.TabIndex = 0
        Me.btnNewClient.Text = "New"
        Me.btnNewClient.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnDeleteProduct)
        Me.GroupBox4.Controls.Add(Me.btnUpdateProduct)
        Me.GroupBox4.Controls.Add(Me.btnNewProduct)
        Me.GroupBox4.Location = New System.Drawing.Point(425, 266)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(315, 100)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Product management"
        '
        'btnNewProduct
        '
        Me.btnNewProduct.Location = New System.Drawing.Point(6, 49)
        Me.btnNewProduct.Name = "btnNewProduct"
        Me.btnNewProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnNewProduct.TabIndex = 1
        Me.btnNewProduct.Text = "New"
        Me.btnNewProduct.UseVisualStyleBackColor = True
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.Location = New System.Drawing.Point(115, 49)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateProduct.TabIndex = 2
        Me.btnUpdateProduct.Text = "Update"
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Location = New System.Drawing.Point(222, 49)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteProduct.TabIndex = 3
        Me.btnDeleteProduct.Text = "Delete"
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(58, 409)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Size = New System.Drawing.Size(505, 173)
        Me.dgvProducts.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 592)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "dgvClients"
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvClients As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDeleteClient As Button
    Friend WithEvents btnUpdateClient As Button
    Friend WithEvents btnNewClient As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents btnNewProduct As Button
    Friend WithEvents dgvProducts As DataGridView
End Class
