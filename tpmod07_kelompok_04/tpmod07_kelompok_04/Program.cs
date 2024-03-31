using tpmod07_kelompok_04;

public class Program
{
    public static void Main(string[] args)
    {
        // memanggil kembali class datamahasiswa untuk menggunakan method readJSON
        DataMahasiswa_1302223120 mahasiswa = new DataMahasiswa_1302223120();
        mahasiswa.ReadJSON();
        // memanggil kembali class kuliahmahasiswa untuk menggunakan method readJSON
        KuliahMahasiswa_1302223120 kuliah = new KuliahMahasiswa_1302223120();
        kuliah.ReadJSON();
    }
}