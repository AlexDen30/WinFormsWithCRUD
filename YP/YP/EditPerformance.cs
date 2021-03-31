using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YP.ModelsAndRepos.PerformedSongs;

namespace YP
{
    public partial class EditPerformance : Form
    {
        public EditPerformance()
        {
            InitializeComponent();
        }

        private void buttonInsertPerfomance_Click(object sender, EventArgs e)
        {
            if (textBoxAuthorId.Text == "" || textBoxCircumstancesPerformance.Text == ""
                || textBoxSongName.Text == "")
            {
                MessageBox.Show("Wrong input!");
                return;
            }

            ISongsRepository songsRep = new SongsRepository();


            bool flag = songsRep.AddPSong(textBoxSongName.Text, 
                textBoxCircumstancesPerformance.Text,
                Convert.ToInt32(textBoxAuthorId.Text));

            if (flag)
            {
                MessageBox.Show("Posted!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxAuthorId.Text = "";
            textBoxCircumstancesPerformance.Text = "";
            textBoxSongName.Text = "";
        }

        private void buttonUpdatePerformance_Click(object sender, EventArgs e)
        {
            if (textBoxPerformanceId.Text == ""
                || textBoxCircumstancesPerformance.Text == "")
            {
                MessageBox.Show("Wrong input!");
                return;
            }

            ISongsRepository songsRep = new SongsRepository();


            bool flag = songsRep.UpdatePSong(Convert.ToInt32(textBoxPerformanceId.Text),
                textBoxCircumstancesPerformance.Text);

            if (flag)
            {
                MessageBox.Show("Updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxPerformanceId.Text = "";
            textBoxCircumstancesPerformance.Text = "";
        }

        private void buttonDeletePerformance_Click(object sender, EventArgs e)
        {
            if (textBoxDeleteId.Text == "")
            {
                MessageBox.Show("Wrong input!");
                return;
            }

            ISongsRepository songsRep = new SongsRepository();

            bool flag = songsRep.DeletePSong(Convert.ToInt32(textBoxDeleteId.Text));

            if (flag)
            {
                MessageBox.Show("Deleted!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxDeleteId.Text = "";
        }
    }
}
