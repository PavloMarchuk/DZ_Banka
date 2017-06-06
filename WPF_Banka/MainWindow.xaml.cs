using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DZ_Banka;




namespace WPF_Banka
	{	
	public partial class MainWindow: Window/*, INotifyPropertyChanged*/
		{
		//public event PropertyChangedEventHandler PropertyChanged;
		//protected void OnPropertyChanged(String propertyName)
		//	{
		//	PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		//	}
		//private decimal _number;
		//public decimal Number
		//	{
		//	get { return _number; }
		//	set
		//		{
		//		_number = Convert.ToDecimal(value);
		//		OnPropertyChanged("Number");				
		//		}
		//	}
		//b1 = new Bank();	
		public DZ_Banka.Bank SS { get; set; }		
		public MainWindow()
			{			
			InitializeComponent();
			SS = new DZ_Banka.Bank();
			}
		}
	}
