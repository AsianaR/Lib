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
            Menu fr1 = new Menu();
            fr1.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text != "")
            {
                Author author = new Author();
                string[] cut = new string[2];
                author.InBase(textBox1.Text);
                cut = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                author.BookName = cut[2];
                Program.authors.Add(author);
            }
            if(textBox2.Text != "")
            {
                User user = new User();
                user.InBase(textBox2.Text);
                Program.users.Add(user);
            }

            textBox1.Clear();
            textBox2.Clear();
        }

        private void Add_Load(object sender, EventArgs e)
        {
        
        }
    }
}
