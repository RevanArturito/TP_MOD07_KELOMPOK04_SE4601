using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tpmod07_kelompok_04
{

    public class DataMahasiswa_1302223120
    {
        public class Mahasiswa_1302223120() 
        {
            public Name nama { set; get; }
            public int nim { set; get; }
            public string fakultas { set; get; }
        }

        //class nama sesuai yg ada di file json, yg mana terdapat nama depan & belakang
        public class Name
        {
            public string depan { set; get; }
            public string belakang { set; get; }
        }
        public void ReadJSON()
        {
            // menentukan path file tp7_1_1302223057.json
            string filePath = "D:\\codingan\\TP_MOD_07_1302223120_Faishal Harits Al Fajri_Kelompok_4\\TP_MOD07_KELOMPOK04_SE4601\\tpmod07_kelompok_04\\tp7_1_1302223120.json";
            string jsonString = File.ReadAllText(filePath);

            //menampilkan seluruh data mahasiswa yang berisikan nama depan & belakang, nim, & fakultas
            Mahasiswa_1302223120 mahasiswa = JsonSerializer.Deserialize<Mahasiswa_1302223120>(jsonString);
            Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
            Console.WriteLine($"NIM : {mahasiswa.nim}");
            Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
        }
    }
}