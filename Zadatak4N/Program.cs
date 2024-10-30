internal class Program
{
    private static void Main(string[] args)
    {
        //unesite 10 cijelih brojeva
        //pronaci onaj broj koji je najcesci u nizu
        //(gledati brojeve od 0 do 100)
        // 1 5 9 1 5 3 5 2 0
        //5
        /*int[] niz = new int[10];

        for (int i = 0; i < niz.Length; i++)
        {
            niz[i]=int.Parse(Console.ReadLine());
        }

        int max = 0;
        int najcesci = 0;

        for (int i = 0; i < niz.Length; i++)
        {
            int brojac = 0;
            for (int j = 0; j < niz.Length; j++)
            {
                if (niz[i] == niz[j])
                {
                    brojac++;
                }
                if (brojac > max)
                {
                    max = brojac;
                    najcesci=niz[i];
                }
            }
        }
        Console.WriteLine(najcesci);*/
        //int[] brojevi = new int[10];
        //int[] brojevi2 = new int[100];

        //Console.WriteLine("Unesite 10 brojeva: ");
        //for (int i = 0; i < brojevi.Length; i++)
        //{
        //    brojevi[i] = int.Parse(Console.ReadLine());
        //    brojevi2[brojevi[i]]++;
        //}

        //int maxPojavljivanja = 0;
        //int a = 0;
        //for (int i = 0; i < brojevi.Length; i++)
        //{
        //    if (brojevi2[i] > maxPojavljivanja)
        //    {
        //        maxPojavljivanja = brojevi2[i];
        //        a = i;
        //    }
        //}
        //Console.WriteLine("Najcesci broj je : " + a);

        Dictionary<int,int> brojPonavljanja = new Dictionary<int,int>();
        int[] brojevi = new int[10];

        for (int i = 0; i < 10; i++)
        {
            brojevi[i] = int.Parse(Console.ReadLine());
            if (brojPonavljanja.ContainsKey(brojevi[i])) {
                brojPonavljanja[brojevi[i]]++;
            }
            else
            {
                brojPonavljanja.Add(brojevi[i],1);
            }
        }

        int maxCifra = brojevi[0];
        foreach (var i in brojPonavljanja.Keys)
        {
            if (brojPonavljanja[i] > brojPonavljanja[maxCifra])
            {
                maxCifra = i;
            }
        }
        Console.WriteLine("Najcesca cifra je: {0}", maxCifra);
    }
}
