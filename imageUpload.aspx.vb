Imports System
Imports System.Data
Imports System.Data.SqlClient

Partial Class imageUpload
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlcon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True")
        sqlcon.Open()
        Dim id As String = txtID.Text
        Dim nm As String = txtName.Text
        Dim path As String
        Dim ext As String = System.IO.Path.GetExtension(fileUploadTool.FileName).ToLower

        If ext = ".jpg" Or ext = ".png" Then
            fileUploadTool.PostedFile.SaveAs(Server.MapPath(".") + "\\images\\" + fileUploadTool.FileName)
            path = "images\" + fileUploadTool.FileName
            Dim query As String = "insert into Image values(@id,@nm,@path);"
            Dim cmd As New SqlCommand(query, sqlcon)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nm", nm)
            cmd.Parameters.AddWithValue("@path", path)

            Try
                cmd.ExecuteNonQuery()
                lblmsg.Text = "Uploading Successful !!!"
            Catch ex As Exception
                lblmsg.Text = ex.Message
            End Try
        Else
            lblmsg.Text = "Please upload jpg or png files"
        End If


        sqlcon.Close()
    End Sub
End Class
