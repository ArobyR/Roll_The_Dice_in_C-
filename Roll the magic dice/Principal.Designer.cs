namespace Roll_the_magic_dice
{
    partial class Principal1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal1));
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.Pbox1 = new System.Windows.Forms.PictureBox();
            this.Pbox2 = new System.Windows.Forms.PictureBox();
            this.lblTittle = new System.Windows.Forms.Label();
            this.MNPrincipal = new System.Windows.Forms.MenuStrip();
            this.MPRules = new System.Windows.Forms.ToolStripMenuItem();
            this.MPAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MPExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MRRules = new System.Windows.Forms.ToolStripMenuItem();
            this.MAAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MEexit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox2)).BeginInit();
            this.MNPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRoll.Location = new System.Drawing.Point(298, 332);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(103, 45);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "ROLL";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDice1
            // 
            this.lblDice1.AutoSize = true;
            this.lblDice1.Font = new System.Drawing.Font("Times New Roman", 24.25F, System.Drawing.FontStyle.Bold);
            this.lblDice1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDice1.Location = new System.Drawing.Point(213, 259);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(34, 37);
            this.lblDice1.TabIndex = 1;
            this.lblDice1.Text = "0";
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Font = new System.Drawing.Font("Times New Roman", 24.25F, System.Drawing.FontStyle.Bold);
            this.lblDice2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDice2.Location = new System.Drawing.Point(463, 259);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(34, 37);
            this.lblDice2.TabIndex = 2;
            this.lblDice2.Text = "0";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblWinner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWinner.Location = new System.Drawing.Point(293, 222);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 25);
            this.lblWinner.TabIndex = 3;
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAttempts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAttempts.Location = new System.Drawing.Point(294, 167);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(0, 22);
            this.lblAttempts.TabIndex = 4;
            this.lblAttempts.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pbox1
            // 
            this.Pbox1.Image = ((System.Drawing.Image)(resources.GetObject("Pbox1.Image")));
            this.Pbox1.Location = new System.Drawing.Point(202, 204);
            this.Pbox1.Name = "Pbox1";
            this.Pbox1.Size = new System.Drawing.Size(51, 52);
            this.Pbox1.TabIndex = 5;
            this.Pbox1.TabStop = false;
            // 
            // Pbox2
            // 
            this.Pbox2.Image = ((System.Drawing.Image)(resources.GetObject("Pbox2.Image")));
            this.Pbox2.Location = new System.Drawing.Point(454, 204);
            this.Pbox2.Name = "Pbox2";
            this.Pbox2.Size = new System.Drawing.Size(51, 52);
            this.Pbox2.TabIndex = 6;
            this.Pbox2.TabStop = false;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTittle.Location = new System.Drawing.Point(193, 52);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(327, 50);
            this.lblTittle.TabIndex = 7;
            this.lblTittle.Text = "The Magic Dice";
            // 
            // MNPrincipal
            // 
            this.MNPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MPRules,
            this.MPAbout,
            this.MPExit});
            this.MNPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MNPrincipal.Name = "MNPrincipal";
            this.MNPrincipal.Size = new System.Drawing.Size(736, 24);
            this.MNPrincipal.TabIndex = 8;
            this.MNPrincipal.Text = "menuStrip1";
            // 
            // MPRules
            // 
            this.MPRules.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MRRules});
            this.MPRules.Name = "MPRules";
            this.MPRules.Size = new System.Drawing.Size(47, 20);
            this.MPRules.Text = "Rules";
            // 
            // MPAbout
            // 
            this.MPAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAAbout});
            this.MPAbout.Name = "MPAbout";
            this.MPAbout.Size = new System.Drawing.Size(52, 20);
            this.MPAbout.Text = "About";
            // 
            // MPExit
            // 
            this.MPExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MEexit});
            this.MPExit.Name = "MPExit";
            this.MPExit.Size = new System.Drawing.Size(38, 20);
            this.MPExit.Text = "Exit";
            // 
            // MRRules
            // 
            this.MRRules.Name = "MRRules";
            this.MRRules.Size = new System.Drawing.Size(180, 22);
            this.MRRules.Text = "All Rules";
            this.MRRules.Click += new System.EventHandler(this.MRRules_Click);
            // 
            // MAAbout
            // 
            this.MAAbout.Name = "MAAbout";
            this.MAAbout.Size = new System.Drawing.Size(180, 22);
            this.MAAbout.Text = "About";
            this.MAAbout.Click += new System.EventHandler(this.MAAbout_Click);
            // 
            // MEexit
            // 
            this.MEexit.Name = "MEexit";
            this.MEexit.Size = new System.Drawing.Size(180, 22);
            this.MEexit.Text = "Exit";
            this.MEexit.Click += new System.EventHandler(this.MEexit_Click);
            // 
            // Principal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(736, 453);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.Pbox2);
            this.Controls.Add(this.Pbox1);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.MNPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MNPrincipal;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(752, 492);
            this.Name = "Principal1";
            this.Text = "Roll The Magic Dice";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox2)).EndInit();
            this.MNPrincipal.ResumeLayout(false);
            this.MNPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.PictureBox Pbox1;
        private System.Windows.Forms.PictureBox Pbox2;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.MenuStrip MNPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MPRules;
        private System.Windows.Forms.ToolStripMenuItem MRRules;
        private System.Windows.Forms.ToolStripMenuItem MPAbout;
        private System.Windows.Forms.ToolStripMenuItem MAAbout;
        private System.Windows.Forms.ToolStripMenuItem MPExit;
        private System.Windows.Forms.ToolStripMenuItem MEexit;
    }
}

