using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YP.ModelsAndRepos.Bands;

namespace YP
{
    public partial class EditBand : Form
    {
        Form1 parentForm;

        public EditBand()
        {
            InitializeComponent();
        }

        public EditBand(Form1 f)
        {
            InitializeComponent();
            parentForm = f;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteBand_Click(object sender, EventArgs e)
        {
            if (textBoxNameDelete.Text == "")
            {
                MessageBox.Show("Wrong input!");
            }

            IBandsRepository bandsRep = new BandsRepository();

            string toPost;

            toPost = textBoxNameDelete.Text;

            bool flag = bandsRep.DeleteBand(toPost);

            if (flag)
            {
                MessageBox.Show("Deleted!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxNameDelete.Text = "";

        }

        private void buttonUpdateBand_Click(object sender, EventArgs e)
        {
            if (textBoxBandName.Text == "" || textBoxNewBandName.Text == "")
            {
                MessageBox.Show("Wrong input!");
            }

            IBandsRepository bandsRep = new BandsRepository();

            bool flag = bandsRep.UpdateBandName(textBoxBandName.Text, textBoxNewBandName.Text);

            if (flag)
            {
                MessageBox.Show("Updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxBandName.Text = "";
            textBoxNewBandName.Text = "";
        }

        private void buttonInsertBand_Click(object sender, EventArgs e)
        {
            if (textBoxBandName.Text == "" || textBoxDescription.Text == "")
            {
                MessageBox.Show("Wrong input!");
            }

            IBandsRepository bandsRep = new BandsRepository();

            BandModel toPost = new BandModel();

            toPost.BandName = textBoxBandName.Text;
            toPost.DiscriptionOfType = textBoxDescription.Text;

            bool flag = bandsRep.AddBand(toPost);

            if (flag)
            {
                MessageBox.Show("Posted!");
            } else
            {
                MessageBox.Show("Error!");
            }

            textBoxBandName.Text = "";
            textBoxDescription.Text = "";
        }
    }
}
