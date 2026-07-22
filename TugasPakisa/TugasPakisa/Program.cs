using System;

namespace tugas1
{
    class kalkulator
    {
        public static int Tambah(int x, int y)
        {
            return x + y;
        }

        public static int Kurang(int x, int y)
        {
            return x - y;
        }

        public static int Kali(int x, int y)
        {
            return x * y;
        }

        public static double Bagi(double x, double y)
        {
            return x / y;
        }
    }

    class bangundatar
    {
        public static double LuasPersegi(double sisi)
        {
            return sisi * sisi;
        }

        public static double LuasSegitiga(double alas, double tinggi)
        {
            return 0.5 * alas * tinggi;
        }

        public static double LuasLingkaran(double jariJari)
        {
            return Math.PI * jariJari * jariJari;
        }
    }

    class zodiak
    {
        // Mengubah Main menjadi fungsi biasa agar bisa dipanggil dari luar
        public static void CekZodiak()
        {
            Console.WriteLine("=== ZODIAK ===");
            Console.Write("Masukkan tanggal lahir (1-31): ");
            int tanggal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan bulan lahir (1-12): ");
            int bulan = Convert.ToInt32(Console.ReadLine());
            string namaZodiak = "";

            if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19))
                namaZodiak = "Aries";
            else if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20))
                namaZodiak = "Taurus";
            else if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20))
                namaZodiak = "Gemini";
            else if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22))
                namaZodiak = "Cancer";
            else if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22))
                namaZodiak = "Leo";
            else if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22))
                namaZodiak = "Virgo";
            else if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22))
                namaZodiak = "Libra";
            else if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21))
                namaZodiak = "Scorpio";
            else if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21))
                namaZodiak = "Sagittarius";
            else if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19))
                namaZodiak = "Capricorn";
            else if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18))
                namaZodiak = "Aquarius";
            else if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20))
                namaZodiak = "Pisces";

            Console.WriteLine($"Zodiak Anda adalah: {namaZodiak}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // --- EKSEKUSI CLASS KALKULATOR ---
            Console.WriteLine("=== HASIL KALKULATOR ===");
            int a = 5;
            int b = 2;
            int c;

            double x = 5.0;
            double y = 2.0;
            double l;

            Console.WriteLine($"Tambah : {c = kalkulator.Tambah(a, b)}");
            Console.WriteLine($"Kurang : {c = kalkulator.Kurang(a, b)}");
            Console.WriteLine($"Kali   : {c = kalkulator.Kali(a, b)}");
            Console.WriteLine($"Bagi   : {l = kalkulator.Bagi(x, y)}");

            Console.WriteLine(); // Jeda baris kosong

            // --- EKSEKUSI CLASS BANGUN DATAR ---
            Console.WriteLine("=== HASIL BANGUN DATAR ===");
            double sisi = 4.0;
            double alas = 3.0;
            double tinggi = 5.0;
            double jariJari = 2.0;

            Console.WriteLine($"Luas Persegi   : {bangundatar.LuasPersegi(sisi)}");
            Console.WriteLine($"Luas Segitiga  : {bangundatar.LuasSegitiga(alas, tinggi)}");
            Console.WriteLine($"Luas Lingkaran : {bangundatar.LuasLingkaran(jariJari):F2}");

            Console.WriteLine(); // Jeda baris kosong

            // --- EKSEKUSI CLASS ZODIAK ---
            zodiak.CekZodiak();

            Console.ReadKey();
        }
    }
}
