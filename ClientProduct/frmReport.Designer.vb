<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalSaleInfoHigh = New System.Windows.Forms.Label()
        Me.lblSaleDateInfoHigh = New System.Windows.Forms.Label()
        Me.lblClientIdInfoHigh = New System.Windows.Forms.Label()
        Me.lblSaleIdInfoHigh = New System.Windows.Forms.Label()
        Me.lblTotalSale = New System.Windows.Forms.Label()
        Me.lblSaleDate = New System.Windows.Forms.Label()
        Me.lblSaleId = New System.Windows.Forms.Label()
        Me.lblClientId = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotalSaleInfoLow = New System.Windows.Forms.Label()
        Me.lblSaleDateInfoLow = New System.Windows.Forms.Label()
        Me.lblClientIdInfoLow = New System.Windows.Forms.Label()
        Me.lblSaleIdInfoLow = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblLeastSoldProductQuantity = New System.Windows.Forms.Label()
        Me.lblLeastSoldProductId = New System.Windows.Forms.Label()
        Me.lblProductId = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblMostSoldProductQuantity = New System.Windows.Forms.Label()
        Me.lblMostSoldProductId = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 205)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalSaleInfoHigh)
        Me.GroupBox2.Controls.Add(Me.lblSaleDateInfoHigh)
        Me.GroupBox2.Controls.Add(Me.lblClientIdInfoHigh)
        Me.GroupBox2.Controls.Add(Me.lblSaleIdInfoHigh)
        Me.GroupBox2.Controls.Add(Me.lblTotalSale)
        Me.GroupBox2.Controls.Add(Me.lblSaleDate)
        Me.GroupBox2.Controls.Add(Me.lblSaleId)
        Me.GroupBox2.Controls.Add(Me.lblClientId)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 80)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sale With Highest Total"
        '
        'lblTotalSaleInfoHigh
        '
        Me.lblTotalSaleInfoHigh.AutoSize = True
        Me.lblTotalSaleInfoHigh.Location = New System.Drawing.Point(442, 42)
        Me.lblTotalSaleInfoHigh.Name = "lblTotalSaleInfoHigh"
        Me.lblTotalSaleInfoHigh.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalSaleInfoHigh.TabIndex = 8
        Me.lblTotalSaleInfoHigh.Text = "."
        '
        'lblSaleDateInfoHigh
        '
        Me.lblSaleDateInfoHigh.AutoSize = True
        Me.lblSaleDateInfoHigh.Location = New System.Drawing.Point(334, 42)
        Me.lblSaleDateInfoHigh.Name = "lblSaleDateInfoHigh"
        Me.lblSaleDateInfoHigh.Size = New System.Drawing.Size(10, 13)
        Me.lblSaleDateInfoHigh.TabIndex = 7
        Me.lblSaleDateInfoHigh.Text = "."
        '
        'lblClientIdInfoHigh
        '
        Me.lblClientIdInfoHigh.AutoSize = True
        Me.lblClientIdInfoHigh.Location = New System.Drawing.Point(181, 42)
        Me.lblClientIdInfoHigh.Name = "lblClientIdInfoHigh"
        Me.lblClientIdInfoHigh.Size = New System.Drawing.Size(10, 13)
        Me.lblClientIdInfoHigh.TabIndex = 6
        Me.lblClientIdInfoHigh.Text = "."
        '
        'lblSaleIdInfoHigh
        '
        Me.lblSaleIdInfoHigh.AutoSize = True
        Me.lblSaleIdInfoHigh.Location = New System.Drawing.Point(77, 42)
        Me.lblSaleIdInfoHigh.Name = "lblSaleIdInfoHigh"
        Me.lblSaleIdInfoHigh.Size = New System.Drawing.Size(10, 13)
        Me.lblSaleIdInfoHigh.TabIndex = 5
        Me.lblSaleIdInfoHigh.Text = "."
        '
        'lblTotalSale
        '
        Me.lblTotalSale.AutoSize = True
        Me.lblTotalSale.Location = New System.Drawing.Point(399, 42)
        Me.lblTotalSale.Name = "lblTotalSale"
        Me.lblTotalSale.Size = New System.Drawing.Size(37, 13)
        Me.lblTotalSale.TabIndex = 4
        Me.lblTotalSale.Text = "Total: "
        '
        'lblSaleDate
        '
        Me.lblSaleDate.AutoSize = True
        Me.lblSaleDate.Location = New System.Drawing.Point(268, 42)
        Me.lblSaleDate.Name = "lblSaleDate"
        Me.lblSaleDate.Size = New System.Drawing.Size(60, 13)
        Me.lblSaleDate.TabIndex = 3
        Me.lblSaleDate.Text = "Sale Date: "
        '
        'lblSaleId
        '
        Me.lblSaleId.AutoSize = True
        Me.lblSaleId.Location = New System.Drawing.Point(28, 42)
        Me.lblSaleId.Name = "lblSaleId"
        Me.lblSaleId.Size = New System.Drawing.Size(43, 13)
        Me.lblSaleId.TabIndex = 2
        Me.lblSaleId.Text = "Sale Id:"
        '
        'lblClientId
        '
        Me.lblClientId.AutoSize = True
        Me.lblClientId.Location = New System.Drawing.Point(124, 42)
        Me.lblClientId.Name = "lblClientId"
        Me.lblClientId.Size = New System.Drawing.Size(51, 13)
        Me.lblClientId.TabIndex = 1
        Me.lblClientId.Text = "Client Id: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalSaleInfoLow)
        Me.GroupBox3.Controls.Add(Me.lblSaleDateInfoLow)
        Me.GroupBox3.Controls.Add(Me.lblClientIdInfoLow)
        Me.GroupBox3.Controls.Add(Me.lblSaleIdInfoLow)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(538, 80)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sale With Lowest Total"
        '
        'lblTotalSaleInfoLow
        '
        Me.lblTotalSaleInfoLow.AutoSize = True
        Me.lblTotalSaleInfoLow.Location = New System.Drawing.Point(442, 42)
        Me.lblTotalSaleInfoLow.Name = "lblTotalSaleInfoLow"
        Me.lblTotalSaleInfoLow.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalSaleInfoLow.TabIndex = 8
        Me.lblTotalSaleInfoLow.Text = "."
        '
        'lblSaleDateInfoLow
        '
        Me.lblSaleDateInfoLow.AutoSize = True
        Me.lblSaleDateInfoLow.Location = New System.Drawing.Point(334, 42)
        Me.lblSaleDateInfoLow.Name = "lblSaleDateInfoLow"
        Me.lblSaleDateInfoLow.Size = New System.Drawing.Size(10, 13)
        Me.lblSaleDateInfoLow.TabIndex = 7
        Me.lblSaleDateInfoLow.Text = "."
        '
        'lblClientIdInfoLow
        '
        Me.lblClientIdInfoLow.AutoSize = True
        Me.lblClientIdInfoLow.Location = New System.Drawing.Point(181, 42)
        Me.lblClientIdInfoLow.Name = "lblClientIdInfoLow"
        Me.lblClientIdInfoLow.Size = New System.Drawing.Size(10, 13)
        Me.lblClientIdInfoLow.TabIndex = 6
        Me.lblClientIdInfoLow.Text = "."
        '
        'lblSaleIdInfoLow
        '
        Me.lblSaleIdInfoLow.AutoSize = True
        Me.lblSaleIdInfoLow.Location = New System.Drawing.Point(77, 42)
        Me.lblSaleIdInfoLow.Name = "lblSaleIdInfoLow"
        Me.lblSaleIdInfoLow.Size = New System.Drawing.Size(10, 13)
        Me.lblSaleIdInfoLow.TabIndex = 5
        Me.lblSaleIdInfoLow.Text = "."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(399, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Sale Date: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Sale Id:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(124, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Client Id: "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(79, 250)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(634, 205)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Products"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblLeastSoldProductQuantity)
        Me.GroupBox5.Controls.Add(Me.lblLeastSoldProductId)
        Me.GroupBox5.Controls.Add(Me.lblProductId)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Location = New System.Drawing.Point(32, 105)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(538, 80)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Least Sold Product"
        '
        'lblLeastSoldProductQuantity
        '
        Me.lblLeastSoldProductQuantity.AutoSize = True
        Me.lblLeastSoldProductQuantity.Location = New System.Drawing.Point(285, 42)
        Me.lblLeastSoldProductQuantity.Name = "lblLeastSoldProductQuantity"
        Me.lblLeastSoldProductQuantity.Size = New System.Drawing.Size(10, 13)
        Me.lblLeastSoldProductQuantity.TabIndex = 6
        Me.lblLeastSoldProductQuantity.Text = "."
        '
        'lblLeastSoldProductId
        '
        Me.lblLeastSoldProductId.AutoSize = True
        Me.lblLeastSoldProductId.Location = New System.Drawing.Point(77, 42)
        Me.lblLeastSoldProductId.Name = "lblLeastSoldProductId"
        Me.lblLeastSoldProductId.Size = New System.Drawing.Size(10, 13)
        Me.lblLeastSoldProductId.TabIndex = 5
        Me.lblLeastSoldProductId.Text = "."
        '
        'lblProductId
        '
        Me.lblProductId.AutoSize = True
        Me.lblProductId.Location = New System.Drawing.Point(12, 42)
        Me.lblProductId.Name = "lblProductId"
        Me.lblProductId.Size = New System.Drawing.Size(59, 13)
        Me.lblProductId.TabIndex = 2
        Me.lblProductId.Text = "Product Id:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(228, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Quantity:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblMostSoldProductQuantity)
        Me.GroupBox6.Controls.Add(Me.lblMostSoldProductId)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Location = New System.Drawing.Point(32, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(538, 80)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Most Sold Product"
        '
        'lblMostSoldProductQuantity
        '
        Me.lblMostSoldProductQuantity.AutoSize = True
        Me.lblMostSoldProductQuantity.Location = New System.Drawing.Point(285, 42)
        Me.lblMostSoldProductQuantity.Name = "lblMostSoldProductQuantity"
        Me.lblMostSoldProductQuantity.Size = New System.Drawing.Size(10, 13)
        Me.lblMostSoldProductQuantity.TabIndex = 6
        Me.lblMostSoldProductQuantity.Text = "."
        '
        'lblMostSoldProductId
        '
        Me.lblMostSoldProductId.AutoSize = True
        Me.lblMostSoldProductId.Location = New System.Drawing.Point(77, 42)
        Me.lblMostSoldProductId.Name = "lblMostSoldProductId"
        Me.lblMostSoldProductId.Size = New System.Drawing.Size(10, 13)
        Me.lblMostSoldProductId.TabIndex = 5
        Me.lblMostSoldProductId.Text = "."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Product Id:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(228, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Quantity:"
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReport"
        Me.Text = "Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblClientId As Label
    Friend WithEvents lblSaleId As Label
    Friend WithEvents lblSaleDate As Label
    Friend WithEvents lblTotalSaleInfoHigh As Label
    Friend WithEvents lblSaleDateInfoHigh As Label
    Friend WithEvents lblClientIdInfoHigh As Label
    Friend WithEvents lblSaleIdInfoHigh As Label
    Friend WithEvents lblTotalSale As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotalSaleInfoLow As Label
    Friend WithEvents lblSaleDateInfoLow As Label
    Friend WithEvents lblClientIdInfoLow As Label
    Friend WithEvents lblSaleIdInfoLow As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblLeastSoldProductQuantity As Label
    Friend WithEvents lblLeastSoldProductId As Label
    Friend WithEvents lblProductId As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblMostSoldProductQuantity As Label
    Friend WithEvents lblMostSoldProductId As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
End Class
