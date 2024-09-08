Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class Form1

    Dim sqlConn As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = ""
    Dim database As String = "parasatemaldb"

    Private Sub viewer()
        Try
            sqlConn.Open()
            sqlcmd = sqlConn.CreateCommand()
            sqlcmd.CommandType = CommandType.Text
            DtA = New MySqlDataAdapter("select * from parasatemaldb", sqlConn)
            sqlDt.Clear()
            DtA.Fill(sqlDt)
            DataGridView1.DataSource = sqlDt
            sqlConn.Close()

            DataGridView1.Columns(0).Width = 90
            DataGridView1.Columns(1).Width = 130
            DataGridView1.Columns(2).Width = 200
            DataGridView1.Columns(3).Width = 120
            DataGridView1.Columns(4).Width = 90
            DataGridView1.Columns(5).Width = 80
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub

    Private Sub updateTable()
        Try
            sqlConn.ConnectionString = $"server={server};user id={username};password={password};database={database}"
            sqlConn.Open()

            sqlcmd.Connection = sqlConn
            sqlcmd.CommandText = "SELECT * FROM parasatemaldb"

            sqlRd = sqlcmd.ExecuteReader()
            sqlDt.Load(sqlRd)
            sqlRd.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try

        DataGridView1.DataSource = sqlDt
    End Sub



    Private Sub MedictionfBTN_Click(sender As Object, e As EventArgs) Handles MedictionfBTN.Click
        Dim f2 As New MedicalField()
        Me.Hide()
        f2.Show()
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        viewer()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dv As New DataView(sqlDt)
            dv.RowFilter = String.Format("Patient_ID LIKE '%{0}%' OR Medicinal_Product LIKE '%{0}%' OR NZMT_Concept LIKE '%{0}%' OR Dose_Unit LIKE '%{0}%'", txtSearch.Text)
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MessageBox.Show("Error filtering data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sortasddesc_Click(sender As Object, e As EventArgs) Handles sortasddesc.Click
        Dim sortColumn As String = "Patient_ID"

        If sqlDt.DefaultView.Sort = sortColumn & " ASC" Then
            sqlDt.DefaultView.Sort = sortColumn & " DESC"
        Else
            sqlDt.DefaultView.Sort = sortColumn & " ASC"
        End If

        DataGridView1.DataSource = sqlDt.DefaultView
    End Sub

    Private Sub HomeBTN_Click(sender As Object, e As EventArgs) Handles HomeBTN.Click
        Dim f2 As New Form1()
        Me.Hide()
        f2.Show()
    End Sub
End Class
