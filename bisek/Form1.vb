Public Class Form1
    'dibawah adalah sub penentu digunakan untuk input semua masukkan, 
    'dan memilih proses di fungsi yg mana, misal kalo kita ceklis toleransi, maka akar_toleransi yg dipanggil
    'lalu fungsi tersebut akan mengkalkulasikan akar dan menampilkan output nya ke textbox, sedangkan output dgv beda lagi,
    'karena output dgv akan memproses output pada saat fungsi nya jalan di dalam proses iterasi
    Private Sub penentu()
        'deklarasi batas a sbg batas ke 1, batas b sbg batas ke 2, n sebagai maksimum iterasi dan koma sebagai toleransi margin error
        Dim a As Double, b As Double, koma As Double = 0.0
        Dim n As Integer = 0

        'ini adalah fungsi if untuk mengecek apakah ada yg kosong kosong saat user mengisi data awalnya
        If inPersamaan.Text = "" Or inA.Text = "" Or inB.Text = "" Or inE.Text = "" Or inITERASI.Text = "" Then
            MessageBox.Show("tolong cek data yg anda masukkan, tidak boleh kosong")
            Return

            'dan ini adalah fungsi if untuk cek lagi apa ada data yg user input tidak sesuai dgn tipe data
        ElseIf Not Double.TryParse(inA.Text, a) Or Not Double.TryParse(inB.Text, b) Or Not Double.TryParse(inE.Text, koma) Or Not Integer.TryParse(inITERASI.Text, n) Then
            MessageBox.Show("salah satu atau beberapa data yg anda masukkan salah, notasi persamaan harus menggunakan notasi komputer ex = x^3-x-11")
            Return

            'jika a = b maka program tidak bisa jalan karena nanti nya ga akan ada akarnya makannya disini kami langsung saring
        ElseIf inA.Text = inB.Text Then
            MessageBox.Show("Nilai awal tidak boleh sama a /= b, silahkan pilih nilai awal yg baru", "Galat")
        End If

        'dibawah adalah fungsi penentu yg sebenarnya, karena kami menggunakan checkbox maka salah satu harus di ceklis, dan yg diceklis akan menentukan
        'kemana program akan berjalan dan memproses output.
        If xtol.Checked = False And iterasi.Checked = True Then
            akar_.Text = akar_iterasi(a, b, koma, n)
            'dan jika toleransi yg di ceklis maka akan menggunakan fungsi akar_tol
        ElseIf xtol.Checked = True And iterasi.Checked = False Then
            akar_.Text = akar_tol(a, b, koma, n)
        End If

    End Sub

    'ini adalah fungsi akar_tol, yg akan mencari akar dengan menggunakan metode dan algoritma biseksi sampai batas toleransi yg ditentukan user.
    Private Function akar_tol(a As Double, b As Double, e As Double, n As Integer) As String
        dataGridView1.Rows.Clear()
        Dim c As Double = 0.0
        Dim i As Integer = 1

        'jika f(a) dikali f(b) > 0 maka akar nya tidak ada, sesuai dengan logika biseksi
        If f(a) * f(b) > 0 Then
            Return "Tidak ditemukan akar, coba cek notasi persamaan yg kamu masukkan"
        End If

        'memulai pengulangan menggunakan do, sehingga iterasi program pasti dijalankan setidaknya satu kali
        Do
            'untuk menentukan c adalah dengan menambahkan a dengan b kemudian dibagi dua, sesuai dengan logika biseksi
            c = (a + b) / 2
            If f(c) = 0 Then
                'jika f(c) = 0 maka akar langsung ketemu, tapi peluangnya kecil sekali, ini juga sesuai dengan logika biseksi
                Exit Do
            End If

            'kodingan dibawah ini berguna untuk menuliskan 1 row untuk di dgv jika looping nya lebih dari 1 maka nantinya bisa jadi tabel
            'nanti di dgv akan di print angkanya saja, misal 1,2,2.3123,4,4.23141,3,3.2314
            Dim dob As Object() = New Object() {i, bulat(a), bulat(f(a)), bulat(b), bulat(f(b)), bulat(c), bulat(f(c))}
            dataGridView1.Rows.Add(dob)

            'ini adalah kondisi metode biseksi dimana jika f(c) dikali dengan f(a) jika kurang dari 0 maka b = c dan jika lebih besar maka a = c
            If f(c) * f(a) < 0 Then
                b = c
            Else
                a = c
            End If
            'i = i + 1 adalah logika untuk menambah kounter i yg akan membuat no bertambah
            i += 1

            'dibawah adalah kondisi agar program berhenti melakukan iterasi/pengulangan
        Loop While Math.Abs(a - b) >= e
        'jika nilai absolute a-b itu lebih besar sama dengan toleransi yg user input, maka program akan berhenti melakukan pengulangan
        'dan fungsi ini akan mereturn sebuah nilai akar, dari harga c terakhir dari pengulangan
        Return String.Concat(bulat(c))
    End Function

    'dibawah adalah fungsi akar_iterasi, jadi ketika user mencentang metode = max iterasi maka, yg akan dijalankan adalah fungsi ini.
    'semua yg ada di fungsi akar_iterasi sama dengan di atas bedanya, di bawah yaitu dimana program akan berhenti melakukan looping 
    Private Function akar_iterasi(a As Double, b As Double, e As Double, n As Integer) As String
        dataGridView1.Rows.Clear()
        Dim c As Double = 0.0
        Dim i As Integer = 1
        If f(a) * f(b) > 0 Then
            Return "Tidak ditemukan akar"
        End If
        Do
            c = (a + b) / 2
            If f(c) = 0 Then
                Exit Do
            End If
            Dim dob As Object() = New Object() {i, bulat(a), bulat(f(a)), bulat(b), bulat(f(b)), bulat(c), bulat(f(c))}
            dataGridView1.Rows.Add(dob)
            If f(c) * f(a) < 0 Then
                b = c
            Else
                a = c
            End If
            i += 1
            'disini program akan berhenti sesuai dengan inputan user ketika memasukkan berapa maks iterasi n = maks iterasi
        Loop While i <= n
        Return String.Concat(bulat(c))
    End Function

    'ini adalah fungsi untuk pembulatan menjadi 6 angka dibelakang koma, digunakan di dob di atas dengan cara memanggil nya bulat(parameter)
    Private Function bulat(hasil As Double) As Double
        Return Math.Round(hasil, 6)
    End Function

    'yang ini adalah fungsi untuk meng parse kan fungsi persamaan, agar string yg didapat dari user input bisa dikembangkan menjadi perhitungan-
    '-yang dapat dibaca komputer, dan di proses melalui fungsi, yg nantinya bisa dipanggil dengan f(parameter input)
    'misal f(2) dan persamaan x^2 +2 maka fungsi ini akan mereturn nilai f(2) = 2^2+2 = 6
    Private Function f(x As Double) As Double
        'try dan catch untuk debug program jadi jikala ada error, nanti akan ditampilkan exception nya dengan variabel e dengan messagebox galat
        Try
            'persiapan untuk menggunakan script engine, yg nantinya bisa dipanggil menggunakan sc
            Dim sc As New MSScriptControl.ScriptControl()
            sc.Language = "VBScript"
            'mendefinisikan func sebagai string, agar nanti dapat dikenali oleh script engine
            Dim _func As String
            'mengganti x dalam persamaan dengan parameter input, jadi misal kita punya fungsi x^2-2 dan parameter input nya 2
            'maka program akan mengartikan nya 2^2-2
            _func = inPersamaan.Text.Replace("x", x.ToString())
            'sc adalah script engine yg udah di siapkan di atas, tugasnya mengevaluasi nilai string tadi menjadi angka lagi
            'jadi yg 2^2-2 tadi itu sudah bisa diproses secara aritmatika dan menghasilkan sebuah nilai yaitu 2
            Return sc.Eval(_func)
        Catch e As Exception
            MessageBox.Show(e.ToString, "Galat")
        End Try
        Return 0.0
    End Function

    'sub ini untuk mengclear kan semua text yg ada saat user klik tombol clear
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles clear.Click
        inA.Text = ""
        inB.Text = ""
        dataGridView1.Rows.Clear()
        inPersamaan.Text = ""
        inE.Text = ""
        akar_.Text = ""
        inITERASI.Text = ""
        xtol.Checked = False
        iterasi.Checked = False
    End Sub

    'saat form load text dari akar dari label akar akan kosong
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        akar_.Text = ""
    End Sub

    'menu exit untuk exit program dari file
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    'fungsi untuk mengexport dgv ke csv ketika di klik menu save, saya hanya nyomot script ini :D credit script : stackoverflow.
    Private Sub ExportToCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToCSVToolStripMenuItem.Click
        Dim headers = (From header As DataGridViewColumn In dataGridView1.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In dataGridView1.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter("csv.txt")
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
        End Using
        Process.Start("csv.txt")
    End Sub

    'ketika menu tentang di klik maka akan ditampilkan form about dan akan menutup form biseksi yg digunakan
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.Show()
        Me.Hide()
    End Sub

    'dua sub dibawah ini untuk checkbox, jika salah satu di klik maka yg satu nya lagi akan unceklis
    Private Sub xtol_CheckedChanged(sender As Object, e As EventArgs) Handles xtol.CheckedChanged
        If xtol.Checked = True Then
            iterasi.Checked = False
        End If
        penentu()
    End Sub
    Private Sub iterasi_CheckedChanged(sender As Object, e As EventArgs) Handles iterasi.CheckedChanged
        If iterasi.Checked = True Then
            xtol.Checked = False
        End If
        penentu()
    End Sub

    'sekian dan terima kasih best regard -c3budiman
End Class