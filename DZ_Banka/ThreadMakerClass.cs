using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_Banka
	{
	class ThreadMakerClass
		{			
		public ThreadMakerClass(string pole, string old_value, string new_value)
			{
			string str = $" {DateTime.Now} властивість «{pole}»\t змінено «{old_value}» на  «{new_value}»";
			Thread thread = new Thread(() => LogerClass.LogMaker(str));			
			thread.Start();
			}
		}
	}
