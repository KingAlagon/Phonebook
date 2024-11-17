Imports MySql.Data.MySqlClient

Public Class deleted_contacts
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim sqlconn As New MySqlConnection
    Public dt As New DataTable
    Public count As Integer

    Private Sub deleted_contacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        da = New MySqlDataAdapter("show tables from adbfinalproject", sqlconn)
        da.Fill(dt)
        count = 0
        cmb_types.Items.Clear()
        cmb_types.Items.Add("+== SELECT DATABASE ==+")
        While count < dt.Rows.Count
            cmb_types.Items.Add(dt.Rows(count)(0).ToString)
            count = count + 1

        End While


    End Sub
    Public Sub connect()

        sqlconn = New MySqlConnection("server=localhost;userid=root;password=;database=adbfinalproject;")
        If sqlconn.State = ConnectionState.Closed Then

            sqlconn.Open()

        End If

    End Sub

    Private Sub cmb_types_TextChanged(sender As Object, e As EventArgs) Handles cmb_types.TextChanged
        Try
            connect()
            ds = New DataSet
            da = New MySqlDataAdapter("Select * from " & cmb_types.Text & "where active = 0", sqlconn)
            da.Fill(ds, "" & cmb_types.Text)
            DataGridView1.DataSource = ds.Tables("" & cmb_types.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        Try
            connect()

            ds = New DataSet
            da = New MySqlDataAdapter("Select * from " & cmb_types.Text & " where active = 0", sqlconn)
            da.Fill(ds, "" & cmb_types.Text)
            Me.DataGridView1.DataSource = ds.Tables("" & cmb_types.Text)
        Catch ex As Exception

        End Try

    End Sub
End Class