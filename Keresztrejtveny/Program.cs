namespace Keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeresztrejtvenyRacs racs = new KeresztrejtvenyRacs("kr1.txt");
            Console.WriteLine($"5. feladat\n\tOszlopok száma: {racs.OszlopokDb}\n\tSorok száma: {racs.SorokDb}");
            Console.Write("6. feladat\n\t");
            for (int i = 0; i < racs.SorokDb; i++)
            {
                for (int j = 0; j < racs.OszlopokDb; j++)
                {
                    if (racs.Racs[i, j] == '-')
                    {
                        Console.Write("[]");
                    }
                    else
                    {
                        Console.Write("##");
					}
				}
                Console.Write("\n\t");
            }
        }
    }
}
