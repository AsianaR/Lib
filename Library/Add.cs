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
    public partial class Add : Form
    {
        public Add()
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
            var book = textBox1.Text;
            var name = textBox2.Text;

            if (textBox1.Text != "")
            {
                using (var writer = new StreamWriter("books.txt", true))
                {
                    writer.WriteLine(book);
                }
            }
            if(textBox2.Text != "")
            {
                using (var writer = new StreamWriter("names.txt", true))
                {
                    writer.WriteLine(name);
                }
            }
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                MessageBox.Show("All fields are empty");
            }

            textBox1.Clear();
            textBox2.Clear();
        }

        private void Add_Load(object sender, EventArgs e)
        {
        
        }
    }
}
