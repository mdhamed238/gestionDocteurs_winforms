Imports System.Data.SqlClient

Public Class Database
    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection("Data Source=LAPTOP-MPCTGRIC;Initial Catalog=gestionDocteurs;Integrated Security=True")
    End Function
End Class
