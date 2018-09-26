Module Modkonek
    Public cn As OleDb.OleDbConnection
    Public cm As OleDb.OleDbCommand
    Public rdx As OleDb.OleDbDataReader
    Public dt As New DataTable
    Public sql As String
    

    Public Sub OPENCONN()
        Dim strcn As String

        strcn = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
            "Data Source=" & Application.StartupPath & "\DBPenjualan.mdb"
        Console.WriteLine(strcn)
        cn = New OleDb.OleDbConnection(strcn)

        Try

            cn.OPEN()


            If cn.STATE = ConnectionState.Closed Then
                MsgBox("DATABASE GAGAL DI AKSES")
            End If

        Catch ex As Exception
            Console.WriteLine("error!!" & ex.Message)
        End Try
    End Sub

    Public Sub closeConn()
        cn.Close()
    End Sub


    Public Sub exec(ByVal q As String)
        Dim cm As OleDb.OleDbCommand
        Try
            cm = New OleDb.OleDbCommand(q, cn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Public Sub read(ByVal q As String)
        Try
            cm = New OleDb.OleDbCommand(q, cn)
            cm.ExecuteNonQuery()
            rdx = cm.ExecuteReader
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub


    Public Function readdt(ByVal q As String) As DataTable
        Dim dt As New DataTable
        Try
            cm = New OleDb.OleDbCommand(q, cn)
            rdx = cm.ExecuteReader
            dt.Rows.Clear()
            dt.Load(rdx)
            Return dt
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return Nothing
    End Function
End Module
