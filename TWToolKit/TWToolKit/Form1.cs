using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Web;
using System.Net;
using System.IO;
using System.Globalization;
using System.Threading;

namespace TWToolKit
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

        public class WorldSetting
        {
            public double General_speed = -1;
            public double General_unit_speed = -1;
            public double General_morale = -1;

            public int Build_destroy = -1;

            public int Misc_log_losses = -1;
            public int Misc_kill_ranking = -1;
            public int Misc_tutorial = -1;
            public int Misc_trade_cancel_time = -1;
            public int Misc_online_time = -1;

            public int Commands_millis_arrival = -1;
            public int Commands_command_cancel_time = -1;

            public double Newbie_days = -1;
            public int Newbie_ratio_days = -1;
            public int Newbie_ratio = -1;
            public int Newbie_removeNewbieVillages = -1;

            public int Game_base_config = -1;
            public int Game_new_buildtime_formula = -1;
            public int Game_knight = -1;
            public int Game_knight_new_items = -1;
            public int Game_archer = -1;
            public int Game_tech = -1;
            public int Game_spy = -1;
            public int Game_farm_limit = -1;
            public int Game_church = -1;
            public int Game_fake_limit = -1;
            public double Game_barbarian_rise = -1;
            public double Game_barbarian_shrink = -1;
            public double Game_barbarian_max_points = -1;
            public int Game_hauls = -1;
            public int Game_hauls_base = -1;
            public int Game_base_production = -1;
            public int Game_event = -1;
            public int Game_compete_event = -1;

            public int Noble_gold = -1;
            public int Noble_cheap_rebuild = -1;
            public int Noble_simple = -1;
            public int Noble_rise = -1;
            public int Noble_max_dist = -1;
            public int Noble_factor = -1;
            public int Noble_coin_wood = -1;
            public int Noble_coin_stone = -1;
            public int Noble_coin_iron = -1;
            public int Noble_no_barb_conquer = -1;

            public int Ally_wars_enabled = -1;
            public int Ally_no_harm = -1;
            public int Ally_no_other_support = -1;
            public int Ally_allytime_support = -1;
            public int Ally_no_leave = -1;
            public int Ally_no_admin = -1;
            public int Ally_limit = -1;
            public int Ally_fixed_allies = -1;
            public int Ally_diplomacy = -1;
            public int Ally_reservation_manager = -1;
            public int Ally_points_member_count = -1;
            public int Ally_wars_member_requirement = -1;
            public int Ally_wars_points_requirement = -1;
            public int Ally_wars_autoaccept_days = -1;

            public int Coord_map_size = -1;
            public int Coord_func_size = -1;
            public int Coord_empty_villages = -1;
            public int Coord_bonus_villages = -1;
            public int Coord_bonus_new = -1;
            public int Coord_inner = -1;
            public int Coord_select_start = -1;
            public int Coord_village_move_wait = -1;
            public int Coord_noble_restart = -1;
            public int Coord_worldmap = -1;
            public int Coord_legacy_scenery = -1;
            public int Coord_start_villages = -1;

            public int Sitter_allow = -1;

            public int Sleep_active = -1;
            public int Sleep_delay = -1;
            public int Sleep_min = -1;
            public int Sleep_max = -1;
            public int Sleep_min_awake = -1;
            public int Sleep_max_awake = -1;
            public int Sleep_warn_time = -1;

            public int Night_active = -1;
            public int Night_start_hour = -1;
            public int Night_end_hour = -1;
            public int Night_def_factor = -1;

            public int Win_check = -1;
        }

        public WorldSetting Settings = new WorldSetting();

        public class Buildings
        {
            public string name = null;
            public int max_level = -1;
            public int min_level = -1;
            public int wood = -1;
            public int stone = -1;
            public int iron = -1;
            public int pop = -1;
            public double wood_factor = -1;
            public double stone_factor = -1;
            public double iron_factor = -1;
            public double pop_factor = -1;
            public int build_time = -1;
            public double build_time_factor = -1;
            public int[] Pop_Table;
            public int[] Wood_Table;
            public int[] Iron_Table;
            public int[] Clay_Table;
            public int[] Total_Res_Table;
            public int[] Build_Table;
            public int[] Point_Table;
            public int Base_Points;
        }

        public List<Buildings> Building = new List<Buildings>();

        public class BuildingIDs
        {
            public int HQ = -1;
            public int Barracks = -1;
            public int Stable = -1;
            public int Workshop = -1;
            public int Church = -1;
            public int Church_f = -1;
            public int Academy = -1;
            public int Smithy = -1;
            public int Rally = -1;
            public int Statue = -1;
            public int Market = -1;
            public int Camp = -1;
            public int Pit = -1;
            public int Mine = -1;
            public int Farm = -1;
            public int Warehouse = -1;
            public int Hiding = -1;
            public int Wall = -1;
        }

        public BuildingIDs BuildingID = new BuildingIDs();

        public class Units
        {
            public string name = null;
            public int wood = -1;
            public int stone = -1;
            public int iron = -1;
            public int pop = -1;
            public double speed = -1;
            public int attack = -1;
            public int defense = -1;
            public int defense_cavalry = -1;
            public int defense_archer = -1;
            public int carry = -1;
            public int build_time = -1;
        }

        public List<Units> Unit = new List<Units>();

        public class UnitIDs
        {
            public int Spearman = -1;
            public int Swordsman = -1;
            public int Axeman = -1;
            public int Archer = -1;
            public int Scout = -1;
            public int Light_Cavalry = -1;
            public int Mounted_Archer = -1;
            public int Heavy_Cavalry = -1;
            public int Ram = -1;
            public int Catapult = -1;
            public int Paladin = -1;
            public int Noble = -1;
            public int Militia = -1;
        }

        public class VillageBuildings {
            public int HQ = -1;
            public int Barracks = -1;
            public int Stable = -1;
            public int Workshop = -1;
            public int Church = -1;
            public int Church_f = -1;
            public int Academy = -1;
            public int Smithy = -1;
            public int Rally = -1;
            public int Statue = -1;
            public int Market = -1;
            public int Camp = -1;
            public int Pit = -1;
            public int Mine = -1;
            public int Farm = -1;
            public int Warehouse = -1;
            public int Hiding = -1;
            public int Wall = -1;
        }

        public UnitIDs UnitID = new UnitIDs();

        private delegate void SetTextCallback(string text);

        private void AddtoLog(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddtoLog);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtLog.Text = text + this.txtLog.Text;
            }
        }

        private void WrapUp(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(WrapUp);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                lblStatus.Text = "Stats Loaded";
                lblStatus.ForeColor = Color.DarkOliveGreen;

                lblWorldLoaded.Text = "W" + txtWorldID.Text;
                lblWorldLoaded.ForeColor = Color.Blue;

                btnVD.Enabled = true;
                btnBG.Enabled = true;
            }
        }

        private void btnGetStats_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(GetStats);
            t.Start();
        }

        private void GetStats()
        {
            System.IO.Directory.CreateDirectory("Troop_Builds");
            System.IO.Directory.CreateDirectory("Village_Builds");
            System.IO.Directory.CreateDirectory("WorldStats");
            System.IO.Directory.CreateDirectory("PossibleBuilds");

            AddtoLog("Started to gather settings for world " + txtWorldID.Text + "\r\n");

            //XDocument xdoc = XDocument.Load("http://en73.tribalwars.net/interface.php?func=get_config");
            //This now holds the set of all elements named field
            XmlDocument SettingsXML = new XmlDocument();
            SettingsXML.Load("http://en" + txtWorldID.Text + ".tribalwars.net/interface.php?func=get_config");

            Settings.General_speed = double.Parse(SettingsXML.GetElementsByTagName("speed")[0].InnerText.ToString(), CultureInfo.InvariantCulture);
            Settings.General_unit_speed = double.Parse(SettingsXML.GetElementsByTagName("unit_speed")[0].InnerText.ToString(), CultureInfo.InvariantCulture);
            Settings.General_morale = double.Parse(SettingsXML.GetElementsByTagName("moral")[0].InnerText.ToString(), CultureInfo.InvariantCulture);

            Settings.Newbie_days = double.Parse(SettingsXML.GetElementsByTagName("days")[0].InnerText.ToString(), CultureInfo.InvariantCulture);

            Settings.Game_archer = Int32.Parse(SettingsXML.GetElementsByTagName("archer")[0].InnerText.ToString(), CultureInfo.InvariantCulture);
            Settings.Game_tech = Int32.Parse(SettingsXML.GetElementsByTagName("tech")[0].InnerText.ToString(), CultureInfo.InvariantCulture);
            Settings.Game_knight = Int32.Parse(SettingsXML.GetElementsByTagName("knight")[0].InnerText.ToString(), CultureInfo.InvariantCulture);
            Settings.Game_spy = Int32.Parse(SettingsXML.GetElementsByTagName("spy")[0].InnerText.ToString(), CultureInfo.InvariantCulture);
            Settings.Game_church = Int32.Parse(SettingsXML.GetElementsByTagName("church")[0].InnerText.ToString(), CultureInfo.InvariantCulture);

            AddtoLog("Gathered world settings " + txtWorldID.Text + "\r\n");
            AddtoLog("Started to gather building stats for world " + txtWorldID.Text + "\r\n");

            //http://forum.tribalwars.us/showthread.php?5996-World-Data
            //Building Info
            //"http://en" + txtWorldID.Text + ".tribalwars.net/interface.php?func=get_building_info"

            //World Settings
            //en73.tribalwars.net/interface.php?func=get_config

            //Unit Info
            //http://en73.tribalwars.net/interface.php?func=get_unit_info

            //Formulars
            //http://forum.tribalwars.us/showthread.php?389-guide-Building-Formulas

            XmlTextReader reader = new XmlTextReader("http://en" + txtWorldID.Text + ".tribalwars.net/interface.php?func=get_building_info");

            AddtoLog("Downloaded Building Info\r\n");

            string clip = "";
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    for (int i = 0; i < reader.Depth; i++)
                        clip += "    ";

                    if (reader.Depth == 1)
                    {
                        clip += "<building>\r\n";
                        clip += "        <name>" + reader.Name + "</name>\r\n";
                    }
                    else
                    {
                        clip += "<" + reader.Name;

                        while (reader.MoveToNextAttribute()) // Read the attributes.
                            clip += " " + reader.Name + "='" + reader.Value + "'";
                        clip += ">\r\n";
                    }
                }
                else if (reader.NodeType == XmlNodeType.Text)
                {
                    for (int i = 0; i < reader.Depth; i++)
                        clip += "    ";
                    clip += reader.Value + "\r\n";
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    for (int i = 0; i < reader.Depth; i++)
                        clip += "    ";
                    if (reader.Depth == 1)
                    {
                        clip += "</building>\r\n";
                    }
                    else
                    {
                        clip += "</" + reader.Name;
                        clip += ">\r\n";
                    }
                }
            }

            AddtoLog("Remade Building Info XML File\r\n");

            System.IO.File.WriteAllText(@"WorldStats/Backup_Building_w" + txtWorldID.Text + ".xml", clip);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(clip);

            XmlNodeList XML_name = xmlDoc.GetElementsByTagName("name");
            XmlNodeList XML_max_level = xmlDoc.GetElementsByTagName("max_level");
            XmlNodeList XML_min_level = xmlDoc.GetElementsByTagName("min_level");
            XmlNodeList XML_wood = xmlDoc.GetElementsByTagName("wood");
            XmlNodeList XML_stone = xmlDoc.GetElementsByTagName("stone");
            XmlNodeList XML_iron = xmlDoc.GetElementsByTagName("iron");
            XmlNodeList XML_pop = xmlDoc.GetElementsByTagName("pop");
            XmlNodeList XML_wood_factor = xmlDoc.GetElementsByTagName("wood_factor");
            XmlNodeList XML_stone_factor = xmlDoc.GetElementsByTagName("stone_factor");
            XmlNodeList XML_iron_factor = xmlDoc.GetElementsByTagName("iron_factor");
            XmlNodeList XML_pop_factor = xmlDoc.GetElementsByTagName("pop_factor");
            XmlNodeList XML_build_time = xmlDoc.GetElementsByTagName("build_time");
            XmlNodeList XML_build_time_factor = xmlDoc.GetElementsByTagName("build_time_factor");


            for (int i = 0; i < XML_max_level.Count; i++) {
                Buildings newBuilding = new Buildings();
                newBuilding.name = ((XML_name[i] != null) ? XML_name[i].InnerText.ToString() : null);

                if (newBuilding.name == "main") {
                    BuildingID.HQ = i;
                    newBuilding.Base_Points = 10; //Base Points are hardcoded, because it doesnt seem to be part of the limited "API"
                } else if (newBuilding.name == "barracks") {
                    BuildingID.Barracks = i;
                    newBuilding.Base_Points = 16;
                } else if (newBuilding.name == "stable") {
                    newBuilding.Base_Points = 20;
                    BuildingID.Stable = i;
                } else if (newBuilding.name == "garage") {
                    newBuilding.Base_Points = 24;
                    BuildingID.Workshop = i;
                } else if (newBuilding.name == "church") {
                    newBuilding.Base_Points = 10;
                    BuildingID.Church = i;
                } else if (newBuilding.name == "church_f") {
                    newBuilding.Base_Points = 10;
                    BuildingID.Church_f = i;
                } else if (newBuilding.name == "snob") {
                    newBuilding.Base_Points = 512;
                    BuildingID.Academy = i;
                } else if (newBuilding.name == "smith") {
                    newBuilding.Base_Points = 19;
                    BuildingID.Smithy = i;
                } else if (newBuilding.name == "place") {
                    newBuilding.Base_Points = 0;
                    BuildingID.Rally = i;
                } else if (newBuilding.name == "statue") {
                    newBuilding.Base_Points = 24;
                    BuildingID.Statue = i;
                } else if (newBuilding.name == "market") {
                    newBuilding.Base_Points = 10;
                    BuildingID.Market = i;
                } else if (newBuilding.name == "wood") {
                    newBuilding.Base_Points = 6;
                    BuildingID.Camp = i;
                } else if (newBuilding.name == "stone") {
                    newBuilding.Base_Points = 6;
                    BuildingID.Pit = i;
                } else if (newBuilding.name == "iron") {
                    newBuilding.Base_Points = 6;
                    BuildingID.Mine = i;
                } else if (newBuilding.name == "farm") {
                    newBuilding.Base_Points = 6;
                    BuildingID.Farm = i;
                } else if (newBuilding.name == "storage") {
                    newBuilding.Base_Points = 6;
                    BuildingID.Warehouse = i;
                } else if (newBuilding.name == "hide") {
                    newBuilding.Base_Points = 5;
                    BuildingID.Hiding = i;
                } else if (newBuilding.name == "wall") {
                    newBuilding.Base_Points = 8;
                    BuildingID.Wall = i;
                }

                newBuilding.max_level = ((XML_max_level[i] != null) ? Int32.Parse(XML_max_level[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newBuilding.min_level = ((XML_min_level[i] != null) ? Int32.Parse(XML_min_level[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newBuilding.stone = ((XML_wood[i] != null) ? Int32.Parse(XML_wood[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newBuilding.stone = ((XML_stone[i] != null) ? Int32.Parse(XML_stone[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newBuilding.iron = ((XML_iron[i] != null) ? Int32.Parse(XML_iron[i].InnerText.ToString()) : 0);
                newBuilding.pop = ((XML_pop[i] != null) ? Int32.Parse(XML_pop[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newBuilding.wood_factor = ((XML_wood_factor[i] != null) ? double.Parse(XML_wood_factor[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newBuilding.stone_factor = ((XML_stone_factor[i] != null) ? double.Parse(XML_stone_factor[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newBuilding.iron_factor = ((XML_iron_factor[i] != null) ? double.Parse(XML_iron_factor[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newBuilding.pop_factor = ((XML_pop_factor[i] != null) ? double.Parse(XML_pop_factor[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newBuilding.build_time = ((XML_build_time[i] != null) ? Int32.Parse(XML_build_time[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newBuilding.build_time_factor = ((XML_build_time_factor[i] != null) ? double.Parse(XML_build_time_factor[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);

                newBuilding.Pop_Table = new int[newBuilding.max_level + 1];
                newBuilding.Wood_Table = new int[newBuilding.max_level + 1];
                newBuilding.Clay_Table = new int[newBuilding.max_level + 1];
                newBuilding.Iron_Table = new int[newBuilding.max_level + 1];
                newBuilding.Total_Res_Table = new int[newBuilding.max_level + 1];
                newBuilding.Build_Table = new int[newBuilding.max_level + 1];
                newBuilding.Point_Table = new int[newBuilding.max_level + 1];

                for (int b = 1; b <= newBuilding.max_level; b++) {
                    newBuilding.Wood_Table[b] = (int)Math.Round((newBuilding.wood * Math.Pow(newBuilding.wood_factor, Convert.ToDouble(b - 1))));
                    newBuilding.Clay_Table[b] = (int)Math.Round((newBuilding.stone * Math.Pow(newBuilding.stone_factor, Convert.ToDouble(b - 1))));
                    newBuilding.Iron_Table[b] = (int)Math.Round((newBuilding.iron * Math.Pow(newBuilding.iron_factor, Convert.ToDouble(b - 1))));
                    newBuilding.Pop_Table[b] = (int)Math.Round((newBuilding.pop * Math.Pow(newBuilding.pop_factor, Convert.ToDouble(b - 1))));
                    newBuilding.Point_Table[b] = (int)Math.Round((newBuilding.Base_Points * Math.Pow(1.2, Convert.ToDouble(b - 1))));
                    newBuilding.Total_Res_Table[b] = newBuilding.Wood_Table[b] + newBuilding.Clay_Table[b] + newBuilding.Iron_Table[b];

                    if (b < 3)
                        newBuilding.Build_Table[b] = (int)Math.Round(newBuilding.build_time*1.18*Math.Pow(newBuilding.build_time_factor,-13));
                    else
                        newBuilding.Build_Table[b] = (int)Math.Round(newBuilding.build_time * 1.18 * Math.Pow(newBuilding.build_time_factor, b - 1 - 14/(b-1)));
                }

                Building.Add(newBuilding);
            }

            AddtoLog("Parsed Building Stats\r\n");

            AddtoLog("Started to gather unit stats for world " + txtWorldID.Text + "\r\n");

            reader = new XmlTextReader("http://en" + txtWorldID.Text + ".tribalwars.net/interface.php?func=get_unit_info");

            AddtoLog("Downloaded Unit Info\r\n");

            clip = "";
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    for (int i = 0; i < reader.Depth; i++)
                        clip += "    ";

                    if (reader.Depth == 1)
                    {
                        clip += "<unit>\r\n";
                        clip += "        <name>" + reader.Name + "</name>\r\n";
                    }
                    else
                    {
                        clip += "<" + reader.Name;

                        while (reader.MoveToNextAttribute()) // Read the attributes.
                            clip += " " + reader.Name + "='" + reader.Value + "'";
                        clip += ">\r\n";
                    }
                }
                else if (reader.NodeType == XmlNodeType.Text)
                {
                    for (int i = 0; i < reader.Depth; i++)
                        clip += "    ";
                    clip += reader.Value + "\r\n";
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    for (int i = 0; i < reader.Depth; i++)
                        clip += "    ";
                    if (reader.Depth == 1)
                    {
                        clip += "</unit>\r\n";
                    }
                    else
                    {
                        clip += "</" + reader.Name;
                        clip += ">\r\n";
                    }
                }
            }

            AddtoLog("Remade Unit Info XML File\r\n");

            System.IO.File.WriteAllText(@"WorldStats/Backup_Unit_w" + txtWorldID.Text + ".xml", clip);

            xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(clip);

            XML_name = xmlDoc.GetElementsByTagName("name");
            XML_wood = xmlDoc.GetElementsByTagName("wood");
            XML_stone = xmlDoc.GetElementsByTagName("stone");
            XML_iron = xmlDoc.GetElementsByTagName("iron");
            XML_pop = xmlDoc.GetElementsByTagName("pop");
            XmlNodeList XML_speed = xmlDoc.GetElementsByTagName("speed");
            XmlNodeList XML_attack = xmlDoc.GetElementsByTagName("attack");
            XmlNodeList XML_defense = xmlDoc.GetElementsByTagName("defense");
            XmlNodeList XML_defense_cavalry = xmlDoc.GetElementsByTagName("defense_cavalry");
            XmlNodeList XML_defense_archer = xmlDoc.GetElementsByTagName("defense_archer");
            XmlNodeList XML_carry = xmlDoc.GetElementsByTagName("carry");
            XML_build_time = xmlDoc.GetElementsByTagName("build_time");


            for (int i = 0; i < XML_name.Count; i++)
            {
                Units newUnit = new Units();
                newUnit.name = ((XML_name[i] != null) ? XML_name[i].InnerText.ToString() : null);

                if (newUnit.name == "spear")
                    UnitID.Spearman = i;
                else if (newUnit.name == "sword")
                    UnitID.Swordsman = i;
                else if (newUnit.name == "axe")
                    UnitID.Axeman = i;
                else if (newUnit.name == "archer")
                    UnitID.Archer = i;
                else if (newUnit.name == "spy")
                    UnitID.Scout = i;
                else if (newUnit.name == "light")
                    UnitID.Light_Cavalry = i;
                else if (newUnit.name == "marcher")
                    UnitID.Mounted_Archer = i;
                else if (newUnit.name == "heavy")
                    UnitID.Heavy_Cavalry = i;
                else if (newUnit.name == "ram")
                    UnitID.Ram = i;
                else if (newUnit.name == "catapult")
                    UnitID.Catapult = i;
                else if (newUnit.name == "knight")
                    UnitID.Paladin = i;
                else if (newUnit.name == "snob")
                    UnitID.Noble = i;
                else if (newUnit.name == "militia")
                    UnitID.Militia = i;

                newUnit.speed = ((XML_speed[i] != null) ? double.Parse(XML_speed[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newUnit.wood = ((XML_wood[i] != null) ? Int32.Parse(XML_wood[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newUnit.stone = ((XML_stone[i] != null) ? Int32.Parse(XML_stone[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newUnit.iron = ((XML_iron[i] != null) ? Int32.Parse(XML_iron[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newUnit.pop = ((XML_pop[i] != null) ? Int32.Parse(XML_pop[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newUnit.attack = ((XML_attack[i] != null) ? Int32.Parse(XML_attack[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newUnit.defense = ((XML_defense[i] != null) ? Int32.Parse(XML_defense[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newUnit.defense_cavalry = ((XML_defense_cavalry[i] != null) ? Int32.Parse(XML_defense_cavalry[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newUnit.defense_archer = ((XML_defense_archer[i] != null) ? Int32.Parse(XML_defense_archer[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newUnit.carry = ((XML_carry[i] != null) ? Int32.Parse(XML_carry[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);
                newUnit.build_time = ((XML_build_time[i] != null) ? Int32.Parse(XML_build_time[i].InnerText.ToString(), CultureInfo.InvariantCulture) : 0);

                Unit.Add(newUnit);
            }

            AddtoLog("Parsed Unit Stats\r\n");

            WrapUp("");
        }

        private void txtDebug_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBG_Click(object sender, EventArgs e)
        {
            BuildingGuesser nForm = new BuildingGuesser();
            nForm.BuildingList = Building;
            nForm.UnitList = Unit;
            nForm.UnitIDList = UnitID;
            nForm.SettingClass = Settings;
            nForm.BuildingIDList = BuildingID;
            nForm.Show();

        }

        private void btnVD_Click(object sender, EventArgs e)
        {
            VillageDesigner nForm = new VillageDesigner();
            nForm.BuildingList = Building;
            nForm.UnitList = Unit;
            nForm.UnitIDList = UnitID;
            nForm.SettingClass = Settings;
            nForm.BuildingIDList = BuildingID;
            nForm.Show();
        }
    }
}
