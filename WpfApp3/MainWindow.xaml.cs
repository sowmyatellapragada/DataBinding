using System;
using System.Collections.Generic;
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

namespace WpfApp3
{
	public partial class ListViewItemTemp : Window
	{
		public  ListViewItemTemp()
		{
			InitializeComponent();
			List<User> items = new List<User>();
			items.Add(new User() { Name = "sowmya", Age = 21, Mail = "sowmya@gmail.com",Mobile=6301134651});
			items.Add(new User() { Name = "sriram", Age = 17, Mail = "sriram@gmail.com",Mobile=6301134663});
			items.Add(new User() { Name = "Aditya", Age = 50, Mail = "aditya@gmail.com",Mobile=6301234765});
			lbDataBinding.ItemsSource = items;
		}
	}

	public class User
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public string Mail { get; set; }
		public ulong Mobile { get; set; }
	}
}