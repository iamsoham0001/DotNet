Imports System
Imports System.Data
Imports System.Data.SqlClient

Partial Class SelectCourse
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlcon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True")
        sqlcon.Open()
        Dim query As String = "insert into Product values('" + txtId.Text + "','" + txtName.Text + "','" + txtPrice.Text + "','" + txtDate.Text + "');"
        Dim cmd As New SqlCommand(query, sqlcon)
        Try
            cmd.ExecuteNonQuery()
            lbl.Visible = True
            lbl.Text = "Successful"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqlcon.Close()

    End Sub
End Class
