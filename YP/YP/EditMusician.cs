using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YP.ModelsAndRepos.Musicians;

namespace YP
{
    public partial class EditMusician : Form
    {
        public EditMusician()
        {
            InitializeComponent();
        }

        private void buttonInsertMusician_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxSurname.Text == "" 
                || textBoxDiscription.Text == "")
            {
                MessageBox.Show("Wrong input!");
            }

            IMusiciansRepository musRep = new MusiciansRepository();


            bool flag = musRep.AddMusician(textBoxFirstName.Text, textBoxSurname.Text,
                textBoxBand.Text, textBoxDiscription.Text);

            if (flag)
            {
                MessageBox.Show("Posted!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxFirstName.Text = "";
            textBoxSurname.Text = "";
            textBoxBand.Text = "";
            textBoxDiscription.Text = "";
        }

        private void buttonUpdateMusician_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxSurname.Text == "")
            {
                MessageBox.Show("Wrong input!");
            }

            IMusiciansRepository musRep = new MusiciansRepository();


            bool flag = musRep.UpdateMusician(textBoxFirstName.Text, textBoxSurname.Text,
                textBoxBand.Text, textBoxDiscription.Text);

            if (flag)
            {
                MessageBox.Show("Updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxFirstName.Text = "";
            textBoxSurname.Text = "";
            textBoxBand.Text = "";
            textBoxDiscription.Text = "";
        }

        private void buttonDeleteMusician_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNameDelete.Text == "" || textBoxSurnameDelete.Text == "")
            {
                MessageBox.Show("Wrong input!");
            }

            IMusiciansRepository musRep = new MusiciansRepository();


            bool flag = musRep.DeleteMusician(textBoxFirstNameDelete.Text, textBoxSurnameDelete.Text);

            if (flag)
            {
                MessageBox.Show("Deleted!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            textBoxFirstNameDelete.Text = "";
            textBoxSurnameDelete.Text = "";
        }
    }
    
}
