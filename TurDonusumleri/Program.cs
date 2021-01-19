using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bilinçsiz Tür Dönüşümleri

            ////bit değeri olarak küçük türlerin atama yolu ile büyük türlere dönüşmesi olayıdır

            //byte s1 = 100;
            //byte s2 = 200;
            ////byte toplam = s1 + s2;
            //int toplam = s1 + s2;
            //Console.WriteLine(toplam);

            #endregion

            #region Bilinçli Tür Dönüşümü

            ////bit değeri olarak Büyük değerlerin küçük türlere atanmaya zorlanma işlemidir
            ////Veri kaybı kaçınılmazdır
            //int sayi2 = 654;
            //byte s3 = (byte)sayi2;
            //Console.WriteLine(s3);

            #endregion

            #region Uyumsuz Tür Dönüşümü

            //string s1 = "45";
            //string s2 = "15";
            //int sayi1 = Convert.ToInt32(s1);
            //int sayi2 = Convert.ToInt32(s2);
            //int toplam = sayi1 + sayi2;
            //Console.WriteLine(toplam);


            #endregion

            #region Uygulama

            Console.WriteLine("Lütfen ilk sayıyı giriniz");
            string strSayi1 = Console.ReadLine();
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            string strSayi2 = Console.ReadLine();

            int sayi1 = Convert.ToInt32(strSayi1);
            int sayi2 = Convert.ToInt32(strSayi2);
            int toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam = " + toplam);
            Console.ReadLine();

            #endregion
        }
    }
}
