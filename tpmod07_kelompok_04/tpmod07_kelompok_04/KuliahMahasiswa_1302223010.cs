using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmod07_kelompok_04
{
    internal class KuliahMahasiswa_1302223010
    {
        public class Kuliah_1302223010
        {
            [JsonPropertyName("courses")]
            public course[] course_1302223010 { get; set; }
        }

        public class course
        {
            [JsonPropertyName("code")]
            public string code { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "D:\\VS\\tpmod7\\TP_MOD07_KELOMPOK04_SE4601\\tpmod07_kelompok_04\\tpmod07_kelompok_04\\tp7_2_1302223010.json";
            string jsonString = File.ReadAllText(filePath);

            Kuliah_1302223010 Kuliah = JsonSerializer.Deserialize<Kuliah_1302223010>(jsonString);
            Console.WriteLine("Daftar mata kuliah yang diambil");

            for (int i = 0; i < Kuliah.course_1302223010.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + Kuliah.course_1302223010[i].code + " - " + Kuliah.course_1302223010[i].name);
            }
        }
    }
}
