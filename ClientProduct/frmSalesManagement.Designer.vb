<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesManagement
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
        Me.btnNewSale = New System.Windows.Forms.Button()
        Me.btnUpdateSale = New System.Windows.Forms.Button()
        Me.btnDeleteSale = New System.Windows.Forms.Button()
        Me.dgvSaleItems = New System.Windows.Forms.DataGridView()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.lblTotalSoldItems = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtClienIdSearch = New System.Windows.Forms.TextBox()
        Me.lblClientId = New System.Windows.Forms.Label()
        Me.txtIdSaleSearch = New System.Windows.Forms.TextBox()
        Me.lblIdSale = New System.Windows.Forms.Label()
        Me.dgvSalesInfo = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvSaleItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSalesInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNewSale
        '
        Me.btnNewSale.Location = New System.Drawing.Point(66, 228)
        Me.btnNewSale.Name = "btnNewSale"
        Me.btnNewSale.Size = New System.Drawing.Size(75, 23)
        Me.btnNewSale.TabIndex = 0
        Me.btnNewSale.Text = "New Sale"
        Me.btnNewSale.UseVisualStyleBackColor = True
        '
        'btnUpdateSale
        '
        Me.btnUpdateSale.Location = New System.Drawing.Point(216, 228)
        Me.btnUpdateSale.Name = "btnUpdateSale"
        Me.btnUpdateSale.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateSale.TabIndex = 1
        Me.btnUpdateSale.Text = "Update"
        Me.btnUpdateSale.UseVisualStyleBackColor = True
        '
        'btnDeleteSale
        '
        Me.btnDeleteSale.Location = New System.Drawing.Point(386, 228)
        Me.btnDeleteSale.Name = "btnDeleteSale"
        Me.btnDeleteSale.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteSale.TabIndex = 2
        Me.btnDeleteSale.Text = "Delete"
        Me.btnDeleteSale.UseVisualStyleBackColor = True
        '
        'dgvSaleItems
        '
        Me.dgvSaleItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaleItems.Location = New System.Drawing.Point(20, 28)
        Me.dgvSaleItems.Name = "dgvSaleItems"
        Me.dgvSaleItems.Size = New System.Drawing.Size(488, 150)
        Me.dgvSaleItems.TabIndex = 3
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Location = New System.Drawing.Point(350, 192)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(116, 13)
        Me.lblTotalItems.TabIndex = 4
        Me.lblTotalItems.Text = "Total Price Sold Items: "
        '
        'lblTotalSoldItems
        '
        Me.lblTotalSoldItems.AutoSize = True
        Me.lblTotalSoldItems.Location = New System.Drawing.Point(472, 192)
        Me.lblTotalSoldItems.Name = "lblTotalSoldItems"
        Me.lblTotalSoldItems.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalSoldItems.TabIndex = 5
        Me.lblTotalSoldItems.Text = "."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClienIdSearch)
        Me.GroupBox1.Controls.Add(Me.lblClientId)
        Me.GroupBox1.Controls.Add(Me.txtIdSaleSearch)
        Me.GroupBox1.Controls.Add(Me.lblIdSale)
        Me.GroupBox1.Controls.Add(Me.dgvSalesInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 201)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Info"
        '
        'txtClienIdSearch
        '
        Me.txtClienIdSearch.Location = New System.Drawing.Point(463, 84)
        Me.txtClienIdSearch.Name = "txtClienIdSearch"
        Me.txtClienIdSearch.Size = New System.Drawing.Size(170, 20)
        Me.txtClienIdSearch.TabIndex = 4
        '
        'lblClientId
        '
        Me.lblClientId.AutoSize = True
        Me.lblClientId.Location = New System.Drawing.Point(418, 87)
        Me.lblClientId.Name = "lblClientId"
        Me.lblClientId.Size = New System.Drawing.Size(48, 13)
        Me.lblClientId.TabIndex = 3
        Me.lblClientId.Text = "Client Id:"
        '
        'txtIdSaleSearch
        '
        Me.txtIdSaleSearch.Location = New System.Drawing.Point(463, 41)
        Me.txtIdSaleSearch.Name = "txtIdSaleSearch"
        Me.txtIdSaleSearch.Size = New System.Drawing.Size(170, 20)
        Me.txtIdSaleSearch.TabIndex = 2
        '
        'lblIdSale
        '
        Me.lblIdSale.AutoSize = True
        Me.lblIdSale.Location = New System.Drawing.Point(418, 44)
        Me.lblIdSale.Name = "lblIdSale"
        Me.lblIdSale.Size = New System.Drawing.Size(43, 13)
        Me.lblIdSale.TabIndex = 1
        Me.lblIdSale.Text = "Sale Id:"
        '
        'dgvSalesInfo
        '
        Me.dgvSalesInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSalesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesInfo.Location = New System.Drawing.Point(20, 29)
        Me.dgvSalesInfo.Name = "dgvSalesInfo"
        Me.dgvSalesInfo.Size = New System.Drawing.Size(382, 150)
        Me.dgvSalesInfo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvSaleItems)
        Me.GroupBox2.Controls.Add(Me.btnNewSale)
        Me.GroupBox2.Controls.Add(Me.lblTotalSoldItems)
        Me.GroupBox2.Controls.Add(Me.btnUpdateSale)
        Me.GroupBox2.Controls.Add(Me.lblTotalItems)
        Me.GroupBox2.Controls.Add(Me.btnDeleteSale)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 264)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sold Items Info"
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Location = New System.Drawing.Point(673, 83)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(111, 23)
        Me.btnGenerateReport.TabIndex = 8
        Me.btnGenerateReport.Text = "Generate Report "
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(673, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = " Sales and Products"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSalesManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 526)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSalesManagement"
        Me.Text = "Sales Management"
        CType(Me.dgvSaleItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSalesInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewSale As Button
    Friend WithEvents btnUpdateSale As Button
    Friend WithEvents btnDeleteSale As Button
    Friend WithEvents dgvSaleItems As DataGridView
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents lblTotalSoldItems As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSalesInfo As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIdSaleSearch As TextBox
    Friend WithEvents lblIdSale As Label
    Friend WithEvents txtClienIdSearch As TextBox
    Friend WithEvents lblClientId As Label
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents Button1 As Button
End Class
