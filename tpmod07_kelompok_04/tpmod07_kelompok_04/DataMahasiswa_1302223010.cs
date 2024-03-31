using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmod07_kelompok_04
{
    internal class DataMahasiswa_1302223010
    {
        public class Mahasiswa_1302223010()
        {
            public Name nama { set; get; }
            public int nim { set; get; }
            public string fakultas { set; get; }
        }

        public class Name
        {
            public string depan { set; get; }
            public string belakang { set; get; }
        }

        public void ReadJSON()
        {
            string filePath = "D:\\VS\\tpmod7\\TP_MOD07_KELOMPOK04_SE4601\\tpmod07_kelompok_04\\tpmod07_kelompok_04\\tp7_1_1302223010.json";
            string jsonString = File.ReadAllText(filePath);

            Mahasiswa_1302223010 mahasiswa = JsonSerializer.Deserialize<Mahasiswa_1302223010>(jsonString);
            Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
            Console.WriteLine($"NIM : {mahasiswa.nim}");
            Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
        }
    }
}
