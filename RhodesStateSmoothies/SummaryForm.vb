'Levi Martin
Public Class SummaryForm

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        'closes window
        Me.Close()
    End Sub

    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display the Friend level variables in  the labels
        smoothiesoldlabel.Text = "Smoothies Sold: " + SmoothieShopForm.smoothiessold.ToString
        totalreceiptslabel.Text = "Total Receipts: " + SmoothieShopForm.smoothiereceipts.ToString("C")

    End Sub
End Class