Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class MedicalField
    Private Sub CMBTN_Click(sender As Object, e As EventArgs) Handles CMBTN.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to change the dose?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim f3 As New CurrentMed()
            Me.Close()
            f3.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f5 As New NewMed()
        Me.Hide()
        f5.Show()
    End Sub

    Private Sub HomeBTN_Click(sender As Object, e As EventArgs) Handles HomeBTN.Click
        Dim f2 As New Form1()
        Me.Hide()
        f2.Show()
    End Sub

    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fT As New DrugForm()
        Me.Hide()
        fT.Show()
    End Sub
End Class