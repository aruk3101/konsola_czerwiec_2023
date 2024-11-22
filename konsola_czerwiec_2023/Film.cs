using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola_czerwiec_2023
{

    
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

       
    }
}
