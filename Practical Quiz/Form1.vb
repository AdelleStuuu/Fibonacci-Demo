Public Class Form1
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim Number As Double = StartingNumber.Value
        Dim CurrentLoops As Double
        Dim LoopNumber As Double = NumberOfLoops.Value
        Dim previousNumber As Double
        Dim previousNumber2 As Double
        Dim NumberText As String
        Dim result As String = ""

        If LoopNumber < 5 Then
            MsgBox("Enter a Loop Count greater than or equal to 5")
        Else
            While CurrentLoops < LoopNumber
                NumberText = Number

                If CurrentLoops = LoopNumber - 1 Then
                    result += NumberText + ". "
                Else
                    result += NumberText + ", "
                End If

                If Number = 0 Then
                    Number += 1
                ElseIf CurrentLoops = 0 Then
                    previousNumber = Number
                    Number = previousNumber + previousNumber2
                Else
                    Number = previousNumber + previousNumber2
                End If
                CurrentLoops += 1
                previousNumber2 = previousNumber
                previousNumber = Number
            End While


            MsgBox("The fibonacci sequence is " & result)
        End If


    End Sub
    ' fibo add 2 numbers before it 
    ' store 2 previous Numbers 
End Class
