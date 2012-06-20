Imports system.data.odbc
Public Class C_Entradas

    Private _rut As String


    Public Function cargarrut(ByVal rutpersona As String)
        Dim miconexion As New OdbcConnection
        Dim Con As New Func
        miconexion.ConnectionString = Con.Conexión
        Dim micomando As New OdbcCommand
        Dim sw As Boolean
        Dim miDataR As OdbcDataReader
        Try
            miconexion.Open()
            micomando.CommandText = "select isnull(rut,0) from reservadas where rut = '" & rutpersona & "' and estado=0 "
            micomando.Connection = miconexion
            miDataR = micomando.ExecuteReader(CommandBehavior.CloseConnection)

            If miDataR.HasRows Then
                rutpersona = miDataR.GetValue(0)
                sw = True
            Else
                sw = False
            End If

            miDataR.Close()
            miconexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Source)
            MessageBox.Show("No encuentra tabla")
        End Try
        miconexion.Close()
        Return sw
    End Function


    Public Function editarrut(ByVal rutpersona As String)
        Dim miconexion As New OdbcConnection
        Dim Con As New Func
        'Dim estado = 1
        miconexion.ConnectionString = Con.Conexión
        Dim miComando As New OdbcCommand
        Dim sw As Boolean = False
        Try
            miconexion.Open()
            'miComando.CommandText = "insert into entregadas values('" & rutpersona & "')"
            miComando.CommandText = "update reservadas set estado=1 where rut='" & rutpersona & "' and estado=0"
            miComando.Connection = miconexion
            miComando.ExecuteNonQuery()
            miconexion.Close()
            sw = True
        Catch Excep As Exception
            MessageBox.Show("Error al conectar con datos" & ControlChars.CrLf & Excep.Message & ControlChars.CrLf & Excep.Source)
        End Try
        Return sw
    End Function




    Public Property rut() As String
        Get
            Return _rut
        End Get
        Set(ByVal value As String)
            _rut = value
        End Set
    End Property


End Class
