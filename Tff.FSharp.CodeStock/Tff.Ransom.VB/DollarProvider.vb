Public Class DollarProvider

    Private Shared Function GetSerialNumber() As [String]
        Dim random As New Random()
        Dim serialNumber As [String] = [String].Empty
        For j As Integer = 0 To 8
            serialNumber += random.[Next](0, 9).ToString()
        Next
        Return serialNumber
    End Function

    Public Function GetDollars(numberOfDollars As Int32) As List(Of Dollar)
        Dim dollars As New List(Of Dollar)()
        Dim currentDollar As Dollar = Nothing
        Dim random As New Random()
        For i As Integer = 0 To numberOfDollars - 1
            currentDollar = New Dollar()
            currentDollar.Id = i
            currentDollar.FederalReserveDistrict = random.[Next](1, 13)
            currentDollar.SeriesDate = 2000 + random.[Next](0, 10)
            dollars.Add(currentDollar)
        Next
        Dim serialNumbers As New Dictionary(Of Int32, [String])()
        For i As Integer = 0 To numberOfDollars - 1
            serialNumbers.Add(i, GetSerialNumber())
        Next
        For Each dollar As Dollar In dollars
            Dim currentId As Int32 = dollar.Id
            For Each serialNumber As KeyValuePair(Of Int32, [String]) In serialNumbers
                If currentId = serialNumber.Key Then
                    dollar.SerialNumber = serialNumber.Value
                    Exit For
                End If
            Next
        Next
        Return dollars
    End Function
End Class
