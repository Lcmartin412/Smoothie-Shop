<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.smoothiesoldlabel = New System.Windows.Forms.Label()
        Me.totalreceiptslabel = New System.Windows.Forms.Label()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'smoothiesoldlabel
        '
        Me.smoothiesoldlabel.AutoSize = True
        Me.smoothiesoldlabel.Location = New System.Drawing.Point(127, 103)
        Me.smoothiesoldlabel.Name = "smoothiesoldlabel"
        Me.smoothiesoldlabel.Size = New System.Drawing.Size(39, 13)
        Me.smoothiesoldlabel.TabIndex = 0
        Me.smoothiesoldlabel.Text = "Label1"
        '
        'totalreceiptslabel
        '
        Me.totalreceiptslabel.AutoSize = True
        Me.totalreceiptslabel.Location = New System.Drawing.Point(127, 151)
        Me.totalreceiptslabel.Name = "totalreceiptslabel"
        Me.totalreceiptslabel.Size = New System.Drawing.Size(39, 13)
        Me.totalreceiptslabel.TabIndex = 1
        Me.totalreceiptslabel.Text = "Label2"
        '
        'closebutton
        '
        Me.closebutton.Location = New System.Drawing.Point(150, 197)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(75, 23)
        Me.closebutton.TabIndex = 2
        Me.closebutton.Text = "Okay"
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 376)
        Me.Controls.Add(Me.closebutton)
        Me.Controls.Add(Me.totalreceiptslabel)
        Me.Controls.Add(Me.smoothiesoldlabel)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents smoothiesoldlabel As Label
    Friend WithEvents totalreceiptslabel As Label
    Friend WithEvents closebutton As Button
End Class
