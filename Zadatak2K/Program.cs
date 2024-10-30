internal class Program
{
    private static void Main(string[] args)
    {
        //definisati klasu Knjiga s atributima
        //naslov(string)
        //autor(string)
        //godinaIzdavanja(int)
        //Dodati i default konstruktor i konstruktor sa svim parametrima
        //dodati metodu koja za proslieđenu godinu gleda da li je unesena godina mlađa u odnosu na godinu izdavanja (bool)
        Knjiga knjiga = new Knjiga("Zlocin i Kazna", "FMD", 1988);
        bool isMladja = knjiga.DaLiJeMladja(2025);
        Console.WriteLine(isMladja);
    }
}

class Knjiga
{
    string Naslov;
    string Autor;
    int GodinaIzdavanja;

    public Knjiga()
    {
        
    }
    public Knjiga(string naslov, string autor, int godinaIzdavanja)
    {
        Naslov = naslov;
        Autor = autor;
        GodinaIzdavanja = godinaIzdavanja;
    }

    public bool DaLiJeMladja(int godina)
    {
        return godina > GodinaIzdavanja;
    }
}