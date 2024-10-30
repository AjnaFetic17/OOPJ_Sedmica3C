internal class Program
{
    private static void Main(string[] args)
    {
        Osoba neko = new Osoba();
        neko.IspisZanimanja();
        neko.Ime = "Ime1";
        neko.Godiste = 2005;
        Osoba novaOsoba = new Osoba("Ajna", 1999, "asistent");
        novaOsoba.IspisZanimanja();
        Console.WriteLine("Ime je {0}", novaOsoba.Ime);
    }
}

class Osoba
{
    public string Ime; //null
    public int Godiste;
    public string Zanimanje = "softver inzenjer";
    
    public Osoba() { }

    public Osoba(string ime, int godiste, string zanimanje)
    {
        Ime = ime;
        Godiste = godiste;
        Zanimanje = zanimanje;
    }

    public void IspisZanimanja()
    {
        Console.WriteLine("");
        Console.WriteLine("Moje zanimanje je {0}", Zanimanje);
    }
}