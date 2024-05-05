//https://dotnetfiddle.net/Jw2eCS
namespace Lekce02BR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int den;
            int mesic;
            int rok;
            Console.WriteLine("Zadej den odjezdu na dovolenou: ");
            den = int.Parse(Console.ReadLine());            
            Console.WriteLine("Zadej měsíc odjezdu na dovolenou: ");
            mesic = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej rok odjezdu na dovolenou: ");
            rok = int.Parse(Console.ReadLine());
            DateTime datumOdjezdu = new DateTime(rok, mesic, rok);
            TimeSpan ts = DateTime.Now - datumOdjezdu;
            Console.WriteLine(ts.ToString());
            Console.ReadLine();

            // Zbyvajici dny do dovolene
            // Postupne se uzivatele zeptej na den, mesic a rok odjezdu na dovolenou. Pomoci DateTime a TimeSpan vypocitej pocet
            // zbyvajicich dni do odjezdu na dovolenou a vypis je na konzoli.
            // Pozn.: pro zjednoduseni staci pouzit int.Parse

        }
    }
}
