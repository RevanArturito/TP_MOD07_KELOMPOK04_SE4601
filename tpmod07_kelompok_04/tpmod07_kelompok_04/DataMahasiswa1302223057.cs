using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmod07_kelompok_04
{
    // deklarasi class DataMahasiswa1302223057
    public class DataMahasiswa1302223057
    {

        // deklarasi class Mahasiswa1302223057
        public class Mahasiswa1302223057
        {
            //mengambil data berupa nama dari class Name
            public Name nama { get; set; }

            // mengambil data berupa nim
            public int nim { get; set; }

            // mengambil data berupa nama fakultas
            public string fakultas { get; set; }

        }

        // deklarasi class Name
        public class Name
        {
            // mengambil data spesifik nama depan
            public string depan { get; set; }

            //mengambil data spesifik nama belakang
            public string belakang { get; set; }
        }

        // method readJSON
        public void ReadJSON()
        {
            // menentukan path file tp7_1_1302223057.json
            string filePath = "D:\\REVAN\\MATERI KULIAH\\SEMESTER 4\\PRAKTIKUM KPL\\TP 7\\tpmod07_kelompok_04\\tpmod07_kelompok_04\\tp7_1_1302223057.json";
            string jsonString = File.ReadAllText(filePath);

            // Menampilkan data mahasiswa berupa nama, NIM , dan fakultas
            Mahasiswa1302223057 mahasiswa = JsonSerializer.Deserialize<Mahasiswa1302223057>(jsonString);
            Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
            Console.WriteLine($"NIM : {mahasiswa.nim}");
            Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
            Console.WriteLine();
        }
    }
}



