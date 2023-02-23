Imports System
Imports System.Data
Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles subBtn.Click
        Dim sqlcon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\soham\Desktop\DotNet\Employee\App_Data\Database.mdf;Integrated Security=True;User Instance=True")

        sqlcon.Open()

        If (txtID.Text = "") Then
            MsgBox("Invalid Input !!!")
        End If
        Dim query As String = "select ename from Employee where eid=' " & txtID.Text & "';"
        Dim cmd As New SqlCommand(query, sqlcon)
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.Read Then
            txtName.Text = dr.GetValue(0)
        End If
        sqlcon.Close()
        

    End Sub

    
    Protected Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtID.Text = ""
        txtName.Text = ""
    End Sub
End Class
