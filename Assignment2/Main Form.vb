Public Class frmMain

    Dim intVotes(2) As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim outFile As IO.StreamWriter
        Dim selection As Integer

        selection = lstCandidate.SelectedIndex

        If selection <= intVotes.GetUpperBound(0) Then
            intVotes(selection) += 1

            If IO.File.Exists("votes.txt") Then
                outFile = IO.File.AppendText("votes.txt")
                Select Case selection
                    Case 0
                        outFile.WriteLine("Mark Stone")
                    Case 1
                        outFile.WriteLine("Sheima Patel")
                    Case 2
                        outFile.WriteLine("Sam Perez")
                    Case Else

                End Select
                outFile.Close()
            End If
        End If



    End Sub



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstCandidate.SelectedIndex = 0


    End Sub

    Private Sub btnDisplayVotes_Click(sender As Object, e As EventArgs) Handles btnDisplayVotes.Click
        Dim inFile As IO.StreamReader
        Dim strNames As String

        If IO.File.Exists("votes.txt") Then
            inFile = IO.File.OpenText("votes.txt")
            Do Until inFile.Peek = -1
                strNames = inFile.ReadLine
                Select Case strNames
                    Case "Mark Stone"
                        intVotes(0) += 1
                    Case "Sheima Patel"
                        intVotes(1) += 1
                    Case "Sam Perez"
                        intVotes(2) += 1
                    Case Else

                End Select
            Loop
            inFile.Close()

        End If
        lblMark.Text = intVotes(0).ToString()
        lblSheima.Text = intVotes(1).ToString()
        lblSam.Text = intVotes(2).ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
