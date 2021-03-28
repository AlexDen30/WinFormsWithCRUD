using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YP.ModelsAndRepos.Bands;

namespace YP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditBand editBand = new EditBand();
            editBand.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditMusician editMusician = new EditMusician();
            editMusician.Show();
        }

        private void buttonEditPerfomances_Click(object sender, EventArgs e)
        {
            EditPerformance editPefomance = new EditPerformance();
            editPefomance.Show();
        }

        private void buttonEditDiscs_Click(object sender, EventArgs e)
        {
            EditDisc editDisc = new EditDisc();
            editDisc.Show();
        }

        private void buttonSeeBands_Click(object sender, EventArgs e)
        {
            IBandsRepository bandsRep = new BandsRepository();
            List<BandModel> bands = bandsRep.GetAllBands().ToList();

            listBands.Items.Clear();

            foreach(BandModel band in bands)
            {
                string toList = band.BandName + ", " + band.DiscriptionOfType;
                listBands.Items.Add(toList);
            }
        }

    }

}
