Imports gestionDocteurs_winforms
Imports System.Data.SqlClient

Public Class FormHopital
    Private Sub FormHopital_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFromDB()
        TextNom.Focus()

        Dim item1 As New ToolStripButton()
        item1.Text = "Gestion des docteurs"
        AddHandler item1.Click, AddressOf item1_Click
        ToolStrip1.Items.Add(item1)

        Dim logoutButton As New ToolStripButton("Logout")
        ToolStrip1.Items.Add(logoutButton)
        AddHandler logoutButton.Click, AddressOf logoutButton_Click
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Dim conn As SqlConnection = Database.GetConnection()
        conn.Open()

        Dim name As String = TextNom.Text
        Dim address As String = TextAdresse.Text

        Dim command As New SqlCommand("INSERT INTO Hopital VALUES(@id, @nom, @adresse)", conn)
        command.Parameters.AddWithValue("@id", GenerateID())
        command.Parameters.AddWithValue("@nom", name)
        command.Parameters.AddWithValue("@adresse", address)

        Try
            command.ExecuteNonQuery()
            'MessageBox.Show("Data inserted successfully")
            LoadFromDB()
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim conn As SqlConnection = Database.GetConnection()
        conn.Open()

        Dim id As String = TextID.Text
        Dim name As String = TextNom.Text
        Dim address As String = TextAdresse.Text

        Dim command As New SqlCommand("UPDATE Hopital SET nom=@nom, adresse=@adresse WHERE id=@id", conn)
        command.Parameters.AddWithValue("@id", id)
        command.Parameters.AddWithValue("@nom", name)
        command.Parameters.AddWithValue("@adresse", address)

        Try
            command.ExecuteNonQuery()
            'MessageBox.Show("Data updated successfully")
            LoadFromDB()
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextID.Text = selectedRow.Cells("id").Value.ToString()
            TextNom.Text = selectedRow.Cells("nom").Value.ToString()
            TextAdresse.Text = selectedRow.Cells("adresse").Value.ToString()
        End If
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        LoadFromDB()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim conn As SqlConnection = Database.GetConnection()
        Dim id
        Try
            id = DataGridView1.SelectedRows(0).Cells(0).Value
        Catch ex As Exception
            Return
        End Try
        conn.Open()
        Dim command As New SqlCommand("DELETE FROM Hopital WHERE id=@id", conn)
        command.Parameters.AddWithValue("@id", id)
        If command.ExecuteNonQuery() > 0 Then
            'MessageBox.Show("Row Deleted Successfully")
            LoadFromDB()
        Else
            MessageBox.Show("Failed to Delete Row")
        End If
        conn.Close()
    End Sub

    Private Sub LoadFromDB()
        Dim conn As SqlConnection = Database.GetConnection()
        conn.Open()
        Dim command As New SqlCommand("SELECT * FROM Hopital", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        conn.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        TextNom.Clear()
        TextAdresse.Clear()
        TextNom.Focus()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim searchValue As String = SearchTextBox.Text.Trim()
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().Contains(searchValue) Then
                    row.Selected = True
                    DataGridView1.FirstDisplayedScrollingRowIndex = row.Index
                    Exit For
                Else
                    row.Selected = False
                End If
            Next
        Next
    End Sub

    Private Sub SearchTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchButton.PerformClick()
        End If
    End Sub

    Private Sub item1_Click(sender As Object, e As EventArgs)
        Dim form As New FormDocteur()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs)
        Me.Close()
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Function GenerateID() As String
        Dim random As New Random()
        Dim id As String = ""
        For i As Integer = 0 To 4
            id += random.Next(0, 9).ToString()
        Next
        Return id
    End Function

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class