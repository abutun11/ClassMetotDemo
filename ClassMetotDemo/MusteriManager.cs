using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " " + "Id'li müşteri başarı ile eklenmiştir.");
        }

        public void MusteriSil(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " " + "Id'li müşteri başarı ile silinmiştir.");
        }
    }
}
