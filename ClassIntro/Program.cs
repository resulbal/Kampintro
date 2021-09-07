using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Resul";
            int yas= 36;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmeni = "Resul";
            kurs1.İzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmeni = "Engin";
            kurs2.İzlenmeOranı = 55;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Eğitmeni = "Serhat";
            kurs3.İzlenmeOranı = 45;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmeni);
            }


            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string  KursAdi { get; set; }

        public string  Eğitmeni { get; set; }

        public int İzlenmeOranı { get; set; }
    }
}
