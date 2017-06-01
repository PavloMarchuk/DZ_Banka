using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace DZ_Banka
	{
	class LogerClass
		{
		static private int log_id =0;
		static private LogerClass log_obj;
		static LogerClass() { }
		private LogerClass() { }


		public static void LogMaker(string str)
			{		
			if(log_obj == null)
				{
				lock(typeof(LogerClass))
					{
					if(log_obj == null)
						log_obj = new LogerClass();
					}
				}
						
			lock(typeof(LogerClass))
				{
				log_id++;							
				Writer(log_id + str);
				}
			return;
			}

		static void Writer(string str)
			{			
			Console.WriteLine(str);
			FileStream fs = new FileStream(@"log.txt", FileMode.Append, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);			
			sw.WriteLine(str);
			sw.Close();
			fs.Close();
			}

		}
	}
