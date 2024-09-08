Imports MySql.Data.MySqlClient

Public Class DrugForm
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = ""
    Dim database As String = "parasatemaldb"

    Private Sub UpdateTable()
        Try
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database};Pooling=False;"
            sqlConn.Open()

            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "SELECT * FROM drugformulary"

            DtA = New MySqlDataAdapter(sqlCmd)
            sqlDt.Clear()
            DtA.Fill(sqlDt)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try

        DataGridView1.DataSource = sqlDt
    End Sub

    Private Sub Viewer()
        Try
            sqlConn.Open()
            sqlCmd = sqlConn.CreateCommand()
            sqlCmd.CommandType = CommandType.Text
            DtA = New MySqlDataAdapter("SELECT * FROM drugformulary", sqlConn)
            sqlDt.Clear()
            DtA.Fill(sqlDt)
            DataGridView1.DataSource = sqlDt
            sqlConn.Close()
            DataGridView1.Columns(0).Width = 300
            DataGridView1.Columns(1).Width = 90
            DataGridView1.Columns(2).Width = 190
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try

    End Sub

    Private Sub MedictionfBTN_Click(sender As Object, e As EventArgs) Handles MedictionfBTN.Click
        Dim f2 As New MedicalField()
        Me.Hide()
        f2.Show()
    End Sub

    Private Sub HomeBTN_Click(sender As Object, e As EventArgs) Handles HomeBTN.Click
        Dim f2 As New Form1()
        Me.Hide()
        f2.Show()
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Close?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub DrugForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTable()
        Viewer()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dv As New DataView(sqlDt)
            dv.RowFilter = String.Format("Convert([Drug Name], System.String) LIKE '%{0}%'", txtSearch.Text)
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MessageBox.Show("Error filtering data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sortasddesc_Click(sender As Object, e As EventArgs) Handles sortasddesc.Click
        Dim sortColumn As String = "Drug Name"

        If sqlDt.DefaultView.Sort = sortColumn & " ASC" Then
            sqlDt.DefaultView.Sort = sortColumn & " DESC"
        Else
            sqlDt.DefaultView.Sort = sortColumn & " ASC"
        End If

        DataGridView1.DataSource = sqlDt.DefaultView
    End Sub
End Class
