Imports MySql.Data.MySqlClient

Public Class add_person_form
    Public ds As New DataSet
    Public da As New MySqlDataAdapter
    Public sqlconn As New MySqlConnection
    Public dt As New DataTable
    Public count As Integer

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        connect()


        ds = New DataSet
        da = New MySqlDataAdapter("insert into " & cmb_types.Text & " (name,number,nickname,email,address,type,active) values (@name,@number,@nickname,@email,@address,@type,1)", sqlconn)
        da.SelectCommand.Parameters.AddWithValue("@name", txt_name.Text)
        da.SelectCommand.Parameters.AddWithValue("@number", txt_number.Text)
        da.SelectCommand.Parameters.AddWithValue("@nickname", txt_nickname.Text)
        da.SelectCommand.Parameters.AddWithValue("@email", txt_email.Text)
        da.SelectCommand.Parameters.AddWithValue("@address", txt_address.Text)
        da.SelectCommand.Parameters.AddWithValue("@type", cmb_type.Text)
        da.Fill(ds, "" & cmb_types.Text)

        MsgBox("DATA ADDED SUCCESSFULLY")

        txt_name.Text = ""
        txt_number.Text = ""
        txt_nickname.Text = ""
        txt_email.Text = ""
        txt_address.Text = ""
        cmb_type.Text = ""

        ds = New DataSet
        da = New MySqlDataAdapter("Select * from " & cmb_types.Text & " where active = 1", sqlconn)
        da.Fill(ds, "" & cmb_types.Text)
        Me.DataGridView1.DataSource = ds.Tables("" & cmb_types.Text)



    End Sub

    Public Sub connect()

        sqlconn = New MySqlConnection("server=localhost;userid=root;password=;database=adbfinalproject;")
        If sqlconn.State = ConnectionState.Closed Then

            sqlconn.Open()

        End If

    End Sub



    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        Try
            connect()

            ds = New DataSet
            da = New MySqlDataAdapter("Select * from " & cmb_types.Text & " where active = 1", sqlconn)
            da.Fill(ds, "" & cmb_types.Text)
            Me.DataGridView1.DataSource = ds.Tables("" & cmb_types.Text)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO UPDATE CONTACT?", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then

            connect()
            ds = New DataSet
            da = New MySqlDataAdapter("update " & cmb_types.Text & " set name=@name,number=@number,nickname=@nickname,email=@email,address=@address,type=@type where id=@id", sqlconn)
            da.SelectCommand.Parameters.AddWithValue("@id", lbl_id.Text)
            da.SelectCommand.Parameters.AddWithValue("@name", txt_name.Text)
            da.SelectCommand.Parameters.AddWithValue("@number", txt_number.Text)
            da.SelectCommand.Parameters.AddWithValue("@nickname", txt_nickname.Text)
            da.SelectCommand.Parameters.AddWithValue("@email", txt_email.Text)
            da.SelectCommand.Parameters.AddWithValue("@address", txt_address.Text)

            da.SelectCommand.Parameters.AddWithValue("@type", cmb_type.Text)
            da.Fill(ds, "" & cmb_types.Text)

            MsgBox("DATA UPDATED SUCCESSFULLY")

            txt_name.Text = ""
            txt_number.Text = ""
            txt_nickname.Text = ""
            txt_email.Text = ""
            txt_address.Text = ""
            cmb_type.Text = ""

            ds = New DataSet
            da = New MySqlDataAdapter("Select * from " & cmb_types.Text & " where active = 1", sqlconn)
            da.Fill(ds, "" & cmb_types.Text)
            DataGridView1.DataSource = ds.Tables("" & cmb_types.Text)

        Else

        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        lbl_id.Text = DataGridView1.SelectedRows(0).Cells("id").Value.ToString
        txt_name.Text = DataGridView1.SelectedRows(0).Cells("name").Value.ToString
        txt_number.Text = DataGridView1.SelectedRows(0).Cells("number").Value.ToString
        txt_nickname.Text = DataGridView1.SelectedRows(0).Cells("nickname").Value.ToString
        txt_email.Text = DataGridView1.SelectedRows(0).Cells("email").Value.ToString
        txt_address.Text = DataGridView1.SelectedRows(0).Cells("address").Value.ToString
        cmb_type.Text = DataGridView1.SelectedRows(0).Cells("type").Value.ToString

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim confirm = MsgBox("ARE YOU SURE YOU WANT TO DELETE CONTACT?", MessageBoxButtons.YesNo + MsgBoxStyle.Information)
        If confirm = MsgBoxResult.Yes Then
            connect()

            ds = New DataSet
            da = New MySqlDataAdapter("update " & cmb_types.Text & " set active = 0 where id=@id", sqlconn)
            da.SelectCommand.Parameters.AddWithValue("@id", lbl_id.Text)
            da.Fill(ds, "" & cmb_types.Text)
            MsgBox("DATA DELETED SUCCESSFULLY")

            da = New MySqlDataAdapter("Select * from " & cmb_types.Text & " where active = 1", sqlconn)
            da.Fill(ds, "" & cmb_types.Text)
            DataGridView1.DataSource = ds.Tables("" & cmb_types.Text)

            txt_name.Text = ""
            txt_number.Text = ""
            txt_nickname.Text = ""
            txt_email.Text = ""
            txt_address.Text = ""
            cmb_type.Text = ""
        Else

        End If
    End Sub

    Private Sub add_person_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class