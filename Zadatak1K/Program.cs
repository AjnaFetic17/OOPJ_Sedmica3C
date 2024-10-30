internal class Program
{
    private static void Main(string[] args)
    {
        //definisati klasu Auto sa atributima marka(string), model(string), godinaProizvidnje(int)
        //dodati konstruktor za inicijalizaciju sva 3 atributa i metodu za ispis PrikaziInformacije()
        //da u default konstruktor postaviti atribute na "Nepoznato" i 0
        Auto auto1 = new Auto();
        auto1.PrikaziInformacije();
        Auto auto2 = new Auto("BMW","M4",2022);
        auto2.PrikaziInformacije();
    }
}

class Auto
{
    string Marka;
    string Model;
    int GodinaProizvodnje;

    public Auto()
    {
        Marka = "Nepoznato";
        Model = "Nepoznato";
        GodinaProizvodnje = 0;
    }

    public Auto(string marka, string model, int godinaProizvodnje)
    {
        Marka = marka;
        Model = model;
        GodinaProizvodnje = godinaProizvodnje;
    }
    public void PrikaziInformacije()
    {
        Console.WriteLine("Marka: {0}, model: {1}, godina proizvodnje: {2}", Marka,Model,GodinaProizvodnje);
    }
}