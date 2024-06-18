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

namespace ProDodger
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //    StreamReader easy = new StreamReader(@"easy.txt");
            //    //StreamReader sr = new StreamReader("easy.txt");
            //    if (easy != null)
            //    {

            //            label1.Text = easy.ReadLine();


            //    }
            //    easy.Close();

            //    StreamReader medium = new StreamReader(@"medium.txt");

            //    if (medium != null)
            //    {
            //        label2.Text = medium.ReadLine();
            //    }
            //    medium.Close();

            //    StreamReader hard = new StreamReader(@"hard.txt");

            //    if (hard != null)
            //    {
            //        label3.Text = hard.ReadLine();
            //    }
            //    hard.Close();
            //}
        }
    }
}
