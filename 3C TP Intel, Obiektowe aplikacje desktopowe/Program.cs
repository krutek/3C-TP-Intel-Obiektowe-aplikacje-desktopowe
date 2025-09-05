using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C_TP_Intel__Obiektowe_aplikacje_desktopowe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // <- symbol komentarza

            /* To jest komentarz
             wieloliniowy w C# */

            /// <summary>
            /// Komentarz dokumentacyjny
            /// </summary>

            // Zakomentowany linie kodu nie będą widziane przez kompilator
           
            byte by = 0; // 0 do 255
            short s = 0;
            int b = 0;
            long l = 0l;

            uint ui = 5u; // unsigned int
            ulong ul = 0ul; // unsigned long

            float f = 0.5f;
            double d = 0.7;
            decimal m = 0.123m; // decimal (money)

            char znak = 'A';
            string tekst = "Ala ma kota";
           
            bool prawda = true;// SQL Server -> bit

            var tekstJakoVar = "Jakiś tekst";//niejawnego typowania zmiennych

            dynamic tekstJakoDynamic = "Jakiś tekst";//dynamiczne niejawne typowanie zmiennych
            tekstJakoDynamic = 5;

            string imie = null; // nie jest typem – to literal

            Console.WriteLine(znak); //  <-  Wyświetla tekst na konsoli
            Console.Write(znak);
           
            int wiek = 18;

            if (wiek >= 18)
            {
                Console.WriteLine("Jesteś pełnoletni");
            }
            else if (wiek == 16 || wiek != 17)
            {

            }
            else
            {
                Console.WriteLine("Nie jesteś pełnoletni");
            }


            string liczba1 = "5";
            string liczba2 = "7";

            string wynik = liczba1 + liczba2; // konkatenacja (łączenie) stringów

            Console.WriteLine(wynik);
        }
    }
}
