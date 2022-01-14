using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOrnek3
{
    class Program
    {
         enum Kadrolar:byte
        {
            Bashekim,
            Mali_Mudur,
            Doktor,
            Hemsire
        }
        static void PersonelBul(Kadrolar e)
        {
            switch (e)
            {
                case Kadrolar.Bashekim:
                    Console.WriteLine("Başkhekimsiniz-->Maaşınız: 50000 TL");
                    break;

                case Kadrolar.Mali_Mudur:
                    Console.WriteLine("Mali İşler Müdürüsünüz-->Maaşınız: 45000 TL");
                    break;

                case Kadrolar.Doktor:
                    Console.WriteLine("Doktorsunuz-->Maaşınız: 30000 TL");
                    break;

                case Kadrolar.Hemsire:
                    Console.WriteLine("Hemşiresiniz-->Maaşınız: 10000 TL");
                    break;

            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kadro Türünü Seçiniz:");
            Console.WriteLine("Başhekim = 1, Mali İşler Müdürü = 2, Doktor = 3, Hemşire = 4");
            Console.WriteLine("Seçiminiz:");
            Kadrolar personel = (Kadrolar)Convert.ToByte(Console.ReadLine());
            PersonelBul(personel - 1);
            Console.ReadKey();
        }
    }
}
