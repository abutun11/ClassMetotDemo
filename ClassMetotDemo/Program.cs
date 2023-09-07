namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "Keskin";
            musteri1.MusteriIbanNo = "TR760009901234567800100001";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Ece";
            musteri2.MusteriSoyadi = "Subaşı";
            musteri2.MusteriIbanNo = "TR760009909999657800300002";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Murat";
            musteri3.MusteriSoyadi = "Yılmaz";
            musteri3.MusteriIbanNo = "TR760007708888877800100009";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.MusteriAdi = "Fulya";
            musteri4.MusteriSoyadi = "Özdoğan";
            musteri4.MusteriIbanNo = "TR760009901111111800200002";


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4};
            foreach (var musteri in musteriler) 
            {
                Console.WriteLine(musteri.Id + "---" + musteri.MusteriAdi + "---" + musteri.MusteriSoyadi + "---" + musteri.MusteriIbanNo );
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriSil(musteri4);
            


        }
    }
}