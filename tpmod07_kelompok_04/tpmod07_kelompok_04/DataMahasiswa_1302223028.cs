using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmod07_kelompok_04
{
    /* internal class DataMahasiswa_1302223028
     {
         public class Mahasiswa_1302223028()
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
             string filePath = "C:\\Users\\Alghifari\\tubeskpl2\\TP_MOD07_KELOMPOK04_SE4601\\tpmod07_kelompok_04\\tpmod07_kelompok_04\\tp7_1_1302223028.json";
             string jsonString = File.ReadAllText(filePath);

             Mahasiswa_1302223028 mahasiswa = JsonSerializer.Deserialize<Mahasiswa_1302223028>(jsonString);
             Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
             Console.WriteLine($"NIM : {mahasiswa.nim}");
             Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
         }
     }
 */

    internal class KuliahMahasiswa_1302223028
    {
        //deklarasi class kuliah1302223057
        public class Kuliah_1302223028
        {

        // mengambil data dari file json yaitu data array course dari class class courses
        [JsonPropertyName("courses")]
        public courses[] course_1302223028 { get; set; }
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
            // menentukan path file tp7_2_1302223028.json
            string filePath = "C:\\Users\\Alghifari\\tubeskpl2\\TP_MOD07_KELOMPOK04_SE4601\\tpmod07_kelompok_04\\tpmod07_kelompok_04\\tp7_2_1302223028.json";
            string jsonString = File.ReadAllText(filePath);

            Kuliah_1302223028 Kuliah = JsonSerializer.Deserialize<Kuliah_1302223028>(jsonString);
            Console.WriteLine("Daftar mata kuliah yang diambil");

            // menampilkan seluruh data dari course, yaitu data code kuliah dan nama mata kuliah
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine((i + 1) + Kuliah.course_1302223028[i].code + " - " + Kuliah.course_1302223028[i].name);
            }
        }    
    }
}
