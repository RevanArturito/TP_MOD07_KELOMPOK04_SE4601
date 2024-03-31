using System;
using System.Text.Json;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

// menamai isi program tersebut dengan namespace tpmod07_kelompok_4
namespace tpmod07_kelompok_4
{
    // deklarasi class bernama DataMahasiswa dan NIM
    public class DataMahasiswa_1302220093
    {
        // deklarasi class bernama Mahasiswa dan NIM didalam class DataMahasiswa dan NIM
        public class Mahasiswa_1302220093
        {
            // mengambil data berupa tipe data Name dari class Name
            public Name nama { set; get; }

            // mengambil data berupa NIM
            public int nim { set; get; }

            // mengambil data berupa nama Fakultas
            public string fakultas { set; get; }
        }

        // deklarasi class bernama Name untuk mengambil value nama dari JSON 1
        public class Name
        {
            // mengambil nama bagian depan dari JSON 1
            public string depan { set; get; }

            // mengambil nama bagian belakang dari JSON 1
            public string belakang { set; get; }
        }

        // deklarasi method ReadJSON()
        public void ReadJSON()
        {
            // menentukan filepath tp7_1_1302220093.json
            string filePath = "C:\\Programing\\C#\\mod07\\TP_MOD07_KELOMPOK04_SE4601\\tpmod07_kelompok_04\\tpmod07_kelompok_04\\tp7_1_1302220093.json";
            string jsonString = File.ReadAllText(filePath);

            //Menampilkan data mahasiswa berupa Nama, NIM, dan fakultas
            Mahasiswa_1302220093 mahasiswa = JsonSerializer.Deserialize<Mahasiswa_1302220093>(jsonString);
            Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
            Console.WriteLine($"NIM : {mahasiswa.nim}");
            Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
        }
    }
}