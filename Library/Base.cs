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

        int count = 0; // номер человека с книгой в базе

        public Base()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu fr1 = new Menu();
            fr1.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            
            if(count >= Program.InfoBase.Count)
            {
                button1.Visible = false;
                count--;
            }
            else           
            {
                
                textBox1.Text = Program.InfoBase[count].Name + " " + Program.InfoBase[count].Surname;
                textBox2.Text = Program.InfoBase[count].MyBook;
                count++;
            }
            
        }

        private void Base_Load(object sender, EventArgs e)
        {
            button1.PerformClick(); 
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(Program.InfoBase.Count <= count)
                count--;
            if (count>=0)
            Program.InfoBase.RemoveAt(count);
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string ToFind = textBox3.Text;

            foreach (Author elements in Program.authors)
            {
                if (elements.BookName == ToFind)
                {
                    textBox4.Text = elements.Name +" " + elements.Surname;
                    return;
                }
            }
            textBox4.Text = "Nothing was found";
        }
    }
}
