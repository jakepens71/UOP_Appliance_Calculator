Public Class Appliances
    Dim applianceCost As Double
    Dim applianceHoursUsed As Double
    Dim applianceName As String

    Public Property nameOfAppliance As String
        Get
            Return applianceName
        End Get
        Set(value As String)
            applianceName = value
        End Set
    End Property

    Public Property costOfAppliance As Double
        Get
            Return applianceCost
        End Get
        Set(value As Double)
            applianceCost = value
        End Set
    End Property

    Public Property hoursUsedAppliance As Double
        Get
            Return applianceHoursUsed
        End Get
        Set(value As Double)
            applianceHoursUsed = value
        End Set

    End Property


End Class
