<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateSale
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
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.lblIdProduct = New System.Windows.Forms.Label()
        Me.txtIdProduct = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox1.Controls.Add(Me.lblUnitPrice)
        Me.GroupBox1.Controls.Add(Me.lblQuantity)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnAccept)
        Me.GroupBox1.Controls.Add(Me.lblIdProduct)
        Me.GroupBox1.Controls.Add(Me.txtIdProduct)
        Me.GroupBox1.Location = New System.Drawing.Point(220, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 394)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Sale"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(122, 216)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(155, 20)
        Me.txtQuantity.TabIndex = 13
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(126, 174)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(151, 20)
        Me.txtUnitPrice.TabIndex = 12
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.Location = New System.Drawing.Point(41, 174)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(56, 13)
        Me.lblUnitPrice.TabIndex = 9
        Me.lblUnitPrice.Text = "Unit Price:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(48, 216)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 13)
        Me.lblQuantity.TabIndex = 8
        Me.lblQuantity.Text = "Quantity:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(211, 336)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(39, 336)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 6
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'lblIdProduct
        '
        Me.lblIdProduct.AutoSize = True
        Me.lblIdProduct.Location = New System.Drawing.Point(36, 121)
        Me.lblIdProduct.Name = "lblIdProduct"
        Me.lblIdProduct.Size = New System.Drawing.Size(61, 13)
        Me.lblIdProduct.TabIndex = 5
        Me.lblIdProduct.Text = "ID Product:"
        '
        'txtIdProduct
        '
        Me.txtIdProduct.Location = New System.Drawing.Point(122, 118)
        Me.txtIdProduct.Name = "txtIdProduct"
        Me.txtIdProduct.Size = New System.Drawing.Size(155, 20)
        Me.txtIdProduct.TabIndex = 2
        '
        'frmUpdateSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUpdateSale"
        Me.Text = "frmUpdateSale"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents lblIdProduct As Label
    Friend WithEvents txtIdProduct As TextBox
End Class
