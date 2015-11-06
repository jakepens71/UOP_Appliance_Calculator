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
    Dim costOfWasherPerLoad As Double
    Dim gallonsOfWater As Double
    Dim pricePerGallon As Double
    Dim newAppliance As New Appliances()
    Dim listOfAppliances As New List(Of Appliances)
    Dim totalCost As Double = 0





    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxApplianceSelect.SelectedIndexChanged
        If comBoxApplianceSelect.Text = "" Then

        Else
            appliance = comBoxApplianceSelect.Text
        End If



        If comBoxApplianceSelect.Text = "Cloth Washer" Or comBoxApplianceSelect.Text = "Laundry Washer" Then
            lblGallonsOfWater.Show()
            lblPricePerGallon.Show()
            txtGallonsOfWater.Show()
            txtPricePerGallon.Show()

        Else
            lblGallonsOfWater.Hide()
            lblPricePerGallon.Hide()
            txtGallonsOfWater.Hide()
            txtPricePerGallon.Hide()
            pricePerGallon = 0
            gallonsOfWater = 0
        End If

        If comBoxApplianceSelect.Text = "Cloth Washer" Or comBoxApplianceSelect.Text = "Laundry Washer" Then
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And txtGallonsOfWater.Text <> "" And txtPricePerGallon.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)
            End If
        Else
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And comBoxApplianceSelect.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)

            End If
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

        If comBoxApplianceSelect.Text = "Cloth Washer" Or comBoxApplianceSelect.Text = "Laundry Washer" Then
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And txtGallonsOfWater.Text <> "" And txtPricePerGallon.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)

            End If
        Else
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And comBoxApplianceSelect.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)

            End If
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

        If comBoxApplianceSelect.Text = "Cloth Washer" Or comBoxApplianceSelect.Text = "Laundry Washer" Then
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And txtGallonsOfWater.Text <> "" And txtPricePerGallon.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)

            End If
        Else
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And comBoxApplianceSelect.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)

            End If
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

        If comBoxApplianceSelect.Text = "Cloth Washer" Or comBoxApplianceSelect.Text = "Laundry Washer" Then
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And txtGallonsOfWater.Text <> "" And txtPricePerGallon.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)

            End If
        Else
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And comBoxApplianceSelect.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)

            End If
        End If

    End Sub

    Sub findCostOfAppliance(ByVal pricePerKilo As Double, ByVal kilowatts As Double, ByVal hoursOfOperation As Double, ByVal gallonsOfWater As Double, ByVal pricePerGallon As Double)

        'Calculate the kilo wat per hour by multyplying the number of kilowats by the number of hours it was ran'
        kilWattPerHour = hoursOfOperation * kilowatts

        'Calculate the final price by multiplying the kilWattPerHour * the pricePerKilo wat'
        finalPrice = kilWattPerHour * pricePerKilo

        'Calculate price of washing machine load
        costOfWasherPerLoad = gallonsOfWater * pricePerGallon

        finalPrice = costOfWasherPerLoad + finalPrice



        newAppliance.nameOfAppliance = appliance.ToString()
        newAppliance.hoursUsedAppliance = hoursOfOperation
        newAppliance.costOfAppliance = finalPrice

        listOfAppliances.Add(newAppliance)



        lblAnswer.Text = ""

        For index As Integer = 0 To listOfAppliances.Count - 1
            lstOfAppliances.Rows.Add(listOfAppliances(index).nameOfAppliance, listOfAppliances(index).hoursUsedAppliance, listOfAppliances(index).costOfAppliance)
            totalCost = totalCost + listOfAppliances(index).costOfAppliance
        Next

        lblAnswer.Text = "Total Cost: $" + totalCost.ToString()


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)
        If txtHoursOfOperation.Text = "" Or txtKiloWattHourPrice.Text = "" Or txtPowerNeeded.Text = "" Then
            MessageBox.Show("Not all values are bound")
        End If
    End Sub

    Private Sub txtGallonsOfWater_TextChanged(sender As Object, e As EventArgs) Handles txtGallonsOfWater.TextChanged
        If txtGallonsOfWater.Text = "" Then

        Else

            'Text box not empty'
            'Check to make sure it is numeric value'
            numericCheck = IsNumeric(txtGallonsOfWater.Text)

            If numericCheck = True Then
                gallonsOfWater = txtGallonsOfWater.Text
            Else
                'If the number is not numeric we want to make sure the user knows that and then reset the textbox value'
                MessageBox.Show("That is not a numerica Value")
                'Reset the text box to empty strings'
                txtGallonsOfWater.Text = ""
            End If

        End If

        If comBoxApplianceSelect.Text = "Cloth Washer" Or comBoxApplianceSelect.Text = "Laundry Washer" Then
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And txtGallonsOfWater.Text <> "" And txtPricePerGallon.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)

            End If
        Else
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And comBoxApplianceSelect.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)
            End If
        End If

    End Sub

    Private Sub txtPricePerGallon_TextChanged(sender As Object, e As EventArgs) Handles txtPricePerGallon.TextChanged
        If txtPricePerGallon.Text = "" Then

        Else
            'Text box not empty'
            'Check to make sure that the hours of operation is numeric'
            numericCheck = IsNumeric(txtPricePerGallon.Text)

            If numericCheck = True Then
                pricePerGallon = txtPricePerGallon.Text
            Else
                'If the number is not numeric we want to make sure the user knows that and then reset the textbox value'
                MessageBox.Show("That is not a numerica Value")
                'Reset the text box to empty strings'
                txtPricePerGallon.Text = ""
            End If
        End If

        If comBoxApplianceSelect.Text = "Cloth Washer" Or comBoxApplianceSelect.Text = "Laundry Washer" Then
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And txtGallonsOfWater.Text <> "" And txtPricePerGallon.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)

            End If
        Else
            'If all out textboxes have valid data then we will call the function to calculate the price'
            If txtHoursOfOperation.Text <> "" And txtKiloWattHourPrice.Text <> "" And txtPowerNeeded.Text <> "" And comBoxApplianceSelect.Text <> "" Then
                findCostOfAppliance(pricePerKilo, kilowatts, hoursOfOperation, gallonsOfWater, pricePerGallon)
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i = 0

        While i < lstOfAppliances.Rows.Count
            lstOfAppliances.Rows.RemoveAt(i)
        End While

        lblAnswer.Text = ""

    End Sub

    Private Sub lstOfAppliances_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstOfAppliances.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SaveFileDialog1 As SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        SaveFileDialog1.DefaultExt = ".txt"
        SaveFileDialog1.Filter = "Text Files | *.txt"
        SaveFileDialog1.InitialDirectory = "desktop"

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim fileStream As System.IO.Stream = SaveFileDialog1.OpenFile()
            Dim sw As New System.IO.StreamWriter(fileStream)

            For Each row As DataGridViewRow In Me.lstOfAppliances.Rows
                Dim line As String = String.Empty
                For x As Integer = 0 To row.Cells.Count - 1
                    line &= row.Cells(x).Value & ","
                Next
                sw.WriteLine(line.Remove(line.Length - 1, 1))
            Next
            sw.Flush()
            sw.Close()
        End If

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim openFileDialog As OpenFileDialog = New System.Windows.Forms.OpenFileDialog

        If (openFileDialog.ShowDialog() = DialogResult.OK) Then

        End If


    End Sub
End Class
