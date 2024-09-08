Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Management
Imports System.Data.OleDb

Public Class NewMed
    Dim sqlConn As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = ""
    Dim database As String = "parasatemaldb"

    Private Sub ResetTextBoxes()
        txtID.Clear()
        txtProd.Clear()
        txtconcept.Clear()
        txtBsa.Clear()
        txtDose.Clear()
        txtUnit.Clear()
    End Sub

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
            DataGridView1.Columns(1).Width = 150
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
    Private Sub HomeBTN_Click(sender As Object, e As EventArgs) Handles HomeBTN.Click
        Dim f2 As New Form1()
        Me.Hide()
        f2.Show()
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub MedictionfBTN_Click(sender As Object, e As EventArgs) Handles MedictionfBTN.Click
        Dim f2 As New MedicalField()
        Me.Hide()
        f2.Show()
    End Sub

    Private Sub saveBTN_Click(sender As Object, e As EventArgs) Handles saveBTN.Click
        Try

            Dim enteredDose As Integer
            If Not Integer.TryParse(txtDose.Text, enteredDose) Then
                MessageBox.Show("Please enter a valid integer for the dose.", "Invalid Dose", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            If enteredDose > 30 Then
                Dim warningResult As DialogResult = MessageBox.Show("The entered dose is too high. Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If warningResult = DialogResult.No Then

                    Return
                End If
            End If


            Dim confirmResult As DialogResult = MessageBox.Show("Is the selected medication correct?", "Confirm Medication", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmResult = DialogResult.Yes Then
                sqlConn.Open()

                sqlcmd = sqlConn.CreateCommand()
                sqlcmd.CommandType = CommandType.Text

                sqlcmd.CommandText = "INSERT INTO parasatemaldb(Patient_ID, Medicinal_Product, NZMT_Concept, Weight_BSA, Dose_Quantity, Dose_Unit) VALUES (@PatientIDParam, @MedicinalProductParam, @NZMTConceptParam, @WeightBSAParam, @DoseQuantityParam, @DoseUnitParam)"

                sqlcmd.Parameters.AddWithValue("@PatientIDParam", txtID.Text)
                sqlcmd.Parameters.AddWithValue("@MedicinalProductParam", txtProd.Text)
                sqlcmd.Parameters.AddWithValue("@NZMTConceptParam", txtconcept.Text)
                sqlcmd.Parameters.AddWithValue("@WeightBSAParam", txtBsa.Text)
                sqlcmd.Parameters.AddWithValue("@DoseQuantityParam", enteredDose)
                sqlcmd.Parameters.AddWithValue("@DoseUnitParam", txtUnit.Text)

                sqlcmd.ExecuteNonQuery()
                sqlConn.Close()

                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewer()
            End If

            ResetTextBoxes()
        Catch ex As Exception
            MessageBox.Show("Error inserting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NewMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        viewer()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 Then
                txtProd.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating prescription: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dv As New DataView(sqlDt)
            dv.RowFilter = String.Format("Medicinal_Product LIKE '%{0}%'", txtSearch.Text)
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MessageBox.Show("Error filtering data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sortasddesc_Click(sender As Object, e As EventArgs) Handles sortasddesc.Click
        Dim sortColumn As String = "Medicinal_Product"

        If sqlDt.DefaultView.Sort = sortColumn & " ASC" Then
            sqlDt.DefaultView.Sort = sortColumn & " DESC"
        Else
            sqlDt.DefaultView.Sort = sortColumn & " ASC"
        End If

        DataGridView1.DataSource = sqlDt.DefaultView
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fT As New DrugForm()
        Me.Hide()
        fT.Show()
    End Sub
End Class