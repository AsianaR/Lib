using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Add fr2 = new Add();
            fr2.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Base fr3 = new Base();
            fr3.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Rent rnt = new Rent();
            rnt.Show();
            this.Hide();
        }
    }
}
