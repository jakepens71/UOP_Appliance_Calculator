﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.lstOfAppliances = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.ApplianceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursUsed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPerKiloHour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Power = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostAppliance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.lstOfAppliances, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblAnswer.Location = New System.Drawing.Point(526, 504)
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
        'lstOfAppliances
        '
        Me.lstOfAppliances.AllowUserToAddRows = False
        Me.lstOfAppliances.AllowUserToDeleteRows = False
        Me.lstOfAppliances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstOfAppliances.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ApplianceName, Me.HoursUsed, Me.CostPerKiloHour, Me.Power, Me.CostAppliance})
        Me.lstOfAppliances.Location = New System.Drawing.Point(12, 260)
        Me.lstOfAppliances.MultiSelect = False
        Me.lstOfAppliances.Name = "lstOfAppliances"
        Me.lstOfAppliances.Size = New System.Drawing.Size(651, 150)
        Me.lstOfAppliances.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(698, 277)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(698, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(698, 387)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 17
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'ApplianceName
        '
        Me.ApplianceName.HeaderText = "Appliance"
        Me.ApplianceName.Name = "ApplianceName"
        '
        'HoursUsed
        '
        Me.HoursUsed.HeaderText = "Hours Used"
        Me.HoursUsed.Name = "HoursUsed"
        '
        'CostPerKiloHour
        '
        Me.CostPerKiloHour.HeaderText = "Cost /  kWh"
        Me.CostPerKiloHour.Name = "CostPerKiloHour"
        '
        'Power
        '
        Me.Power.HeaderText = "Power"
        Me.Power.Name = "Power"
        '
        'CostAppliance
        '
        Me.CostAppliance.HeaderText = "Cost"
        Me.CostAppliance.Name = "CostAppliance"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 575)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstOfAppliances)
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
        CType(Me.lstOfAppliances, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lstOfAppliances As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents ApplianceName As DataGridViewTextBoxColumn
    Friend WithEvents HoursUsed As DataGridViewTextBoxColumn
    Friend WithEvents CostPerKiloHour As DataGridViewTextBoxColumn
    Friend WithEvents Power As DataGridViewTextBoxColumn
    Friend WithEvents CostAppliance As DataGridViewTextBoxColumn
End Class
