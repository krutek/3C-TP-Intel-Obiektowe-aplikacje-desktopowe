using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            //short nazwa = 0;
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

            int wiek = 18;

            if (wiek >= 18)
            {
                //Console.WriteLine("Jesteś pełnoletni");
            }
            else if (wiek == 16 || wiek != 17)
            {

            }
            else
            {
                //Console.WriteLine("Nie jesteś pełnoletni");
            }


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
                //Console.WriteLine(tablicaIntow[i]);
            }
            //int <-integer
            List<int> listaIntow = new List<int>();
            List<string> listaImion = new List<string>();
            listaImion.Add("Adam");
            listaImion.Add("Dawid");

            foreach (var elementListy in listaImion)
            {
                //Console.WriteLine(elementListy);
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

           // while (NiechPetrlaSieWykonuje)
           // {
                //int wiekUzytkownia1 = Convert.ToInt32(Console.ReadLine());
               // bool czyUzytkownikPodalLiczbe = int.TryParse(Console.ReadLine(), out int wiekUzytkownia);

                //if (czyUzytkownikPodalLiczbe && wiekUzytkownia >= 18) 
                //{
                //    Console.WriteLine( "jesteś pełnoletni" );
                //    NiechPetrlaSieWykonuje = false;
                //}
                ////Console.WriteLine("nie jesteś");
           // }

            /// tablica wielowymiarowa
            int[,] macierz = new int[5, 5]
            {
                {1, 2, 3, 5 ,6},
                {4, 5, 6, 5 ,6},
                {7, 8, 9, 5 ,6},
                {7, 8, 9, 5 ,6},
                {7, 8, 9, 50 ,6}
            };
            var suma = 0;
            for (int i = 0; i < macierz.GetLength(0); i++)        // liczba wierszy
            {
 
                for (int j = 0; j < macierz.GetLength(1); j++)    // liczba kolumn
                {
                        suma += macierz[i, j];
                }
            }
            //Console.WriteLine(suma);

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


            // foreach (var para in umiejetnosc)
            // Console.WriteLine($"{para.Key} = {para.Value}");


            ///Obsługa plików
            ///na konsoli ma się wyświetlić opcja wyboru zapis czy odczny, wyjdź
            /// user podaje 1 lub 2 (zapis Lub odczyt)
            /// po kliknieciu 1 user ma wpisac jakiś tekst
            /// program ma zapisać do pliku write.txt
            /// po kliknieciu 2 program ma odczytać z pliku readme.txt
            /// i wyrzucić tekst na konsolę
            /// wszystko niech się dzieje w pętli tak by po odczycie lub zapisie
            /// apilkacja kontynuowała działanie
            /// po kliknieciu 3 program ma się zakończyć
            //using (StreamWriter writetext = new StreamWriter("write.txt"))
            //{
            //    writetext.WriteLine("writing in text file");
            //}

            //using (StreamReader readtext = new StreamReader("readme.txt"))
            //{
            //    string readText = readtext.ReadLine();
            //}


            //////
            ///zaj 3
            //int a = 10, b = 3;

            //// Operatory arytmetyczne
            //Console.WriteLine("=== Operatory arytmetyczne ===");
            //Console.WriteLine($"{a} + {b} = {a + b}");
            //Console.WriteLine($"{a} - {b} = {a - b}");
            //Console.WriteLine($"{a} * {b} = {a * b}");
            //Console.WriteLine($"{a} / {b} = {a / b}");   // dzielenie całkowite
            //Console.WriteLine($"{a} % {b} = {a % b}");   // reszta z dzielenia

            //// Operatory porównania
            //Console.WriteLine("\n=== Operatory porównania ===");
            //Console.WriteLine($"{a} > {b}  -> {a > b}");
            //Console.WriteLine($"{a} < {b}  -> {a < b}");
            //Console.WriteLine($"{a} >= {b}  -> {a > b}");
            //Console.WriteLine($"{a} <= {b}  -> {a < b}");
            //Console.WriteLine($"{a} == {b} -> {a == b}"); 
            //Console.WriteLine($"{a} != {b} -> {a != b}");
            ////! <- negacji

            //// Operatory logiczne
            //bool x = true, y = false;
            //Console.WriteLine("\n=== Operatory logiczne ===");
            //Console.WriteLine($"{x} && {y} -> {x && y}"); // AND
            //Console.WriteLine($"{x} || {y} -> {x || y}"); // OR
            //Console.WriteLine($"!{x} -> {!x}");           // NOT

            //// Operator inkrementacji / dekrementacji
            //Console.WriteLine("\n=== Inkrementacja / Dekrementacja ===");
            //int c = 5;
            //Console.WriteLine($"c = {c}");
            //Console.WriteLine($"c++ -> {c++} (najpierw zwraca, potem zwiększa)");
            //Console.WriteLine($"c po c++ = {c}");
            //Console.WriteLine($"++c -> {++c} (najpierw zwiększa, potem zwraca)");


            //Console.WriteLine("Podaj licznik: ");
            //int licznik = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj mianownik: ");
            //int mianownik = int.Parse(Console.ReadLine());


            //try
            //{
            //    int wynik = licznik / mianownik;
            //    Console.WriteLine($"Wynik dzielenia: {wynik}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Błąd: próba dzielenia przez zero!");
            //    Console.WriteLine($"Szczegóły: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Blok finally – wykonuje się zawsze (np. zamknięcie pliku/połączenia).");
            //}


            //void WyswietlPowitanie()
            //{
            //    Console.WriteLine("Witaj");
            //}
            //WyswietlPowitanie();
            //WyswietlPowitanie();

            int DodajDwieLiczby(int pierwszaLiczba, int drugaLiczba = 10)
            {
                int wynik = pierwszaLiczba + drugaLiczba;
                return wynik;
            }

   










            void jakasNazwa(string jeden, string dwa = "Warosc albo nawiasy")
            {
                Console.WriteLine(jeden + " " + dwa); //konkatenacja
            }



            int obliczenie(int liczbaX, int liczbaY)
            {
                
                for (int i=0; i< liczbaY; i++)
                {
                    liczbaX = liczbaX * liczbaX;
                }
                return liczbaX;

            }

           Console.WriteLine(obliczenie(2, 10));

            //
            //Stwórz kolekcję do zapamiętwania towarów i ceny 
            //a potem w funkcji dodawaj do tej kolecji te towary z ceną 

            //Dictionary<string, decimal> produktyICena = new Dictionary<string, decimal>();

            //void DodajProdukt(string nazwa, decimal cena)
            //{
            //    if (produktyICena.ContainsKey(nazwa))
            //    {
            //        // jeśli do słownika odwołam się po kluczu to dostanę wartość
            //        produktyICena[nazwa] += cena;
            //    }
            //    else
            //    {
            //        produktyICena.Add(nazwa, cena);
            //    }   
            //}

            //DodajProdukt("Ser", 5);
            //DodajProdukt("Chleb", 3);
            //DodajProdukt("Mleko", 4);
            //DodajProdukt("Mleko", 4);


            //foreach (var item in produktyICena)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}







        }
    }
}
