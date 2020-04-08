<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmoothieShopForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SmoothieShopForm))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SmoothieCostLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SpinachCheckBox = New System.Windows.Forms.CheckBox()
        Me.GreenTeaCheckBox = New System.Windows.Forms.CheckBox()
        Me.FlaxseedCheckBox = New System.Windows.Forms.CheckBox()
        Me.VitaminsCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProteinCheckBox = New System.Windows.Forms.CheckBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlavorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSmoothieFlavorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSmoothFlavorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveSmoothieFlavorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ShowTotalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 87)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(418, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Stop in today and try our latest flavors."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RhodesStateSmoothies.My.Resources.Resources.Smoothie
        Me.PictureBox1.Location = New System.Drawing.Point(329, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(341, 28)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "The best in the Lima area!"
        '
        'SmoothieCostLabel
        '
        Me.SmoothieCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SmoothieCostLabel.Location = New System.Drawing.Point(227, 415)
        Me.SmoothieCostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SmoothieCostLabel.Name = "SmoothieCostLabel"
        Me.SmoothieCostLabel.Size = New System.Drawing.Size(133, 26)
        Me.SmoothieCostLabel.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 416)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Order Cost:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SpinachCheckBox)
        Me.GroupBox1.Controls.Add(Me.GreenTeaCheckBox)
        Me.GroupBox1.Controls.Add(Me.FlaxseedCheckBox)
        Me.GroupBox1.Controls.Add(Me.VitaminsCheckBox)
        Me.GroupBox1.Controls.Add(Me.ProteinCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 193)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(219, 193)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Additional Add-Ins"
        '
        'SpinachCheckBox
        '
        Me.SpinachCheckBox.AutoSize = True
        Me.SpinachCheckBox.Location = New System.Drawing.Point(8, 141)
        Me.SpinachCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SpinachCheckBox.Name = "SpinachCheckBox"
        Me.SpinachCheckBox.Size = New System.Drawing.Size(89, 17)
        Me.SpinachCheckBox.TabIndex = 4
        Me.SpinachCheckBox.Text = "Spinach $.25"
        Me.SpinachCheckBox.UseVisualStyleBackColor = True
        '
        'GreenTeaCheckBox
        '
        Me.GreenTeaCheckBox.AutoSize = True
        Me.GreenTeaCheckBox.Location = New System.Drawing.Point(8, 113)
        Me.GreenTeaCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GreenTeaCheckBox.Name = "GreenTeaCheckBox"
        Me.GreenTeaCheckBox.Size = New System.Drawing.Size(107, 17)
        Me.GreenTeaCheckBox.TabIndex = 3
        Me.GreenTeaCheckBox.Text = "Green Tea $1.00"
        Me.GreenTeaCheckBox.UseVisualStyleBackColor = True
        '
        'FlaxseedCheckBox
        '
        Me.FlaxseedCheckBox.AutoSize = True
        Me.FlaxseedCheckBox.Location = New System.Drawing.Point(8, 87)
        Me.FlaxseedCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FlaxseedCheckBox.Name = "FlaxseedCheckBox"
        Me.FlaxseedCheckBox.Size = New System.Drawing.Size(92, 17)
        Me.FlaxseedCheckBox.TabIndex = 2
        Me.FlaxseedCheckBox.Text = "Flaxseed $.50"
        Me.FlaxseedCheckBox.UseVisualStyleBackColor = True
        '
        'VitaminsCheckBox
        '
        Me.VitaminsCheckBox.AutoSize = True
        Me.VitaminsCheckBox.Location = New System.Drawing.Point(8, 60)
        Me.VitaminsCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.VitaminsCheckBox.Name = "VitaminsCheckBox"
        Me.VitaminsCheckBox.Size = New System.Drawing.Size(112, 17)
        Me.VitaminsCheckBox.TabIndex = 1
        Me.VitaminsCheckBox.Text = "Vitamin Pack $.75"
        Me.VitaminsCheckBox.UseVisualStyleBackColor = True
        '
        'ProteinCheckBox
        '
        Me.ProteinCheckBox.AutoSize = True
        Me.ProteinCheckBox.Location = New System.Drawing.Point(8, 34)
        Me.ProteinCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ProteinCheckBox.Name = "ProteinCheckBox"
        Me.ProteinCheckBox.Size = New System.Drawing.Size(122, 17)
        Me.ProteinCheckBox.TabIndex = 0
        Me.ProteinCheckBox.Text = "Protein Powder $.50"
        Me.ProteinCheckBox.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(190, 155)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(132, 20)
        Me.QuantityTextBox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Quantity"
        '
        'FlavorComboBox
        '
        Me.FlavorComboBox.FormattingEnabled = True
        Me.FlavorComboBox.Location = New System.Drawing.Point(3, 155)
        Me.FlavorComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FlavorComboBox.Name = "FlavorComboBox"
        Me.FlavorComboBox.Size = New System.Drawing.Size(160, 21)
        Me.FlavorComboBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Choose a flavor:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(574, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateOrderToolStripMenuItem, Me.PrintSmoothieFlavorsToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ShowTotalsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CalculateOrderToolStripMenuItem
        '
        Me.CalculateOrderToolStripMenuItem.Name = "CalculateOrderToolStripMenuItem"
        Me.CalculateOrderToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CalculateOrderToolStripMenuItem.Text = "Calculate Order"
        '
        'PrintSmoothieFlavorsToolStripMenuItem
        '
        Me.PrintSmoothieFlavorsToolStripMenuItem.Name = "PrintSmoothieFlavorsToolStripMenuItem"
        Me.PrintSmoothieFlavorsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PrintSmoothieFlavorsToolStripMenuItem.Text = "Print Smoothie Flavors"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.AddSmoothFlavorToolStripMenuItem, Me.RemoveSmoothieFlavorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'AddSmoothFlavorToolStripMenuItem
        '
        Me.AddSmoothFlavorToolStripMenuItem.Name = "AddSmoothFlavorToolStripMenuItem"
        Me.AddSmoothFlavorToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AddSmoothFlavorToolStripMenuItem.Text = "Add Smooth Flavor"
        '
        'RemoveSmoothieFlavorToolStripMenuItem
        '
        Me.RemoveSmoothieFlavorToolStripMenuItem.Name = "RemoveSmoothieFlavorToolStripMenuItem"
        Me.RemoveSmoothieFlavorToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.RemoveSmoothieFlavorToolStripMenuItem.Text = "Remove Smoothie Flavor"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ShowTotalsToolStripMenuItem
        '
        Me.ShowTotalsToolStripMenuItem.Name = "ShowTotalsToolStripMenuItem"
        Me.ShowTotalsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ShowTotalsToolStripMenuItem.Text = "Show Totals"
        '
        'SmoothieShopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(574, 453)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SmoothieCostLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlavorComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "SmoothieShopForm"
        Me.Text = "The Best in Lima"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SmoothieCostLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SpinachCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GreenTeaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FlaxseedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VitaminsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProteinCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlavorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSmoothieFlavorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSmoothFlavorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveSmoothieFlavorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ShowTotalsToolStripMenuItem As ToolStripMenuItem
End Class
