<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkbox_NoServerMessages = New System.Windows.Forms.CheckBox()
        Me.txt_FilterInput = New System.Windows.Forms.TextBox()
        Me.button_AddToFilter = New System.Windows.Forms.Button()
        Me.button_RemoveFromFilter = New System.Windows.Forms.Button()
        Me.button_ClearFilters = New System.Windows.Forms.Button()
        Me.listbox_Filters = New System.Windows.Forms.ListBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.button_SortAndFilter = New System.Windows.Forms.Button()
        Me.button_SaveToFile = New System.Windows.Forms.Button()
        Me.lbl_LinesInput = New System.Windows.Forms.Label()
        Me.lbl_LinesOutput = New System.Windows.Forms.Label()
        Me.lbl_Progressbar = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_Empty = New System.Windows.Forms.Label()
        Me.link_Email = New System.Windows.Forms.LinkLabel()
        Me.link_Website = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.label_Input = New System.Windows.Forms.Label()
        Me.txt_Input = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.label_Output = New System.Windows.Forms.Label()
        Me.txt_Output = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.chkbox_NoServerMessages)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_FilterInput)
        Me.FlowLayoutPanel1.Controls.Add(Me.button_AddToFilter)
        Me.FlowLayoutPanel1.Controls.Add(Me.button_RemoveFromFilter)
        Me.FlowLayoutPanel1.Controls.Add(Me.button_ClearFilters)
        Me.FlowLayoutPanel1.Controls.Add(Me.listbox_Filters)
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'chkbox_NoServerMessages
        '
        resources.ApplyResources(Me.chkbox_NoServerMessages, "chkbox_NoServerMessages")
        Me.chkbox_NoServerMessages.Name = "chkbox_NoServerMessages"
        Me.chkbox_NoServerMessages.UseVisualStyleBackColor = True
        '
        'txt_FilterInput
        '
        Me.txt_FilterInput.AcceptsReturn = True
        resources.ApplyResources(Me.txt_FilterInput, "txt_FilterInput")
        Me.txt_FilterInput.Name = "txt_FilterInput"
        '
        'button_AddToFilter
        '
        resources.ApplyResources(Me.button_AddToFilter, "button_AddToFilter")
        Me.button_AddToFilter.Name = "button_AddToFilter"
        Me.button_AddToFilter.UseVisualStyleBackColor = True
        '
        'button_RemoveFromFilter
        '
        resources.ApplyResources(Me.button_RemoveFromFilter, "button_RemoveFromFilter")
        Me.button_RemoveFromFilter.Name = "button_RemoveFromFilter"
        Me.button_RemoveFromFilter.UseVisualStyleBackColor = True
        '
        'button_ClearFilters
        '
        resources.ApplyResources(Me.button_ClearFilters, "button_ClearFilters")
        Me.button_ClearFilters.Name = "button_ClearFilters"
        Me.button_ClearFilters.UseVisualStyleBackColor = True
        '
        'listbox_Filters
        '
        Me.listbox_Filters.FormattingEnabled = True
        resources.ApplyResources(Me.listbox_Filters, "listbox_Filters")
        Me.listbox_Filters.Name = "listbox_Filters"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.button_SortAndFilter)
        Me.FlowLayoutPanel2.Controls.Add(Me.button_SaveToFile)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_LinesInput)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_LinesOutput)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_Progressbar)
        Me.FlowLayoutPanel2.Controls.Add(Me.ProgressBar1)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_Empty)
        Me.FlowLayoutPanel2.Controls.Add(Me.link_Email)
        Me.FlowLayoutPanel2.Controls.Add(Me.link_Website)
        resources.ApplyResources(Me.FlowLayoutPanel2, "FlowLayoutPanel2")
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        '
        'button_SortAndFilter
        '
        resources.ApplyResources(Me.button_SortAndFilter, "button_SortAndFilter")
        Me.button_SortAndFilter.Name = "button_SortAndFilter"
        Me.button_SortAndFilter.UseVisualStyleBackColor = True
        '
        'button_SaveToFile
        '
        resources.ApplyResources(Me.button_SaveToFile, "button_SaveToFile")
        Me.button_SaveToFile.Name = "button_SaveToFile"
        Me.button_SaveToFile.UseVisualStyleBackColor = True
        '
        'lbl_LinesInput
        '
        resources.ApplyResources(Me.lbl_LinesInput, "lbl_LinesInput")
        Me.lbl_LinesInput.Name = "lbl_LinesInput"
        '
        'lbl_LinesOutput
        '
        resources.ApplyResources(Me.lbl_LinesOutput, "lbl_LinesOutput")
        Me.lbl_LinesOutput.Name = "lbl_LinesOutput"
        '
        'lbl_Progressbar
        '
        resources.ApplyResources(Me.lbl_Progressbar, "lbl_Progressbar")
        Me.lbl_Progressbar.Name = "lbl_Progressbar"
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Step = 1
        '
        'lbl_Empty
        '
        resources.ApplyResources(Me.lbl_Empty, "lbl_Empty")
        Me.lbl_Empty.Name = "lbl_Empty"
        '
        'link_Email
        '
        Me.link_Email.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        resources.ApplyResources(Me.link_Email, "link_Email")
        Me.link_Email.Name = "link_Email"
        Me.link_Email.TabStop = True
        '
        'link_Website
        '
        Me.link_Website.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        resources.ApplyResources(Me.link_Website, "link_Website")
        Me.link_Website.Name = "link_Website"
        Me.link_Website.TabStop = True
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.label_Input, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Input, 0, 1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'label_Input
        '
        resources.ApplyResources(Me.label_Input, "label_Input")
        Me.label_Input.Name = "label_Input"
        '
        'txt_Input
        '
        Me.txt_Input.AcceptsReturn = True
        Me.txt_Input.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.txt_Input, "txt_Input")
        Me.txt_Input.Name = "txt_Input"
        '
        'TableLayoutPanel3
        '
        resources.ApplyResources(Me.TableLayoutPanel3, "TableLayoutPanel3")
        Me.TableLayoutPanel3.Controls.Add(Me.label_Output, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Output, 0, 1)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        '
        'label_Output
        '
        resources.ApplyResources(Me.label_Output, "label_Output")
        Me.label_Output.Name = "label_Output"
        '
        'txt_Output
        '
        Me.txt_Output.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.txt_Output, "txt_Output")
        Me.txt_Output.Name = "txt_Output"
        Me.txt_Output.ReadOnly = True
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents label_Input As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents label_Output As System.Windows.Forms.Label
    Friend WithEvents txt_Input As System.Windows.Forms.TextBox
    Friend WithEvents txt_Output As System.Windows.Forms.TextBox
    Friend WithEvents chkbox_NoServerMessages As System.Windows.Forms.CheckBox
    Friend WithEvents txt_FilterInput As System.Windows.Forms.TextBox
    Friend WithEvents button_AddToFilter As System.Windows.Forms.Button
    Friend WithEvents listbox_Filters As System.Windows.Forms.ListBox
    Friend WithEvents button_SortAndFilter As System.Windows.Forms.Button
    Friend WithEvents button_SaveToFile As System.Windows.Forms.Button
    Friend WithEvents button_RemoveFromFilter As System.Windows.Forms.Button
    Friend WithEvents lbl_LinesInput As System.Windows.Forms.Label
    Friend WithEvents lbl_LinesOutput As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Progressbar As System.Windows.Forms.Label
    Friend WithEvents lbl_Empty As System.Windows.Forms.Label
    Friend WithEvents link_Email As System.Windows.Forms.LinkLabel
    Friend WithEvents link_Website As System.Windows.Forms.LinkLabel
    Friend WithEvents button_ClearFilters As System.Windows.Forms.Button

End Class
