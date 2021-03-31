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
using YP.ModelsAndRepos.Discs;
using YP.ModelsAndRepos.Musicians;

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
            EditBand editBand = new EditBand(this);
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
                string toList = "Id:" + band.BandId + ", Name:" + band.BandName
                    + ", Description:" + band.DiscriptionOfType;
                listBands.Items.Add(toList);
            }
        }

        private void buttonSeeMusicians_Click(object sender, EventArgs e)
        {
            IMusiciansRepository musRep = new MusiciansRepository();
            List<MusicianModel> musicians = musRep.GetAllMusicians().ToList();

            listMusicians.Items.Clear();

            foreach (MusicianModel musician in musicians)
            {
                string toList = "First name: " + musician.FirstName + ", Second name:"
                    + musician.Surname + ", Role description:" + musician.DiscriptionOfRole +
                    ", Current band:";
                if (musician.BandName == null)
                {
                    toList += "none";
                } else
                {
                    toList += musician.BandName;
                }
                 
                listMusicians.Items.Add(toList);
            }
        }

        private void buttonSeeDiscs_Click(object sender, EventArgs e)
        {
            IDiscsRepository discsRep = new DiscsRepository();
            List<DiscModel> discs = discsRep.GetAllDiscs().ToList();

            listDiscs.Items.Clear();

            foreach (DiscModel disc in discs)
            {
                string toList = "Disc title:" + disc.Title + ", disc serial number:" +
                    disc.SerialNumber + ", date of release:" + disc.DateOfRelease +
                    ", sold in current year:" + disc.SaledInCurrentYear + ", in last year:" +
                    disc.SaledInLastYear + ", how much left:" + disc.HowMuchLeft +
                    ", retail price:" + disc.RetailPrice + ", wholesale:" +
                    disc.WholesalePrice + ", wholesale company:" + disc.WholesaleCompany +
                    ", list of songs:" + disc.ListOfSongs;


                listDiscs.Items.Add(toList);
            }
        }
    }

}
