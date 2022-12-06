using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgungDwiSaputra_4116
{
	public partial class Form2 : Form
	{

		public delegate void Proses(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil);

		public event Proses prosesEvent;
		public Form2()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int nilaiA = int.Parse(textBox1.Text);
			int nilaiB = int.Parse(textBox2.Text);
			string operasi = "";
			string operasiLabel = "";
			float hasil = 0;
			switch (comboBox1.SelectedIndex)
			{
				//penjumlahan
				case 0:
					hasil = AgungDwiSaputra_4116.Operasi.Penjumlahan(nilaiA, nilaiB);
					operasiLabel = "Penjumlahan";
					operasi = "+";
					break;
				//pengurangan
				case 1:
					hasil = AgungDwiSaputra_4116.Operasi.Pengurangan(nilaiA, nilaiB);
					operasiLabel = "Pengurangan";
					operasi = "-";
					break;
				//perkalian
				case 2:
					hasil = AgungDwiSaputra_4116.Operasi.Perkalian(nilaiA, nilaiB);
					operasiLabel = "Perkalian";
					operasi = "x";
					break;
				//pembagian
				case 3:
					hasil = AgungDwiSaputra_4116.Operasi.Pembagian(nilaiA, nilaiB);
					operasiLabel = "Pembagian";
					operasi = "/";
					break;
			}
			prosesEvent(nilaiA, nilaiB, operasi, operasiLabel, hasil);
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
