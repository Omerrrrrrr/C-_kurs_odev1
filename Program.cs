// See https://aka.ms/new-console-template for more information




using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class program
    {
         static void Main(string[] args)
        {
            // Degiskenler();

            SelamVer(isim: "Omer") ;
            SelamVer(isim: "Merve");

            List<string> Sehirler = new List<string> { "Ankara", "Istanbul", "izmir" };
            Sehirler.Add("Adana");

            foreach (string s in Sehirler)
            {
                Console.WriteLine(s);
            }

                Vatandas vatandas1 = new Vatandas();

            Person person1 = new Person();
            person1.FirstName = "omer ";

            Person person2 = new Person();
            person2.FirstName = "gulluce";


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



        }


        static void SelamVer(string isim="isimsiz ")
        {
            Console.WriteLine("Merhaba"+ isim);
        }

        


        private static void Degiskenler()
        {
            bool GirisYapildiMi = false;
            
            
            
            string ad = "Omer";
            string soyad = "Gulluce";
            int dogumyili = 1989;
            long tcno = 12345678;

            

            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
    




public class Vatandas
{
    public string Ad { get; set; }

    public string Soyad { get; set; }

    public int Dogumyili { get; set; }     

    public long Tcno { get; set; } 
}
