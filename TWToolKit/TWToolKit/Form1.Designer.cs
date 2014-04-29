namespace TWToolKit
{
    partial class Form1
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
            this.btnGetStats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorldID = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            this.lblWorldLoaded = new System.Windows.Forms.ToolStripLabel();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.btnVD = new System.Windows.Forms.Button();
            this.btnBG = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetStats
            // 
            this.btnGetStats.Location = new System.Drawing.Point(0, 54);
            this.btnGetStats.Name = "btnGetStats";
            this.btnGetStats.Size = new System.Drawing.Size(385, 49);
            this.btnGetStats.TabIndex = 0;
            this.btnGetStats.Text = "Get Stats";
            this.btnGetStats.UseVisualStyleBackColor = true;
            this.btnGetStats.Click += new System.EventHandler(this.btnGetStats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "World ID:";
            // 
            // txtWorldID
            // 
            this.txtWorldID.Location = new System.Drawing.Point(60, 28);
            this.txtWorldID.Name = "txtWorldID";
            this.txtWorldID.Size = new System.Drawing.Size(325, 20);
            this.txtWorldID.TabIndex = 2;
            this.txtWorldID.Text = "73";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblWorldLoaded});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(385, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 22);
            this.lblStatus.Text = "Stats Not Loaded";
            // 
            // lblWorldLoaded
            // 
            this.lblWorldLoaded.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblWorldLoaded.Name = "lblWorldLoaded";
            this.lblWorldLoaded.Size = new System.Drawing.Size(58, 22);
            this.lblWorldLoaded.Text = "No World";
            // 
            // btnVD
            // 
            this.btnVD.Enabled = false;
            this.btnVD.Location = new System.Drawing.Point(0, 313);
            this.btnVD.Name = "btnVD";
            this.btnVD.Size = new System.Drawing.Size(171, 95);
            this.btnVD.TabIndex = 4;
            this.btnVD.Text = "Village Designer";
            this.btnVD.UseVisualStyleBackColor = true;
            this.btnVD.Click += new System.EventHandler(this.btnVD_Click);
            // 
            // btnBG
            // 
            this.btnBG.Enabled = false;
            this.btnBG.Location = new System.Drawing.Point(214, 313);
            this.btnBG.Name = "btnBG";
            this.btnBG.Size = new System.Drawing.Size(171, 95);
            this.btnBG.TabIndex = 5;
            this.btnBG.Text = "Building Guesser";
            this.btnBG.UseVisualStyleBackColor = true;
            this.btnBG.Click += new System.EventHandler(this.btnBG_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 411);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(385, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabel1.Text = "Release Build:";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel3.Text = "Alpha 0.1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel4.Text = "23/04/14";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.ForeColor = System.Drawing.Color.DarkGreen;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel2.Text = "Release Date:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(0, 109);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(385, 198);
            this.txtLog.TabIndex = 7;
            this.txtLog.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(335, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.btnBG);
            this.Controls.Add(this.btnVD);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtWorldID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TW ToolKit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorldID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblStatus;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button btnVD;
        private System.Windows.Forms.Button btnBG;
        private System.Windows.Forms.ToolStripLabel lblWorldLoaded;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label2;
    }
}

