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
            Main fr1 = new Main();
            fr1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            var text = listBox1.SelectedItem + " " + listBox2.SelectedItem;
            using (var writer = new StreamWriter("rented.txt", true))
            {
                writer.WriteLine(text);
            }

            listBox1.SelectedItem = "";
            listBox2.SelectedItem = "";
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            string[] users = File.ReadAllLines("names.txt");
            listBox1.Items.AddRange(users);
            string[] books = File.ReadAllLines("books.txt");
            listBox2.Items.AddRange(books);
        }
    }
}
