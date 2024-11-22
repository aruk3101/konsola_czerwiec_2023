using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola_czerwiec_2023
{

    /******************************************************
     nazwa          klasy: Film
     pola:          tytul - Tytul filmu
                    wypozyczenia - liczba wypozyczen 
     metody:        SetTytul, void – ustawia nową wartość tytułu
                    GetTytul, string – zwraca tytuł
                    GetWypozyczenia, int – zwaraca listę wypożyczeń
                    Inkrementuj, void – zwiększa liczbę wypożyczeń
     informacje:    Klasa reprezentuje film, zawiera informacje o tytule oraz liczbie wypożyczeń
     autor:         Damian Raczek
    *****************************************************/
    public class Film
    {
        protected string tytul;
        protected int wypozyczenia;

        public Film(string tytul = "", int wypozyczenia = 0)
        {
            this.tytul = tytul;
            this.wypozyczenia = wypozyczenia;
        }

        public void SetTytul(string tytul)
        {
            if (tytul.Length <= 20)
            {
                this.tytul = tytul;
            }
            else
            {
                Console.WriteLine("Tytuł nie może przekraczać 20 znaków.");
            }
        }

        public string GetTytul()
        {
            return tytul;
        }

        public int GetWypozyczenia()
        {
            return wypozyczenia;
        }

        public void Inkrementuj()
        {
            wypozyczenia++;
        }
    }
}
