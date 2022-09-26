using System;

namespace donguler_while_foreach
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("**** While Loop ****");

            //While
            // 1 den başlayarak console'dan girilen sayıya akdar sayı dahil ortralama hesaplayıp konsola yazdıran program
            Console.WriteLine("Lütfen bi sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }

            Console.WriteLine(toplam / sayi);


            //'a' dan 'z'ye kadar tüm harfleri konsola yazdıralım

            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character ++;
            }


            Console.WriteLine("**** Foreach ****");
            
            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}