Public Class Form1


    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        sfd1.ShowDialog()
        rtb1.SaveFile(sfd1.FileName & ".txt", RichTextBoxStreamType.PlainText)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        ofd1.ShowDialog()
        rtb1.LoadFile(ofd1.FileName & ".txt")

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        sfd1.ShowDialog()
        rtb1.SaveFile(sfd1.FileName & ".txt", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim i As Integer = MessageBox.Show("Do you want to save It ?", "Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If i = 6 Then
            sfd1.ShowDialog()
            rtb1.SaveFile(sfd1.FileName & ".txt", RichTextBoxStreamType.PlainText)
            rtb1.Clear()
            rtb1.Focus()
        ElseIf i = 7 Then
            rtb1.Clear()
            rtb1.Focus()
        Else

        End If
    End Sub



    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        rtb1.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        rtb1.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        rtb1.Text = rtb1.Text.Remove(rtb1.SelectionStart, rtb1.SelectionLength)
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        rtb1.Cut()
    End Sub

    Private Sub DateTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimeToolStripMenuItem.Click
        rtb1.AppendText(Now)
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        cd1.showdialog()
        rtb1.ForeColor = cd1.color

    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        rtb1.SelectAll()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolStripMenuItem.Click
        rtb1.Text = Replace(rtb1.Text, InputBox("Enter string to find"), InputBox("Enter String to Replace"))
    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        rtb1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        rtb1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        rtb1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        rtb1.Find(InputBox("Search", "Enter string search data"))

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        fd1.ShowDialog()

    End Sub


    Private Sub ZoomInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomInToolStripMenuItem.Click
        rtb1.ZoomFactor += 0.5
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomOutToolStripMenuItem.Click
        rtb1.ZoomFactor -= 0.55
    End Sub

    Private Sub BackcolorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackcolorToolStripMenuItem.Click
        cd1.ShowDialog()
        rtb1.BackColor = cd1.Color
    End Sub

    Private Sub BoldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldToolStripMenuItem.Click
        rtb1.SelectionFont = New Font(rtb1.Font, FontStyle.Bold)
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalicToolStripMenuItem.Click
        rtb1.SelectionFont = New Font(rtb1.Font, FontStyle.Italic)
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnderlineToolStripMenuItem.Click
        rtb1.SelectionFont = New Font(rtb1.Font, FontStyle.Underline)
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub


    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        Application.Exit()
    End Sub

    Private Sub UnodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnodToolStripMenuItem.Click
        rtb1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        rtb1.Redo()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub rtb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb1.TextChanged

    End Sub
End Class
