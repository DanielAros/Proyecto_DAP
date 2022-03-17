'//*******************************************
'// Se importan librerias para realizar la conexión a la BDA
'//*******************************************

Imports System.Data
Imports System.Data.OleDb

Module Conexion

    Public Ruta As String = Application.StartupPath
    Public Conexion As New OleDbConnection

    Sub Enlace()
        Try
            Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & Ruta + "\Recursos Sistema\Base principal.accdb"
            Conexion.Open()
        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Module
