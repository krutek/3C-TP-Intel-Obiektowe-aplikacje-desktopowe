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

            //byte by = 0; // 0 do 255
            //short s = 0;
            //int b = 0;
            //long l = 0l;

            //uint ui = 5u; // unsigned int
            //ulong ul = 0ul; // unsigned long

            //float f = 0.5f;
            //double d = 0.7;
            //decimal m = 0.123m; // decimal (money)

            //char znak = 'A';
            //string tekst = "Ala ma kota";

            //bool prawda = true;// SQL Server -> bit

            //var tekstJakoVar = "Jakiś tekst";//niejawnego typowania zmiennych

            //dynamic tekstJakoDynamic = "Jakiś tekst";//dynamiczne niejawne typowanie zmiennych
            //tekstJakoDynamic = 5;

            //string imie = null; // nie jest typem – to literal

            //Console.WriteLine(znak); //  <-  Wyświetla tekst na konsoli
            //Console.Write(znak);

            //int wiek = 18;

            //if (wiek >= 18)
            //{
            //    Console.WriteLine("Jesteś pełnoletni");
            //}
            //else if (wiek == 16 || wiek != 17)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Nie jesteś pełnoletni");
            //}


            //string liczba1 = "5";
            //string liczba2 = "7";

            //string wynik = liczba1 + liczba2; // konkatenacja (łączenie) stringów

            //Console.WriteLine(wynik);

            ///////////////////////////////////////////////////
            ///
            int[] tablicaIntow = new int[5]; // tablica 5 elementowa
            int[] innaTablica = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // tablica inicjalizowana
            //typ [] nazwa = new typ[rozmiar];
            string[] tablicaStringow = new string[10]; // tablica 10 elementowa
            //pierwszy element tablicy będzie miał indeks 0
            // drugi element tablicy będzie miał indeks 1
            // trzeci element tablicy będzie miał indeks 2

            for (int i = 0; i < tablicaIntow.Length; i++)
            {
                tablicaIntow[i] = i * 2;
                
            }
            for (int i = 0; i < tablicaIntow.Length; i++)
            {
                Console.WriteLine(tablicaIntow[i]);
            }
            //int <-integer
            List<int> listaIntow = new List<int>();
            List<string> listaImion = new List<string>();
            listaImion.Add("Adam");
            listaImion.Add("Dawid");

            foreach (var elementListy in listaImion)
            {
                Console.WriteLine(elementListy);
            }




            //int wiek = Convert.ToInt32(Console.ReadLine());
            // convert toint32 jeżeli się uda to zwraca liczbę a jak nie to błąd
           // var wynik = int.TryParse(Console.ReadLine(), out int Liczba);
            // tryParce jeśli się nie uda to w zmiennej out da nam false



            //1.zrób tablie intów 10 elementową
            // za pomocą pętli for wypełnij tablicę dowolnymi liczbami 
            // wyświelt tablice za pomocą pętli foreach

            //2. stwórz listę stringów
            // dodaj do listy 2 imiona
            // wyświetl imiona za pomocą pętli foreach

            // 3.w pętli stwórz instrukcje warnukową 
            // instrukcja ma sprawdzić czy użytkownik jest pełnoletni
            // jeśli tak to wyjdź z pętli 
            //jeśli nie to poproś o ponowne podanie wieku
            //Console.WriteLine("Podaj swoj wiek:");
            //int wiek = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(wiek);
            //break <- - przerywa działanie pętli

            bool NiechPetrlaSieWykonuje = true;

            ////int wiekUzytkownia1 = Convert.ToInt32(Console.ReadLine());
            // Tutaj zakładamy że user poda liczbe, jeśli nie poda liczby to zwróci błąd

            /// bool czyUzytkownikPodalLiczbe = int.TryParse(Console.ReadLine(), out int wiekUzytkownia);
            /// tutaj jeśli user poda liczbe to zmienna czyUzytkownikPodalLiczbe zamieni się na true
            /// a podana zmienna wiekUzytkownia będzie zawierać liczbe
            /// jesli user nie poda liczby to zmienna czyUzytkownikPodalLiczbe będzie false
            /// i nie wywali nam błędu

            while (NiechPetrlaSieWykonuje)
            {
                //int wiekUzytkownia1 = Convert.ToInt32(Console.ReadLine());
                bool czyUzytkownikPodalLiczbe = int.TryParse(Console.ReadLine(), out int wiekUzytkownia);

                if (czyUzytkownikPodalLiczbe && wiekUzytkownia >= 18) 
                {
                    Console.WriteLine( "jesteś pełnoletni" );
                    NiechPetrlaSieWykonuje = false;
                }
                Console.WriteLine("nie jesteś");
            }

            /// tablica wielowymiarowa
            int[,] macierz = new int[5, 5]
            {
                {1, 2, 3, 5 ,6},
                {4, 5, 6, 5 ,6},
                {7, 8, 9, 5 ,6},
                {7, 8, 9, 5 ,6},
                {7, 8, 9, 50 ,61}
            };
            var suma = 0;
            for (int i = 0; i < macierz.GetLength(0); i++)        // liczba wierszy
            {
 
                for (int j = 0; j < macierz.GetLength(1); j++)    // liczba kolumn
                {
                        suma += macierz[i, j];
                }
            }
            Console.WriteLine(suma);

            /// Tabiica postrzępiona - jagged array
            int[][] trojkat = new int[3][];
            trojkat[0] = new int[] { 1 };
            trojkat[1] = new int[] { 2, 3 };
            trojkat[2] = new int[] { 4, 5, 6 };

             suma = 0;
            for (int i = 0; i < trojkat.Length; i++)
            {
                for (int j = 0; j < trojkat[i].Length; j++)
                {
                    suma += trojkat[i][j];
                }
            }

            // Klucz, wartość
            Dictionary<string,int> umiejetnosc = new Dictionary<string, int>();
            umiejetnosc.Add("Broń jednoręczna", 5);
            umiejetnosc.Add("Broń dwuręczna", 3);
            umiejetnosc.Add("Magia", 1);
            umiejetnosc.Add("Skradanie sie", 2);


            foreach (var para in umiejetnosc)
                Console.WriteLine($"{para.Key} = {para.Value}");


        }
    }
}
