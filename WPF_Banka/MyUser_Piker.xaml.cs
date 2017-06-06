using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WPF_Banka
	{
	public partial class MyUser_Piker: UserControl, INotifyPropertyChanged
		{

		private decimal _number;	
		public Brush UpColorDefault { get; set; }
		public Brush DownColorDefault { get; set; }		
		Brush UpColor = Brushes.Green;
		Brush DownColor = Brushes.Red;
		
		public decimal Number
			{
			get {return _number; }
			set
				{
				_number = Convert.ToDecimal(value);
				onPropertyChanged();
				}
			}

		public MyUser_Piker()
			{
			InitializeComponent();
			this.DataContext = this;
			tbText.Text = Number.ToString();
			Loaded += MyUser_Piker_Loaded;
			}


		// 1- потрібен делегат
		EventHandler _UpClick;
		// 2. - Оголошуємо собитія і звязати з делегатом
		public event EventHandler UpClick_event
			{
			add { _UpClick += value; }
			remove { _UpClick -= value; }
			}
		//Захищений метод виклику делегата
		protected virtual void UpClick_Call()
			{
			_UpClick?.Invoke(this, EventArgs.Empty);
			}


		EventHandler _DownClick;
		// 2. - Оголошуємо собитія і звязати з делегатом
		public event EventHandler DownClick_event
			{
			add { _DownClick += value; }
			remove { _DownClick -= value; }
			}
		//Захищений метод виклику делегата
		protected virtual void DownClick_Call()
			{
			_DownClick?.Invoke(this, EventArgs.Empty);
			}


		private void MyUser_Piker_Loaded(object sender, RoutedEventArgs e)
			{
			double tmp;
			if(this.Width < this.Height)
				tmp = this.Width;
			else tmp = this.Height;

			this.FontSize = tmp * 0.7;
			}

		private void bUpButton_Click(object sender, RoutedEventArgs e)
			{
			Number++;
			tbText.Text = Number.ToString();
			bUpButton.Background = UpColor;
			bDownpButton.Background = DownColorDefault;
			UpClick_Call();
			}

		private void bDownpButton_Click(object sender, RoutedEventArgs e)
			{
			Number--;
			tbText.Text = Number.ToString();
			bDownpButton.Background = DownColor;
			bUpButton.Background = UpColorDefault;
			DownClick_Call();
			}


		public event PropertyChangedEventHandler PropertyChanged;
		protected void onPropertyChanged([CallerMemberName] String propertyName = "")
			{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
