using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmod07_kelompok_04
{
    internal class KuliahMahasiswa_1302223120
    {
        public class Kuliah1302223120
        {

            // mengambil data dari file json yaitu data array course dari class class courses
            [JsonPropertyName("courses")]
            public courses[] course1302223120 { get; set; }
        }
        public class courses
        {
            // mengambil data code dari courses
            [JsonPropertyName("code")]
            public string code { get; set; }

            // mengambil data name dari courses 
            [JsonPropertyName("name")]
            public string name { get; set; }
        }
        public void ReadJSON()
        {
            // menentukan path file tp7_2_1302223057.json
            string filePath = "D:\\codingan\\TP_MOD_07_1302223120_Faishal Harits Al Fajri_Kelompok_4\\TP_MOD07_KELOMPOK04_SE4601\\tpmod07_kelompok_04\\tp7_2_1302223120.json";
            string jsonString = File.ReadAllText(filePath);

            Kuliah1302223120 Kuliah = JsonSerializer.Deserialize<Kuliah1302223120>(jsonString);
            Console.WriteLine("Daftar mata kuliah yang diambil");

            // menampilkan seluruh data dari course yang berisikan data kode kuliah dan nama mata kuliah
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(i + 1 + Kuliah.course1302223120[i].code + " - " + Kuliah.course1302223120[i].name);
            }


        }
    }
}

