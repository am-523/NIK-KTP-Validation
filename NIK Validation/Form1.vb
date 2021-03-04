Imports NikvalidatorLib.NIKvalidator.Properti
Imports NikvalidatorLib

Public Class Form1

    Dim DATA As New NIKproperti
    Private Sub VIEWDATA()
        If NIKvalidator.Aksi.Checkstatus.NIKfungsi.StatusValidasiNIK = False Then 'jika gagal
            MessageBox.Show("Mohon periksa kembali nik anda!", "Information")
        Else


            '//// Tampilkan informasi NIK /////
            labelNik.Text = TextBoxNIK.Text
            labelUnik.Text = DATA.kodeUnik
            labelUsia.Text = DATA.usia & " tahun"
            labelTanggal_lahir.Text = DATA.tanggalLahir
            labelJenis_kelamin.Text = DATA.jenisKelamin
            labelUlang_tahun.Text = DATA.ulangTahun
            labelZodiak.Text = DATA.zodiak
            labelProvinsi.Text = DATA.provinsi
            labelKotaKabupaten.Text = DATA.kotaKabupaten
            labelKecamatan.Text = DATA.kecamatan
            labelKode_pos.Text = DATA.kodePos
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.LightBlue
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        DATA.setNIK = TextBoxNIK.Text
        NIKvalidator.Aksi.ValidasiNIK(DATA)

        'tampilkan informasi data
        VIEWDATA()
    End Sub
End Class
