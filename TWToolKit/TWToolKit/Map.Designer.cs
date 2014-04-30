namespace TWToolKit {
    partial class Map {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvMap = new System.Windows.Forms.DataGridView();
            this.btnProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMap
            // 
            this.dgvMap.AllowUserToAddRows = false;
            this.dgvMap.AllowUserToDeleteRows = false;
            this.dgvMap.AllowUserToOrderColumns = true;
            this.dgvMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMap.Location = new System.Drawing.Point(0, 0);
            this.dgvMap.Name = "dgvMap";
            this.dgvMap.ReadOnly = true;
            this.dgvMap.Size = new System.Drawing.Size(852, 640);
            this.dgvMap.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Lucida Fax", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnProcess.Location = new System.Drawing.Point(0, 646);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(852, 51);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Get Map Data (can take time)";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 695);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.dgvMap);
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMap;
        private System.Windows.Forms.Button btnProcess;
    }
}