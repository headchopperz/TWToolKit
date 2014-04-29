using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Serialization;
using System.IO;

namespace TWToolKit {
    public partial class BuildingGuesser : Form {
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

        public Form1.VillageBuildings VillageBuild_Guess = new Form1.VillageBuildings();

        public BuildingGuesser() {
            InitializeComponent();
        }

        private void BuildingGuesser_Load(object sender, EventArgs e) {
        }

        private void btnOpenVB_Click(object sender, EventArgs e) {
            VillageBuild nForm = new VillageBuild(this);
            nForm.lblUnits.Text = "Check the units you know he has";
            nForm.VarType = "Guessed";
            nForm.VillageBuild_Guess_Class = VillageBuild_Guess;
            nForm.BuildingList = Building;
            nForm.BuildingIDList = BuildingIDs;
            nForm.Show();
        }

        private void btnSelectFile_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML|*.xml";
            saveFileDialog1.Title = "Select The File To Dump Data To";
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.InitialDirectory = "PossibleBuilds/";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "") {
                txtOutputFile.Text = saveFileDialog1.FileName;
            }
        }

        private delegate void SetTextCallback(string text);

        private void SetText(string text) {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtMatches.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            } else {
                this.txtMatches.Text = text;
            }
        }

        private delegate void SetProgressCallback(int percent);

        private void SetPercent(int percent) {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.pgrLoop.InvokeRequired) {
                SetProgressCallback d = new SetProgressCallback(SetPercent);
                this.Invoke(d, new object[] { percent });
            } else {
                this.pgrLoop.Value = percent;
            }
        }

        private delegate void SetWrapupCallback(string text);

        private void Wrapup(string text) {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.btnProcess.InvokeRequired) {
                SetWrapupCallback d = new SetWrapupCallback(SetText);
                this.Invoke(d, new object[] { text });
            } else {
                this.btnProcess.Text = "Process";
                this.btnProcess.Enabled = true;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e) {
            Thread t = new Thread(ProcessStuff);
            t.Start();

            btnProcess.Text = "Processing...";
            btnProcess.Enabled = false;
        }

        private void ProcessStuff() {
            int[] WarehouseLimit = new int[31];
            int[] FarmLimit = new int[31];
            for (int i = 0; i <= 30; i++) {
                WarehouseLimit[i] = (int)Math.Round((double)1000 * Math.Pow(1.2294934, (double)(i - 1)));
                FarmLimit[i] = (int)Math.Round((double)240 * Math.Pow(1.172103, (double)(i - 1)));
            }

            if (VillageBuild_Guess.HQ < Building[BuildingIDs.HQ].min_level)
                VillageBuild_Guess.HQ = Building[BuildingIDs.HQ].min_level;
            if (VillageBuild_Guess.Barracks < Building[BuildingIDs.Barracks].min_level)
                VillageBuild_Guess.Barracks = Building[BuildingIDs.Barracks].min_level;
            if (VillageBuild_Guess.Stable < Building[BuildingIDs.Stable].min_level)
                VillageBuild_Guess.Stable = Building[BuildingIDs.Stable].min_level;
            if (VillageBuild_Guess.Workshop < Building[BuildingIDs.Workshop].min_level)
                VillageBuild_Guess.Workshop = Building[BuildingIDs.Workshop].min_level;

            if (BuildingIDs.Church != -1) {
                if (VillageBuild_Guess.Church < Building[BuildingIDs.Church].min_level)
                    VillageBuild_Guess.Church = Building[BuildingIDs.Church].min_level;
                if (VillageBuild_Guess.Church_f < Building[BuildingIDs.Church_f].min_level)
                    VillageBuild_Guess.Church_f = Building[BuildingIDs.Church_f].min_level;
            }

            if (VillageBuild_Guess.Academy < Building[BuildingIDs.Academy].min_level)
                VillageBuild_Guess.Academy = Building[BuildingIDs.Academy].min_level;
            if (VillageBuild_Guess.Smithy < Building[BuildingIDs.Smithy].min_level)
                VillageBuild_Guess.Smithy = Building[BuildingIDs.Smithy].min_level;
            if (VillageBuild_Guess.Statue < Building[BuildingIDs.Statue].min_level)
                VillageBuild_Guess.Statue = Building[BuildingIDs.Statue].min_level;
            if (VillageBuild_Guess.Market < Building[BuildingIDs.Market].min_level)
                VillageBuild_Guess.Market = Building[BuildingIDs.Market].min_level;
            if (VillageBuild_Guess.Camp < Building[BuildingIDs.Camp].min_level)
                VillageBuild_Guess.Camp = Building[BuildingIDs.Camp].min_level;
            if (VillageBuild_Guess.Pit < Building[BuildingIDs.Pit].min_level)
                VillageBuild_Guess.Pit = Building[BuildingIDs.Pit].min_level;
            if (VillageBuild_Guess.Mine < Building[BuildingIDs.Mine].min_level)
                VillageBuild_Guess.Mine = Building[BuildingIDs.Mine].min_level;
            if (VillageBuild_Guess.Farm < Building[BuildingIDs.Farm].min_level)
                VillageBuild_Guess.Farm = Building[BuildingIDs.Farm].min_level;
            if (VillageBuild_Guess.Warehouse < Building[BuildingIDs.Warehouse].min_level)
                VillageBuild_Guess.Warehouse = Building[BuildingIDs.Warehouse].min_level;
            if (VillageBuild_Guess.Hiding < Building[BuildingIDs.Hiding].min_level)
                VillageBuild_Guess.Hiding = Building[BuildingIDs.Hiding].min_level;
            if (VillageBuild_Guess.Wall < Building[BuildingIDs.Wall].min_level)
                VillageBuild_Guess.Wall = Building[BuildingIDs.Wall].min_level;


            int Points_To_Parse = Int32.Parse(txtPoints.Text);

            string Path = "PossibleBuilds/Points_" + txtPoints.Text + ".xml";
            //Path = txtOutputFile.Text;

            int Count = 0;

            List<Form1.VillageBuildings> Possible_Buildings = new List<Form1.VillageBuildings>();

            System.IO.File.WriteAllText(@Path, string.Empty);

            /*
             * WAREHOUSE
             */
            for (int Warehouse = VillageBuild_Guess.Warehouse; Warehouse <= Building[BuildingIDs.Warehouse].max_level; Warehouse++) {

                SetPercent(Warehouse);

                //Point Check
                int Cur_Points_Warehouse = Building[BuildingIDs.Warehouse].Point_Table[Warehouse];
                if (Cur_Points_Warehouse > Points_To_Parse)
                    break;

                /*
                 * FARM
                 */
                for (int Farm = VillageBuild_Guess.Farm; Farm <= Building[BuildingIDs.Farm].max_level; Farm++) {

                    //Warehouse Check
                    if (Building[BuildingIDs.Farm].Total_Res_Table[Farm] > WarehouseLimit[Warehouse])
                        break;

                    //Point Check
                    int Cur_Points_Farm = Building[BuildingIDs.Farm].Point_Table[Farm] + Cur_Points_Warehouse;
                    if (Cur_Points_Farm > Points_To_Parse)
                        break;


                    /*
                     *  HQ
                     */ 
                    for (int HQ = VillageBuild_Guess.HQ; HQ <= Building[BuildingIDs.HQ].max_level; HQ++) {

                        //Warehouse Check
                        if (Building[BuildingIDs.HQ].Total_Res_Table[HQ] > WarehouseLimit[Warehouse]) 
                            break;

                        //Point Check
                        int Cur_Points_HQ = Building[BuildingIDs.HQ].Point_Table[HQ] + Cur_Points_Farm;
                        if (Cur_Points_HQ > Points_To_Parse)
                            break;

                        //Population Check
                        int Cur_Farm_HQ = Building[BuildingIDs.HQ].Pop_Table[HQ];
                        if (Cur_Farm_HQ > FarmLimit[Farm])
                            break;                        

                        /*
                         * Barracks
                         */
                        //Building Query
                        bool CanBuildBarracks = true;
                        if (HQ < 3)
                            CanBuildBarracks = false;

                        for (int Barracks = VillageBuild_Guess.Barracks; Barracks <= ((CanBuildBarracks) ? Building[BuildingIDs.Barracks].max_level : 0); Barracks++) {

                            //Warehouse Check
                            if (Building[BuildingIDs.Barracks].Total_Res_Table[Barracks] > WarehouseLimit[Warehouse])
                                break;

                            //Point Check
                            int Cur_Points_Barracks = Building[BuildingIDs.Barracks].Point_Table[Barracks] + Cur_Points_HQ;
                            if (Cur_Points_Barracks > Points_To_Parse)
                                break;

                            //Population Check
                            int Cur_Farm_Barracks = Building[BuildingIDs.Barracks].Pop_Table[Barracks] + Cur_Farm_HQ;
                            if (Cur_Farm_Barracks > FarmLimit[Farm])
                                break;

                            /*
                             * Market
                             */ 
                            //Building Query
                            bool CanBuildMarket = true;
                            if ((HQ < 3) || (Warehouse < 2))
                                CanBuildMarket = false;

                            for (int Market = VillageBuild_Guess.Market; Market <= ((CanBuildMarket) ? Building[BuildingIDs.Market].max_level : 0); Market++) {

                                //Warehouse Check
                                if (Building[BuildingIDs.Market].Total_Res_Table[Market] > WarehouseLimit[Warehouse])
                                    break;

                                //Point Check
                                int Cur_Points_Market = Building[BuildingIDs.Market].Point_Table[Market] + Cur_Points_Barracks;
                                if (Cur_Points_Market > Points_To_Parse)
                                    break;

                                //Population Check
                                int Cur_Farm_Market = Building[BuildingIDs.Market].Pop_Table[Market] + Cur_Points_Barracks;
                                if (Cur_Farm_Market > FarmLimit[Farm])
                                    break;

                                /*
                                 * Smithy
                                 */ 
                                //Building Query
                                bool CanBuildSmithy = true;
                                if ((HQ < 5) || (Barracks < 1))
                                    CanBuildSmithy = false;

                                for (int Smithy = VillageBuild_Guess.Smithy; Smithy <= ((CanBuildSmithy) ? Building[BuildingIDs.Smithy].max_level : 0); Smithy++) {

                                    //Warehouse Check
                                    if (Building[BuildingIDs.Smithy].Total_Res_Table[Smithy] > WarehouseLimit[Warehouse])
                                        break;

                                    //Point Check
                                    int Cur_Points_Smithy = Building[BuildingIDs.Smithy].Point_Table[Smithy] + Cur_Points_Market;
                                    if (Cur_Points_Smithy > Points_To_Parse)
                                        break;

                                    //Population Check
                                    int Cur_Farm_Smithy = Building[BuildingIDs.Smithy].Pop_Table[Smithy] + Cur_Farm_Market;
                                    if (Cur_Farm_Smithy > FarmLimit[Farm])
                                        break;

                                    /*
                                     * Academy
                                     */ 
                                    //Building Query
                                    bool CanBuildAcademy = true;
                                    if ((HQ < 20) || (Market < 10) || (Smithy < 20))
                                        CanBuildAcademy = false;

                                    for (int Academy = VillageBuild_Guess.Academy; Academy <= ((CanBuildAcademy) ? Building[BuildingIDs.Academy].max_level : 0); Academy++) {

                                        //Warehouse Check
                                        if (Building[BuildingIDs.Academy].Total_Res_Table[Academy] > WarehouseLimit[Warehouse])
                                            break;

                                        //Point Check
                                        int Cur_Points_Academy = Building[BuildingIDs.Academy].Point_Table[Academy] + Cur_Points_Smithy;
                                        if (Cur_Points_Academy > Points_To_Parse)
                                            break;

                                        //Population Check
                                        int Cur_Farm_Academy = Building[BuildingIDs.Academy].Pop_Table[Academy] + Cur_Farm_Smithy;
                                        if (Cur_Farm_Academy > FarmLimit[Farm])
                                            break;

                                        /*
                                         * Stable
                                         */
                                        //Building Query
                                        bool CanBuildStables = true;
                                        if ((HQ < 10) || (Barracks < 5) || (Smithy < 5))
                                            CanBuildStables = false;

                                        for (int Stables = VillageBuild_Guess.Stable; Stables <= ((CanBuildStables) ? Building[BuildingIDs.Stable].max_level : 0); Stables++) {
                                            
                                            //Warehouse Check
                                            if (Building[BuildingIDs.Stable].Total_Res_Table[Stables] > WarehouseLimit[Warehouse])
                                                break;

                                            //Point Check
                                            int Cur_Points_Stable = Building[BuildingIDs.Stable].Point_Table[Stables] + Cur_Points_Academy;
                                            if (Cur_Points_Stable > Points_To_Parse)
                                                break;

                                            //Population Check
                                            int Cur_Farm_Stable = Building[BuildingIDs.Stable].Pop_Table[Stables] + Cur_Farm_Academy;
                                            if (Cur_Farm_Stable > FarmLimit[Farm])
                                                break;
                                            
                                            /*
                                             * Workshop
                                             */
                                            //Building Check
                                            bool CanBuildWorkshop = true;
                                            if ((HQ < 10) || (Smithy < 10))
                                                CanBuildWorkshop = false;

                                            for (int Workshop = VillageBuild_Guess.Workshop; Workshop <= ((CanBuildWorkshop) ? Building[BuildingIDs.Workshop].max_level : 0); Workshop++) {

                                                //Building Check
                                                if (Building[BuildingIDs.Workshop].Total_Res_Table[Workshop] > WarehouseLimit[Warehouse])
                                                    break;

                                                //Point Check
                                                int Cur_Points_Workshop = Building[BuildingIDs.Workshop].Point_Table[Workshop] + Cur_Points_Stable;
                                                if (Cur_Points_Workshop > Points_To_Parse)
                                                    break;

                                                //Population Check
                                                int Cur_Farm_Workshop = Building[BuildingIDs.Workshop].Pop_Table[Workshop] + Cur_Farm_Stable;
                                                if (Cur_Farm_Workshop > FarmLimit[Farm])
                                                    break;

                                                /*
                                                 * Statue
                                                 */ 
                                                for (int Statue = VillageBuild_Guess.Statue; Statue <= Building[BuildingIDs.Statue].max_level; Statue++) {
                                                    
                                                    //Building Check
                                                    if (Building[BuildingIDs.Statue].Total_Res_Table[Statue] > WarehouseLimit[Warehouse])
                                                        break;

                                                    //Point Check
                                                    int Cur_Points_Statue = Building[BuildingIDs.Statue].Point_Table[Statue] + Cur_Points_Workshop;
                                                    if (Cur_Points_Statue > Points_To_Parse)
                                                        break;

                                                    //Population Check
                                                    int Cur_Farm_Statue = Building[BuildingIDs.Statue].Pop_Table[Statue] + Cur_Farm_Workshop;
                                                    if (Cur_Farm_Statue > FarmLimit[Farm])
                                                        break;

                                                    /*
                                                     * Camp
                                                     */ 
                                                    for (int TimberCamp = VillageBuild_Guess.Camp; TimberCamp <= Building[BuildingIDs.Camp].max_level; TimberCamp++) {

                                                        //Building Check
                                                        if (Building[BuildingIDs.Camp].Total_Res_Table[TimberCamp] > WarehouseLimit[Warehouse])
                                                            break;

                                                        //Point Check
                                                        int Cur_Points_Camp = Building[BuildingIDs.Camp].Point_Table[TimberCamp] + Cur_Points_Statue;
                                                        if (Cur_Points_Camp > Points_To_Parse)
                                                            break;

                                                        //Population Check
                                                        int Cur_Farm_Camp = Building[BuildingIDs.Camp].Pop_Table[TimberCamp] + Cur_Farm_Statue;
                                                        if (Cur_Farm_Camp > FarmLimit[Farm])
                                                            break;

                                                        /*
                                                         * Pit
                                                         */ 
                                                        for (int ClayPit = VillageBuild_Guess.Pit; ClayPit <= Building[BuildingIDs.Pit].max_level; ClayPit++) {

                                                            //Warehouse Check
                                                            if (Building[BuildingIDs.Pit].Total_Res_Table[ClayPit] > WarehouseLimit[Warehouse])
                                                                break;

                                                            //Point Check
                                                            int Cur_Points_Pit = Building[BuildingIDs.Pit].Point_Table[ClayPit] + Cur_Points_Camp;
                                                            if (Cur_Points_Pit > Points_To_Parse)
                                                                break;

                                                            //Population Check
                                                            int Cur_Farm_Pit = Building[BuildingIDs.Pit].Pop_Table[ClayPit] + Cur_Farm_Camp;
                                                            if (Cur_Farm_Pit > FarmLimit[Farm])
                                                                break;

                                                            /*
                                                             * Mine
                                                             */ 
                                                            for (int IronMine = VillageBuild_Guess.Mine; IronMine <= Building[BuildingIDs.Mine].max_level; IronMine++) {

                                                                //Warehouse Check
                                                                if (Building[BuildingIDs.Mine].Total_Res_Table[IronMine] > WarehouseLimit[Warehouse])
                                                                    break;

                                                                //Point Check
                                                                int Cur_Points_Mine = Building[BuildingIDs.Mine].Point_Table[IronMine] + Cur_Points_Pit;
                                                                if (Cur_Points_Mine > Points_To_Parse)
                                                                    break;

                                                                //Population Check
                                                                int Cur_Farm_Mine = Building[BuildingIDs.Mine].Pop_Table[IronMine] + Cur_Farm_Pit;
                                                                if (Cur_Farm_Mine > FarmLimit[Farm])
                                                                    break;

                                                                /*
                                                                 * Hiding
                                                                 */ 
                                                                for (int HidingPlace = VillageBuild_Guess.Hiding; HidingPlace <= Building[BuildingIDs.Hiding].max_level; HidingPlace++) {

                                                                    //Warehouse Check
                                                                    if (Building[BuildingIDs.Hiding].Total_Res_Table[HidingPlace] > WarehouseLimit[Warehouse])
                                                                        break;

                                                                    //Point Check
                                                                    int Cur_Points_Hiding = Building[BuildingIDs.Hiding].Point_Table[HidingPlace] + Cur_Points_Mine;
                                                                    if (Cur_Points_Hiding > Points_To_Parse)
                                                                        break;

                                                                    //Population Check
                                                                    int Cur_Farm_Hiding = Building[BuildingIDs.Hiding].Pop_Table[HidingPlace] + Cur_Farm_Mine;
                                                                    if (Cur_Farm_Hiding > FarmLimit[Farm])
                                                                        break;

                                                                    /*
                                                                     * Wall
                                                                     */
                                                                    //Building Check
                                                                    bool CanBuildWalls = true;
                                                                    if (Barracks < 1)
                                                                        CanBuildWalls = false;

                                                                    for (int Wall = VillageBuild_Guess.Wall; Wall <= ((CanBuildWalls) ? Building[BuildingIDs.Wall].max_level : 0); Wall++) {

                                                                        //Warehouse Check
                                                                        if (Building[BuildingIDs.Wall].Total_Res_Table[Wall] > WarehouseLimit[Warehouse])
                                                                            break;

                                                                        //Point Check
                                                                        int Cur_Points_Wall = Building[BuildingIDs.Wall].Point_Table[Wall] + Cur_Points_Hiding;
                                                                        if (Cur_Points_Wall > Points_To_Parse)
                                                                            break;

                                                                        //Population Check
                                                                        int Cur_Farm_Wall = Building[BuildingIDs.Wall].Pop_Table[Wall] + Cur_Farm_Hiding;
                                                                        if (Cur_Farm_Wall > FarmLimit[Farm])
                                                                            break;

                                                                        if (Cur_Farm_Wall == Points_To_Parse) {
                                                                            SetText((Count++).ToString());

                                                                            Form1.VillageBuildings Guessed_Build = new Form1.VillageBuildings();
                                                                            Guessed_Build.Academy = Academy;
                                                                            Guessed_Build.Barracks = Barracks;
                                                                            Guessed_Build.Camp = TimberCamp;
                                                                            Guessed_Build.Farm = Farm;
                                                                            Guessed_Build.Hiding = HidingPlace;
                                                                            Guessed_Build.HQ = HQ;
                                                                            Guessed_Build.Market = Market;
                                                                            Guessed_Build.Mine = IronMine;
                                                                            Guessed_Build.Pit = ClayPit;
                                                                            Guessed_Build.Smithy = Smithy;
                                                                            Guessed_Build.Stable = Stables;
                                                                            Guessed_Build.Statue = Statue;
                                                                            Guessed_Build.Wall = Wall;
                                                                            Guessed_Build.Warehouse = Warehouse;
                                                                            Guessed_Build.Workshop = Workshop;

                                                                            Possible_Buildings.Add(Guessed_Build);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            System.IO.FileStream fs =
                new FileStream(@Path, FileMode.Create);


            XmlSerializer mySerializer = new XmlSerializer(typeof(Form1.VillageBuildings));
            mySerializer.Serialize(fs, Possible_Buildings);

            fs.Close();

            SetPercent(31);
        }
    }
}
