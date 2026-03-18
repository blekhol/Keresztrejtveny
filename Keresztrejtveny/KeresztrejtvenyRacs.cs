using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keresztrejtveny
{
	internal class KeresztrejtvenyRacs
	{
		List<string> adatsorok;
		char[,] racs;
		int[,] sorszamok;

		public int OszlopokDb { get { return adatsorok[0].Length; } }
		public int SorokDb { get { return adatsorok.Count; } }

		public char[,] Racs { get => racs; }

		public KeresztrejtvenyRacs(string forras)
		{
			BeolvasAdatsorok(forras);
			racs = new char[SorokDb, OszlopokDb];
			sorszamok = new int[SorokDb, OszlopokDb];
			FeltoltRacs(adatsorok);
		}

		private void BeolvasAdatsorok(string forras)
		{
			adatsorok = [];
			using (var olvaso = new StreamReader(forras))
			{
				while (!olvaso.EndOfStream)
				{
					adatsorok.Add(olvaso.ReadLine());
				}
			}
		}

		private void FeltoltRacs(List<string> adatsorok)
		{
			for (int i = 0; i < SorokDb; i++)
			{
				for (int j = 0; j < OszlopokDb; j++)
				{
					racs[i, j] = adatsorok[i][j];
				}
			}
		}
	}
}
