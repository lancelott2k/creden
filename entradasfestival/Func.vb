Imports system.data.odbc
Public Class Func
    Private _str As String
    Public Function Conexión() As String
        'CONEXION LOCAL EN BENJAMIN_MOVIL
        'Dim miConexion As New odbcconnection("Data Source=benjamin_movil;Initial Catalog=longavipresupuesto;integrated security=yes;")
        Dim miconodbc As New OdbcConnection("DSN=reservadas;uid=entradas;pwd=entradas")

        'CONEXION DSN PARA INTRANET
        'Dim miconexion As New odbcconnection("Dns=Presupuestos;uid=sa;app=Microsoft® Visual Studio® 2005;wsid=BENJAMIN_MOVIL;database=longavipresupuesto;autotranslate=No;trusted_connection=Yes;quotedid=No;ansinpw=No")
        'CONEXION RED EN LONGAVI-SQL PROBADA, TENER UN USUARIO CON CONTRASEÑA EN EL SERVER PARA LA BASE DE DATOS
        ' Dim miConexion As New odbcconnection("Data Source=LONGAVI-SQL;Initial Catalog=longavipresupuesto;User ID=SMCLONGA;Password=SMCLONGA;trusted_connection=Yes")
        'Return miConexion.ConnectionString
        Return miconodbc.ConnectionString


    End Function
    Public Property cadena() As Integer
        ' bloque Get para devolver
        ' el valor de la propiedad
        Get
            Return _str
        End Get
        ' bloque Set para asignar
        ' valor a la propiedad
        Set(ByVal Value As Integer)
            _str = Value
        End Set
    End Property
End Class
