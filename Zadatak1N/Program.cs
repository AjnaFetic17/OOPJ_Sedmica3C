internal class Program
{
    private static void Main(string[] args)
    {
        //korisnik unosi 5 cijelih brojeva, te brojeve pohraniti u niz i pronaci sumu
        int[] brojevi = new int[5];
        int suma = 0;

        Console.WriteLine("Unesite 5 cijelih brojeva u niz");

        for (int i = 0; i < 5; i++)
        {
            brojevi[i] = int.Parse(Console.ReadLine());
            suma += brojevi[i];
        }

        Console.WriteLine("Suma je {0}", suma);
    }
}