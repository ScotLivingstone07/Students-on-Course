Public Class frmMultiCourses
    Dim ND As New Course("Nat Dip IT Pract")
    Dim HND As New Course("HND Computing")
    'Dim ExtDip As New Course("Extended Diploma in IT")
    'Create a variable to hold the status of which course is presently being used
    Dim CurrentCourse As Course
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim name As String
        Dim mark1, mark2, mark3 As Integer
        name = txtName.Text 'getting the name from the textbox
        mark1 = CType(txtMark1.Text, Integer) 'getting mark1 from textbox
        mark2 = CType(txtMark2.Text, Integer) 'getting mark2 from textbox
        mark3 = CType(txtMark3.Text, Integer)
        'Based upon current course selected add the student to that course
        CurrentCourse.enrolStudent(name, mark1, mark2, mark3)
        'Display the number of students on that course
        lblCount.Text = CurrentCourse.studentCount.ToString
    End Sub
    Private Sub btndetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click
        'Based upon current course selected display student details
        'of the student identified in the nud control
        lblDetails.Text = CurrentCourse.getStudentDetails(CType(npdIndex.Value, Integer))
    End Sub
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        'Based upon current course selected find the student
        'identified by the name in the textbox control
        lblDetails.Text = CurrentCourse.findStudents(txtName.Text)
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        'Used a variable index to hold the student identified
        Dim index As Integer = CType(npdIndex.Value, Integer)
        'Create a pointer that can point to a student objectBased upon current
        ' course selected display student details
        'Initially the pointer is pointing to no object
        Dim temp As Boolean
        'Based upon current course selected set the temp pointer
        'to point to the Student object to be removed
        temp = CurrentCourse.removeStudent(index)
        'If the Then pointer Is Not pointing To Nothing'
        'count the number of students remaining on the course
        If Not (temp) Then
            lblCount.Text = CurrentCourse.studentCount.ToString
        End If
    End Sub
    Private Sub btnDisplayAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
        'Based upon current course selected display all the
        'details of students on the course.
        lblDetails.Text = CurrentCourse.displayALL
    End Sub
    Private Sub btnGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrade.Click
        'Based upon current course selected display the student grade
        'of the student identified in the nud control
        lblDetails.Text = CurrentCourse.getStudentGrade(CType(npdIndex.Value, Integer))
    End Sub
    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        Dim dblCourseAverage As Double
        'Based upon current course selected get the
        'average mark of all students on the course.
        dblCourseAverage = CurrentCourse.findAverage()
        'Display the average mark in the output label
        lblDetails.Text = "The average mark for the course " &
        CurrentCourse.title & " is: " & Format(dblCourseAverage, "0.00")
    End Sub
    Private Sub btnHighest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighest.Click
        'Display the highest mark of a student
        ' on a course, to the output label
        lblDetails.Text = "The student with the highest average mark is : " &
        CurrentCourse.getHighest()
    End Sub
    Private Sub rdoNatDip_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoNatDip.Click
        ' Set the current course to Nat Dip
        CurrentCourse = ND
        'Count and display number of students on course
        lblCount.Text = CurrentCourse.studentCount.ToString
    End Sub
    Private Sub rdoHND_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoHND.Click
        ' Set the current course to Higher Nat Dip
        CurrentCourse = HND
        'Count and display number of students on course
        lblCount.Text = CurrentCourse.studentCount.ToString
    End Sub
    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        Dim transCourse As Course
        If rdoHND.Checked Then
            transCourse = ND 'Course to move to
        Else
            transCourse = HND 'Course to move to
        End If
        ' Test if move to course is NOT full
        If transCourse.studentCount() < 6 Then
            'Declare reference to student being deleted
            If CurrentCourse.TransferTo(npdIndex.Value, transCourse) Then
                lblDetails.Text = " Transfer has been successful"
            Else
                lblDetails.Text = " Transfer unsuccessful"
            End If
        End If
    End Sub
End Class