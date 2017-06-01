using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Banka
	{
	class Program
		{
		

		static void Main(string[] args)
			{
			Console.OutputEncoding = new UTF8Encoding();

			Bank b1 = new Bank();
			b1.Name = "Микола";
			b1.Percent++;
			b1.Money += 1000;
			}
		}
	}
