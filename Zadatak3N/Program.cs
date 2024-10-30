internal class Program
{
    private static void Main(string[] args)
    {
        //unesite 5 cijelih brojeva u niz
        //prebrojati broj pozitivnih, negativnih i 0

        int[] brojevi = new int[5];

        int negativni = 0;
        int pozitivni = 0;
        int nule = 0;

        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Unesite broj {0}",i+1);
            brojevi[i] = int.Parse(Console.ReadLine());
            if (brojevi[i]<0)
            {
                negativni++;
            }else if (brojevi[i]>0) { pozitivni++; }
            else { nule++; }
        }
        Console.WriteLine("Pozitivni: {0}",pozitivni);
        Console.WriteLine("Negativni :{0}",negativni);
        Console.WriteLine("Nule: {0}",nule);

    }
}