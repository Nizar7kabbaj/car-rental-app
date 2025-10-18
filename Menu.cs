using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace location_de_voiture
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VoiturePct_Click(object sender, EventArgs e)
        {
            Voitures Obj = new Voitures();
            Obj.Show();
            this.Hide();
        }

        private void VoitureLbl_Click(object sender, EventArgs e)
        {
            Voitures Obj = new Voitures();
            Obj.Show();
            this.Hide();
        }
    }
}
