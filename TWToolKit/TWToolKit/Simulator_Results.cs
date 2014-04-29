using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWToolKit {
    public partial class Simulator_Results : Form {
        public Simulator_Results(VillageDesigner.TroopCount Off_Rem_Units, VillageDesigner.TroopCount Off_Lost_Units, VillageDesigner.TroopCount Def_Rem_Units, VillageDesigner.TroopCount Def_Lost_Units) {
            InitializeComponent();


            int SpearWinPercent = (int)Math.Round(((double)Off_Rem_Units.Spearman / (Off_Lost_Units.Spearman + Off_Rem_Units.Spearman)) * 100);
            int SwordWinPercent = (int)Math.Round(((double)Off_Rem_Units.Swordsman / (Off_Lost_Units.Swordsman + Off_Rem_Units.Swordsman)) * 100);
            int ArcherWinPercent = (int)Math.Round(((double)Off_Rem_Units.Archer / (Off_Lost_Units.Archer + Off_Rem_Units.Archer)) * 100);
            int AxeWinPercent = (int)Math.Round(((double)Off_Rem_Units.Axeman / (Off_Lost_Units.Axeman + Off_Rem_Units.Axeman)) * 100);
            int ScoutWinPercent = (int)Math.Round(((double)Off_Rem_Units.Scout / (Off_Lost_Units.Scout + Off_Rem_Units.Scout)) * 100);
            int LCWinPercent = (int)Math.Round(((double)Off_Rem_Units.Light_Cavalry / (Off_Lost_Units.Light_Cavalry + Off_Rem_Units.Light_Cavalry)) * 100);
            int MAWinPercent = (int)Math.Round(((double)Off_Rem_Units.Mounted_Archer / (Off_Lost_Units.Mounted_Archer + Off_Rem_Units.Mounted_Archer)) * 100);
            int HCWinPercent = (int)Math.Round(((double)Off_Rem_Units.Heavy_Cavalry / (Off_Lost_Units.Heavy_Cavalry + Off_Rem_Units.Heavy_Cavalry)) * 100);
            int RamWinPercent = (int)Math.Round(((double)Off_Rem_Units.Ram / (Off_Lost_Units.Ram + Off_Rem_Units.Ram)) * 100);
            int CatWinPercent = (int)Math.Round(((double)Off_Rem_Units.Catapult / (Off_Lost_Units.Catapult + Off_Rem_Units.Catapult)) * 100);
            int PalWinPercent = (int)Math.Round(((double)Off_Rem_Units.Paladin / (Off_Lost_Units.Paladin + Off_Rem_Units.Paladin)) * 100);
            int NobleWinPercent = (int)Math.Round(((double)Off_Rem_Units.Noble / (Off_Lost_Units.Noble + Off_Rem_Units.Noble)) * 100);

            int i = 0;
            if (SpearWinPercent < 0)
                SpearWinPercent = 0;
            else
                i++;
            if (SwordWinPercent < 0)
                SwordWinPercent = 0;
            else
                i++;
            if (ArcherWinPercent < 0)
                ArcherWinPercent = 0;
            else
                i++;
            if (AxeWinPercent < 0)
                AxeWinPercent = 0;
            else
                i++;
            if (ScoutWinPercent < 0)
                ScoutWinPercent = 0;
            else
                i++;
            if (LCWinPercent < 0)
                LCWinPercent = 0;
            else
                i++;
            if (MAWinPercent < 0)
                MAWinPercent = 0;
            else
                i++;
            if (HCWinPercent < 0)
                HCWinPercent = 0;
            else
                i++;
            if (RamWinPercent < 0)
                RamWinPercent = 0;
            else
                i++;
            if (CatWinPercent < 0)
                CatWinPercent = 0;
            else
                i++;
            if (PalWinPercent < 0)
                PalWinPercent = 0;
            else
                i++;
            if (NobleWinPercent < 0)
                NobleWinPercent = 0;
            else
                i++;
            

            int OverallPercent = (SpearWinPercent + SwordWinPercent + ArcherWinPercent + AxeWinPercent + ScoutWinPercent + LCWinPercent + MAWinPercent + HCWinPercent + RamWinPercent + CatWinPercent + PalWinPercent + NobleWinPercent) / i;
            string VictoryType = "Pengtastic";

            if (OverallPercent < 10)
                VictoryType = "Pyrrhic";
            else if (OverallPercent < 20)
                VictoryType = "Costly";
            else if (OverallPercent < 40)
                VictoryType = "Close";
            else if (OverallPercent < 60)
                VictoryType = "Clear";
            else if (OverallPercent < 75)
                VictoryType = "Heroic";
            else if (OverallPercent < 88)
                VictoryType = "Legendary";
            else if (OverallPercent < 100)
                VictoryType = "Mythical";

            lblVictory.Text = VictoryType + " Offensive Victory!";
            pnlVictory.BackColor = Color.Sienna;



            txtSpear.Text = Off_Lost_Units.Spearman.ToString();
            txtSword.Text = Off_Lost_Units.Swordsman.ToString();
            txtArcher.Text = Off_Lost_Units.Archer.ToString();
            txtAxe.Text = Off_Lost_Units.Axeman.ToString();
            txtScout.Text = Off_Lost_Units.Scout.ToString();
            txtLC.Text = Off_Lost_Units.Light_Cavalry.ToString();
            txtMA.Text = Off_Lost_Units.Mounted_Archer.ToString();
            txtHC.Text = Off_Lost_Units.Heavy_Cavalry.ToString();
            txtRam.Text = Off_Lost_Units.Ram.ToString();
            txtCat.Text = Off_Lost_Units.Catapult.ToString();
            txtPaladin.Text = Off_Lost_Units.Paladin.ToString();
            txtNoble.Text = Off_Lost_Units.Noble.ToString();

            txtSpearDefense.Text = Def_Lost_Units.Spearman.ToString();
            txtSwordDefense.Text = Def_Lost_Units.Swordsman.ToString();
            txtArcherDefense.Text = Def_Lost_Units.Archer.ToString();
            txtAxeDefense.Text = Def_Lost_Units.Axeman.ToString();
            txtScoutDefense.Text = Def_Lost_Units.Scout.ToString();
            txtLCDefense.Text = Def_Lost_Units.Light_Cavalry.ToString();
            txtMADefense.Text = Def_Lost_Units.Mounted_Archer.ToString();
            txtHCDefense.Text = Def_Lost_Units.Heavy_Cavalry.ToString();
            txtRamDefense.Text = Def_Lost_Units.Ram.ToString();
            txtCatDefense.Text = Def_Lost_Units.Catapult.ToString();
            txtPaladinDefense.Text = Def_Lost_Units.Paladin.ToString();
            txtNobleDefense.Text = Def_Lost_Units.Noble.ToString();
            txtMilitia.Text = Def_Lost_Units.Militia.ToString();

        }

        private void txtMA_TextChanged(object sender, EventArgs e) {

        }

        private void Simulator_Results_Load(object sender, EventArgs e) {

        }

        private void btnReturn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
