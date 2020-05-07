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

namespace Library
{
    public partial class Base : Form
    {
 
        string[] data;
        int count =-1;
        public Base()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Main fr1 = new Main();
            fr1.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            count++;

            if (count < data.Length)
            {
                string tempor = data[count];
                string[] cut = tempor.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                textBox1.Text = cut[0];
                if (cut.Length == 2)
                {
                    textBox2.Text = cut[1];
                }
                if(cut.Length>2)
                {

                    for(int i=1; i<cut.Length; i++)
                    {
                        textBox2.Text = textBox2.Text + " " + cut[i] + " ";
                    }
                }
            }
        }

        private void Base_Load(object sender, EventArgs e)
        {
            data = File.ReadAllLines("Rented.txt");
            button1.PerformClick();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
