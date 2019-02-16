' *********************************************************************************************************
' * Name: Anastasiia Kononirenko
' * ID: 100717670
' * Date: 08/02/2019
' * Purpose: Lab_2_Semester_Average
' * Description: A windows forms application that determines a course letter grade, semester average, and
' *              a semester letter grade, based on the user input of course numeric grades.
' *********************************************************************************************************

Option Strict On
Public Class frmSemesterAverage

#Region "Declarations"
    ' CONSTANT DECLARATIONS
    Const MINIMUM_GRADE As Integer = 0
    Const MAXIMUM_GRADE As Integer = 100
    Const NUMBER_OF_COURSES As Integer = 6
    ' VARIABLE DECLARATIONS
    Dim grades() As Double = New Double(NUMBER_OF_COURSES - 1) {}
    Dim courseGrade As Double = 0
    Dim textBox As TextBox
#End Region

#Region "InputValidationFunction"
    ''' <summary>
    ''' Function used to validate user input for the grade of the course 
    ''' </summary>
    ''' <param name="userInput"></param>
    ''' <returns></returns>
    Private Function InputValidation(userInput As String) As Double
        Dim validNumber As Double                                                       ' declare a variable validNumber as double
        If (Double.TryParse(userInput, validNumber) = False) Then                       ' if the entered input is not a number,
            validNumber = -2                                                            ' set the validNumber value to -2
        ElseIf (validNumber < MINIMUM_GRADE OrElse validNumber > MAXIMUM_GRADE) Then    ' if the entered number isn't within the required range,
            validNumber = -1                                                            ' set the validNumber value to -1
        End If
        Return validNumber                                                              ' return validNumber
    End Function
#End Region

#Region "LetterGradeFunction"
    ''' <summary>
    ''' Function that is used to determine letter grade based on numeric grade parameter based on the provided chart
    ''' </summary>
    ''' <param name="grade"></param>
    ''' <returns></returns>
    Private Function DetermineLetterGrade(grade As Double) As String
        Dim letterGrade As String = "F"  ' declare a variable letterGrade to hold a letter grade, as string
        If (grade >= 90.0) Then
            letterGrade = "A+"
        ElseIf (grade >= 85.0) Then
            letterGrade = "A"
        ElseIf (grade >= 80.0) Then
            letterGrade = "A-"
        ElseIf (grade >= 77.0) Then
            letterGrade = "B+"
        ElseIf (grade >= 73.0) Then
            letterGrade = "B"
        ElseIf (grade >= 70.0) Then
            letterGrade = "B-"
        ElseIf (grade >= 67.0) Then
            letterGrade = "C+"
        ElseIf (grade >= 63.0) Then
            letterGrade = "C"
        ElseIf (grade >= 60.0) Then
            letterGrade = "C-"
        ElseIf (grade >= 57.0) Then
            letterGrade = "D+"
        ElseIf (grade >= 53.0) Then
            letterGrade = "D"
        ElseIf (grade >= 50.0) Then
            letterGrade = "D-"
        End If
        Return letterGrade ' return letterGrade
    End Function
#End Region

#Region "TextBoxes"
    ''' <summary>
    ''' Event handler for all text boxes that validates user input for the grade of the course, 
    ''' determines a letter grade and displays it in the label next to the text box.
    ''' This event handler is executed when the focus is moved from the text box.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextBoxes_Leave(sender As Object, e As EventArgs)
        textBox = CType(sender, TextBox)                  ' convert the type of sender to TextBox 
        If (textBox.Text <> String.Empty) Then            ' if the Text property of the text box is not null,
            courseGrade = InputValidation(textBox.Text)   ' validate user input using InputValidation function
            If (courseGrade = -2) Then                    ' if user input is not numeric, display the error message
                lblError.Text = "Please ensure that what you input is a number!"
                textBox.Focus()                           ' set Focus to the text box
                textBox.SelectAll()                       ' select the text in the text box
            ElseIf (courseGrade = -1) Then                ' if user input isn't within the required range, display the error message
                lblError.Text = "Please ensure that what you input is a number between " & MINIMUM_GRADE.ToString & " and " & MAXIMUM_GRADE.ToString & "!" & vbCrLf
                textBox.Focus()                           ' set Focus to the text box
                textBox.SelectAll()                       ' select the text in the text box
            Else   ' if user input is valid, store output labels in an array
                Dim labels() As Label = {lblDisplayGrade1, lblDisplayGrade2, lblDisplayGrade3, lblDisplayGrade4, lblDisplayGrade5, lblDisplayGrade6}
                Dim counter As Integer = -1                          ' declare a variable counter and set its value to -1
                For Each textBox In Me.Controls.OfType(Of TextBox)   ' determine the label that is next to the text box
                    counter += 1
                    If (textBox.Text <> String.Empty AndAlso labels(counter).Text = String.Empty) Then
                        labels(counter).Text = DetermineLetterGrade(courseGrade)    ' display the letter grade in the label
                        grades(counter) = courseGrade                               ' store the grade in the grades() array
                        Exit For                                                    ' exit the for loop
                    End If
                Next
                lblError.Text = String.Empty  ' set the text of the lblError label to an empty string
            End If
        End If
    End Sub

    ''' <summary>
    ''' Load event of the frmSemesterAverage form that adds TextBoxes_Leave handler to all the text boxes as soon as the form loads
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmSemesterAverage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each textBox In Me.Controls.OfType(Of TextBox)
            AddHandler textBox.Leave, AddressOf TextBoxes_Leave
        Next
    End Sub
#End Region

#Region "btnCalculate"
    ''' <summary>
    ''' Click event of the btnCalculate button that checks if the grades have been entered for all text boxes, then
    ''' calculates semester average, displays the letter grade of the semester, disables text boxes and the Calculate button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        btnCalculate.Focus()                                ' set Focus to the btnCalculate button
        Dim checkFocusedBox As Boolean = True               ' declare a variable checkFocusedBox and set its value to True
        For Each textBox In Me.Controls.OfType(Of TextBox)
            If (textBox.Focused) Then                       ' if any of the text boxes is focused,
                checkFocusedBox = False                     ' set the checkFocusedBox value to False
                Exit For                                    ' exit the for loop
            End If
        Next
        If (checkFocusedBox) Then                                           ' if none of the text boxes is focused,
            lblError.Text = String.Empty                                    ' set the text of the lblError label to an empty string
            Dim counter As Integer = 0                                      ' declare a variable counter and set its value to 0
            Dim textBoxNumber As Integer = 0                                ' declare a variable textBoxNumber and set its value to 0
            For Each textBox As TextBox In Me.Controls.OfType(Of TextBox)   ' for each and every text box, do
                textBoxNumber += 1
                If (textBox.Text = String.Empty) Then                       ' if the Text property of the text box is an empty string, then
                    counter += 1                                            ' display the error message
                    If (counter = 1) Then
                        lblError.Text = "ERROR(s)" & vbCrLf
                        textBox.Focus()
                    End If
                    lblError.Text += "Please ensure that what you input in Course " & textBoxNumber.ToString & " is a number between " & MINIMUM_GRADE.ToString & " and " & MAXIMUM_GRADE.ToString & "!" & vbCrLf
                End If
            Next
        End If

        If (lblError.Text = String.Empty) Then
            Dim semesterAverage As Double = 0
            For course As Integer = 0 To NUMBER_OF_COURSES - 1              ' if Text of the lblError label is empty, then
                semesterAverage += grades(course)                           ' calculate the sum of the grades
            Next
            semesterAverage = semesterAverage / NUMBER_OF_COURSES           ' calculate semester average
            lblSemesterAverage.Text = Math.Round(semesterAverage, 2).ToString("n2") ' display semester average
            lblDisplaySemesterGrade.Text = DetermineLetterGrade(semesterAverage)    ' display semester letter grade
            For Each textBox In Me.Controls.OfType(Of TextBox)()                    ' set the ReadOnly property of all text boxes to True
                textBox.ReadOnly = True
            Next
            btnCalculate.Enabled = False                                            ' disable the btnCalculate button
        End If

    End Sub
#End Region

#Region "btnReset"
    ''' <summary>
    ''' Subroutine that is used to reset the form (clear text boxes and output labels, enable all text boxes
    ''' and the btnCalculate button)
    ''' </summary>
    Private Sub resetForm()
        For Each textBox In Me.Controls.OfType(Of TextBox)()
            textBox.ReadOnly = False                          ' set the ReadOnly property of all text boxes to False
            textBox.Text = String.Empty                       ' set the Text property of all text boxes to an empty string
        Next
        ' store all output labels in an array
        Dim labels() As Label = {lblDisplayGrade1, lblDisplayGrade2, lblDisplayGrade3, lblDisplayGrade4, lblDisplayGrade5, lblDisplayGrade6, lblDisplaySemesterGrade, lblSemesterAverage, lblError}
        For Each label As Label In labels
            label.Text = String.Empty   ' set the Text property of all output labels to an empty string
        Next

        btnCalculate.Enabled = True     ' enable the btnCalculate button
        txtCourse1.Focus()              ' set Focus to the txtCourse1 text box
    End Sub

    ''' <summary>
    ''' Click event of the Reset button that resets the form using the subroutine
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()
    End Sub
#End Region

#Region "btnExit"
    ''' <summary>
    ''' Click event of the Exit button that exits the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region

End Class
