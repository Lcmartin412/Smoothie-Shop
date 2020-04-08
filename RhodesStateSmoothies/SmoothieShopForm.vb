'Levi
'Smoothie Shop
'11/25/2019
Option Strict On
Public Class SmoothieShopForm
    Const protein As Decimal = 0.5D
    Const vitamins As Decimal = 0.75D
    Const flaxseed As Decimal = 0.5D
    Const greentea As Decimal = 1D
    Const spinach As Decimal = 0.25D
    Const smoothiecost As Integer = 5I
    'Friend level vars are good anywhere in the project
    Friend smoothiessold As Integer
    Friend smoothiereceipts As Decimal
    Private Sub CalculateOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateOrderToolStripMenuItem.Click

        'declare variables

        Dim ordercost As Decimal
        Dim addins As Decimal
        Dim quantity As Integer

        'try catch 

        Try
            'conversions
            If QuantityTextBox.Text = "" Then
                MessageBox.Show("Please select quantity")
            Else
                quantity = CInt(QuantityTextBox.Text)
            End If

            'have to select a flavor
            If FlavorComboBox.SelectedIndex <> -1 And quantity > 0 Then

                'account for add ins 
                'seperate if statements because they can all be true 
                If ProteinCheckBox.Checked = True Then
                    addins += protein
                End If
                If VitaminsCheckBox.Checked = True Then
                    addins += vitamins
                End If
                If FlaxseedCheckBox.Checked = True Then
                    addins += flaxseed
                End If
                If GreenTeaCheckBox.Checked = True Then
                    addins += greentea
                End If
                If SpinachCheckBox.Checked = True Then
                    addins += spinach
                End If



                'calculations

                ordercost = (smoothiecost * quantity) + (quantity * addins)
                'add to total tickets
                smoothiessold += quantity
                smoothiereceipts += ordercost

                'display
                SmoothieCostLabel.Text = "Your cost is " + ordercost.ToString("C")
            Else MessageBox.Show("Please, select a flavor!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Sub

    Private Sub SmoothieShopForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlavorComboBox.Items.Add("Banana")
        FlavorComboBox.Items.Add("Pineapple")
        FlavorComboBox.Items.Add("Mango")
    End Sub

    Private Sub FlavorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FlavorComboBox.SelectedIndexChanged

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        QuantityTextBox.Text = ""
        SmoothieCostLabel.Text = ""
        FlavorComboBox.SelectedIndex = -1
        FlavorComboBox.Text = ""
        'ask if they wish to clear totals too
        Dim answer As DialogResult
        answer = MessageBox.Show("Clear totals too?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            smoothiessold = 0
            'TotalTicketsLabel.Text = "0"
            smoothiereceipts = 0
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'closes app
        Close()
    End Sub

    Private Sub AddSmoothFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSmoothFlavorToolStripMenuItem.Click
        'add some items to the flavor combo box
        'flavorcombobox.Items.Add(flavorComboBox.Text)
        'before adding, make sure its not already there
        Dim NameFound As Boolean = False
        Dim Index As Integer = 0
        If FlavorComboBox.Text <> "" Then
            'searching that list
            While NameFound = False And Index < FlavorComboBox.Items.Count
                If FlavorComboBox.Text.ToUpper = FlavorComboBox.Items(Index).ToString.ToUpper Then
                    NameFound = True
                Else
                    Index += 1
                End If
            End While
            'check the value of NameFound
            If NameFound = True Then
                MessageBox.Show("No duplicates, please !")
            Else
                FlavorComboBox.Items.Add(FlavorComboBox.Text)
            End If

        Else
            MessageBox.Show("Flavor is required.")
        End If
    End Sub

    Private Sub RemoveSmoothieFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSmoothieFlavorToolStripMenuItem.Click
        'remove an item from the list
        'ClassesListbox.Items.Remove
        'remove at looks for an index
        Dim Selection As Integer = FlavorComboBox.SelectedIndex
        If Selection <> -1 Then
            FlavorComboBox.Items.RemoveAt(Selection)
        Else
            MessageBox.Show("Select a flavor to remove, please!")
        End If
    End Sub

    Private Sub PrintSmoothieFlavorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSmoothieFlavorsToolStripMenuItem.Click
        'display the print preview dialog
        'first point the dialog box to the print document
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'here is where we create our page
        ' e.Graphics.DrawRectangle(Pens.Blue, 20, 20, 100, 300)
        ' e.Graphics.FillEllipse(Brushes.Red, 20, 20, 100, 300)

        'need to create a font for our drawstring method
        Dim reportFont As New Font("Times New Roman", 20)
        e.Graphics.DrawString("Here Are Our Flavors Today", reportFont, Brushes.Black, 150, 20)

        'loop through all items in list box,
        'printing each on a new line
        Dim Index As Integer = 0
        Dim ycoordinate As Integer = 40

        For Index = 0 To FlavorComboBox.Items.Count - 1
            e.Graphics.DrawString(FlavorComboBox.Items(Index).ToString, reportFont, Brushes.DarkGray, 30, ycoordinate)
            ycoordinate += 25
        Next
        ycoordinate += 50
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ShowTotalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowTotalsToolStripMenuItem.Click
        SummaryForm.ShowDialog()
    End Sub
End Class
