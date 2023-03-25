Imports System.Net.Security

Public Class Form1

    Private Sub setstyle()
        Dim newstyle = FontStyle.Regular

        If bold.Checked Then
            newstyle = newstyle Or FontStyle.Bold
        End If

        If italic.Checked Then
            newstyle = newstyle Or FontStyle.Italic
        End If

        If underline.Checked Then
            newstyle = newstyle Or FontStyle.Underline
        End If

        namebox.Font = New Font(namebox.Font, newstyle)
        vowles.Font = New Font(vowles.Font, newstyle)
        resultbox.Font = New Font(resultbox.Font, newstyle)
    End Sub

    Private Sub display_Click(sender As Object, e As EventArgs) Handles display.Click
        MsgBox("NAME : " + namebox.Text + vbCrLf + "DEPARTMENT : " + deptbox.Text + vbCrLf +
               "SEMESTER : " + sembox.Text + vbCrLf + "MARKS : " + marksbox.Text)
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles reset.Click
        namebox.Text = ""
        deptbox.Text = ""
        sembox.Text = ""
        marksbox.Text = ""
        vowles.Text = ""
        resultbox.Text = ""

        bold.CheckState = 0
        italic.CheckState = 0
        underline.CheckState = 0

    End Sub

    Private Sub bold_CheckedChanged(sender As Object, e As EventArgs) Handles bold.CheckedChanged
        setstyle()
    End Sub

    Private Sub italic_CheckedChanged(sender As Object, e As EventArgs) Handles italic.CheckedChanged
        setstyle()
    End Sub

    Private Sub underline_CheckedChanged(sender As Object, e As EventArgs) Handles underline.CheckedChanged
        setstyle()
    End Sub

    Private Sub checkv_Click(sender As Object, e As EventArgs) Handles checkv.Click
        Dim str As String
        Dim i, strlen, num As Integer
        num = 0

        str = namebox.Text
        strlen = Len(str)
        str = LCase(str)

        For i = 0 To strlen - 1 Step 1
            If str(i) = "a" Or str(i) = "e" Or str(i) = "i" Or str(i) = "o" Or str(i) = "u" Then
                num += 1
            End If
        Next

        vowles.Text = num
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub result_Click(sender As Object, e As EventArgs) Handles result.Click
        Dim mark As Integer

        mark = marksbox.Text

        If mark < 35 Then
            resultbox.Text = "POOR"
        ElseIf mark >= 35 And mark < 85 Then
            resultbox.Text = "EXCELENT"
        ElseIf mark >= 85 And mark <= 100 Then
            resultbox.Text = "OUTSATNDING"
        End If

    End Sub
End Class
