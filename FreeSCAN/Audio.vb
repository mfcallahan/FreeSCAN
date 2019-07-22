
Imports System.data
Module Audio
    Public Function getSoundDeviceStructure() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("Manufacturer"))
        dt.Columns.Add(New DataColumn("Name"))
        dt.Columns.Add(New DataColumn("PNPDeviceID"))
        dt.Columns.Add(New DataColumn("ProductName"))
        Return dt
    End Function
    Public Sub addSoundDevice(ByRef dt As DataTable, ByVal Manufacturer As String, ByVal Name As String, ByVal PNPDeviceID As String, ByVal ProductName As String)
        Dim dr As DataRow
        dr = dt.NewRow
        dr("Manufacturer") = Manufacturer
        dr("Name") = Name
        dr("PNPDeviceID") = PNPDeviceID
        dr("ProductName") = ProductName
        dt.Rows.Add(dr)
    End Sub

    Public Sub addMotherBoardDevice(ByRef dt As DataTable, ByVal DeviceID As String, ByVal PrimaryBusType As String, ByVal SecondaryBusType As String)
        Dim dr As DataRow
        dr = dt.NewRow
        dr("DeviceID") = DeviceID
        dr("PrimaryBusType") = PrimaryBusType
        dr("SecondaryBusType") = SecondaryBusType
        dt.Rows.Add(dr)
    End Sub
    Public Function getBusStructure() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("BusType"))
        dt.Columns.Add(New DataColumn("DeviceID"))
        dt.Columns.Add(New DataColumn("PNPDeviceID"))
        dt.Columns.Add(New DataColumn("SystemName"))
        Return dt
    End Function
    Public Sub addBus(ByRef dt As DataTable, ByVal BusType As String, ByVal DeviceID As String, ByVal PNPDeviceID As String, ByVal SystemName As String)
        Dim dr As DataRow
        dr = dt.NewRow
        dr("BusType") = BusType
        dr("DeviceID") = DeviceID
        dr("PNPDeviceID") = PNPDeviceID
        dr("SystemName") = SystemName
        dt.Rows.Add(dr)
    End Sub

    Public Sub addRow(ByRef dt As DataTable, ByVal p As String, ByVal v As String)
        Dim dr As DataRow
        dr = dt.NewRow
        dr("Property") = p
        dr("Value") = v
        dt.Rows.Add(dr)
    End Sub
    Public Function getStructure() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("Property"))
        dt.Columns.Add(New DataColumn("Value"))
        Return dt
    End Function

End Module
