using System;
public class HelloWorld
{
    static public void Main ()
    {
     familyhobi ak = new familyhobi();
     familyhobi ibu = new Ibu();
     familyhobi kakak = new Kakak();
     familyhobi anak = new Anak();
     
     familydata ibuku = new familydata("Irawati",50,085806877389);
    familydata kakakku = new familydata("Wigraha Dimas I",24,085706874219);
    familydata aku = new familydata("Ardila Novita Sari",16,081217477381);
     Console.WriteLine("DATA IBU:\n"+ibuku.nama+"\n"+ibuku.umur+"\n"+ibuku.nohp);
     ibu.Hobi();
   Console.WriteLine("DATA KAKAK:\n"+kakakku.nama+"\n"+kakakku.umur+"\n"+kakakku.nohp);
     kakak.Hobi();
     Console.WriteLine("DATA ANAK:\n"+aku.nama+"\n"+aku.umur+"\n"+aku.nohp);
     anak.Hobi();
    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;
        public familydata(string Nama,int Umur,long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }
    }
    class familyhobi 
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ibu:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Masak");
        }
    }
    class Kakak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("futsal");
        }
    }
    class Anak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("bulutangkis");
        }
    }
}
