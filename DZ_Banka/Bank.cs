using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Banka
	{
	class Bank : INotifyPropertyChanged
		{
		decimal money = 0;
		string name = "Void_Name";
		int percent = 20;

		
		public decimal Money
			{
			get { return money; }
			set {
				ThreadMakerClass t = new ThreadMakerClass("Money", money.ToString(), value.ToString());
				money = value;
				}
			}		

		public string Name
			{
			get { return name; }
			set {
				ThreadMakerClass t = new ThreadMakerClass("Name", name.ToString(), value.ToString());
				name = value;
				}
			}
			

		public int Percent
			{
			get { return percent; }
			set {
				ThreadMakerClass t = new ThreadMakerClass("Percent", percent.ToString(), value.ToString());
				percent = value;
				}
			}

		public event PropertyChangedEventHandler PropertyChanged;
		}
	}
