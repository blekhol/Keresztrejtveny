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
            int max = 0;
            for (int i = 0; i < racs.OszlopokDb; i++)
            {
				int szamlalo = 0;
				for (int j = 0; j < racs.SorokDb; j++)
                {   
					if (racs.Racs[j, i] == '-')
                    {
                        szamlalo++;
                    }
                    else
                    {
						if (szamlalo > max)
						{
							max = szamlalo;
						}
                        szamlalo = 0;
					}
				}
				if (szamlalo > max)
				{
					max = szamlalo;
				}
			}
			Console.WriteLine("\n7.feladat: leghosszabb függ: " + max);
		}
    }
}
