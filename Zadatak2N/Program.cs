internal class Program
{
    private static void Main(string[] args)
    {
        //Korisnik unosi 10 brojeva u niz
        //pronaci najveci i najmanji element niza

        int[] brojevi = new int[10];

        //I
        for (int i = 0; i < 10; i++)
        {
            brojevi[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (brojevi[i] < brojevi[j])
                {
                    int temp = brojevi[i];
                    brojevi[i] = brojevi[j];
                    brojevi[j] = temp;
                }
            }
        }

        Console.WriteLine($"Najmanji element je {brojevi[0]}");
        Console.WriteLine($"Najveći element je {brojevi[9]}");
        //II
        int[] brojevi2 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            brojevi2[i] = int.Parse(Console.ReadLine());
        }
        int max = brojevi2[0];
        int min = brojevi2[0];
        for (int i = 0; i < 10; i++)
        {
            if (brojevi2[i] > max)
            {
                max = brojevi2[i];
            }
            if (brojevi2[i] < min)
            {
                min = brojevi2[i];
            }
        }
        Console.WriteLine("Najveci broj u nizu je: {0}", max);
        Console.WriteLine("Najveci broj u nizu je: {0}", min);

    }
}