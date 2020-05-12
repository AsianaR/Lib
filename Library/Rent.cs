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
    public partial class Rent : Form
    {

        
        public Rent()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Menu fr1 = new Menu();
            fr1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            User tempBase = new User();
            string[] cut = new string[2];
            cut = listBox1.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            tempBase.Name = cut[0];
            tempBase.Surname = cut[1];
            tempBase.MyBook = listBox2.SelectedItem.ToString();

            Program.InfoBase.Add(tempBase);
        }

        private void Rent_Load(object sender, EventArgs e)
        {

            List<string> _names = new List<string>();
            List<string> _books = new List<string>();

            foreach (User elements in Program.users)
            {
                _names.Add(elements.Name + " " + elements.Surname);
                listBox1.Items.AddRange(_names.ToArray());
            }

            foreach (Author elements in Program.authors)
            {
                _books.Add(elements.BookName);
                listBox2.Items.AddRange(_books.ToArray());
            }

            
            
        }
    }
}
