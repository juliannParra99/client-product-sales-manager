﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.btnNewProduct = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.btnSalesManagment = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNewClient = New System.Windows.Forms.Button()
        Me.btnUpdateClient = New System.Windows.Forms.Button()
        Me.btnDeleteClient = New System.Windows.Forms.Button()
        Me.dgvClients = New System.Windows.Forms.DataGridView()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNameOrCategory = New System.Windows.Forms.TextBox()
        Me.lblNameOrCategory = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnDeleteProduct)
        Me.GroupBox4.Controls.Add(Me.btnUpdateProduct)
        Me.GroupBox4.Controls.Add(Me.btnNewProduct)
        Me.GroupBox4.Location = New System.Drawing.Point(564, 529)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(315, 100)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Product management"
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
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.Location = New System.Drawing.Point(115, 49)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateProduct.TabIndex = 2
        Me.btnUpdateProduct.Text = "Update"
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
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
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(12, 456)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Size = New System.Drawing.Size(505, 173)
        Me.dgvProducts.TabIndex = 5
        '
        'btnSalesManagment
        '
        Me.btnSalesManagment.Location = New System.Drawing.Point(819, 82)
        Me.btnSalesManagment.Name = "btnSalesManagment"
        Me.btnSalesManagment.Size = New System.Drawing.Size(162, 23)
        Me.btnSalesManagment.TabIndex = 6
        Me.btnSalesManagment.Text = "Sales Management"
        Me.btnSalesManagment.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDeleteClient)
        Me.GroupBox3.Controls.Add(Me.btnUpdateClient)
        Me.GroupBox3.Controls.Add(Me.btnNewClient)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 353)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 66)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clients management"
        '
        'btnNewClient
        '
        Me.btnNewClient.Location = New System.Drawing.Point(12, 19)
        Me.btnNewClient.Name = "btnNewClient"
        Me.btnNewClient.Size = New System.Drawing.Size(75, 23)
        Me.btnNewClient.TabIndex = 0
        Me.btnNewClient.Text = "New"
        Me.btnNewClient.UseVisualStyleBackColor = True
        '
        'btnUpdateClient
        '
        Me.btnUpdateClient.Location = New System.Drawing.Point(124, 19)
        Me.btnUpdateClient.Name = "btnUpdateClient"
        Me.btnUpdateClient.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateClient.TabIndex = 1
        Me.btnUpdateClient.Text = "Update"
        Me.btnUpdateClient.UseVisualStyleBackColor = True
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.Location = New System.Drawing.Point(247, 19)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteClient.TabIndex = 2
        Me.btnDeleteClient.Text = "Delete"
        Me.btnDeleteClient.UseVisualStyleBackColor = True
        '
        'dgvClients
        '
        Me.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClients.Location = New System.Drawing.Point(6, 127)
        Me.dgvClients.Name = "dgvClients"
        Me.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClients.Size = New System.Drawing.Size(769, 210)
        Me.dgvClients.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(18, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name/Email:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(92, 35)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(175, 20)
        Me.txtName.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNameOrCategory)
        Me.GroupBox1.Controls.Add(Me.lblNameOrCategory)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.dgvClients)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(823, 425)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clients And Products"
        '
        'txtNameOrCategory
        '
        Me.txtNameOrCategory.Location = New System.Drawing.Point(511, 374)
        Me.txtNameOrCategory.Name = "txtNameOrCategory"
        Me.txtNameOrCategory.Size = New System.Drawing.Size(175, 20)
        Me.txtNameOrCategory.TabIndex = 8
        '
        'lblNameOrCategory
        '
        Me.lblNameOrCategory.AutoSize = True
        Me.lblNameOrCategory.Location = New System.Drawing.Point(423, 377)
        Me.lblNameOrCategory.Name = "lblNameOrCategory"
        Me.lblNameOrCategory.Size = New System.Drawing.Size(82, 13)
        Me.lblNameOrCategory.TabIndex = 7
        Me.lblNameOrCategory.Text = "Name/Category"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 641)
        Me.Controls.Add(Me.btnSalesManagment)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "dgvClients"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents btnNewProduct As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnSalesManagment As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDeleteClient As Button
    Friend WithEvents btnUpdateClient As Button
    Friend WithEvents btnNewClient As Button
    Friend WithEvents dgvClients As DataGridView
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNameOrCategory As TextBox
    Friend WithEvents lblNameOrCategory As Label
End Class
