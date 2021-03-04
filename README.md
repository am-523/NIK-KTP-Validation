#  - - NIK KTP VALIDATOR - - 
## Cara memasang 'NikvalidatorLib.dll' pada project
1. Pada project anda, Add references "NikvalidatorLib.dll"
2. Letakan folder "assets" pada \bin\Debug
3. Pastikan target framework versi 4.5 atau lebih tinggi.

## Cara menggunakan library pada project :
Setelah menambahkan NikvalidatorLib.dll pada refrences, <br>
tambahkan code berikut : <br>
`Imports NikvalidatorLib.NIKvalidator.Properti` <br>
`Imports NikvalidatorLib`
<br>

`Dim DATA As New NIKproperti` <br>

Untuk mem-validasi NIK, cukup dengan menambahkan perintah : <br>
`NIKvalidator.Aksi.ValidasiNIK(DATA)`
<p> 


### Screenshot :
![Screenshot_1014](https://user-images.githubusercontent.com/61135648/109921154-5e403f80-7cf6-11eb-9877-8efbc75f2111.png)
![Screenshot_1013](https://user-images.githubusercontent.com/61135648/109921185-69936b00-7cf6-11eb-8bc6-44faef02a3b8.png)








 <br>
[>>  Library 'NikvalidatorLib.dll' ](https://gitlab.com/PoetralesanA/nik-validator-lib/-/tree/master/example%20use)
