Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class CustomerRecord
    Inherits System.Web.UI.Page

    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
     
        Dim sqlcon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True")
        sqlcon.Open()

        Dim query As String = "insert into Customer values('" + txtId.Text + "','" + txtName.Text + "','" + txtPh.Text + "');"

        Dim cmd As New SqlCommand(query, sqlcon)

        Try
            cmd.ExecuteNonQuery()
            lbl.Text = "Successful"
            lbl.Visible = True

        Catch ex As Exception
            lbl.Visible = True
            lbl.Text = ex.ToString

        End Try

        txtId.Text = ""
        txtName.Text = ""
        txtPh.Text = ""


        sqlcon.Close()

    End Sub
End Class
