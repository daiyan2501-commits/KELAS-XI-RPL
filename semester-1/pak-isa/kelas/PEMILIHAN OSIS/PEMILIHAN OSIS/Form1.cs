using System;
using System.Windows.Forms;

namespace PEMILIHAN_OSIS
{
    public partial class Form1 : Form
    {
        int voteCalon1 = 0;
        int voteCalon2 = 0;
        int voteCalon3 = 0;

        public Form1()
        {
            InitializeComponent();

            lblCalon1.Text = "CALON 1 : 0";
            lblCalon2.Text = "CALON 2 : 0";
            lblCalon3.Text = "CALON 3 : 0";
            lblTotalVote.Text = "TOTAL VOTE: 0";
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            if (rbCalon1.Checked)
            {
                voteCalon1++;
                lblCalon1.Text = "CALON 1 : " + voteCalon1;
            }
            else if (rbCalon2.Checked)
            {
                voteCalon2++;
                lblCalon2.Text = "CALON 2 : " + voteCalon2;
            }
            else if (rbCalon3.Checked)
            {
                voteCalon3++;
                lblCalon3.Text = "CALON 3 : " + voteCalon3;
            }
            else
            {
                MessageBox.Show("Silakan pilih calon terlebih dahulu!");
                return;
            }

            // Menghitung total semua vote
            int totalVote = voteCalon1 + voteCalon2 + voteCalon3;

            // Menampilkan total semua vote
            lblTotalVote.Text = "TOTAL VOTE: " + totalVote;

            // Menghapus pilihan setelah vote
            rbCalon1.Checked = false;
            rbCalon2.Checked = false;
            rbCalon3.Checked = false;
        }
    }
}