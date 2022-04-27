Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const strName As String = "MUHAMMAD ZULEHLMI BIN NOOR AFENDI (10DDT20F1005)"
        lblName.Text = "Name : " & strName

        Dim Years As Integer
        Dim Srate As Integer
        Dim Erate As Integer

        Years = 2
        Srate = 1
        Erate = 2

        While Years <= 10
            cbYears.Items.Add(Years)
            Years += 1
        End While

        While Srate <= 10
            cbSrate.Items.Add(Srate)
            Srate += 1
        End While

        While Erate <= 12
            cbErate.Items.Add(Erate)
            Erate += 1
        End While
        listOutput.Items.Add("                     Interest Rate (%)                    Monthly Payment (RM)")
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Amount As Double
        Dim Years As Integer
        Dim Srate As Integer
        Dim Erate As Integer
        Dim sStep As Double
        Dim Total As Decimal

        Amount = Double.Parse(txtAmount.Text.ToString())
        Years = Integer.Parse(cbYears.GetItemText(cbYears.SelectedItem))
        Srate = Integer.Parse(cbSrate.GetItemText(cbSrate.SelectedItem))
        Erate = Integer.Parse(cbErate.GetItemText(cbErate.SelectedItem))
        sStep = Double.Parse(txtRate.Text.ToString())

        For strRate = Srate To Erate Step sStep
            'Interest rate = (rate / 12) / 100
            Total = -Pmt((strRate / 12) / 100, Years * 12, Amount)
            listOutput.Items.Add("                            " & String.Format(FormatPercent(strRate.ToString / 100) & "                                     " & FormatCurrency(Total.ToString, 2)))

        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Text = ""
        cbYears.ResetText()
        cbSrate.ResetText()
        cbErate.ResetText()
        txtRate.Text = ""
        listOutput.Items.Clear()
        listOutput.Items.Add("                     Interest Rate (%)                    Monthly Payment (RM)")
    End Sub

    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click
        Dim Car(0, 0) As String

        Car(0, 0) = " Perodua Ativa" & vbCrLf & " 5-Seater SUV" & vbCrLf & " From RM 61,500" & vbCrLf & vbCrLf &
            " Proton X50" & vbCrLf & " SUV" & vbCrLf & " From RM 79,200" & vbCrLf & vbCrLf &
            " Honda HR-V" & vbCrLf & " Compact crossover SUV" & vbCrLf & " From RM 104,000 " & vbCrLf & vbCrLf &
            " Nissan X-trail" & vbCrLf & " Compact crossover SUV" & vbCrLf & " From RM 128,630"
        For intList1 = 0 To 0
            For intList2 = 0 To 0
                MsgBox(Car(intList1, intList2), MsgBoxStyle.OkCancel, "Car List")
            Next intList2
        Next intList1
    End Sub
End Class
