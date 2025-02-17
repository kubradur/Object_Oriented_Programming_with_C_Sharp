using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ybs_hafta_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kontrol yapıları ve döngüler(for-while)
            //if kullımında 3 farklı senaryo söz konusu olabilir
            //if:kontrol edilen durum
            //else if:olası başka durum/durumlar
            //else:if ve else if'in de olmadığı durum

            //veri girişi: Console.ReadLine()
            //Console.ReadLine() methodunun geriye döndürdüğü değerin tipi varsayılan olarak string'dir

            //Console.WriteLine("lütfen bir sayo giriniz:");
            //int sayi_1 = Convert.ToInt32(Console.ReadLine());

            //elimizde artık int tipinde bir tam sayı var.
            //Şimdi birkaç senaryo ile if-else kullanımını görelim.
            // C# ve java gibi dillerdde scope (yani kodun çalışacağı ilgili kapsam-blok)mekanizması için süslü parantez kullanılır.

            //süslü parantez içerisinde yazılan kodalar aynı zamanda yerel ifadelerdir
            //

            //if (sayi_1 > 0)
            //{
            //    Console.WriteLine($"Girmiş olduğunuz {sayi_1} sayı pozitif bir tam sayıdır");
            //}
            //else if(sayi_1<0)
            //{
            //    Console.WriteLine($"Girmiş olduğunuz {sayi_1} sayı negatif bir tam sayıdır");
            //}

            ////else son ifade olduğu için yanına şartlı bir ifade yazılmaz.
            //else
            //{
            //    Console.WriteLine($"Lütfen tam sayı giriniz... ");
            //}

            //kullanıcıdan bir gün adı alınız.Verdiği gün ismine göre o günün haftanın kaçıncı günü olduğunu ekrana yazdırınız ve kullanıcı büyük harfle girse bile küçük harfe göre işlem yapıl.sın

            //Console.WriteLine("Lütfen bir gün giriniz.");

            //string kul_gir = Console.ReadLine();
            //string[] gun= {"pazartesi","salı","carsamba","persembe","cuma","cumartesi","pazar"};


            //if (kul_gir.ToLower() == gun[0])
            //{
            //    Console.WriteLine($"Girmiş olduğunuz {gun[0]} haftanın 1. günüdür.");
            //}
            //else if (kul_gir.ToLower() == gun[1])
            //{
            //    Console.WriteLine($"Girmiş olduğunuz {gun[1]} haftanın 2. günüdür.");
            //}
            //else if (kul_gir.ToLower() == gun[2])
            //{
            //    Console.WriteLine($"Girmiş olduğunuz {gun[2]} haftanın 3. günüdür.");
            //}
            //else if (kul_gir.ToLower() == gun[3])
            //{
            //    Console.WriteLine($"Girmiş olduğunuz {gun[3]} haftanın 4. günüdür.");
            //}
            //else if (kul_gir.ToLower() == gun[4])
            //{
            //    Console.WriteLine($"Girmiş olduğunuz {gun[4]} haftanın 5. günüdür.");
            //}
            //else if (kul_gir.ToLower() == gun[5])
            //{
            //    Console.WriteLine($"Girmiş olduğunuz {gun[5]} haftanın 6. günüdür.");
            //}
            //else if (kul_gir.ToLower() == gun[6])
            //{
            //    Console.WriteLine($"Girmiş olduğunuz {gun[6]} haftanın 7. günüdür.");
            //}
            //else
            //{
            //    Console.WriteLine($"Lütfen bir gün girdiğinizden emin olunuz.");
            //}

            //tek satırlık if kullanımı
            //eğer ki iki ihtimali söz konusu olduğu bir durum varsa if yapısı aşağıdaki gibi de kullanılabilir.

            //kulllanıcının girdiği sayı pozitif mi negatif mi olduğunu bu mantıkla işleyelim

            //Console.WriteLine("Lütfen bir sayı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            ////tek satırlık if kullanımı syntax yapısı (sözdizimi) 
            ////veri_tipi değişken_adi= (karşılaştırma_işlemi)?"True yanıtı":"değil yanıtı;    
            //string result = (sayi > 0) ? "pozitif sayı" : "negatif sayı";
            //Console.WriteLine(result);

            //iç içe if kullanımında amaç, birbirine bağlı ve işlem önceliği bulunan olayların kontrolünü sağlamaktır.
            //bir sonraki koda /kontrole geçmek için önceki aşamayı doğru şekilde yani yanıt true dönecek şekilde tamamlamak ZORUNLUDUR!!

            //tıpkı bir kuruma girmeden önce arabanızın aranması,kimliğinizi kontrol edilmesi ve bu işlemlerin gergangi bir sorun olmaması 
            //durumunda kuruma giriş yapabilmeniz gibi

            //özellikşe kurumlarda ,belli yazılımlara sadece yetkili kişilerin erişmesi istenir ya da gerçcek hayatta da kendi bankacılık 
            //e-ddevlet işlemlerinizi sadece sizin görüntülemeniz istenir.

            //girilen bir sayı int tipindeyse ve çift sayı ise o sayının karesini alan kod örneği

            //Console.WriteLine("lütfen bir sayı giriniz");
            //string deger = Console.ReadLine();

            //string'den int'e dönüşüm için özel bir metot vardır
            //out özel bir anahtar kelimedir.
            //aşağıdaki işlemlerde şu yapılır: değer değişkeninin tuttuğu değerin int'e dönüştürülüp dönüştürülemeyceği kontrol edilir eğer dönüşümün yanıtı true ise yani 
            //dönüşümün yanıtı true ise yani dönüşüm gerçekleştiriliyorsa out anahtar kelimesini true yanıtı yüklenir ve number değişkeni de stringden inte dçönüştürülen değer yüklenir 

            //if (int.TryParse(deger, out int number))
            //{
            //    if (number % 2==0)
            //    {
            //        Console.WriteLine($"{number} sayısının karesi = {number*number}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen çift sayı giriniz.");


            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen int tipinde sayı giriniz.");

            //}

            //if kullanımı: aynı anda birden fazka şartın sağlanması and-or işlemleri
            //and: tüm şartların aynı anda sağlanması (tüm sonuçlar true dönmeli)
            //or: en az bir şartın sağlanması (en az bir sonuç true dönmeli)

            //kullanıcı adu vee şifrenin aynı anda doğru girilmesi and işlemine örnektir 
            //kullanıcı adı ve şifre bilgisini kullanıcıdan alınız.
            //daha önceden kendi belrilemiş olduğunuz geçiçi kullanıcı adı ve geçicii şifreyle karişılağtırınız.
            //eğer her ikisi de doğruysa if bloku içerisinde hoşgeldin{kullanıcı adı} çıktısını yazdırınız.
            //bilgilerinden en az birisi yanlışsa else bloku içerisinde kullanıcıya uyarı veriniz 

            //and işleminin simgesi &
            //or işleminin simgesi |

            //string pass_username = "kubra7";
            //string pass_password= "1234";
            //Console.WriteLine("lütfen kullanıcı adınızı giriniz:");
            //string username = Console.ReadLine();
            //Console.WriteLine("lütfen şifrenizi giriniz:");
            //string password= Console.ReadLine();
            //if((username== pass_username) && (password == pass_password))
            //{
            //    Console.WriteLine($"Hoşgeldiniz sayın kullanıcı{username}");
            //}
            //else
            //{
            //    Console.WriteLine("kullanıcı adı veya parola hatalı!!");
            //}

            //iki adet tam sayı girişi isteyin kullanıcıdan bunlardan en az biri çift sayı ise bu iki sayıyı çarpın
            //değilse lütfen en az bir adet çift sayı giriniz mesajı yazdırınız
            Console.WriteLine("lütfenn bir tam sayı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfenn ikinci bir tam sayı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if ((sayi1 % 2 == 0)  || (sayi2 % 2 == 0))
            {
               Console.WriteLine($"{sayi1}*{sayi2}={sayi1*sayi2}");
            }
            else
            {
               Console.WriteLine("lütfen en az bir çit tam sayı giriniz...");
            }





        }
    }
}
