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
    public partial class VillageDesigner : Form
    {
        List<Form1.Buildings> Building; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public List<Form1.Buildings> BuildingList { set { Building = value; } }

        Form1.BuildingIDs BuildingIDs; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public Form1.BuildingIDs BuildingIDList { set { BuildingIDs = value; } }

        List<Form1.Units> Unit; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public List<Form1.Units> UnitList { set { Unit = value; } }

        Form1.UnitIDs UnitID; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public Form1.UnitIDs UnitIDList { set { UnitID = value; } }

        Form1.WorldSetting Settings; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public Form1.WorldSetting SettingClass { set { Settings = value; } }

        public Form1.VillageBuildings VillageBuild_Offense = new Form1.VillageBuildings();
        public Form1.VillageBuildings VillageBuild_Defense = new Form1.VillageBuildings();

        public class TroopCount {
            public double Spearman = -1;
            public double Swordsman = -1;
            public double Axeman = -1;
            public double Archer = -1;
            public double Scout = -1;
            public double Light_Cavalry = -1;
            public double Mounted_Archer = -1;
            public double Heavy_Cavalry = -1;
            public double Ram = -1;
            public double Catapult = -1;
            public double Paladin = -1;
            public double Noble = -1;
            public double Militia = -1;

            public TroopCount ShallowCopy() {
                return (TroopCount)this.MemberwiseClone();
            }
        }

        public VillageDesigner()
        {
            InitializeComponent();
        }

        public int minUsedPop_Offense = 5;
        public int minUsedPop_Defense = 5;

        public void parseBuildingData(string Type) {
            int FarmSpace = 0;
            Form1.VillageBuildings tmp_Build = new Form1.VillageBuildings();
            if (Type == "Offense")
                tmp_Build = VillageBuild_Offense;
            else if (Type == "Defense")
                tmp_Build = VillageBuild_Defense;

            FarmSpace = (int)Math.Round(240 * Math.Pow(1.172103, tmp_Build.Farm - 1));

            if (Type == "Offense")
                txtFarmTotal.Text = FarmSpace.ToString();
            else if (Type == "Defense")
                txtFarmTotalDefense.Text = FarmSpace.ToString();

            int UsedFarmSpace = 0;
            if (BuildingIDs.HQ != -1)
                UsedFarmSpace += Building[BuildingIDs.HQ].Pop_Table[tmp_Build.HQ];
            if (BuildingIDs.Barracks != -1)
                UsedFarmSpace += Building[BuildingIDs.Barracks].Pop_Table[tmp_Build.Barracks];
            if (BuildingIDs.Stable != -1)
                UsedFarmSpace += Building[BuildingIDs.Stable].Pop_Table[tmp_Build.Stable];
            if (BuildingIDs.Workshop != -1)
                UsedFarmSpace += Building[BuildingIDs.Workshop].Pop_Table[tmp_Build.Workshop];
            if (BuildingIDs.Church != -1)
                UsedFarmSpace += Building[BuildingIDs.Church].Pop_Table[tmp_Build.Church];
            if (BuildingIDs.Church_f != -1)
                UsedFarmSpace += Building[BuildingIDs.Church_f].Pop_Table[tmp_Build.Church_f];
            if (BuildingIDs.Academy != -1)
                UsedFarmSpace += Building[BuildingIDs.Academy].Pop_Table[tmp_Build.Academy];
            if (BuildingIDs.Smithy != -1)
                UsedFarmSpace += Building[BuildingIDs.Smithy].Pop_Table[tmp_Build.Smithy];
            if (BuildingIDs.Rally != -1)
                UsedFarmSpace += Building[BuildingIDs.Rally].Pop_Table[tmp_Build.Rally];
            if (BuildingIDs.Statue != -1)
                UsedFarmSpace += Building[BuildingIDs.Statue].Pop_Table[tmp_Build.Statue];
            if (BuildingIDs.Market != -1)
                UsedFarmSpace += Building[BuildingIDs.Market].Pop_Table[tmp_Build.Market];
            if (BuildingIDs.Camp != -1)
                UsedFarmSpace += Building[BuildingIDs.Camp].Pop_Table[tmp_Build.Camp];
            if (BuildingIDs.Pit != -1)
                UsedFarmSpace += Building[BuildingIDs.Pit].Pop_Table[tmp_Build.Pit];
            if (BuildingIDs.Mine != -1)
                UsedFarmSpace += Building[BuildingIDs.Mine].Pop_Table[tmp_Build.Mine];
            if (BuildingIDs.Farm != -1)
                UsedFarmSpace += Building[BuildingIDs.Farm].Pop_Table[tmp_Build.Farm];
            if (BuildingIDs.Warehouse != -1)
                UsedFarmSpace += Building[BuildingIDs.Warehouse].Pop_Table[tmp_Build.Warehouse];
            if (BuildingIDs.Hiding != -1)
                UsedFarmSpace += Building[BuildingIDs.Hiding].Pop_Table[tmp_Build.Hiding];
            if (BuildingIDs.Wall != -1)
                UsedFarmSpace += Building[BuildingIDs.Wall].Pop_Table[tmp_Build.Wall];

            if (Type == "Offense") {
                txtFarm.Text = UsedFarmSpace.ToString();
                minUsedPop_Offense = UsedFarmSpace;
            } else if (Type == "Defense") {
                txtFarmDefense.Text = UsedFarmSpace.ToString();
                minUsedPop_Defense = UsedFarmSpace;
            }
                
        }

        private void btnSetBuildings_Click(object sender, EventArgs e)
        {
            VillageBuild nForm = new VillageBuild(this);
            nForm.VillageBuild_Offense_Class = VillageBuild_Offense;
            nForm.VarType = "Offense";
            nForm.BuildingList = Building;
            nForm.BuildingIDList = BuildingIDs;
            nForm.Show();
        }

        private void btnPalaWep_Click(object sender, EventArgs e)
        {
            PalaWeapon nForm = new PalaWeapon();
            nForm.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, importing is not functional in this version");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, exporting is not functional in this version");
        }

        private void VillageDesigner_Load(object sender, EventArgs e)
        {

        }

        private void btnSimulate_Click(object sender, EventArgs e) {
            CalculateOffensiveStats(null, null);
            CalculateDefensiveStats(null, null);

            TroopCount TroopCount_Offense = new TroopCount();
            TroopCount TroopCount_Defense = new TroopCount();

            TroopCount_Offense.Spearman = Int32.Parse(txtSpear.Text);
            TroopCount_Offense.Swordsman = Int32.Parse(txtSword.Text);
            TroopCount_Offense.Axeman = Int32.Parse(txtAxe.Text);
            TroopCount_Offense.Archer = Int32.Parse(txtArcher.Text);
            TroopCount_Offense.Scout = Int32.Parse(txtScout.Text);
            TroopCount_Offense.Light_Cavalry = Int32.Parse(txtLC.Text);
            TroopCount_Offense.Mounted_Archer = Int32.Parse(txtMA.Text);
            TroopCount_Offense.Heavy_Cavalry = Int32.Parse(txtHC.Text);
            TroopCount_Offense.Ram = Int32.Parse(txtRam.Text);
            TroopCount_Offense.Catapult = Int32.Parse(txtCat.Text);
            TroopCount_Offense.Paladin = Int32.Parse(txtPaladin.Text);
            TroopCount_Offense.Noble = Int32.Parse(txtNoble.Text);

            TroopCount_Defense.Spearman = Int32.Parse(txtSpearDefense.Text);
            TroopCount_Defense.Swordsman = Int32.Parse(txtSwordDefense.Text);
            TroopCount_Defense.Axeman = Int32.Parse(txtAxeDefense.Text);
            TroopCount_Defense.Archer = Int32.Parse(txtArcherDefense.Text);
            TroopCount_Defense.Scout = Int32.Parse(txtScoutDefense.Text);
            TroopCount_Defense.Light_Cavalry = Int32.Parse(txtLCDefense.Text);
            TroopCount_Defense.Mounted_Archer = Int32.Parse(txtMADefense.Text);
            TroopCount_Defense.Heavy_Cavalry = Int32.Parse(txtHCDefense.Text);
            TroopCount_Defense.Ram = Int32.Parse(txtRamDefense.Text);
            TroopCount_Defense.Catapult = Int32.Parse(txtCatDefense.Text);
            TroopCount_Defense.Paladin = Int32.Parse(txtPaladinDefense.Text);
            TroopCount_Defense.Noble = Int32.Parse(txtNobleDefense.Text);
            TroopCount_Defense.Militia = Int32.Parse(txtMilitia.Text);

            int Offensive_General_Strength = Int32.Parse(txtGeneralOff.Text);
            int Offensive_Cavalry_Strength = Int32.Parse(txtCavalryOff.Text);
            int Offensive_Archer_Strength = Int32.Parse(txtArcherOff.Text);

            int Offensive_Total_Strength = Int32.Parse(txtOffense.Text);

            double Offensive_General_Ratio = Offensive_General_Strength / (double) Offensive_Total_Strength;
            double Offensive_Cavalry_Ratio = Offensive_Cavalry_Strength / (double) Offensive_Total_Strength;
            double Offensive_Archer_Ratio = Offensive_Archer_Strength / (double) Offensive_Total_Strength;

            double Defensive_General_Strength = (Int32.Parse(txtGeneralDef.Text) * Offensive_General_Ratio) + (20 * Offensive_General_Ratio); //The 20 is the base village defense
            double Defensive_Cavalry_Strength = (Int32.Parse(txtCavalryDef.Text) * Offensive_Cavalry_Ratio) + (20 * Offensive_Cavalry_Ratio);
            double Defensive_Archer_Strength = (Int32.Parse(txtArcherDef.Text) * Offensive_Archer_Ratio) + (20 * Offensive_Archer_Ratio);

            double General_Loss_Ratio = 0;
            string General_Winner = "Penguin";

            double Cavalry_Loss_Ratio = 0;
            string Cavalry_Winner = "Penguin";

            double Archer_Loss_Ratio = 0;
            string Archer_Winner = "Penguin";

            if (Offensive_General_Strength > Defensive_General_Strength) {
                General_Winner = "Offense";
                General_Loss_Ratio = Math.Pow((Defensive_General_Strength / Offensive_General_Strength), 0.5) / (Offensive_General_Strength / Defensive_General_Strength);
            } else {
                General_Winner = "Defense";
                General_Loss_Ratio = Math.Pow((Offensive_General_Strength / Defensive_General_Strength), 0.5) / (Defensive_General_Strength / Offensive_General_Strength);
            }

            if (Offensive_Cavalry_Strength > Defensive_Cavalry_Strength) {
                Cavalry_Winner = "Offense";
                Cavalry_Loss_Ratio = Math.Pow((Defensive_Cavalry_Strength / Offensive_Cavalry_Strength), 0.5) / (Offensive_Cavalry_Strength / Defensive_Cavalry_Strength);
            } else {
                Cavalry_Winner = "Defense";
                Cavalry_Loss_Ratio = Math.Pow((Offensive_Cavalry_Strength / Defensive_Cavalry_Strength), 0.5) / (Defensive_Cavalry_Strength / Offensive_Cavalry_Strength);
            }

            if (Offensive_Archer_Strength > Defensive_Archer_Strength) {
                Archer_Winner = "Offense";
                Archer_Loss_Ratio = Math.Pow((Defensive_Archer_Strength / Offensive_Archer_Strength), 0.5) / (Offensive_Archer_Strength / Defensive_Archer_Strength);
            } else {
                Archer_Winner = "Defense";
                Archer_Loss_Ratio = Math.Pow((Offensive_Archer_Strength / Defensive_Archer_Strength), 0.5) / (Defensive_Archer_Strength / Offensive_Archer_Strength);
            }

            TroopCount tmp_Offense = new TroopCount();
            TroopCount tmp_Defense = new TroopCount();

            tmp_Offense = TroopCount_Offense.ShallowCopy();
            tmp_Defense = TroopCount_Defense.ShallowCopy();

            if (General_Winner == "Offense") {
                tmp_Offense.Spearman -= TroopCount_Offense.Spearman * General_Loss_Ratio;
                tmp_Offense.Swordsman -= TroopCount_Offense.Swordsman * General_Loss_Ratio;
                tmp_Offense.Axeman -= TroopCount_Offense.Axeman * General_Loss_Ratio;
                tmp_Offense.Ram -= TroopCount_Offense.Ram * General_Loss_Ratio;
                tmp_Offense.Catapult -= TroopCount_Offense.Catapult * General_Loss_Ratio;
                tmp_Offense.Paladin -= TroopCount_Offense.Paladin * General_Loss_Ratio;

                tmp_Defense.Spearman -= TroopCount_Defense.Spearman * Offensive_General_Ratio;
                tmp_Defense.Swordsman -= TroopCount_Defense.Swordsman * Offensive_General_Ratio;
                tmp_Defense.Axeman -= TroopCount_Defense.Axeman * Offensive_General_Ratio;
                tmp_Defense.Ram -= TroopCount_Defense.Ram * Offensive_General_Ratio;
                tmp_Defense.Catapult -= TroopCount_Defense.Catapult * Offensive_General_Ratio;
                tmp_Defense.Paladin -= TroopCount_Defense.Paladin * Offensive_General_Ratio;
                tmp_Defense.Noble -= TroopCount_Defense.Noble * Offensive_General_Ratio;
                tmp_Defense.Archer -= TroopCount_Defense.Archer * Offensive_General_Ratio;
                tmp_Defense.Mounted_Archer -= TroopCount_Defense.Mounted_Archer * Offensive_General_Ratio;
                tmp_Defense.Light_Cavalry -= TroopCount_Defense.Light_Cavalry * Offensive_General_Ratio;
                tmp_Defense.Heavy_Cavalry -= TroopCount_Defense.Heavy_Cavalry * Offensive_General_Ratio;
            } else {
                tmp_Offense.Spearman = 0;
                tmp_Offense.Swordsman = 0;
                tmp_Offense.Axeman = 0;
                tmp_Offense.Ram = 0;
                tmp_Offense.Catapult = 0;
                tmp_Offense.Paladin = 0;

                tmp_Defense.Spearman -= TroopCount_Defense.Spearman * Offensive_General_Ratio * General_Loss_Ratio;
                tmp_Defense.Swordsman -= TroopCount_Defense.Swordsman * Offensive_General_Ratio * General_Loss_Ratio;
                tmp_Defense.Axeman -= TroopCount_Defense.Axeman * Offensive_General_Ratio * General_Loss_Ratio;
                tmp_Defense.Ram -= TroopCount_Defense.Ram * Offensive_General_Ratio * General_Loss_Ratio;
                tmp_Defense.Catapult -= TroopCount_Defense.Catapult * Offensive_General_Ratio * General_Loss_Ratio;
                tmp_Defense.Paladin -= TroopCount_Defense.Paladin * Offensive_General_Ratio * General_Loss_Ratio;
                tmp_Defense.Noble -= TroopCount_Defense.Noble * Offensive_General_Ratio * General_Loss_Ratio;
                tmp_Defense.Archer -= TroopCount_Defense.Archer * Offensive_General_Ratio * General_Loss_Ratio;
                tmp_Defense.Mounted_Archer -= TroopCount_Defense.Mounted_Archer * Offensive_General_Ratio * General_Loss_Ratio;
                tmp_Defense.Light_Cavalry -= TroopCount_Defense.Light_Cavalry * Offensive_General_Ratio * General_Loss_Ratio;
                tmp_Defense.Heavy_Cavalry -= TroopCount_Defense.Heavy_Cavalry * Offensive_General_Ratio * General_Loss_Ratio;
            }

            if (Cavalry_Winner == "Offense") {
                tmp_Offense.Light_Cavalry -= TroopCount_Offense.Light_Cavalry * Cavalry_Loss_Ratio;
                tmp_Offense.Heavy_Cavalry -= TroopCount_Offense.Heavy_Cavalry * Cavalry_Loss_Ratio;

                tmp_Defense.Spearman -= TroopCount_Defense.Spearman * Offensive_Cavalry_Ratio;
                tmp_Defense.Swordsman -= TroopCount_Defense.Swordsman * Offensive_Cavalry_Ratio;
                tmp_Defense.Axeman -= TroopCount_Defense.Axeman * Offensive_Cavalry_Ratio;
                tmp_Defense.Ram -= TroopCount_Defense.Ram * Offensive_Cavalry_Ratio;
                tmp_Defense.Catapult -= TroopCount_Defense.Catapult * Offensive_Cavalry_Ratio;
                tmp_Defense.Paladin -= TroopCount_Defense.Paladin * Offensive_Cavalry_Ratio;
                tmp_Defense.Noble -= TroopCount_Defense.Noble * Offensive_Cavalry_Ratio;
                tmp_Defense.Archer -= TroopCount_Defense.Archer * Offensive_Cavalry_Ratio;
                tmp_Defense.Mounted_Archer -= TroopCount_Defense.Mounted_Archer * Offensive_Cavalry_Ratio;
                tmp_Defense.Light_Cavalry -= TroopCount_Defense.Light_Cavalry * Offensive_Cavalry_Ratio;
                tmp_Defense.Heavy_Cavalry -= TroopCount_Defense.Heavy_Cavalry * Offensive_Cavalry_Ratio;
            } else {
                tmp_Offense.Light_Cavalry = 0;
                tmp_Offense.Heavy_Cavalry = 0;

                tmp_Defense.Spearman -= TroopCount_Defense.Spearman * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
                tmp_Defense.Swordsman -= TroopCount_Defense.Swordsman * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
                tmp_Defense.Axeman -= TroopCount_Defense.Axeman * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
                tmp_Defense.Ram -= TroopCount_Defense.Ram * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
                tmp_Defense.Catapult -= TroopCount_Defense.Catapult * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
                tmp_Defense.Paladin -= TroopCount_Defense.Paladin * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
                tmp_Defense.Noble -= TroopCount_Defense.Noble * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
                tmp_Defense.Archer -= TroopCount_Defense.Archer * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
                tmp_Defense.Mounted_Archer -= TroopCount_Defense.Mounted_Archer * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
                tmp_Defense.Light_Cavalry -= TroopCount_Defense.Light_Cavalry * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
                tmp_Defense.Heavy_Cavalry -= TroopCount_Defense.Heavy_Cavalry * Offensive_Cavalry_Ratio * Cavalry_Loss_Ratio;
            }

            if (Archer_Winner == "Offense") {
                tmp_Offense.Archer -= TroopCount_Offense.Archer * Archer_Loss_Ratio;
                tmp_Offense.Mounted_Archer -= TroopCount_Offense.Mounted_Archer * Archer_Loss_Ratio;


                tmp_Defense.Spearman -= TroopCount_Defense.Spearman * Offensive_Archer_Ratio;
                tmp_Defense.Swordsman -= TroopCount_Defense.Swordsman * Offensive_Archer_Ratio;
                tmp_Defense.Axeman -= TroopCount_Defense.Axeman * Offensive_Archer_Ratio;
                tmp_Defense.Ram -= TroopCount_Defense.Ram * Offensive_Archer_Ratio;
                tmp_Defense.Catapult -= TroopCount_Defense.Catapult * Offensive_Archer_Ratio;
                tmp_Defense.Paladin -= TroopCount_Defense.Paladin * Offensive_Archer_Ratio;
                tmp_Defense.Noble -= TroopCount_Defense.Noble * Offensive_Archer_Ratio;
                tmp_Defense.Archer -= TroopCount_Defense.Archer * Offensive_Archer_Ratio;
                tmp_Defense.Mounted_Archer -= TroopCount_Defense.Mounted_Archer * Offensive_Archer_Ratio;
                tmp_Defense.Light_Cavalry -= TroopCount_Defense.Light_Cavalry * Offensive_Archer_Ratio;
                tmp_Defense.Heavy_Cavalry -= TroopCount_Defense.Heavy_Cavalry * Offensive_Archer_Ratio;
            } else {
                tmp_Offense.Archer = 0;
                tmp_Offense.Mounted_Archer = 0;

                tmp_Defense.Spearman -= TroopCount_Defense.Spearman * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
                tmp_Defense.Swordsman -= TroopCount_Defense.Swordsman * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
                tmp_Defense.Axeman -= TroopCount_Defense.Axeman * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
                tmp_Defense.Ram -= TroopCount_Defense.Ram * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
                tmp_Defense.Catapult -= TroopCount_Defense.Catapult * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
                tmp_Defense.Paladin -= TroopCount_Defense.Paladin * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
                tmp_Defense.Noble -= TroopCount_Defense.Noble * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
                tmp_Defense.Archer -= TroopCount_Defense.Archer * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
                tmp_Defense.Mounted_Archer -= TroopCount_Defense.Mounted_Archer * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
                tmp_Defense.Light_Cavalry -= TroopCount_Defense.Light_Cavalry * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
                tmp_Defense.Heavy_Cavalry -= TroopCount_Defense.Heavy_Cavalry * Offensive_Cavalry_Ratio * Archer_Loss_Ratio;
            }            

            TroopCount Lost_TroopCount_Offense = new TroopCount();
            TroopCount Lost_TroopCount_Defense = new TroopCount();

            Lost_TroopCount_Offense.Spearman = Math.Round(TroopCount_Offense.Spearman - tmp_Offense.Spearman);
            Lost_TroopCount_Offense.Swordsman = Math.Round(TroopCount_Offense.Swordsman - tmp_Offense.Swordsman);
            Lost_TroopCount_Offense.Axeman = Math.Round(TroopCount_Offense.Axeman - tmp_Offense.Axeman);
            Lost_TroopCount_Offense.Archer = Math.Round(TroopCount_Offense.Archer - tmp_Offense.Archer);
            Lost_TroopCount_Offense.Scout = Math.Round(TroopCount_Offense.Scout - tmp_Offense.Scout);
            Lost_TroopCount_Offense.Light_Cavalry = Math.Round(TroopCount_Offense.Light_Cavalry - tmp_Offense.Light_Cavalry);
            Lost_TroopCount_Offense.Mounted_Archer = Math.Round(TroopCount_Offense.Mounted_Archer - tmp_Offense.Mounted_Archer);
            Lost_TroopCount_Offense.Heavy_Cavalry = Math.Round(TroopCount_Offense.Heavy_Cavalry - tmp_Offense.Heavy_Cavalry);
            Lost_TroopCount_Offense.Ram = Math.Round(TroopCount_Offense.Ram - tmp_Offense.Ram);
            Lost_TroopCount_Offense.Catapult = Math.Round(TroopCount_Offense.Catapult - tmp_Offense.Catapult);
            Lost_TroopCount_Offense.Paladin = Math.Round(TroopCount_Offense.Paladin - tmp_Offense.Paladin);
            Lost_TroopCount_Offense.Noble = Math.Round(TroopCount_Offense.Noble - tmp_Offense.Noble);

            Lost_TroopCount_Defense.Spearman = Math.Round(TroopCount_Defense.Spearman - tmp_Defense.Spearman);
            Lost_TroopCount_Defense.Swordsman = Math.Round(TroopCount_Defense.Swordsman - tmp_Defense.Swordsman);
            Lost_TroopCount_Defense.Axeman = Math.Round(TroopCount_Defense.Axeman - tmp_Defense.Axeman);
            Lost_TroopCount_Defense.Archer = Math.Round(TroopCount_Defense.Archer - tmp_Defense.Archer);
            Lost_TroopCount_Defense.Scout = Math.Round(TroopCount_Defense.Scout - tmp_Defense.Scout);
            Lost_TroopCount_Defense.Light_Cavalry = Math.Round(TroopCount_Defense.Light_Cavalry - tmp_Defense.Light_Cavalry);
            Lost_TroopCount_Defense.Mounted_Archer = Math.Round(TroopCount_Defense.Mounted_Archer - tmp_Defense.Mounted_Archer);
            Lost_TroopCount_Defense.Heavy_Cavalry = Math.Round(TroopCount_Defense.Heavy_Cavalry - tmp_Defense.Heavy_Cavalry);
            Lost_TroopCount_Defense.Ram = Math.Round(TroopCount_Defense.Ram - tmp_Defense.Ram);
            Lost_TroopCount_Defense.Catapult = Math.Round(TroopCount_Defense.Catapult - tmp_Defense.Catapult);
            Lost_TroopCount_Defense.Paladin = Math.Round(TroopCount_Defense.Paladin - tmp_Defense.Paladin);
            Lost_TroopCount_Defense.Noble = Math.Round(TroopCount_Defense.Noble - tmp_Defense.Noble);
            Lost_TroopCount_Defense.Militia = Math.Round(TroopCount_Defense.Militia - tmp_Defense.Militia);
            
            //TroopCount_Offense

            Simulator_Results nForm = new Simulator_Results(TroopCount_Offense, Lost_TroopCount_Offense, TroopCount_Defense, Lost_TroopCount_Defense);
            nForm.Show();
        }

        private void btnSetBuildingsDefense_Click(object sender, EventArgs e) {
            VillageBuild nForm = new VillageBuild(this);
            nForm.VillageBuild_Defense_Class = VillageBuild_Defense;
            nForm.BuildingList = Building;
            nForm.BuildingIDList = BuildingIDs;
            nForm.VarType = "Defense";
            nForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void CalculateOffensiveStats(object sender, EventArgs e) {
            int ci = 0;
            TextBox[] TXTARR = new TextBox[15];
            TXTARR[ci++] = txtSpear;
            TXTARR[ci++] = txtSword;
            TXTARR[ci++] = txtAxe;
            if (UnitID.Archer != -1)
                TXTARR[ci++] = txtArcher;
            TXTARR[ci++] = txtScout;
            TXTARR[ci++] = txtLC;
            if (UnitID.Mounted_Archer != -1)
                TXTARR[ci++] = txtMA;
            TXTARR[ci++] = txtHC;
            TXTARR[ci++] = txtRam;
            TXTARR[ci++] = txtCat;
            TXTARR[ci++] = txtPaladin;
            TXTARR[ci++] = txtNoble;

            int General_Offense = 0;
            int Cavalry_Offense = 0;
            int Archer_Offense = 0;
            int Farm_Usage = 0;

            for (int i = 0; i < ci; i++) {
                int n;
                if (int.TryParse(TXTARR[i].Text, out n)) {
                    int TroopCount = Int32.Parse(TXTARR[i].Text);
                    if (TroopCount < 0)
                        TroopCount = 0;
                    if ((i == UnitID.Paladin) && (TroopCount > 1))
                        TroopCount = 1;

                    TXTARR[i].Text = TroopCount.ToString();

                    Farm_Usage += (int)Math.Round((double)(Unit[i].pop * TroopCount));
                    if ((i == UnitID.Spearman) || (i == UnitID.Swordsman) || (i == UnitID.Axeman) || (i == UnitID.Paladin) || (i == UnitID.Noble))
                        General_Offense += (int)Math.Round((double)(Unit[i].attack * TroopCount));
                    else if ((i == UnitID.Archer) || (i == UnitID.Mounted_Archer))
                        Archer_Offense += (int)Math.Round((double)(Unit[i].attack * TroopCount));
                    else if ((i == UnitID.Scout) || (i == UnitID.Light_Cavalry) || (i == UnitID.Heavy_Cavalry))
                        Cavalry_Offense += (int)Math.Round((double)(Unit[i].attack * TroopCount));
                    
                } else {
                    TXTARR[i].Text = "0";
                }
            }

            txtFarm.Text = (Farm_Usage + minUsedPop_Offense).ToString();

            txtGeneralOff.Text = General_Offense.ToString();
            txtCavalryOff.Text = Cavalry_Offense.ToString();
            txtArcherOff.Text = Archer_Offense.ToString();
            txtOffense.Text = (General_Offense + Cavalry_Offense + Archer_Offense).ToString();
        }

        private void CalculateDefensiveStats(object sender, EventArgs e) {
            int ci = 0;
            TextBox[] TXTARR = new TextBox[15];
            TXTARR[ci++] = txtSpearDefense;
            TXTARR[ci++] = txtSwordDefense;
            TXTARR[ci++] = txtAxeDefense;
            if (UnitID.Archer != -1)
                TXTARR[ci++] = txtArcherDefense;
            TXTARR[ci++] = txtScoutDefense;
            TXTARR[ci++] = txtLCDefense;
            if (UnitID.Mounted_Archer != -1)
                TXTARR[ci++] = txtMADefense;
            TXTARR[ci++] = txtHCDefense;
            TXTARR[ci++] = txtRamDefense;
            TXTARR[ci++] = txtCatDefense;
            TXTARR[ci++] = txtPaladinDefense;
            TXTARR[ci++] = txtNobleDefense;
            TXTARR[ci++] = txtMilitia;

            int General_Defense = 0;
            int Cavalry_Defense = 0;
            int Archer_Defense = 0;
            int Farm_Usage = 0;

            for (int i = 0; i < ci; i++) {
                int n;
                if (int.TryParse(TXTARR[i].Text, out n)) {
                    int TroopCount = Int32.Parse(TXTARR[i].Text);
                    if (TroopCount < 0)
                        TroopCount = 0;

                    TXTARR[i].Text = TroopCount.ToString();

                    Farm_Usage += (int)Math.Round((double)(Unit[i].pop * TroopCount));

                    General_Defense += (int)Math.Round((double)(Unit[i].defense * TroopCount));
                    Archer_Defense += (int)Math.Round((double)(Unit[i].defense_archer * TroopCount));
                    Cavalry_Defense += (int)Math.Round((double)(Unit[i].defense_cavalry * TroopCount));
                } else {
                    TXTARR[i].Text = "0";
                }
            }
            int b;
            if (int.TryParse(txtWall.Text, out b)) {
                int Wall_Level = Int32.Parse(txtWall.Text);
                if (Wall_Level < Building[BuildingIDs.Wall].min_level)
                    Wall_Level = Building[BuildingIDs.Wall].min_level;
                else if (Wall_Level > Building[BuildingIDs.Wall].max_level)
                    Wall_Level = Building[BuildingIDs.Wall].max_level;

                txtWall.Text = Wall_Level.ToString();

                int Wall_Defense_Ratio = (int)Math.Round(Math.Pow(1.037, Wall_Level));
                General_Defense *= Wall_Defense_Ratio;
                Cavalry_Defense *= Wall_Defense_Ratio;
                Archer_Defense *= Wall_Defense_Ratio;

                int Wall_Defense_Basic = Wall_Level * 50;
                General_Defense += Wall_Defense_Basic;
                Cavalry_Defense += Wall_Defense_Basic;
                Archer_Defense += Wall_Defense_Basic;
            } else {
                txtWall.Text = "0";
            }

            //Add on basic village defense... for just... existing
            /*General_Defense += 20;
            Cavalry_Defense += 20;
            Archer_Defense += 20;*/

            txtFarmDefense.Text = (Farm_Usage + minUsedPop_Defense).ToString();

            txtGeneralDef.Text = General_Defense.ToString();
            txtCavalryDef.Text = Cavalry_Defense.ToString();
            txtArcherDef.Text = Archer_Defense.ToString();
            txtDefense.Text = (General_Defense + Cavalry_Defense + Archer_Defense).ToString();
        }

        private void btnImportDefense_Click(object sender, EventArgs e) {
            MessageBox.Show("Sorry, importing is not functional in this version");
        }

        private void btnExportDefense_Click(object sender, EventArgs e) {
            MessageBox.Show("Sorry, exporting is not functional in this version");
        }
    }
}
