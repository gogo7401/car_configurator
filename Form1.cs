using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_selector
{
    public partial class Form1 : Form
    {
        decimal price = 0M;
        decimal priceBase = 99500M;
        decimal priceKlimatronik = 0M;
        decimal pricePodgrev = 0M;
        decimal priceMirror = 0M;
        decimal priceWhell = 0M;

        private string path = null;
        private string FILENAME = null;

        public Form1()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            path = Directory.GetCurrentDirectory();
            FILENAME = $"{path}\\images\\BMW_X1.jpg";
            pictureBox1.Image = car_selector.Properties.Resources.BMW_X1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            price = priceBase + priceKlimatronik + pricePodgrev + priceMirror + priceWhell;
            label8.Text = price.ToString() + " лв.";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton1.PerformClick();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                priceKlimatronik = 2200.00M;
            }
            else
            {
                priceKlimatronik = 0M;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                pricePodgrev = 860.00M;
            }
            else
            {
                pricePodgrev = 0M;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                priceMirror = 1600.00M;
            }
            else
            {
                priceMirror = 0M;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                priceWhell = 1200.00M;
            }
            else
            {
                priceWhell = 0M;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Двигател: X1 xDrive23i";
            label3.Text = "Мощност: 160 kW (218 PS)";
            label4.Text = "Скоростна кутия: Автоматична";
            label5.Text = "Гориво: Бензин";
            label6.Text = "Брой врати: 5 врати";
            label8.Text = "99500 лв.";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            priceBase = 99500M;
            pictureBox1.Image = car_selector.Properties.Resources.BMW_X1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Двигател: 320d xDrive";
            label3.Text = "Мощност: 140 kW (190 PS)";
            label4.Text = "Скоростна кутия: Автоматична";
            label5.Text = "Гориво: Дизел";
            label6.Text = "Брой врати: 4 врати";
            label8.Text = "103050 лв.";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            priceBase = 103050M;
            pictureBox1.Image = car_selector.Properties.Resources.BMW_3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Двигател: Z4 sDrive20i";
            label3.Text = "Мощност: 145 kW (197 PS)";
            label4.Text = "Скоростна кутия: Ръчна";
            label5.Text = "Гориво: Бензин";
            label6.Text = "Брой врати: 2 врати";
            label8.Text = "98400 лв.";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            priceBase = 98400M;
            pictureBox1.Image = car_selector.Properties.Resources.BMW_Z4;
        }
    }
}
