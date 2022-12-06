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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.prosesEvent += proses;
			form2.ShowDialog();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void proses(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil)
		{
				listBox1.Items.Add(
				String.Format($"Hasil {operasiLabel} dari {nilaiA} {operasi} {nilaiB} = ") +
				String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
				);
		}
	}
}
