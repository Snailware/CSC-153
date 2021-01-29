/*
* 1/21/21
* CSC 153
* Adam Lancaster
* Total Sales - program will read contents of Sales.txt file and display data.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TotalSales
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ReadButton_Click(object sender, EventArgs e)
		{
			decimal total = 0m;
			// declare total variable and set to zero.

			string[] entries = File.ReadAllLines(@"..\..\Sales.txt");
			// create array holding values from sales file.

			contentsListBox.DataSource = entries;
			// set contentsListBox data source to entries array.

			foreach (string entry in entries)
			{
				decimal.TryParse(entry, out decimal formattedEntry);
				// convert string entry to decimal and store as formattedEntry.

				total += formattedEntry;
				// add entry value to total.
			}
			// loop through all entries and calculate total.

			totalTextBox.Text = total.ToString();
			// convert total to string, then display in totalTextBox.
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
			// closes program.
		}
	}
}
