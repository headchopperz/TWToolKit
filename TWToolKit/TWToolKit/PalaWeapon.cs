using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWToolKit
{
    public partial class PalaWeapon : Form
    {
        public PalaWeapon()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkSpear_CheckedChanged(object sender, EventArgs e) {
            if (chkSpear.Checked)
                unchk("Spear");
        }

        private void chkSword_CheckedChanged(object sender, EventArgs e) {
            if (chkSword.Checked)
                unchk("Sword");
        }

        private void unchk(string Type) {
            if (Type != "Spear")
                chkSpear.Checked = false;
            if (Type != "Sword")
                chkSword.Checked = false;
            if (Type != "Archer")
                chkArcher.Checked = false;
            if (Type != "Axe")
                chkAxe.Checked = false;
            if (Type != "Scout")
                chkScout.Checked = false;
            if (Type != "LC")
                chkLC.Checked = false;
            if (Type != "MA")
                chkMA.Checked = false;
            if (Type != "HC")
                chkHC.Checked = false;
            if (Type != "Ram")
                chkRam.Checked = false;
            if (Type != "Cata")
                chkCata.Checked = false;
        }

        private void chkArcher_CheckedChanged(object sender, EventArgs e) {
            if (chkArcher.Checked)
                unchk("Archer");
        }

        private void chkAxe_CheckedChanged(object sender, EventArgs e) {
            if (chkAxe.Checked)
                unchk("Axe");
        }

        private void chkRam_CheckedChanged(object sender, EventArgs e) {
            if (chkRam.Checked)
                unchk("Ram");
        }

        private void chkCata_CheckedChanged(object sender, EventArgs e) {
            if (chkCata.Checked)
                unchk("Cata");
        }

        private void chkMA_CheckedChanged(object sender, EventArgs e) {
            if (chkMA.Checked)
                unchk("MA");
        }

        private void chkScout_CheckedChanged(object sender, EventArgs e) {
            if (chkScout.Checked)
                unchk("Scout");
        }

        private void chkHC_CheckedChanged(object sender, EventArgs e) {
            if (chkHC.Checked)
                unchk("HC");
        }

        private void chkLC_CheckedChanged(object sender, EventArgs e) {
            if (chkLC.Checked)
                unchk("LC");
        }
    }
}
