using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YP.ModelsAndRepos.Discs;

namespace YP
{
    public partial class EditDisc : Form
    {
        public EditDisc()
        {
            InitializeComponent();
        }

        private void EditDisc_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsertDisc_Click(object sender, EventArgs e)
        {
            if (textBoxBandId.Text == "" || textBoxDateOfRelease.Text == "" ||
                 textBoxDiscTitle.Text == "" || textBoxHowMuchLeft.Text == "" ||
                 textBoxListOfSongs.Text == "" || textBoxRetailPrice.Text == "" ||
                 textBoxSaledInCurrentYear.Text == "" || textBoxSaledInLastYear.Text == "" ||
                 textBoxWholeSaleCompany.Text == "" || textBoxWholesalePrice.Text == "")
            {
                MessageBox.Show("Wrong input!");
                return;
            }

            IDiscsRepository discsRep = new DiscsRepository();

            DiscModel toPost = new DiscModel();

            toPost.BandId = Convert.ToInt32(textBoxBandId.Text);
            toPost.DateOfRelease = textBoxDateOfRelease.Text;
            toPost.HowMuchLeft = Convert.ToInt32(textBoxHowMuchLeft.Text);
            toPost.ListOfSongs = textBoxListOfSongs.Text;
            toPost.RetailPrice = Convert.ToInt32(textBoxRetailPrice.Text);
            toPost.SaledInCurrentYear = Convert.ToInt32(textBoxSaledInCurrentYear.Text);
            toPost.SaledInLastYear = Convert.ToInt32(textBoxSaledInLastYear.Text);
            toPost.Title = textBoxDiscTitle.Text;
            toPost.WholesaleCompany = textBoxWholeSaleCompany.Text;
            toPost.WholesalePrice = Convert.ToInt32(textBoxWholesalePrice.Text);

            bool flag = discsRep.AddDisc(toPost);

            if (flag)
            {
                MessageBox.Show("Posted!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxBandId.Text = "";
            textBoxDateOfRelease.Text = "";
            textBoxHowMuchLeft.Text = "";
            textBoxListOfSongs.Text = "";
            textBoxRetailPrice.Text = "";
            textBoxSaledInCurrentYear.Text = "";
            textBoxSaledInLastYear.Text = "";
            textBoxDiscTitle.Text = "";
            textBoxWholeSaleCompany.Text = "";
            textBoxWholesalePrice.Text = "";
        }

        private void buttonUpdateDisc_Click(object sender, EventArgs e)
        {
            if (textBoxSerialNumber.Text == "" || textBoxHowMuchLeft.Text == "" ||
                textBoxRetailPrice.Text == "" || textBoxWholesalePrice.Text == "" ||
                textBoxSaledInCurrentYear.Text == "")
            {
                MessageBox.Show("Wrong input!");
                return;
            }

            IDiscsRepository discsRep = new DiscsRepository();

            bool flag = discsRep.UpdateDisc(
                    Convert.ToInt32(textBoxSerialNumber.Text),
                    Convert.ToInt32(textBoxWholesalePrice.Text),
                    Convert.ToInt32(textBoxRetailPrice.Text),
                    Convert.ToInt32(textBoxSaledInCurrentYear.Text),
                    Convert.ToInt32(textBoxHowMuchLeft.Text)
                );

            if (flag)
            {
                MessageBox.Show("Updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxBandId.Text = "";
            textBoxDateOfRelease.Text = "";
            textBoxHowMuchLeft.Text = "";
            textBoxListOfSongs.Text = "";
            textBoxRetailPrice.Text = "";
            textBoxSaledInCurrentYear.Text = "";
            textBoxSaledInLastYear.Text = "";
            textBoxDiscTitle.Text = "";
            textBoxWholeSaleCompany.Text = "";
            textBoxWholesalePrice.Text = "";
        }

        private void buttonDeleteDisc_Click(object sender, EventArgs e)
        {
            if (textBoxDeleteSerialNumber.Text == "")
            {
                MessageBox.Show("Wrong input!");
                return;
            }

            IDiscsRepository bandsRep = new DiscsRepository();


            bool flag = bandsRep.DeleteMusician(Convert.ToInt32(textBoxDeleteSerialNumber.Text));

            if (flag)
            {
                MessageBox.Show("Deleted!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxDeleteSerialNumber.Text = "";
        }
    }
    
}
