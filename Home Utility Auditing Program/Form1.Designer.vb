<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.comBoxApplianceSelect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKiloWattHourPrice = New System.Windows.Forms.TextBox()
        Me.lblAppliance = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPowerNeeded = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHoursOfOperation = New System.Windows.Forms.TextBox()
        Me.lblGallonsOfWater = New System.Windows.Forms.Label()
        Me.txtGallonsOfWater = New System.Windows.Forms.TextBox()
        Me.txtPricePerGallon = New System.Windows.Forms.TextBox()
        Me.lblPricePerGallon = New System.Windows.Forms.Label()
        Me.lstViewAppliances = New System.Windows.Forms.ListView()
        Me.applianceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.applianceCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.applianceHours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'comBoxApplianceSelect
        '
        Me.comBoxApplianceSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxApplianceSelect.FormattingEnabled = True
        Me.comBoxApplianceSelect.Items.AddRange(New Object() {"Refrigerator", "TV", "Space Heater", "Fan", "Dryer", "Oven", "Laundry Washer", "Cloth Washer"})
        Me.comBoxApplianceSelect.Location = New System.Drawing.Point(384, 87)
        Me.comBoxApplianceSelect.Name = "comBoxApplianceSelect"
        Me.comBoxApplianceSelect.Size = New System.Drawing.Size(121, 21)
        Me.comBoxApplianceSelect.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cost Per kWh"
        '
        'txtKiloWattHourPrice
        '
        Me.txtKiloWattHourPrice.Location = New System.Drawing.Point(186, 90)
        Me.txtKiloWattHourPrice.Name = "txtKiloWattHourPrice"
        Me.txtKiloWattHourPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtKiloWattHourPrice.TabIndex = 2
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.Location = New System.Drawing.Point(324, 90)
        Me.lblAppliance.Name = "lblAppliance"
        Me.lblAppliance.Size = New System.Drawing.Size(54, 13)
        Me.lblAppliance.TabIndex = 3
        Me.lblAppliance.Text = "Appliance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Power need in kw"
        '
        'txtPowerNeeded
        '
        Me.txtPowerNeeded.Location = New System.Drawing.Point(186, 157)
        Me.txtPowerNeeded.Name = "txtPowerNeeded"
        Me.txtPowerNeeded.Size = New System.Drawing.Size(100, 20)
        Me.txtPowerNeeded.TabIndex = 6
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(186, 304)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hours of Operation"
        '
        'txtHoursOfOperation
        '
        Me.txtHoursOfOperation.Location = New System.Drawing.Point(426, 157)
        Me.txtHoursOfOperation.Name = "txtHoursOfOperation"
        Me.txtHoursOfOperation.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursOfOperation.TabIndex = 9
        '
        'lblGallonsOfWater
        '
        Me.lblGallonsOfWater.AutoSize = True
        Me.lblGallonsOfWater.Location = New System.Drawing.Point(50, 207)
        Me.lblGallonsOfWater.Name = "lblGallonsOfWater"
        Me.lblGallonsOfWater.Size = New System.Drawing.Size(120, 13)
        Me.lblGallonsOfWater.TabIndex = 10
        Me.lblGallonsOfWater.Text = "Gallons of Water / Hour"
        Me.lblGallonsOfWater.Visible = False
        '
        'txtGallonsOfWater
        '
        Me.txtGallonsOfWater.Location = New System.Drawing.Point(186, 207)
        Me.txtGallonsOfWater.Name = "txtGallonsOfWater"
        Me.txtGallonsOfWater.Size = New System.Drawing.Size(100, 20)
        Me.txtGallonsOfWater.TabIndex = 11
        Me.txtGallonsOfWater.Visible = False
        '
        'txtPricePerGallon
        '
        Me.txtPricePerGallon.Location = New System.Drawing.Point(426, 207)
        Me.txtPricePerGallon.Name = "txtPricePerGallon"
        Me.txtPricePerGallon.Size = New System.Drawing.Size(100, 20)
        Me.txtPricePerGallon.TabIndex = 12
        Me.txtPricePerGallon.Visible = False
        '
        'lblPricePerGallon
        '
        Me.lblPricePerGallon.AutoSize = True
        Me.lblPricePerGallon.Location = New System.Drawing.Point(324, 207)
        Me.lblPricePerGallon.Name = "lblPricePerGallon"
        Me.lblPricePerGallon.Size = New System.Drawing.Size(72, 13)
        Me.lblPricePerGallon.TabIndex = 13
        Me.lblPricePerGallon.Text = "Price / Gallon"
        Me.lblPricePerGallon.Visible = False
        '
        'lstViewAppliances
        '
        Me.lstViewAppliances.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.applianceName, Me.applianceCost, Me.applianceHours})
        Me.lstViewAppliances.Location = New System.Drawing.Point(186, 264)
        Me.lstViewAppliances.Name = "lstViewAppliances"
        Me.lstViewAppliances.Size = New System.Drawing.Size(340, 137)
        Me.lstViewAppliances.TabIndex = 14
        Me.lstViewAppliances.UseCompatibleStateImageBehavior = False
        '
        'applianceName
        '
        Me.applianceName.Text = "Appliance"
        '
        'applianceCost
        '
        Me.applianceCost.Text = "Cost"
        '
        'applianceHours
        '
        Me.applianceHours.Text = "Hours of Operation"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 452)
        Me.Controls.Add(Me.lstViewAppliances)
        Me.Controls.Add(Me.lblPricePerGallon)
        Me.Controls.Add(Me.txtPricePerGallon)
        Me.Controls.Add(Me.txtGallonsOfWater)
        Me.Controls.Add(Me.lblGallonsOfWater)
        Me.Controls.Add(Me.txtHoursOfOperation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtPowerNeeded)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAppliance)
        Me.Controls.Add(Me.txtKiloWattHourPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comBoxApplianceSelect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comBoxApplianceSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKiloWattHourPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblAppliance As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPowerNeeded As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHoursOfOperation As System.Windows.Forms.TextBox
    Friend WithEvents lblGallonsOfWater As Label
    Friend WithEvents txtGallonsOfWater As TextBox
    Friend WithEvents txtPricePerGallon As TextBox
    Friend WithEvents lblPricePerGallon As Label
    Friend WithEvents lstViewAppliances As ListView
    Friend WithEvents applianceName As ColumnHeader
    Friend WithEvents applianceCost As ColumnHeader
    Friend WithEvents applianceHours As ColumnHeader
End Class
