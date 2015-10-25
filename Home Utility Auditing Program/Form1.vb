'Created by: Jacob Shay'
'October 20th, 2015'


Public Class Form1
    Dim kilowatts As Double
    Dim pricePerKilo As Double
    Dim hoursOfOperation As Double
    Dim kilWattPerHour As Double
    Dim finalPrice As Double
    Dim answer As Double
    Dim appliance As String
    Dim numericCheck As Boolean



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxApplianceSelect.SelectedIndexChanged
        If comBoxApplianceSelect.Text = "" Then

        Else
            appliance = comBoxApplianceSelect.Text
        End If

        'If all out textboxes have valid data then we will call the function to calculate the price'
        If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And comBoxApplianceSelect.Text <> "" Then
            answer = findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation)
            lblAnswer.Text = "It would cost $" + answer.ToString + " to run a " + appliance.ToString + " For " + txtHoursOfOperation.Text.ToString + " hour(s)."
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtKiloWattHour_TextChanged(sender As Object, e As EventArgs) Handles txtKiloWattHourPrice.TextChanged
        If txtKiloWattHourPrice.Text = "" Then

        Else
            numericCheck = IsNumeric(txtKiloWattHourPrice.Text)

            If numericCheck = True Then

                'Get pricePerKil from textbox'
                pricePerKilo = txtKiloWattHourPrice.Text
            Else
                MessageBox.Show("That is not a numeric Value")
                txtKiloWattHourPrice.Text = ""
            End If
        End If

        'If all out textboxes have valid data then we will call the function to calculate the price'
        If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And comBoxApplianceSelect.Text <> "" Then
            answer = findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation)
            lblAnswer.Text = "It would cost $" + answer.ToString + " to run a " + appliance.ToString + " For " + txtHoursOfOperation.Text.ToString + " hour(s)."
        End If

    End Sub

    Private Sub txtPowerNeeded_TextChanged(sender As Object, e As EventArgs) Handles txtPowerNeeded.TextChanged
        'If the text box is empty then we dont want to set any values'
        If txtPowerNeeded.Text = "" Then

        Else
            'Text box not empty'
            'Check to make sure the number is numeric'
            numericCheck = IsNumeric(txtPowerNeeded.Text)

            'If the number is numeric then we want to grab the numeric value'
            If numericCheck = True Then
                kilowatts = txtPowerNeeded.Text
            Else
                'If the number is not numeric we want to make sure the user knows that and then reset the textbox value'
                MessageBox.Show("That is not a numeric Value")
                'Reset the text box to empty strings'
                txtPowerNeeded.Text = ""
            End If
        End If

        'If all out textboxes have valid data then we will call the function to calculate the price'
        If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And comBoxApplianceSelect.Text <> "" Then
            answer = findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation)
            lblAnswer.Text = "It would cost $" + answer.ToString + " to run a " + appliance.ToString + " For " + txtHoursOfOperation.Text.ToString + " hour(s)."
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtHoursOfOperation.TextChanged
        If txtHoursOfOperation.Text = "" Then

        Else
            'Text box not empty'
            'Check to make sure that the hours of operation is numeric'
            numericCheck = IsNumeric(txtHoursOfOperation.Text)

            If numericCheck = True Then
                hoursOfOperation = txtHoursOfOperation.Text
            Else
                'If the number is not numeric we want to make sure the user knows that and then reset the textbox value'
                MessageBox.Show("That is not a numerica Value")
                'Reset the text box to empty strings'
                txtHoursOfOperation.Text = ""
            End If
        End If

        'If all out textboxes have valid data then we will call the function to calculate the price'
        If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And comBoxApplianceSelect.Text <> "" Then
            answer = findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation)
            lblAnswer.Text = "It would cost $" + answer.ToString + " to run a " + appliance.ToString + " For " + txtHoursOfOperation.Text.ToString + " hour(s)."
        End If

    End Sub

    Function findCostOfAppliance(ByVal pricePerKilo As Double, ByVal kilowatts As Double, ByVal hoursOfOperation As Double)

        'Calculate the kilo wat per hour by multyplying the number of kilowats by the number of hours it was ran'
        kilWattPerHour = hoursOfOperation * kilowatts

        'Calculate the final price by multiplying the kilWattPerHour * the pricePerKilo wat'
        finalPrice = kilWattPerHour * pricePerKilo

        'Return the answer'
        Return finalPrice
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)
        If txtHoursOfOperation.Text = "" Or txtKiloWattHourPrice.Text = "" Or txtPowerNeeded.Text = "" Then
            MessageBox.Show("Not all values are bound")
        End If
    End Sub
End Class
