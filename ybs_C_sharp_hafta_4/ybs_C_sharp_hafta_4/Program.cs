using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybs_C_sharp_hafta_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generic ve non generic veri yapıları:
            // non generic, Tip güvenli olmayan veri yapılarını temsil eder.
            // non generic veri yapılarıydı (arraylar,stack,queue)

            //tip güvenli değil (non generic) demek, farklı veri tiplerinde verilerin aynı yapı içinde tutulabilmesi demektir.
            //Oldukça maliyetli ve riskli bir durumdur. Çünkü boxing-unboxing (yani her bir veriyi kendi veri tipinde) dönüştürme 
            //durumu söz konusu olduğu için Run time error dediğimiz çalışma zamanı hatası alması olasıdır 

            //non-Generic yapılar namespace dışında yer alan global alabda using systemCollections; ifadesiyle tanımlanır.
            //sonra Main metodu içerisinde ilgili veri yapısı çağırılır

            ArrayList my_al_1 = new ArrayList();

            ArrayList my_al_2 = new ArrayList() {"Burdur","MAKÜ","Bucak","ZTYO",18,true,56.65};
            Console.WriteLine("foreach döngüsü:");
            foreach(var item in my_al_2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("for döngüsü:");
            for (int i = 0; i < my_al_2.Count; i++)
            {
                Console.WriteLine(my_al_2[i]);
            }

            // Arraylist ile en sık kullanılan metotlar 
            // Tekli veri eklemek için add metodu

            my_al_2.Add(100);

            //Çoklu veri eklemek için AddRange metodu 

            my_al_2.AddRange(new object[] { 101, 102, "103" });

            // veri silmek için (değer bazlı)
            my_al_2.Remove(100);  // 100 değerini siler

            //veri silmek için (index bazlı)
            my_al_2.RemoveAt(2); //2. indexteki elemanı siler. 

            //my_al_2.Clear(); //hepsini siler
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("ArrayList'in son hali:");
            foreach (var item in my_al_2)
            {
                Console.WriteLine(item);           
            }

            Console.WriteLine($"Eleman sayısı için my_al_2.Count= {my_al_2.Count}");
            // 100 değerini içeriyor mu? True-False
            Console.WriteLine($"100 değerini içeriyor mu ? = {my_al_2.Contains(100)}");
            //101 değerinin index numarasını getirecek 
            Console.WriteLine(my_al_2.IndexOf(101));
            Console.WriteLine("-----------------------------------------------------");

            //İçerisinde aynı değerden üç tane olan ve farklı değerlerde içeren bir ArrayList tanımlayın

            ArrayList my_al_3 = new ArrayList() { "Deger_1", 25, 47.55, "Kübra", true, 45, "Deger_1", 74, 41.14, "Deger_1" };
            Console.WriteLine("Silinmeden önceki ArrayList");
            foreach (var item in my_al_3)
            {
                Console.WriteLine(item);
            }

            //Daha sonra aynı 3 değer barındıran 2 değeri silin sadece bir tanesi kalsın.
            string silinecek_deger = "Deger_1";
            int sayac = 0;
            for (int i=0;i<my_al_3.Count;i++)
            {
                var item = my_al_3[i];
                if (sayac!=2 && silinecek_deger == item)
                {
                    my_al_3.Remove(item);
                    sayac++;
                }
            }

            // Arraylist'in ilk halini ve silme işleminden sonraki halini tekrar yazdırın.
            Console.WriteLine("Silindikten sonraki ArrayList");
            foreach (var item in my_al_3)
            {
                Console.WriteLine(item);   
            }
            Console.WriteLine("--------------------------");

            Console.WriteLine("Generic veri yapıları: List<Type>");
            //Generic COLLECTİONS, Tip güvenli veri yapılardır.
            //Bunlar arasında en sık kullanılan List<T> veri yapısıdır.
            //Generic ve non generic  coolections' lar arasındaki en önemli fark tip güvenli olmasıdır(generic yapıların )

            // Aşağıda sadece int tipindeki verilerin tutulmasına izin veren bir list tanımlamıştır.

            //namespace dışında global alnda using System.Collectşons.Generic tanımlaması ile bunlara erişim sağlayabiliriz.

            List<int> my_int_list_1 = new List<int>();
            List<int> my_int_list_2 = new List<int>() { 10,20,30,40,50,60,70,80};

            //tekli eleman ekleme
            my_int_list_2.Add(90);

            //Çoklu eleman ekleme 


            //eleman silme(deger bazlı ) 
            my_int_list_2.Remove(70);

            // Eleman silme (index bazlı)
            //my_int_list_2.RemoveAt(9);

            // Tüm elemanları silme (clear metodu ile)
            // my_int_list_2.Clear();

            //veri güncelleme 


            //toplam eleman sayısını bulma 
            Console.WriteLine($" Eleman sayısı={ my_int_list_2.Count()}");

            //Bir elemana ait indexi bulma (sonuncu değer olan 120'nin indexi)
            Console.WriteLine($" 120'nin indexi= {my_int_list_2.IndexOf(120)}");

            //110 elemanı içerip içermediğini sorgulama
            Console.WriteLine($" 110 değeri var mı?= {my_int_list_2.Contains(120)}");
            Console.WriteLine();

            Console.WriteLine("----------------------------------");
            //Öncelikle ,50'den 200'e kadar olan sayıları bir int tipli listeye ekleyin 
            List<int> my_int_1 = new List<int>();

            for (int i = 50; i < 201; i++)
            {
                my_int_1.Add(i);
            }
            // sonra yine int tipli iki liste oluşturun 
            List<int> my_int_tek= new List<int>();
            List<int> my_int_cift = new List<int>();
            //birinci  listede, içi dolu olan listedeki tek sayılar,ikinci listede ise içi dolu olan listedeki çift sayılar olacak 
            foreach (var item in my_int_1)
            {
                if (item % 2 == 0)
                {
                    my_int_cift.Add(item);
                }
                else
                {
                    my_int_tek.Add(item);
                }



            }

            // Daha sonra içini tek-çift sayılalrla doldurduğunuz bu listedeki eleman sayılarını da yazdırın
            Console.WriteLine("Çift sayıların olduğu liste");
            foreach (var item in my_int_cift)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Tek sayıların olduğu liste");

            foreach (var item in my_int_tek)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------");

            Console.WriteLine($"son çift eleman= {my_int_cift[my_int_cift.Count-1]}");
            my_int_cift[my_int_cift.Count - 1] = 202;
            Console.WriteLine($"son çift eleman= {my_int_cift[my_int_cift.Count - 1]}");

            Console.ReadLine();


        }
    }
}
