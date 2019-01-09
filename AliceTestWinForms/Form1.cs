using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliceTestWinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int[] z = new int[] { 1, 2, 3, 4, 5 };
			Random r = new Random();
			for (int i = 0; i < z.Length; i++)
			{
				z[i] = r.Next(101);
			}
			label1.Text = Convert.ToString(z[0]);
			label2.Text = Convert.ToString(z[1]);
			label3.Text = Convert.ToString(z[2]);
			label4.Text = Convert.ToString(z[3]);
			label5.Text = Convert.ToString(z[4]);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int score = 0;
			if (textBox1.Text == label1.Text)
			{
				score++;
			}
			else
				textBox1.ForeColor = Color.Red;
			if (textBox2.Text == label2.Text)
				score++;
			else
				textBox2.ForeColor = Color.Red;
			if (textBox3.Text == label3.Text)
				score++;
			else
				textBox3.ForeColor = Color.Red;
			if (textBox4.Text == label4.Text)
				score++;
			else
				textBox4.ForeColor = Color.Red;
			if (textBox5.Text == label5.Text)
				score++;
			else
				textBox5.ForeColor = Color.Red;
			scores.Items.Add(score);
			label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = true;
			if (textBox1.Text == label1.Text && textBox2.Text == label2.Text && textBox3.Text == label3.Text && textBox4.Text == label4.Text && textBox5.Text == label5.Text)
			{
				MessageBox.Show("You Won!!","", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show("you were wrong", "", MessageBoxButtons.OK);
			}
		}

		private void starter_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
			label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = false;
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int[] z = new int[] { 1, 2, 3, 4, 5 };
			Random r = new Random();
			for (int i = 0; i < z.Length; i++)
			{
				z[i] = r.Next(101);
			}
			label1.Text = Convert.ToString(z[0]);
			label2.Text = Convert.ToString(z[1]);
			label3.Text = Convert.ToString(z[2]);
			label4.Text = Convert.ToString(z[3]);
			label5.Text = Convert.ToString(z[4]);

			textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				   == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
