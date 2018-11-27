Public Class Course
    Private arrStudents(4) As Student
    Private count As Integer
    Public title As String

    Public Sub New(ByRef name As String)
        title = name
        count = 0
    End Sub
    Public ReadOnly Property studentCount() As Integer
        Get
            Return count
        End Get
    End Property
    Public Sub enrolStudent(ByVal Name As String, ByVal Mark1 As Integer, ByVal Mark2 As Integer, ByVal Mark3 As Integer)
        Dim mystudent As Student = Nothing
        'If the number of students is less than array size then add student'
        If count < arrStudents.Length Then
            mystudent = New Student(Name, Mark1, Mark2, Mark3)
            arrStudents(count) = mystudent
            count = count + 1
        End If
    End Sub
    Public Function enrolStudent(ByVal otherStudent As Student) As Student
        Dim myStudent As Student = otherStudent
        'If the number of students is less than array size then add student'
        If count < arrStudents.Length Then

            arrStudents(count) = myStudent
            count = count + 1
        End If
        Return myStudent
    End Function
    Public Function TransferTo(ByVal position As Integer, ByVal otherCourse As Course) As Boolean
        Dim delStudent As Student = arrStudents(position - 1)
        If Not delStudent Is Nothing Then
            otherCourse.enrolStudent(delStudent)
            Return True
        Else
            Return False
        End If
    End Function
    Public Function getStudentDetails(ByVal index As Integer)
        index = index - 1
        If index < count Then
            Return arrStudents(index).getDetails()
        Else
            Return "No Students available"
        End If

    End Function
    Public Function displayALL() As String
        Dim strOutput As String = Nothing
        If count = 0 Then
            strOutput = "No students enrolled"
        Else
            For index As Integer = 0 To (count - 1)
                'Call getDetails module within student object'
                strOutput += arrStudents(index).getDetails & vbNewLine
            Next
        End If
        Return strOutput
    End Function
    Public Function findStudents(ByVal name As String) As String
        Dim found As String = Nothing
        Dim index As Integer
        If count > 0 Then
            For index = 0 To (count - 1)
                If name = arrStudents(index).getName() Then
                    found = name & " found that postion" & index
                End If
            Next
        End If
        Return found
    End Function
    Public Function removeStudent(ByVal index As Integer) As Boolean
        index = index - 1
        If (index >= count) Or (count = 0) Then
            Return False
            Exit Function
        End If
        If (index = (count - 1)) Then
            arrStudents(index) = Nothing    'object to remove'
            Return True
        Else
            arrStudents(index) = Nothing
            While (index + 1) < count
                'Set the arrary element pointer pointing to next object '
                arrStudents(index) = arrStudents(index + 1)
                index = index + 1   'increment remove variable'
            End While
            count = count - 1 'Reduce the number of studetns by one'
            Return True

        End If
    End Function
    Public Function findAverage() As Double
        Dim index As Integer = 0
        Dim total, Average As Double

        While (index < count)
            total += arrStudents(index).getAverage()
            index += 1
        End While
        If count <> 0 Then
            Average = total / count
        End If
        Return Average
    End Function
    Public Function getStudentGrade(ByVal index As Integer) As String
        Dim strGrade As String
        strGrade = arrStudents(index - 1).getName() & "achieved a " & arrStudents(index - 1).getGrade()
        Return strGrade

    End Function
    Public Function getHighest() As String
        Dim highest As Integer = 0
        Dim index As Integer = 0
        While (index < count)
            If (arrStudents(highest).getAverage()) < (arrStudents(index).getAverage()) Then
                highest = index
            End If
            index += 1
        End While
        Return arrStudents(highest).getName()


    End Function
End Class
