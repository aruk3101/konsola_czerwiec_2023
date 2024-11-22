namespace konsola_czerwiec_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film1 = new Film();

            Console.WriteLine($"Początkowy tytuł: {film1.GetTytul()}");
            Console.WriteLine($"Początkowa liczba wypożyczeń: {film1.GetWypozyczenia()}");

            film1.SetTytul("Zielona Mila");
            Console.WriteLine($"Tytuł po ustawieniu: {film1.GetTytul()}");

            Console.WriteLine($"Liczba wypożyczeń przed inkrementacją: {film1.GetWypozyczenia()}");
            film1.Inkrementuj();
            Console.WriteLine($"Liczba wypożyczeń po inkrementacji: {film1.GetWypozyczenia()}");

            film1.Inkrementuj();
            film1.Inkrementuj();
            Console.WriteLine($"Liczba wypożyczeń po dwóch inkrementacjach: {film1.GetWypozyczenia()}");
        }
    }
}
