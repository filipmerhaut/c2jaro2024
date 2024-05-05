//https://dotnetfiddle.net/dYKfAb
namespace Lekce02BR2
{
    //Upravte tridu Clovek tak, aby konstruktor vyhodil vyjimku, pokud jmeno neni platne (null nebo prazdny string)
    //nebo pokud tel cislo neni validni (zkontrolujte pocet cislic). Tip: Delku cisla zjistite zavolanim telCislo.ToString().Length.
    //Do metody Main doplnte blok try-catch, ktery uzivatele upozorni, pokud udela chybu
    //Muzete pouzit obecnou tridu Exception, nebo lepe specifickou ArgumentException

    public class Clovek
    {
        public string Jmeno;
        public int TelCislo;

        public Clovek(string jmeno, int telCislo)
        {
            if (String.IsNullOrEmpty(jmeno))
            {
                throw new ArgumentException("Jméno není validní");
            }
            else
            {
                Jmeno = jmeno;
            }
            if ((telCislo < 100000000 || telCislo > 999999999))
            {
                throw new ArgumentException("Číšlo není validní");
            }
            else
            {
                TelCislo = telCislo;
            }                        
        }

        public string VypisJmenoACislo()
        {
            return $"{Jmeno}: {TelCislo}";
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Program na vytvareni telefonniho seznamu");
            Console.WriteLine("========================================");
            Console.Write("Zadejte jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte telefonni cislo: ");
            string cislo = Console.ReadLine();

            try
            {
                Clovek prvniClovek = new Clovek(jmeno, int.Parse(cislo));
                Console.WriteLine(prvniClovek.VypisJmenoACislo());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nastala výjimka: " + ex.Message);
                throw;
            }
           
            Console.ReadLine();

        }
    }
}
