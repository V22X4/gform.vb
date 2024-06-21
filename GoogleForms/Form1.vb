Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1
    Private Sub btnAddQuestion_Click(sender As Object, e As EventArgs) Handles btnAddQuestion.Click
        If Not String.IsNullOrWhiteSpace(txtQuestion.Text) Then
            lstQuestions.Items.Add(txtQuestion.Text)
            txtQuestion.Clear()
        Else
            MessageBox.Show("Please enter a question.")
        End If
    End Sub

    Private Async Sub btnCreateForm_Click(sender As Object, e As EventArgs) Handles btnCreateForm.Click
        Dim questions As New List(Of String)
        For Each item In lstQuestions.Items
            questions.Add(item.ToString())
        Next

        Dim formData As New Dictionary(Of String, Object) From {
            {"questions", questions}
        }

        Dim json As String = JsonConvert.SerializeObject(formData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/create", content)
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                If response.IsSuccessStatusCode Then
                    Dim formIdResponse = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(responseBody)
                    MessageBox.Show("Form created successfully. Form ID: " & formIdResponse("formId"))
                    lstQuestions.Items.Clear()
                Else
                    MessageBox.Show("Error creating form: " & responseBody)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Exception occurred: " & ex.Message)
        End Try
    End Sub

    Private Async Sub btnLoadForm_Click(sender As Object, e As EventArgs) Handles btnLoadForm.Click
        Dim formId As String = txtFormId.Text.Trim()
        If String.IsNullOrWhiteSpace(formId) Then
            MessageBox.Show("Please enter a Form ID.")
            Return
        End If

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/form/" & formId)
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                If response.IsSuccessStatusCode Then
                    Dim formResponse = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseBody)
                    Dim questions = JsonConvert.DeserializeObject(Of List(Of String))(formResponse("questions").ToString())

                    lstQuestions.Items.Clear()
                    pnlAnswers.Controls.Clear()
                    Dim yPos As Integer = 0
                    For Each question As String In questions
                        Dim lblQuestion As New Label()
                        lblQuestion.Text = question
                        lblQuestion.Location = New Point(0, yPos)
                        lblQuestion.Size = New Size(300, 20)
                        pnlAnswers.Controls.Add(lblQuestion)

                        yPos += 25

                        Dim txtAnswer As New TextBox()
                        txtAnswer.Name = "txtAnswer_" & pnlAnswers.Controls.Count.ToString()
                        txtAnswer.Location = New Point(0, yPos)
                        txtAnswer.Size = New Size(300, 20)
                        pnlAnswers.Controls.Add(txtAnswer)

                        yPos += 25
                    Next
                Else
                    MessageBox.Show("Error loading form: " & responseBody)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Exception occurred: " & ex.Message)
        End Try
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim formId As String = txtFormId.Text.Trim()
        If String.IsNullOrWhiteSpace(formId) Then
            MessageBox.Show("Please load a form first.")
            Return
        End If

        Dim answers As New List(Of String)
        For Each ctrl As Control In pnlAnswers.Controls
            If TypeOf ctrl Is TextBox Then
                answers.Add(ctrl.Text)
            End If
        Next

        Dim answerData As New Dictionary(Of String, Object) From {
            {"answers", answers}
        }

        Dim json As String = JsonConvert.SerializeObject(answerData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit/" & formId, content)
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Form submitted successfully.")
                    pnlAnswers.Controls.Clear()
                    txtFormId.Clear()
                Else
                    MessageBox.Show("Error submitting form: " & responseBody)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Exception occurred: " & ex.Message)
        End Try
    End Sub

    Private Async Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim formId As String = txtFormId.Text.Trim()
        If String.IsNullOrWhiteSpace(formId) Then
            MessageBox.Show("Please enter a Form ID.")
            Return
        End If

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/submissions/" & formId)
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                If response.IsSuccessStatusCode Then
                    Dim submissionsResponse = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseBody)
                    Dim submissions = JsonConvert.DeserializeObject(Of List(Of List(Of String)))(submissionsResponse("submissions").ToString())

                    lstSubmissions.Items.Clear()
                    For Each submission In submissions
                        lstSubmissions.Items.Add(String.Join(", ", submission))
                    Next
                Else
                    MessageBox.Show("Error loading submissions: " & responseBody)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Exception occurred: " & ex.Message)
        End Try
    End Sub
End Class
