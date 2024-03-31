using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static tpmod07_kelompok_4.DataMahasiswa_1302220093;

// deklarasi class bernama KuliahMahasiswa_1302220093
public class KuliahMahasiswa_1302220093
{
    // deklarasi class bernama Kuliah_1302220093
    public class Kuliah_1302220093()
	{
        // mengambil data dari file json yaitu data array course dari class courses
        [JsonPropertyName("courses")]
        public courses[] course1302220093 { get; set; }
    }

    // deklarasi class courses
    public class courses
    {
        // mengambil data code dari courses
        [JsonPropertyName("code")]
        public string code { get; set; }

        // mengambil data name dari courses 
        [JsonPropertyName("name")]
        public string name { get; set; }
    }

    // method ReadJSON
    public void ReadJSON()
    {
        // menentukan path file tp7_2_1302223057.json
        string filePath = "C:\\Programing\\C#\\mod07\\TP_MOD07_KELOMPOK04_SE4601\\tpmod07_kelompok_04\\tpmod07_kelompok_04\\tp7_2_1302220093.json";
        string jsonString = File.ReadAllText(filePath);

        Kuliah_1302220093 Kuliah = JsonSerializer.Deserialize<Kuliah_1302220093>(jsonString);
        Console.WriteLine("Daftar mata kuliah yang diambil");

        // menampilkan seluruh data dari course, yaitu data code kuliah dan nama mata kuliah
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(i + 1 + Kuliah.course1302220093[i].code + " - " + Kuliah.course1302220093[i].name);
        }
    }
}
