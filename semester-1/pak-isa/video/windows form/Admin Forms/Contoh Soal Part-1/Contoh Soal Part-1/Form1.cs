using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contoh_Soal_Part_1
{
    public partial class Form1Login : Form
    {
        public object Register { get; private set; }

        public Form1Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2Register register = new Form2Register();
            this.Hide();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2Register register = new Form2Register();
            this.Hide();
            register.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
