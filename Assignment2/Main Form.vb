' Name: Warren high school vote tally
' Purpose: School Project
' Programmer: Murray Duke on May 13th 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Fill list box with candidates
        Dim candidateNames() As String = {"Mark Stone", "Sheima Patel", "Sam Perez"}

        For Each name As String In candidateNames
            lstCandidate.Items.Add(name)
        Next name
        ' Select first name in list
        lstCandidate.SelectedIndex = 0

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim outFile As IO.StreamWriter

        If IO.File.Exists("votes.txt") Then
            outFile = IO.File.AppendText("votes.txt")
            ' Write candidate name to file
            outFile.WriteLine(lstCandidate.SelectedItem)
            outFile.Close()
        Else
            MessageBox.Show("Can't find file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDisplayVotes_Click(sender As Object, e As EventArgs) Handles btnDisplayVotes.Click

        Dim inFile As IO.StreamReader
        Dim strNames As String
        Dim voteCount(2) As Integer

        If IO.File.Exists("votes.txt") Then
            inFile = IO.File.OpenText("votes.txt")
            Do Until inFile.Peek = -1
                strNames = inFile.ReadLine
                Select Case strNames
                    Case "Mark Stone"
                        voteCount(0) += 1
                    Case "Sheima Patel"
                        voteCount(1) += 1
                    Case "Sam Perez"
                        voteCount(2) += 1
                    Case Else

                End Select
            Loop
            inFile.Close()

        End If

        'Display vote count for each person
        lblMark.Text = voteCount(0).ToString()
        lblSheima.Text = voteCount(1).ToString()
        lblSam.Text = voteCount(2).ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles btnSave.Click, lstCandidate.SelectedIndexChanged

        lblMark.Text = String.Empty
        lblSam.Text = String.Empty
        lblSheima.Text = String.Empty
    End Sub
End Class
