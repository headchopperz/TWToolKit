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
    public partial class Map : Form {
        public Map() {
            InitializeComponent();
        }

        int WorldID; //This should be a reference/pointer, so we cant repeating the same variable in ram
        public int World_ID { set { WorldID = value; } }

        private void Map_Load(object sender, EventArgs e) {

        }

        private void btnProcess_Click(object sender, EventArgs e) {

            var defaultCellStyle = new DataGridViewCellStyle();

            defaultCellStyle.ForeColor = SystemColors.ControlText;
            defaultCellStyle.WrapMode = DataGridViewTriState.False;
            defaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            defaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            defaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            defaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            defaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((0)));

            dgvMap.DefaultCellStyle = defaultCellStyle;

            dgvMap.MultiSelect = false;
            dgvMap.RowHeadersVisible = false;
            dgvMap.AllowUserToAddRows = false;
            dgvMap.ColumnHeadersVisible = false;
            dgvMap.AllowUserToResizeRows = false;
            dgvMap.AllowUserToDeleteRows = false;
            dgvMap.AllowUserToOrderColumns = true;
            dgvMap.AllowUserToResizeColumns = false;
            dgvMap.AutoGenerateColumns = false;

            dgvMap.RowTemplate.Height = 38;

            //dgvMap.ColumnCount = 300;
            //dgvMap.RowCount = 300;


            dgvMap.BackgroundColor = Color.DarkSeaGreen;

            //return;
            var Villages_Raw = new System.Net.WebClient().DownloadString("http://en" + WorldID.ToString() + ".tribalwars.net/map/village.txt");

            string[] Villages = Villages_Raw.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            this.Controls.Add(dgvMap);

            int Min = 400;
            int Max = 600;


            for (int Y = Min; Y <= Max; Y++) {
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Name = Y.ToString();
                imageCol.Width = 53;
                imageCol.HeaderText = "Y";

                dgvMap.Columns.Add(imageCol);
            }

            for (int X = Min; X <= Max; X++) {
                dgvMap.Rows.Add();

                Bitmap img;

                img = new Bitmap(@"C:\Users\dis_c_000\Documents\GitHub\TWToolKit\TWToolKit\TWToolKit\Sprites\Foilage\gras1.png");

                for (int Y = Min; Y <= Max; Y++) {
                    dgvMap.Rows[X - Min].Cells[Y - Min].Value = img;
                }
            }

            foreach (string Village_Data in Villages) {
                string[] Village = Village_Data.Split(',');

                try {
                    int X = Int32.Parse(Village[2]);
                    int Y = Int32.Parse(Village[3]);
                    int Points = Int32.Parse(Village[5]);

                    if ((X < Min) || (X > Max))
                        continue;
                    if ((Y < Min) || (Y > Max))
                        continue;

                    Bitmap img;

                    if (Points > 11000)
                        img = new Bitmap(@"C:\Users\dis_c_000\Documents\GitHub\TWToolKit\TWToolKit\TWToolKit\Sprites\Villages\v6.png");
                    else if (Points > 9000)
                        img = new Bitmap(@"C:\Users\dis_c_000\Documents\GitHub\TWToolKit\TWToolKit\TWToolKit\Sprites\Villages\v5.png");
                    else if (Points > 3000)
                        img = new Bitmap(@"C:\Users\dis_c_000\Documents\GitHub\TWToolKit\TWToolKit\TWToolKit\Sprites\Villages\v4.png");
                    else if (Points > 1000)
                        img = new Bitmap(@"C:\Users\dis_c_000\Documents\GitHub\TWToolKit\TWToolKit\TWToolKit\Sprites\Villages\v3.png");
                    else if (Points > 300)
                        img = new Bitmap(@"C:\Users\dis_c_000\Documents\GitHub\TWToolKit\TWToolKit\TWToolKit\Sprites\Villages\v2.png");
                    else
                        img = new Bitmap(@"C:\Users\dis_c_000\Documents\GitHub\TWToolKit\TWToolKit\TWToolKit\Sprites\Villages\v1.png");


                    dgvMap.Rows[X - Min].Cells[Y - Min].Value = img;
                } catch (Exception ex) {
                    int a = 1;
                }

            }
        }
    }
}
