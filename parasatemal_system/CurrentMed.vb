Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class CurrentMed
    Dim sqlConn As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = ""
    Dim database As String = "parasatemaldb"

    Private Sub ResetTextBoxes()
        txtID.Clear()
        txtBsa.Clear()
        txtDose.Clear()
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
            DataGridView1.Columns(1).Width = 140
            DataGridView1.Columns(2).Width = 190
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
    Private Sub CurrentMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        viewer()
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

    Private Sub UpdatepresBTN_Click(sender As Object, e As EventArgs) Handles UpdatepresBTN.Click
        Try
            sqlConn.Open()

            sqlcmd = sqlConn.CreateCommand()
            sqlcmd.CommandType = CommandType.Text

            Dim enteredDose As Integer

            Do
                If Not Integer.TryParse(txtDose.Text, enteredDose) Then
                    MessageBox.Show("Please enter a valid integer for the dose.", "Invalid Dose", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                If enteredDose > 30 Then
                    Dim warningResult As DialogResult = MessageBox.Show("The entered dose is too high. Please check the Dosage!. Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If warningResult = DialogResult.No Then
                        Return
                    End If
                End If
            Loop While enteredDose > 30 AndAlso MessageBox.Show("Do you want to update the prescription with the corrected dosage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes

            If enteredDose <= 30 Then
                sqlcmd.CommandText = "UPDATE parasatemaldb SET Dose_Quantity = @DoseQuantity, Weight_BSA = @WeightBSA WHERE Patient_ID = @PatientID"
                sqlcmd.Parameters.AddWithValue("@DoseQuantity", enteredDose)
                sqlcmd.Parameters.AddWithValue("@WeightBSA", txtBsa.Text)
                sqlcmd.Parameters.AddWithValue("@PatientID", txtID.Text)

                Dim rowsAffected As Integer = sqlcmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Prescription updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No matching record found. Prescription not updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                ResetTextBoxes()
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating prescription: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Close()
        End Try

        viewer()
    End Sub




    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 Then
                txtID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
                txtDose.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
                txtBsa.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating prescription: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sortasddesc_Click(sender As Object, e As EventArgs) Handles sortasddesc.Click
        Dim sortColumn As String = "Dose_Quantity"

        If sqlDt.DefaultView.Sort = sortColumn & " ASC" Then
            sqlDt.DefaultView.Sort = sortColumn & " DESC"
        Else
            sqlDt.DefaultView.Sort = sortColumn & " ASC"
        End If

        DataGridView1.DataSource = sqlDt.DefaultView
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fT As New DrugForm()
        fT.Show()
    End Sub
End Class