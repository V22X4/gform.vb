<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.btnAddQuestion = New System.Windows.Forms.Button()
        Me.lstQuestions = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCreateForm = New System.Windows.Forms.Button()
        Me.lblFormId = New System.Windows.Forms.Label()
        Me.txtFormId = New System.Windows.Forms.TextBox()
        Me.btnLoadForm = New System.Windows.Forms.Button()
        Me.pnlAnswers = New System.Windows.Forms.Panel()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.lstSubmissions = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(12, 12)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(200, 20)
        Me.txtQuestion.TabIndex = 0
        '
        'btnAddQuestion
        '
        Me.btnAddQuestion.Location = New System.Drawing.Point(218, 10)
        Me.btnAddQuestion.Name = "btnAddQuestion"
        Me.btnAddQuestion.Size = New System.Drawing.Size(100, 23)
        Me.btnAddQuestion.TabIndex = 1
        Me.btnAddQuestion.Text = "Add Question"
        Me.btnAddQuestion.UseVisualStyleBackColor = True
        '
        'lstQuestions
        '
        Me.lstQuestions.FormattingEnabled = True
        Me.lstQuestions.Location = New System.Drawing.Point(12, 38)
        Me.lstQuestions.Name = "lstQuestions"
        Me.lstQuestions.Size = New System.Drawing.Size(306, 134)
        Me.lstQuestions.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 178)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCreateForm
        '
        Me.btnCreateForm.Location = New System.Drawing.Point(243, 178)
        Me.btnCreateForm.Name = "btnCreateForm"
        Me.btnCreateForm.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateForm.TabIndex = 4
        Me.btnCreateForm.Text = "Create Form"
        Me.btnCreateForm.UseVisualStyleBackColor = True
        '
        'lblFormId
        '
        Me.lblFormId.AutoSize = True
        Me.lblFormId.Location = New System.Drawing.Point(12, 214)
        Me.lblFormId.Name = "lblFormId"
        Me.lblFormId.Size = New System.Drawing.Size(47, 13)
        Me.lblFormId.TabIndex = 5
        Me.lblFormId.Text = "Form ID:"
        '
        'txtFormId
        '
        Me.txtFormId.Location = New System.Drawing.Point(65, 211)
        Me.txtFormId.Name = "txtFormId"
        Me.txtFormId.Size = New System.Drawing.Size(147, 20)
        Me.txtFormId.TabIndex = 6
        '
        'btnLoadForm
        '
        Me.btnLoadForm.Location = New System.Drawing.Point(218, 209)
        Me.btnLoadForm.Name = "btnLoadForm"
        Me.btnLoadForm.Size = New System.Drawing.Size(100, 23)
        Me.btnLoadForm.TabIndex = 7
        Me.btnLoadForm.Text = "Load Form"
        Me.btnLoadForm.UseVisualStyleBackColor = True
        '
        'pnlAnswers
        '
        Me.pnlAnswers.AutoScroll = True
        Me.pnlAnswers.Location = New System.Drawing.Point(12, 250)
        Me.pnlAnswers.Name = "pnlAnswers"
        Me.pnlAnswers.Size = New System.Drawing.Size(306, 150)
        Me.pnlAnswers.TabIndex = 8
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.Location = New System.Drawing.Point(12, 410)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(140, 23)
        Me.btnViewSubmissions.TabIndex = 9
        Me.btnViewSubmissions.Text = "View Submissions"
        Me.btnViewSubmissions.UseVisualStyleBackColor = True
        '
        'lstSubmissions
        '
        Me.lstSubmissions.FormattingEnabled = True
        Me.lstSubmissions.Location = New System.Drawing.Point(12, 439)
        Me.lstSubmissions.Name = "lstSubmissions"
        Me.lstSubmissions.Size = New System.Drawing.Size(306, 95)
        Me.lstSubmissions.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 561)
        Me.Controls.Add(Me.lstSubmissions)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Controls.Add(Me.pnlAnswers)
        Me.Controls.Add(Me.btnLoadForm)
        Me.Controls.Add(Me.txtFormId)
        Me.Controls.Add(Me.lblFormId)
        Me.Controls.Add(Me.btnCreateForm)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lstQuestions)
        Me.Controls.Add(Me.btnAddQuestion)
        Me.Controls.Add(Me.txtQuestion)
        Me.Name = "Form1"
        Me.Text = "Google Forms Clone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents btnAddQuestion As System.Windows.Forms.Button
    Friend WithEvents lstQuestions As System.Windows.Forms.ListBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCreateForm As System.Windows.Forms.Button
    Friend WithEvents lblFormId As System.Windows.Forms.Label
    Friend WithEvents txtFormId As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadForm As System.Windows.Forms.Button
    Friend WithEvents pnlAnswers As System.Windows.Forms.Panel
    Friend WithEvents btnViewSubmissions As System.Windows.Forms.Button
    Friend WithEvents lstSubmissions As System.Windows.Forms.ListBox
End Class
