using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static tpmod07_kelompok_04.DataMahasiswa1302223057;

//deklarasi class KuliahMahasiswa1302223057
public class KuliahMahasiswa1302223057
{
    //deklarasi class kuliah1302223057
    public class Kuliah1302223057
    {

        // mengambil data dari file json yaitu data array course dari class class courses
        [JsonPropertyName("courses")]
        public courses[] course1302223057 { get; set; }
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
        string filePath = "D:\\REVAN\\MATERI KULIAH\\SEMESTER 4\\PRAKTIKUM KPL\\TP 7\\tpmod07_kelompok_04\\tpmod07_kelompok_04\\tp7_2_1302223057.json";
        string jsonString = File.ReadAllText(filePath);

        Kuliah1302223057 Kuliah = JsonSerializer.Deserialize<Kuliah1302223057>(jsonString);
        Console.WriteLine("Daftar mata kuliah yang diambil");

        // menampilkan seluruh data dari course, yaitu data code kuliah dan nama mata kuliah
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(i + 1 + Kuliah.course1302223057[i].code + " - " + Kuliah.course1302223057[i].name);
        }


    }
}

