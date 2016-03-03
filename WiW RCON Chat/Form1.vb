Imports System
Imports System.Diagnostics

Public Class frmMain

    Private Sub button_AddToFilter_Click(sender As Object, e As EventArgs) Handles button_AddToFilter.Click
        If txt_FilterInput.Text <> "" Then
            listbox_Filters.Items.Add(txt_FilterInput.Text)
            txt_FilterInput.Text = Nothing
        End If
    End Sub

    Private Sub button_RemoveFromFilter_Click(sender As Object, e As EventArgs) Handles button_RemoveFromFilter.Click
        On Error Resume Next
        listbox_Filters.Items.Remove(listbox_Filters.SelectedItem)
        listbox_Filters.SetSelected(0, True)
    End Sub

    Private Sub button_SortAndFilter_Click(sender As Object, e As EventArgs) Handles button_SortAndFilter.Click
        If txt_Input.Text = "" Then
            Exit Sub
        End If
        txt_Output.Text = ""

        Dim aInput As Array = txt_Input.Lines
        'Dim aOutput() As Array

        Array.Reverse(aInput)
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = Int(aInput.Length)

        For Each _inputlines As String In aInput
            ProgressBar1.Increment(1)
            If chkbox_NoServerMessages.Checked = True And _inputlines.ToString.Contains("Server") Then
                Continue For
            End If
            If listbox_Filters.Items.Count > 0 Then
                ' run filters on _inputlines
                For Each _filter As String In listbox_Filters.Items
                    If _inputlines.ToString.Contains(_filter) Then
                        txt_Output.AppendText(_inputlines + vbNewLine)
                    End If
                Next
            Else
                txt_Output.AppendText(_inputlines + vbNewLine)
            End If
        Next

        Dim strInputLines As String = Int(aInput.Length)
        Dim strOutputLines As String = Int(txt_Output.Lines.Length) - 1

        lbl_LinesInput.Text = " Input Lines: " + strInputLines
        lbl_LinesOutput.Text = "Output Lines: " + strOutputLines
    End Sub

    Private Sub link_Email_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_Email.LinkClicked
        On Error GoTo showerr
        link_Email.LinkVisited = True
        System.Diagnostics.Process.Start("mailto:Dominic Reich <dominic@tmsn.at>")
        Exit Sub
showerr:
        MessageBox.Show(Err.Description, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub link_Website_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_Website.LinkClicked
        On Error GoTo showerr
        link_Website.LinkVisited = True
        System.Diagnostics.Process.Start("http://tmsn.at/?tools&rcon-chat")
        Exit Sub
showerr:
        MessageBox.Show(Err.Description, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub txt_FilterInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_FilterInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            button_AddToFilter_Click(txt_FilterInput, Nothing)
        End If
    End Sub

    Private Sub button_ClearFilters_Click(sender As Object, e As EventArgs) Handles button_ClearFilters.Click
        On Error Resume Next
        listbox_Filters.Items.Clear()
    End Sub
End Class