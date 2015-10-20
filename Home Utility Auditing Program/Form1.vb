Public Class Form1
    Dim kilowatts As Double
    Dim pricePerKilo As Double
    Dim hoursOfOperation As Double
    Dim kilWattPerHour As Double
    Dim finalPrice As Double
    Dim answer As Double
    Dim appliance As String



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxApplianceSelect.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtKiloWattHour_TextChanged(sender As Object, e As EventArgs) Handles txtKiloWattHourPrice.TextChanged
        If txtKiloWattHourPrice.Text = "" Then

        Else
            'Get pricePerKil from textbox'
            pricePerKilo = txtKiloWattHourPrice.Text
        End If

        If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" Then
            answer = findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation)
            lblAnswer.Text = "$" + answer
        End If

    End Sub

    Private Sub txtPowerNeeded_TextChanged(sender As Object, e As EventArgs) Handles txtPowerNeeded.TextChanged
        If txtPowerNeeded.Text = "" Then

        Else
            kilowatts = txtPowerNeeded.Text
        End If

        If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" Then
            answer = findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation)
            lblAnswer.Text = "$" + answer
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtHoursOfOperation.TextChanged
        If txtHoursOfOperation.Text = "" Then

        Else
            hoursOfOperation = txtHoursOfOperation.Text
        End If


        If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" Then
            answer = findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation)
            lblAnswer.Text = "$" + answer
        End If

    End Sub

    Function findCostOfAppliance(ByVal pricePerKilo As Double, ByVal kilowatts As Double, ByVal hoursOfOperation As Double)

        kilWattPerHour = hoursOfOperation * kilowatts

        finalPrice = kilWattPerHour * pricePerKilo

        Return finalPrice
    End Function

End Class
