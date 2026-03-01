# 📘 Week 2 — GUI Builder (Windows Forms Calculator)

## 📖 Deskripsi

Pada Week 2 ini, pembelajaran berfokus pada pembuatan aplikasi berbasis GUI menggunakan Windows Forms di C#.

Project yang dibuat adalah aplikasi **Kalkulator Sederhana** dengan fitur:

- Input angka 0–9
- Operator aritmatika (+, -, *, /)
- Tombol "=" untuk menghitung hasil
- Tombol "Clear" untuk mereset input
- Tampilan riwayat operasi menggunakan Label

---

## 🖥 Konsep yang Dipelajari

- Event Handling (Button Click)
- Penggunaan TextBox
- Penggunaan Label
- Konversi tipe data (string ke double)
- Struktur kontrol (switch-case)
- Validasi input

---

## 🧠 Alur Program

1. User memasukkan angka pertama melalui tombol angka.
2. User memilih operator (+, -, *, /).
3. TextBox akan otomatis clear untuk input angka kedua.
4. User memasukkan angka kedua.
5. User menekan tombol "=".
6. Hasil perhitungan ditampilkan pada TextBox.
7. Label menampilkan riwayat operasi (angka1 operator angka2).

---

## 🏗 Struktur Komponen GUI

### 🎛 Komponen yang Digunakan

- 1 TextBox → tempat input & hasil
- 3 Label → menampilkan angka1, operator, angka2
- 16 Button:
  - 10 tombol angka (0–9)
  - 4 tombol operator (+, -, *, /)
  - 1 tombol "="
  - 1 tombol Clear

---

## 🧮 Fitur Perhitungan

Operasi yang didukung:

- Penjumlahan (+)
- Pengurangan (-)
- Perkalian (*)
- Pembagian (/)
- Validasi pembagian dengan nol
- Validasi operator belum dipilih
- Validasi input angka kedua

---

## 🔍 Contoh Flow Penggunaan
Input: 5
Tekan: +
Input: 3
Tekan: =
Hasil: 8
