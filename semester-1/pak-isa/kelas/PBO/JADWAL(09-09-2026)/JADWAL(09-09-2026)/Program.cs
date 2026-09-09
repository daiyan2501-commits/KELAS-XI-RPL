using System;
namespace Jadwal
{ 
    class Home
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("===== JADWAL HARI SENIN =====");
                Senin senin = new Senin();
                Console.WriteLine("Sesi 1:");
                senin.sesi1();
                Console.WriteLine("Sesi 2:");
                senin.sesi2();
                Console.WriteLine("Sesi 3:");
                senin.sesi3();

                Console.WriteLine();

                Console.WriteLine("===== JADWAL HARI SELASA =====");
                Selasa selasa = new Selasa();
                Console.WriteLine("Sesi 1:");
                selasa.sesi1();
                Console.WriteLine("Sesi 2:");
                selasa.sesi2();
                Console.WriteLine("Sesi 3:");
                selasa.sesi3();

                Console.WriteLine();

                Console.WriteLine("===== JADWAL HARI RABU =====");
                Rabu rabu = new Rabu();
                Console.WriteLine("Sesi 1:");
                rabu.sesi1();
                Console.WriteLine("Sesi 2:");
                rabu.sesi2();
                Console.WriteLine("Sesi 3:");
                rabu.sesi3();

                Console.WriteLine();

                Console.WriteLine("===== JADWAL HARI KAMIS =====");
                Kamis kamis = new Kamis();
                Console.WriteLine("Sesi 1:");
                kamis.sesi1();
                Console.WriteLine("Sesi 2:");
                kamis.sesi2();
                Console.WriteLine("Sesi 3:");
                kamis.sesi3();

                Console.WriteLine();

                Console.WriteLine("===== JADWAL HARI JUMAT =====");
                Jumat jumat = new Jumat();
                Console.WriteLine("Sesi 1:");
                jumat.sesi1();
                Console.WriteLine("Sesi 2:");
                jumat.sesi2();

                Console.WriteLine();
                Console.WriteLine("Tekan ENTER untuk keluar...");
                Console.ReadLine();
            }
        }

    }
    class Senin
    {
        public void sesi1()
        {
            Console.WriteLine("Upacara");
            Console.WriteLine("Bahasa Jepang");
            Console.WriteLine("Bahasa Inggris");
        }
        public void sesi2() 
        {
            Console.WriteLine("Matematika");
        }
        public void sesi3()
        {
            Console.WriteLine("PPLG");
        }
    }
    class Selasa
    {
        public void sesi1()
        {
            Console.WriteLine("PKWU");
            Console.WriteLine("PJOK");
        }
        public void sesi2()
        {
            Console.WriteLine("Bahasa Indonesia");
        }
        public void sesi3()
        {
            Console.WriteLine("PPLG");
        }
    }
    class Rabu
    {
        public void sesi1()
        {
            Console.WriteLine("PPLG");
        }
        public void sesi2()
        {
            Console.WriteLine("PPLG");
        }
        public void sesi3()
        {
            Console.WriteLine("PPLG");
            Console.WriteLine("BK");
        }
    }
    class Kamis
    {
        public void sesi1()
        {
            Console.WriteLine("Bahasa Jerman");
            Console.WriteLine("Bahasa Jawa");
        }
        public void sesi2()
        {
            Console.WriteLine("PKWU");
        }
        public void sesi3()
        {
            Console.WriteLine("PAI");
        }
    }
    class Jumat
    {
        public void sesi1()
        {
            Console.WriteLine("Bahasa Inggris");
            Console.WriteLine("Sejarah");
        }
        public void sesi2()
        {
            Console.WriteLine("Pendidikan Pancasila");
        }
    }





}
