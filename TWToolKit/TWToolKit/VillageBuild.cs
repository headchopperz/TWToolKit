using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace TWToolKit {
    public partial class VillageBuild : Form {
        Form1.VillageBuildings VillageBuild_Defense; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public Form1.VillageBuildings VillageBuild_Defense_Class { set { VillageBuild_Defense = value; } }

        Form1.VillageBuildings VillageBuild_Offense; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public Form1.VillageBuildings VillageBuild_Offense_Class { set { VillageBuild_Offense = value; } }

        Form1.VillageBuildings VillageBuild_Guess; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public Form1.VillageBuildings VillageBuild_Guess_Class { set { VillageBuild_Guess = value; } }

        List<Form1.Buildings> Building; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public List<Form1.Buildings> BuildingList { set { Building = value; } }

        Form1.BuildingIDs BuildingIDs; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public Form1.BuildingIDs BuildingIDList { set { BuildingIDs = value; } }

        string Type; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public string VarType { set { Type = value; } }

        VillageDesigner Parent_VD_Form = null;
        BuildingGuesser Parent_BG_Form = null;

        public VillageBuild(VillageDesigner Form) {
            Parent_VD_Form = Form;
            InitializeComponent();
        }

        public VillageBuild(BuildingGuesser Form) {
            Parent_BG_Form = Form;
            InitializeComponent();


        }
        private void txtChange(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.') {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1) {
                e.Handled = true;
            }
        }

        private void chkSpear_CheckedChanged(object sender, EventArgs e) {

        }

        private void btnReturn_Click(object sender, EventArgs e) {
            Form1.VillageBuildings tmp_Build = new Form1.VillageBuildings();
            if (Type == "Offense")
                tmp_Build = VillageBuild_Offense;
            else if (Type == "Defense")
                tmp_Build = VillageBuild_Defense;
            else if (Type == "Guessed")
                tmp_Build = VillageBuild_Guess;

            tmp_Build.HQ = Int32.Parse(txtHQ.Text);
            tmp_Build.Barracks = Int32.Parse(txtBarracks.Text);
            tmp_Build.Stable = Int32.Parse(txtStable.Text);
            tmp_Build.Workshop = Int32.Parse(txtWorkshop.Text);
            tmp_Build.Church = Int32.Parse(txtChurch.Text);
            tmp_Build.Church_f = Int32.Parse(txtChurch_F.Text);
            tmp_Build.Academy = Int32.Parse(txtAcademy.Text);
            tmp_Build.Smithy = Int32.Parse(txtSmithy.Text);
            tmp_Build.Rally = Int32.Parse(txtRally.Text);
            tmp_Build.Statue = Int32.Parse(txtStatue.Text);
            tmp_Build.Market = Int32.Parse(txtMarket.Text);
            tmp_Build.Camp = Int32.Parse(txtWood.Text);
            tmp_Build.Pit = Int32.Parse(txtClay.Text);
            tmp_Build.Mine = Int32.Parse(txtIron.Text);
            tmp_Build.Farm = Int32.Parse(txtFarm.Text);
            tmp_Build.Warehouse = Int32.Parse(txtStorage.Text);
            tmp_Build.Hiding = Int32.Parse(txtHiding.Text);
            tmp_Build.Wall = Int32.Parse(txtWall.Text);

            tmp_Build.Max_HQ = Int32.Parse(txtHQMax.Text);
            tmp_Build.Max_Barracks = Int32.Parse(txtBarracksMax.Text);
            tmp_Build.Max_Stable = Int32.Parse(txtStableMax.Text);
            tmp_Build.Max_Workshop = Int32.Parse(txtWorkshopMax.Text);
            tmp_Build.Max_Church = Int32.Parse(txtChurchMax.Text);
            tmp_Build.Max_Church_f = Int32.Parse(txtChurch_FMax.Text);
            tmp_Build.Max_Academy = Int32.Parse(txtAcademyMax.Text);
            tmp_Build.Max_Smithy = Int32.Parse(txtSmithyMax.Text);
            tmp_Build.Max_Rally = Int32.Parse(txtRallyMax.Text);
            tmp_Build.Max_Statue = Int32.Parse(txtStatueMax.Text);
            tmp_Build.Max_Market = Int32.Parse(txtMarketMax.Text);
            tmp_Build.Max_Camp = Int32.Parse(txtWoodMax.Text);
            tmp_Build.Max_Pit = Int32.Parse(txtClayMax.Text);
            tmp_Build.Max_Mine = Int32.Parse(txtIronMax.Text);
            tmp_Build.Max_Farm = Int32.Parse(txtFarmMax.Text);
            tmp_Build.Max_Warehouse = Int32.Parse(txtStorageMax.Text);
            tmp_Build.Max_Hiding = Int32.Parse(txtHidingMax.Text);
            tmp_Build.Max_Wall = Int32.Parse(txtWallMax.Text);


            if (Parent_VD_Form != null) {
                Parent_VD_Form.parseBuildingData(Type);
            } else if (Parent_BG_Form != null) {
                //Parent_BG_Form.parseBuildingData();
            }

            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e) {
            Form1.VillageBuildings tmp_Build = new Form1.VillageBuildings();
            if (Type == "Offense")
                tmp_Build = VillageBuild_Offense;
            else if (Type == "Defense")
                tmp_Build = VillageBuild_Defense;
            else if (Type == "Guessed")
                tmp_Build = VillageBuild_Guess;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML|*.xml";
            openFileDialog1.Title = "Load Your Village Build";
            openFileDialog1.InitialDirectory = "Village_Builds/";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Form1.VillageBuildings));

                System.IO.StreamReader file = new System.IO.StreamReader(
                    @openFileDialog1.FileName);

                tmp_Build = (Form1.VillageBuildings)reader.Deserialize(file);

                txtHQ.Text = (tmp_Build.HQ != -1) ? tmp_Build.HQ.ToString() : "0";
                txtBarracks.Text = (tmp_Build.Barracks != -1) ? tmp_Build.Barracks.ToString() : "0";
                txtStable.Text = (tmp_Build.Stable != -1) ? tmp_Build.Stable.ToString() : "0";
                txtWorkshop.Text = (tmp_Build.Workshop != -1) ? tmp_Build.Workshop.ToString() : "0";
                txtChurch.Text = (tmp_Build.Church != -1) ? tmp_Build.Church.ToString() : "0";
                txtChurch_F.Text = (tmp_Build.Church_f != -1) ? tmp_Build.Church_f.ToString() : "0";
                txtAcademy.Text = (tmp_Build.Academy != -1) ? tmp_Build.Academy.ToString() : "0";
                txtSmithy.Text = (tmp_Build.Smithy != -1) ? tmp_Build.Smithy.ToString() : "0";
                txtRally.Text = (tmp_Build.Rally != -1) ? tmp_Build.Rally.ToString() : "0";
                txtStatue.Text = (tmp_Build.Market != -1) ? tmp_Build.Market.ToString() : "0";
                txtWood.Text = (tmp_Build.Camp != -1) ? tmp_Build.Camp.ToString() : "0";
                txtClay.Text = (tmp_Build.Pit != -1) ? tmp_Build.Pit.ToString() : "0";
                txtIron.Text = (tmp_Build.Mine != -1) ? tmp_Build.Mine.ToString() : "0";
                txtFarm.Text = (tmp_Build.Farm != -1) ? tmp_Build.Farm.ToString() : "0";
                txtStorage.Text = (tmp_Build.Warehouse != -1) ? tmp_Build.Warehouse.ToString() : "0";
                txtHiding.Text = (tmp_Build.Hiding != -1) ? tmp_Build.Hiding.ToString() : "0";
                txtWall.Text = (tmp_Build.Wall != -1) ? tmp_Build.Wall.ToString() : "0";
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            Form1.VillageBuildings tmp_Build = new Form1.VillageBuildings();
            if (Type == "Offense")
                tmp_Build = VillageBuild_Offense;
            else if (Type == "Defense")
                tmp_Build = VillageBuild_Defense;
            else if (Type == "Guessed")
                tmp_Build = VillageBuild_Guess;

            tmp_Build.HQ = Int32.Parse(txtHQ.Text);
            tmp_Build.Barracks = Int32.Parse(txtBarracks.Text);
            tmp_Build.Stable = Int32.Parse(txtStable.Text);
            tmp_Build.Workshop = Int32.Parse(txtWorkshop.Text);
            tmp_Build.Church = Int32.Parse(txtChurch.Text);
            tmp_Build.Church_f = Int32.Parse(txtChurch_F.Text);
            tmp_Build.Academy = Int32.Parse(txtAcademy.Text);
            tmp_Build.Smithy = Int32.Parse(txtSmithy.Text);
            tmp_Build.Rally = Int32.Parse(txtRally.Text);
            tmp_Build.Statue = Int32.Parse(txtStatue.Text);
            tmp_Build.Market = Int32.Parse(txtMarket.Text);
            tmp_Build.Camp = Int32.Parse(txtWood.Text);
            tmp_Build.Pit = Int32.Parse(txtClay.Text);
            tmp_Build.Mine = Int32.Parse(txtIron.Text);
            tmp_Build.Farm = Int32.Parse(txtFarm.Text);
            tmp_Build.Warehouse = Int32.Parse(txtStorage.Text);
            tmp_Build.Hiding = Int32.Parse(txtHiding.Text);
            tmp_Build.Wall = Int32.Parse(txtWall.Text);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML|*.xml";
            saveFileDialog1.Title = "Save Your Village Build";
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.InitialDirectory = "Village_Builds/";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "") {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();


                XmlSerializer mySerializer = new XmlSerializer(typeof(Form1.VillageBuildings));
                mySerializer.Serialize(fs, tmp_Build);

                fs.Close();
            }

        }

        private void VillageBuild_Load(object sender, EventArgs e) {
            Form1.VillageBuildings tmp_Build = new Form1.VillageBuildings();
            if (Type == "Offense")
                tmp_Build = VillageBuild_Offense;
            else if (Type == "Defense")
                tmp_Build = VillageBuild_Defense;
            else if (Type == "Guessed")
                tmp_Build = VillageBuild_Guess;

            txtHQ.Text = tmp_Build.HQ.ToString();
            txtBarracks.Text = tmp_Build.Barracks.ToString();
            txtStable.Text = tmp_Build.Stable.ToString();
            txtWorkshop.Text = tmp_Build.Workshop.ToString();
            txtChurch.Text = tmp_Build.Church.ToString();
            txtChurch_F.Text = tmp_Build.Church_f.ToString();
            txtAcademy.Text = tmp_Build.Academy.ToString();
            txtSmithy.Text = tmp_Build.Smithy.ToString();
            txtRally.Text = tmp_Build.Rally.ToString();
            txtStatue.Text = tmp_Build.Statue.ToString();
            txtMarket.Text = tmp_Build.Market.ToString();
            txtWood.Text = tmp_Build.Camp.ToString();
            txtClay.Text = tmp_Build.Pit.ToString();
            txtIron.Text = tmp_Build.Mine.ToString();
            txtFarm.Text = tmp_Build.Farm.ToString();
            txtStorage.Text = tmp_Build.Warehouse.ToString();
            txtHiding.Text = tmp_Build.Hiding.ToString();
            txtWall.Text = tmp_Build.Wall.ToString();

            txtHQ_TextChanged(null, null);
            txtBarracks_TextChanged(null, null);
            txtStable_TextChanged(null, null);
            txtWorkshop_TextChanged(null, null);
            txtChurch_TextChanged(null, null);
            txtChurch_F_TextChanged(null, null);
            txtAcademy_TextChanged(null, null);
            txtSmithy_TextChanged(null, null);
            txtRally_TextChanged(null, null);
            txtStatue_TextChanged(null, null);
            txtWood_TextChanged(null, null);
            txtClay_TextChanged(null, null);
            txtIron_TextChanged(null, null);
            txtFarm_TextChanged(null, null);
            txtStorage_TextChanged(null, null);
            txtHiding_TextChanged(null, null);
            txtWall_TextChanged(null, null);
        }

        private void txtHQ_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtHQ.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtHQ.Text);
                if (BuildingLevel > Building[BuildingIDs.HQ].max_level)
                    BuildingLevel = Building[BuildingIDs.HQ].max_level;
                else if (BuildingLevel < Building[BuildingIDs.HQ].min_level)
                        BuildingLevel = Building[BuildingIDs.HQ].min_level;
                txtHQ.Text = BuildingLevel.ToString();
            } else {
                txtHQ.Text = "0";
            }
        }

        private void txtBarracks_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtBarracks.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtBarracks.Text);
                if (BuildingLevel > Building[BuildingIDs.Barracks].max_level)
                    BuildingLevel = Building[BuildingIDs.Barracks].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Barracks].min_level)
                    BuildingLevel = Building[BuildingIDs.Barracks].min_level;
                txtBarracks.Text = BuildingLevel.ToString();

                if (minLevels.Checked) {
                    if (BuildingLevel > 0) {
                        if (Int32.Parse(txtHQ.Text) < 3)
                            txtHQ.Text = "3";
                    }
                }
            } else {
                txtBarracks.Text = "0";
            }
        }

        private void txtStable_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtStable.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtStable.Text);
                if (BuildingLevel > Building[BuildingIDs.Stable].max_level)
                    BuildingLevel = Building[BuildingIDs.Stable].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Stable].min_level)
                    BuildingLevel = Building[BuildingIDs.Stable].min_level;
                txtStable.Text = BuildingLevel.ToString();

                if (minLevels.Checked) {
                    if (BuildingLevel > 0) {
                        if (Int32.Parse(txtSmithy.Text) < 5)
                            txtSmithy.Text = "5";
                        if (Int32.Parse(txtBarracks.Text) < 5)
                            txtBarracks.Text = "5";
                        if (Int32.Parse(txtHQ.Text) < 10)
                            txtHQ.Text = "10";
                    }
                }
            } else {
                txtStable.Text = "0";
            }
        }

        private void txtWorkshop_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtWorkshop.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtWorkshop.Text);
                if (BuildingLevel > Building[BuildingIDs.Workshop].max_level)
                    BuildingLevel = Building[BuildingIDs.Workshop].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Workshop].min_level)
                    BuildingLevel = Building[BuildingIDs.Workshop].min_level;
                txtWorkshop.Text = BuildingLevel.ToString();

                if (minLevels.Checked) {
                    if (BuildingLevel > 0) {
                        if (Int32.Parse(txtSmithy.Text) < 10)
                            txtSmithy.Text = "10";
                        if (Int32.Parse(txtHQ.Text) < 10)
                            txtHQ.Text = "10";
                    }
                }
            } else {
                txtWorkshop.Text = "0";
            }
        }

        private void txtChurch_TextChanged(object sender, EventArgs e) {
            if (BuildingIDs.Church != -1) {
                int n;
                if (int.TryParse(txtChurch.Text, out n)) {
                    int BuildingLevel = Int32.Parse(txtChurch.Text);
                    if (BuildingLevel > Building[BuildingIDs.Church].max_level)
                        BuildingLevel = Building[BuildingIDs.Church].max_level;
                    else if (BuildingLevel < Building[BuildingIDs.Church].min_level)
                        BuildingLevel = Building[BuildingIDs.Church].min_level;
                    txtChurch.Text = BuildingLevel.ToString();

                    if (minLevels.Checked) {
                        if (BuildingLevel > 0) {
                            if (Int32.Parse(txtFarm.Text) < 5)
                                txtFarm.Text = "5";
                            if (Int32.Parse(txtHQ.Text) < 5)
                                txtHQ.Text = "5";
                        }
                    }
                } else {
                    txtChurch.Text = "0";
                }
            } else
                txtChurch.Enabled = false;
        }

        private void txtChurch_F_TextChanged(object sender, EventArgs e) {
            if (BuildingIDs.Church_f != -1) {
                int n;
                if (int.TryParse(txtChurch_F.Text, out n)) {
                    int BuildingLevel = Int32.Parse(txtChurch_F.Text);
                    if (BuildingLevel > Building[BuildingIDs.Church_f].max_level)
                        BuildingLevel = Building[BuildingIDs.Church_f].max_level;
                    else if (BuildingLevel < Building[BuildingIDs.Church_f].min_level)
                        BuildingLevel = Building[BuildingIDs.Church_f].min_level;
                    txtChurch_F.Text = BuildingLevel.ToString();
                } else {
                    txtChurch_F.Text = "0";
                }
            } else
                txtChurch_F.Enabled = false;
        }

        private void txtAcademy_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtAcademy.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtAcademy.Text);
                if (BuildingLevel > Building[BuildingIDs.Academy].max_level)
                    BuildingLevel = Building[BuildingIDs.Academy].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Academy].min_level)
                    BuildingLevel = Building[BuildingIDs.Academy].min_level;
                txtAcademy.Text = BuildingLevel.ToString();

                if (minLevels.Checked) {
                    if (BuildingLevel > 0) {
                        if (Int32.Parse(txtSmithy.Text) < 20)
                            txtSmithy.Text = "20";
                        if (Int32.Parse(txtMarket.Text) < 10)
                            txtMarket.Text = "10";
                        if (Int32.Parse(txtHQ.Text) < 20)
                            txtHQ.Text = "20";
                    }
                }
            } else {
                txtAcademy.Text = "0";
            }
        }

        private void txtSmithy_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtSmithy.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtSmithy.Text);
                if (BuildingLevel > Building[BuildingIDs.Smithy].max_level)
                    BuildingLevel = Building[BuildingIDs.Smithy].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Smithy].min_level)
                    BuildingLevel = Building[BuildingIDs.Smithy].min_level;
                txtSmithy.Text = BuildingLevel.ToString();

                if (minLevels.Checked) {
                    if (BuildingLevel > 0) {
                        if (Int32.Parse(txtHQ.Text) < 5)
                            txtHQ.Text = "5";
                        if (Int32.Parse(txtBarracks.Text) < 1)
                            txtBarracks.Text = "1";
                    }
                }
            } else {
                txtSmithy.Text = "0";
            }
        }

        private void txtRally_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtRally.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtRally.Text);
                if (BuildingLevel > Building[BuildingIDs.Rally].max_level)
                    BuildingLevel = Building[BuildingIDs.Rally].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Rally].min_level)
                    BuildingLevel = Building[BuildingIDs.Rally].min_level;
                txtRally.Text = BuildingLevel.ToString();
            } else {
                txtRally.Text = "0";
            }
        }

        private void txtStatue_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtStatue.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtStatue.Text);
                if (BuildingLevel > Building[BuildingIDs.Statue].max_level)
                    BuildingLevel = Building[BuildingIDs.Statue].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Statue].min_level)
                    BuildingLevel = Building[BuildingIDs.Statue].min_level;
                txtStatue.Text = BuildingLevel.ToString();
            } else {
                txtStatue.Text = "0";
            }
        }

        private void txtMarket_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtMarket.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtMarket.Text);
                if (BuildingLevel > Building[BuildingIDs.Market].max_level)
                    BuildingLevel = Building[BuildingIDs.Market].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Market].min_level)
                    BuildingLevel = Building[BuildingIDs.Market].min_level;
                txtMarket.Text = BuildingLevel.ToString();

                if (minLevels.Checked) {
                    if (BuildingLevel > 0) {
                        if (Int32.Parse(txtStorage.Text) < 2)
                            txtStorage.Text = "2";
                        if (Int32.Parse(txtHQ.Text) < 3)
                            txtHQ.Text = "3";
                    }
                }
            } else {
                txtMarket.Text = "0";
            }
        }

        private void txtWood_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtWood.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtWood.Text);
                if (BuildingLevel > Building[BuildingIDs.Camp].max_level)
                    BuildingLevel = Building[BuildingIDs.Camp].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Camp].min_level)
                    BuildingLevel = Building[BuildingIDs.Camp].min_level;
                txtWood.Text = BuildingLevel.ToString();
            } else {
                txtWood.Text = "0";
            }
        }

        private void txtClay_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtClay.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtClay.Text);
                if (BuildingLevel > Building[BuildingIDs.Pit].max_level)
                    BuildingLevel = Building[BuildingIDs.Pit].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Pit].min_level)
                    BuildingLevel = Building[BuildingIDs.Pit].min_level;
                txtClay.Text = BuildingLevel.ToString();
            } else {
                txtClay.Text = "0";
            }
        }

        private void txtIron_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtIron.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtIron.Text);
                if (BuildingLevel > Building[BuildingIDs.Mine].max_level)
                    BuildingLevel = Building[BuildingIDs.Mine].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Mine].min_level)
                    BuildingLevel = Building[BuildingIDs.Mine].min_level;
                txtIron.Text = BuildingLevel.ToString();
            } else {
                txtIron.Text = "0";
            }
        }

        private void txtFarm_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtFarm.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtFarm.Text);
                if (BuildingLevel > Building[BuildingIDs.Farm].max_level)
                    BuildingLevel = Building[BuildingIDs.Farm].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Farm].min_level)
                    BuildingLevel = Building[BuildingIDs.Farm].min_level;
                txtFarm.Text = BuildingLevel.ToString();
            } else {
                txtFarm.Text = "0";
            }
        }

        private void txtStorage_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtStorage.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtStorage.Text);
                if (BuildingLevel > Building[BuildingIDs.Warehouse].max_level)
                    BuildingLevel = Building[BuildingIDs.Warehouse].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Warehouse].min_level)
                    BuildingLevel = Building[BuildingIDs.Warehouse].min_level;
                txtStorage.Text = BuildingLevel.ToString();
            } else {
                txtStorage.Text = "0";
            }
        }

        private void txtHiding_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtHiding.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtHiding.Text);
                if (BuildingLevel > Building[BuildingIDs.Hiding].max_level)
                    BuildingLevel = Building[BuildingIDs.Hiding].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Hiding].min_level)
                    BuildingLevel = Building[BuildingIDs.Hiding].min_level;
                txtHiding.Text = BuildingLevel.ToString();
            } else {
                txtHiding.Text = "0";
            }
        }

        private void txtWall_TextChanged(object sender, EventArgs e) {
            int n;
            if (int.TryParse(txtWall.Text, out n)) {
                int BuildingLevel = Int32.Parse(txtWall.Text);
                if (BuildingLevel > Building[BuildingIDs.Wall].max_level)
                    BuildingLevel = Building[BuildingIDs.Wall].max_level;
                else if (BuildingLevel < Building[BuildingIDs.Wall].min_level)
                    BuildingLevel = Building[BuildingIDs.Wall].min_level;
                txtWall.Text = BuildingLevel.ToString();

                if (minLevels.Checked) {
                    if (BuildingLevel > 0) {
                        if (Int32.Parse(txtBarracks.Text) < 1)
                            txtBarracks.Text = "1";
                    }
                }
            } else {
                txtWall.Text = "0";
            }
        }
    }
}
