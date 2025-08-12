Public Class Keywords
    'Stores the collection of keywords for a report.
    Private ReadOnly k As List(Of String)

    Public Sub New()
        'Initialize the keyword list to avoid null reference issues when adding.
        k = New List(Of String)()
    End Sub

    'Return all keywords currently stored.
    Public Function List() As IEnumerable(Of String)
        Return k.AsReadOnly()
    End Function

    'Adds a keyword to the collection if it isn't blank.
    Public Sub Add(keyword As String)
        If Not String.IsNullOrWhiteSpace(keyword) Then
            k.Add(keyword)
        End If
    End Sub
End Class

Public Class SEOREPORT
    Public Function New_report(name As String, url As String, keywords As Keywords) As String
        Dim report As String = $"Report for {name} ({url})" & Environment.NewLine
        For Each kw As String In keywords.List()
            report &= "- " & kw & Environment.NewLine
        Next
        Return report
    End Function
End Class

