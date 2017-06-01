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
		Thread thread;
		string str = "";
		public ThreadMakerClass(string pole, string old_value, string new_value)
			{
			str = $" {DateTime.Now} властивість «{pole}»\t змінено «{old_value}» на  «{new_value}»";
			thread = new Thread(LogMakerOut);
			thread.Start();
			}

		void LogMakerOut()
			{
			LogerClass.LogMaker(str);
			}



		}
	}
