Imports System
Imports System.Data
Imports System.Data.SqlClient

Partial Class View
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlcon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True")
        sqlcon.Open()
        Dim query As String = "select * from Customer where id='" + txtId.Text + "';"
        Dim da As New SqlDataAdapter(query, sqlcon)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            lblName.Text = dt.Rows(0).Item(1)
            lblNo.Text = dt.Rows(0).Item(2)
            lblName.Visible = True
            lblNo.Visible = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
End Class
