// See https://aka.ms/new-console-template for more information
using tpmod07_kelompok_04;
public class Program
{
    public static void Main(string[] args)
    {
        // memanggil kembali class datamahasiswa untuk menggunakan method readJSON
        DataMahasiswa1302223057 mahasiswa = new DataMahasiswa1302223057();
        mahasiswa.ReadJSON();

        // memanggil kembali class kuliahmahasiswa untuk menggunakan method readJSON
        KuliahMahasiswa1302223057 kuliah = new KuliahMahasiswa1302223057();
        kuliah.ReadJSON();

    }
}