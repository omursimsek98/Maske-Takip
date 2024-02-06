// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System.ComponentModel;
using System.IO.Pipes;

namespace Workaround
{
    class program
    {
        static void Main(string[] args)
        {
            SelamVer(isim: "Ömür");//Altta oluşturduğumuz methodu çağırdık
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Furkan");
            SelamVer();
            int sonuc = toplam(5,7);
            //diziler/arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            ogrenciler = new string[4];
            ogrenciler[3] = "ilker";
            for (int  i= 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            string[] sehirler1 = new[] {"Ankara","İstanbul","İzmir"};
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1=new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 12345;
            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara1","İstanbul1","İzmir1"};
            yeniSehirler1.Add("Adana1");//Listenin sonuna veri eklemesi yaptık
            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            PttManager pttmanager= new PttManager(new PersonManager() );
            pttmanager.GiveMask(person1);
            

            Console.ReadLine();
        }
        //resharper
        static void SelamVer(string isim = "isimsiz")//Eğer method çağırılırken pparametreye değer verilmezse hata almamak adına merhaba isimsiz olarak görünmesi için default bir değer atadık
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int toplam(int sayi1=5, int sayi2 = 10)
        {
            int sonuc=sayi1+sayi2;
            Console.WriteLine("Toplam:" + sonuc.ToString());
            return sonuc;

        }
    }
       
}