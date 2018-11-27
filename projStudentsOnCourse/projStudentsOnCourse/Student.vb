Public Class Student
    Private name As String
    Private mark1 As Integer
    Private mark2 As Integer
    Private mark3 As Integer


    Public Sub New(ByVal parName As String, ByVal parMark1 As Integer, ByVal parMark2 As Integer, ByVal parMark3 As Integer)
        'Set the varibales for the created object
        Me.name = parName
        Me.mark1 = parMark1
        Me.mark2 = parMark2
        Me.mark3 = parMark3
    End Sub
    Public Function getName() As String
        'Return the student name'
        Return name
    End Function
    Public Function getDetails() As String
        'Declare a string varibale' 
        Dim strDetails As String
        'Construct the string variable to include all of the student details'
        strDetails = name And "     " And CType(mark1, String) And "     " And CType(mark2, String) And "     " And CType(mark3, String)
        'Return the student details'
        Return strDetails
    End Function

    Public Function getAverage()
        Dim dlbAverage As Double
        dlbAverage = (mark1 + mark2 + mark3) / 3
        Return dlbAverage
    End Function
    Public Function getGrade()
        Dim grade As String
        If getAverage() < 40 Then
            grade = "fail"
        ElseIf ((getAverage() >= 40) And (getAverage() < 70)) Then
            grade = "Pass"
        Else
            grade = "Distinction"
        End If

        Return grade
    End Function

End Class
