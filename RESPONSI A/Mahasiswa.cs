using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace LathianList
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "4870";
            mhs1.NamaMahasiswa = "Kevin";
            mhs1.Alamat = "Jalan Merdeka No. 123";

            // membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "4870";
            mhs2.NamaMahasiswa = "Kokomi";
            mhs2.Alamat = "Jalan Jendral Sudirman No. 456";

            // membuat objek mhs3
            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.Nim = "4870";
            mhs3.NamaMahasiswa = "Raiden";
            mhs3.Alamat = "Jalan Veteran No. 789";

            // membuat objek list
            List<Mahasiswa> list = new List<Mahasiswa>();

            // menambahkan elemen List
            list.Add(mhs1);
            list.Add(mhs2);
            list.Add(mhs3);

            // Mengakses elemen list dan mencetak NIM, Nama Mahasiswa, dan Alamat
            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("NIM: {0}, Nama: {1}, Alamat: {2}", mhs.Nim, mhs.NamaMahasiswa, mhs.Alamat);
            }

            Console.ReadKey();
        }
    }
}

