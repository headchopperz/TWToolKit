namespace TWToolKit
{
    partial class BuildingGuesser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenVB = new System.Windows.Forms.Button();
            this.pgrLoop = new System.Windows.Forms.ProgressBar();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatches = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenVB
            // 
            this.btnOpenVB.Font = new System.Drawing.Font("Lucida Fax", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnOpenVB.Location = new System.Drawing.Point(12, 7);
            this.btnOpenVB.Name = "btnOpenVB";
            this.btnOpenVB.Size = new System.Drawing.Size(512, 38);
            this.btnOpenVB.TabIndex = 0;
            this.btnOpenVB.Text = "Set Minimum Buildings";
            this.btnOpenVB.UseVisualStyleBackColor = true;
            this.btnOpenVB.Click += new System.EventHandler(this.btnOpenVB_Click);
            // 
            // pgrLoop
            // 
            this.pgrLoop.Location = new System.Drawing.Point(12, 170);
            this.pgrLoop.Maximum = 31;
            this.pgrLoop.Name = "pgrLoop";
            this.pgrLoop.Size = new System.Drawing.Size(512, 50);
            this.pgrLoop.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Lucida Fax", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(12, 226);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(244, 52);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // txtPoints
            // 
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.Location = new System.Drawing.Point(126, 51);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(398, 31);
            this.txtPoints.TabIndex = 3;
            this.txtPoints.Text = "3361";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output:";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputFile.Location = new System.Drawing.Point(126, 88);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(296, 31);
            this.txtOutputFile.TabIndex = 5;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectFile.Location = new System.Drawing.Point(428, 88);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(96, 31);
            this.btnSelectFile.TabIndex = 7;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 15.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Matches:";
            // 
            // txtMatches
            // 
            this.txtMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatches.Location = new System.Drawing.Point(126, 125);
            this.txtMatches.Name = "txtMatches";
            this.txtMatches.Size = new System.Drawing.Size(398, 31);
            this.txtMatches.TabIndex = 8;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Lucida Fax", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnProcess.Location = new System.Drawing.Point(286, 226);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(238, 52);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // BuildingGuesser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 283);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatches);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pgrLoop);
            this.Controls.Add(this.btnOpenVB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuildingGuesser";
            this.ShowIcon = false;
            this.Text = "BuildingGuesser";
            this.Load += new System.EventHandler(this.BuildingGuesser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenVB;
        private System.Windows.Forms.ProgressBar pgrLoop;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatches;
        private System.Windows.Forms.Button btnProcess;
    }
}