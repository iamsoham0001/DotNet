Imports System
Imports System.Data
Imports System.Data.SqlClient

Partial Class imageDetails
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        pnl.Visible = True

        Dim sqlcon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True")
        sqlcon.Open()

        Dim id As String = txtid.Text

        Dim query As String = "select * from Image where ID =" & id & ";"

        Dim da As New SqlDataAdapter(query, sqlcon)
        Dim dt As New DataTable
        Try
            da.Fill(dt)

            lblnm.Text = dt.Rows(0).Item(1)
            img.ImageUrl = dt.Rows(0).Item(2)

        Catch ex As Exception
            lblnm.Text = ex.Message
        End Try
        


        sqlcon.Close()

    End Sub
End Class
