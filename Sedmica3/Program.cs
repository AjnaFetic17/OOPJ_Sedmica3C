internal class Program
{
    private static void Main(string[] args)
    {
        int[] brojevi = new int[5];

        brojevi[0] = 1;
        brojevi[1] = 2;

        Console.WriteLine(brojevi[1]);

        char[] samoglasnici = {'a','e','i', 'o', 'u'};
        char[] samoglasnici2 = ['a', 'e', 'i', 'o', 'u'];
        Console.WriteLine(samoglasnici[0]);
        Console.WriteLine(samoglasnici2[4]);
    }
}