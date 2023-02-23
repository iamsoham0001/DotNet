Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1


    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtName.Text = "" And txtEmail.Text = "" And txtNo.Text = "" Then
            MsgBox("Input Invalid")
        End If

        Dim sqlcon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\soham\Desktop\DotNet\RegistrationApplication\RegistrationNow\RegistrationNow\Database1.mdf;Integrated Security=True;User Instance=True")
        sqlcon.Open()
        Dim gender As String = ""
        If rm.Checked = True Then
            gender = "Male"
        ElseIf rf.Checked = True Then
            gender = "Female"
        End If

        Dim stream As String = ddlStream.Text
        Dim couse As String = ddlCourse.Text
        Dim query As String = "insert into Reg values ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtNo.Text + "','" + gender + "','" + stream + "','" + couse + "');"
        Dim cmd As New SqlCommand(query, sqlcon)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Successful")
        Catch ex As Exception
            MsgBox("error")
        End Try
        sqlcon.Close()
        txtName.Text = ""
        txtEmail.Text = ""
        txtNo.Text = ""
        rm.Checked = False
        rf.Checked = False

        ddlCourse.Text = "select"
        ddlStream.Text = "select"

    End Sub

  
End Class
