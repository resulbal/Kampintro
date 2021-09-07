using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmışMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if(dolarDun>dolarBugun) 
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {

                Console.WriteLine("Artış butonu");
            }

            Console.WriteLine("Kategori");
            
        }
    }
}
