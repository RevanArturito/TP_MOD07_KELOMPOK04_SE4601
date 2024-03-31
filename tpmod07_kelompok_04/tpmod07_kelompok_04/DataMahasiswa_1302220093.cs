using System;
using System.Text.Json;
using System.Xml.Linq;
public class DataMahasiswa_1302220093
{
    public Name nama { set; get; }
    public int nim { set; get; }
    public string fakultas { set; get; }

    public class Name
    {
        public string depan { set; get; }
        public string belakang { set; get; }
    }

    public void ReadJSON()
    {
        string filePath = "C:\\Programing\\C#\\mod07\\TP_MOD07_KELOMPOK04_SE4601\\tpmod07_kelompok_04\\tpmod07_kelompok_04";
        string jsonString = File.ReadAllText(filePath);

        DataMahasiswa_1302220093 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302220093>(jsonString);
        Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
        Console.WriteLine($"NIM : {mahasiswa.nim}");
        Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
    }
}
