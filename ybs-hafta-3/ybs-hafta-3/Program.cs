
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ybs_hafta_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dögüler
            // While döngüsü: Bir şarta göre çalışır. Sayaç mantığı devredebilir(diğer döngülerde olduğu gibi) diğer döngülerden farklı olarak sayaç,
            // döngünün dışında tanımlanır. ve döngünün içerisinde şart sağlanır (artış-azalış)

            // örnek:
            int sayac = 0;

            while (sayac < 10) 
            {
                Console.WriteLine($"Sayacın şimdiki değeri={sayac + 1}");
                //sayac++;     burası da sayacı 1 arttırır.
                //sayac = +1;      burası da sayacı 1 arttırır.
                sayac = sayac + 1;
            }
            Console.ReadLine();

            //1-100 arasıda 3'e tam bölünen sayıları yazın (while)
            //1.yol (modüler artış ile)

            int sayac_4 = 3;
            while (sayac_4 <= 100)
            {
                Console.WriteLine($"Sayı 3'e tamm bölünür : {sayac_4}");
                sayac_4 += 3;
            }

            //2.yol (if kullanımı)

            int sayi_3 = 0;

            while (sayi_3 < 101)
            {
                if (sayi_3 < 101)
                {
                    Console.WriteLine($"Sayı= {sayi_3}");
                    sayi_3 = sayi_3 + 1;
                }
            }

            //while(true) ifadesi: koşulu her zaman doğru olduğu için sonsuz bir döngü oluşturur. Bu, genellikle belirli bir şart
            //gerçekleşene kadar programını sürekli çalışmasını sağlamak için kullanılır.

            //while (true)
            //{
            //    Console.WriteLine("kübra");
            //}

            //1 ile 500 arasında 3'e ve 4'e 5'e tam bölünen ama 8'e tam bölünmeyen sayıları yazınız. bu sayılardan kaç tane olduğunu da en son da yazınız

            //if kullanımı

            int sayac_5 = 1;
            int sayi = 1;
            while (sayi < 501)
            {
                if ((sayi % 3 == 0) && (sayi % 4 == 0) && (sayi % 5 == 0) && (sayi % 8 != 0)) 
                {
                    Console.WriteLine($"sayı={sayi}");
                    sayac_5 = sayac_5 + 1;

                }
            }
            Console.WriteLine($"{sayac_5} adet sayı bulundu. ");

            //modüler artış ile 
            //önce sayıların ekokunu buluyoruz.

            int sayi_2 = 3 * 4 * 5;
            int sayac_2 = 0;

            while (sayi_2 < 501)
            {
                sayi_2 = sayi_2 + 120;
                //sonra da artış miktarını bulup bu şekilde artmasını sağlıyoruz
                sayac_2++;
            }
            Console.WriteLine($"{sayac_2} adet sayı bulundu. ");


            //döngü2: For döngüsü

            //While'dan farklı olarak genellikle tüm işlemler değişken tanımlama ,şart belirleme ve artış tek satırda for ifadesinin hemen yanındayken yapılır.
            //1'den 10'a kadar sayıları yazdıran for döngüsü

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            //1'den 10'a kadar olan çift sayıları yazdıran ve bunların tek mi çift mi olduğunu döndüren for döngüsü

            int sayac_1 = 0;
            for (int i = 2; i < 11; i += 2)
            {
                Console.WriteLine($" sayı:{i}");
                sayac_1++;
            }
            ////tek satırda if kullanımı
            ////string sonuc = (sayac_1 % 2 == 0) ? $"sayac = {sayac_1} ve çift bir sayıdır" : $"sayac = {sayac_1} ve tek bir sayıdır";
            //Console.WriteLine(sonuc);
            if (sayac_1 % 2 == 0)
            {
                Console.WriteLine($"sayac = {sayac_1} ve çift bir sayıdır");
            }
            else
            {
                Console.WriteLine($"sayac = {sayac_1} ve tek bir sayıdır");
            }

            //veri yapıları - Array
            //Array'ler indexleme mantığına uygun ,bellekte sıralı şekilde depolanan veri yapılarıdır.
            //Bir çok kısıtı vardır (tanımlanırken ya da değer atanırken ) tutacağı veri yapısının önceden belirlenmesi,ekleme,çıkarma işlemleri yapılamaması vb. 
            //ancak ,bellekteki erişim hızı nedeniyle,giriş değerleri ce giriş sayısı önceden belli olan işlemlerde hızı nedeniyle tercih edilen bir yapıdır.
            //aray tanımlama : Not: veri tipi[] değişken_adı; formülüyle tanımlanır

            string[] haftanın_gunleri = new string[7];

            string[] haftanın_gunleri_2;
            haftanın_gunleri_2 = new string[7];
            haftanın_gunleri_2[0] = "Pazartesi";
            haftanın_gunleri_2[1] = "Salı";
            haftanın_gunleri_2[2] = "Çarşamba";
            haftanın_gunleri_2[3] = "Perşembe";
            haftanın_gunleri_2[4] = "Cuma";
            haftanın_gunleri_2[5] = "Cumartesi";
            haftanın_gunleri_2[6] = "Pazar";

            string[] haftanın_gunleri_3 = { "pazartesi", "salı", "3", "4", "5","6","7"};

            //for döngüsünü Array'ler ile kullanımı
            //Not: diğer veri yapıları için de geçerlidir.(indexleme olunca)

            for (int i = 0; i < haftanın_gunleri_2.Length; i++)
            {
                Console.WriteLine($"dizinin {i + 1}. elemanı = {haftanın_gunleri_2[i]}");
            }

            //bütün değerleri okusun anca eğer  hafta sonları ise yazdırmasın
            //1.yol (index bazlı)
            for (int i = 0; i < haftanın_gunleri_2.Length; i++)
            {
                if (i == 5 || i == 6)
                {
                    continue;                
                }
                else 
                {
                    Console.WriteLine($"dizinin {i + 1}. elemanı = {haftanın_gunleri_2[i]}");
                }
               
            }
            //2.yol (değer bazlı)
            for (int i = 0; i < haftanın_gunleri_2.Length; i++)
            {
                if (haftanın_gunleri_2[i]=="Cumartesi" || haftanın_gunleri_2[i] == "Cumartesi")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"dizinin {i + 1}. elemanı = {haftanın_gunleri_2[i]}");
                }

            }
            Console.WriteLine("---------------------------------------");
            //Reverse methodu tersine çevirir
            Array.Reverse(haftanın_gunleri_2);
            for(int i=0;i<haftanın_gunleri_2.Length;i++)
            {
                Console.WriteLine(haftanın_gunleri_2[i]);
            }
            //sourth:Karışıksa kendi sıralar.
            Console.WriteLine(Array.IndexOf(haftanın_gunleri_2,"Pazartesi"));
            Console.WriteLine(haftanın_gunleri_2.Contains("pazar")); //false değer verir.büyük-küçük harf uyumluluğundan kaynaklı hata verir

            //sadece veri yapıları için geliştirilmiş bir for döngüsü vardır C#'ta (foreach)
            foreach (var item in haftanın_gunleri_2)
            {
                Console.WriteLine(item);
            }








            Console.ReadLine();

        }
    }
}
