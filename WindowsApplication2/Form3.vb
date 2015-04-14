Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form3
    Dim connectionsql As String = "workstation id=hieunlpps02024.mssql.somee.com;packet size=4096;user id=hieups02024_SQLLogin_1;pwd=xoh8u5tiw5;data source=hieunlpps02024.mssql.somee.com;persist security info=False;initial catalog=hieunlpps02024"
    Dim connect1 As New SqlConnection(connectionsql)
    Public Sub LoadData()
        '' Mã điền vào tiêu đề ko có dấu '' cứ gõ (select MANHANVIEN As 'Mã nhân viên',MATKHAU As 'Mật khẩu',TENNHANVIEN As 'Tên nhân viên',SODT As 'Số điện thoại' from nhanvien)
        Dim getdata As New SqlDataAdapter("select * from sanpham", connect1)
        Dim bang As New DataTable
        Try
            getdata.Fill(bang)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ''dưới này là thực thi
        drvDS.DataSource = bang
        connect1.Close()
        '' rồi hiểu rồi . chưa có dữ liệu trong bảng loaisanpha
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect1.Open()
        Me.LoadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim add As String = "insert into sanpham values(@masp,@tensp,@dongia,@soluong,@loaisp)"
        connect1.Open()
        Dim cmdsql As New SqlCommand(add, connect1)
        Try
            cmdsql.Parameters.AddWithValue("@masp", txtMa.Text)
            cmdsql.Parameters.AddWithValue("@tensp", txtTen.Text)
            cmdsql.Parameters.AddWithValue("@dongia", Convert.ToInt32(txtGia.Text))
            cmdsql.Parameters.AddWithValue("@soluong", Convert.ToInt32(txtSL.Text))
            cmdsql.Parameters.AddWithValue("@loaisp", cbxSP.SelectedItem)
            '' tui biết r :) để im tui sữa thữ gán vậy có ổn ko  gán vậy ko đc đâu :)  để im 1 lát 
            '' sai ở code lệnh truy vấn insert rồi . chứ ko sao ko vào đc :( xem lại form sư de im
            '' nó hiện thêm là do loadata chứ ko phải thêm đc đâu :( hiểu r :) ! căn bản là tại á
            cmdsql.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Đã lưu thành công")
        End Try

        LoadData()
    End Sub

    Private Sub drvDS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles drvDS.CellContentClick
        Dim getdatadrv As Integer = drvDS.CurrentCell.RowIndex
        txtMa.Text = drvDS.Item(0, getdatadrv).Value
        txtTen.Text = drvDS.Item(1, getdatadrv).Value
        cbxSP.Text = drvDS.Item(4, getdatadrv).Value
        txtSL.Text = drvDS.Item(3, getdatadrv).Value
        txtGia.Text = drvDS.Item(2, getdatadrv).Value
    End Sub

    Private Sub btnUpD_Click(sender As Object, e As EventArgs) Handles btnUpD.Click
        Dim change As String = "update sanpham set tensp = @tensp , dongia = @dongia , soluong = @soluong where masp = @masp"
        connect1.Open()
        Dim cmdsql As New SqlCommand(change, connect1)
        Try
            cmdsql.Parameters.AddWithValue("@masp", txtMa.Text)
            cmdsql.Parameters.AddWithValue("@tensp", txtTen.Text)
            cmdsql.Parameters.AddWithValue("@dongia", Convert.ToInt32(txtGia.Text))
            cmdsql.Parameters.AddWithValue("@soluong", Convert.ToInt32(txtSL.Text))
            cmdsql.Parameters.AddWithValue("@loaisp", cbxSP.SelectedItem)

            cmdsql.ExecuteNonQuery()
            connect1.Close()
        Catch ex As Exception
            MessageBox.Show("Đã sữa thành công")
        End Try

        LoadData()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim del As String = " delete from sanpham where masp = @masp"
        connect1.Open()
        Dim cmdsql As New SqlCommand(del, connect1)
        Try
            cmdsql.Parameters.AddWithValue("@masp", txtMa.Text)
            cmdsql.ExecuteNonQuery()
            connect1.Close()
        Catch ex As Exception
            MessageBox.Show("đã xóa thành công")
        End Try
        LoadData()

    End Sub
End Class