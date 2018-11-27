Public Class frmStudentApp



    Dim ED As New Course("Level 3 IT")

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        'do validation (ensure all values are filled and valid)
        If txtName.Text = Nothing Or txtMark1.Text = Nothing Or txtMark2.Text = Nothing Or txtMark3.Text = Nothing Then
            MsgBox("Invalid Data")
            txtName.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtMark1.Text) Or Not IsNumeric(txtMark2.Text) Or Not IsNumeric(txtMark3.Text) Then
            MsgBox("Please enter valid marks")
            Exit Sub
        End If

        Dim strName As String = txtName.Text
        Dim intMark1, intMark2, intMark3 As Integer

        'convert strings from "mark" textboxes to integers and store in variables
        Name = txtName.Text
        intMark1 = CType(txtMark1.Text, Integer)
        intMark2 = CType(txtMark2.Text, Integer)
        intMark3 = CType(txtMark3.Text, Integer)

        'enrolling a student onto this course
        ED.enrolStudent(strName, intMark1, intMark2, intMark3)
        'display number of students on the course
        lblDetails.Text = ED.studentCount.ToString

        'clear textboxes
        txtName.Clear()
        txtMark1.Clear()
        txtMark2.Clear()
        txtMark3.Clear()

    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click

        lblDetails.Text = ED.getStudentDetails(CType(npdIndex.Value, Integer))

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        lblDetails.Text = ED.findStudent(txtName.Text)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim index As Integer = CInt(npdIndex.Value)
        Dim temp As Boolean = Nothing

        temp = ED.removeStudent(index)

        If (temp) Then
            MessageBox.Show("Student removed")
            lblDetails.Text = ED.studentCount.ToString
        Else
            MessageBox.Show("No student to remove")
        End If

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click

        'Display all students details within the label
        lblDetails.Text = ED.displayALL

    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click

        Dim dblCourseAverage As Double

        dblCourseAverage = ED.findAverge()
        lblDetails.Text = "The average mark for the course " & ED.title & " is: " & Format(dblCourseAverage, "0.00")

    End Sub

    Private Sub btnHighest_Click(sender As Object, e As EventArgs) Handles btnHighest.Click

        lblDetails.Text = "The student with the highest average mark is: " & ED.getHighest()

    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        lblDetails.Text = ED.getStudentGrade(CType(npdIndex.Value, Integer))

    End Sub
End Class

