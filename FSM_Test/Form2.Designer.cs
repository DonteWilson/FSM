namespace FSM_Test
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.P1p = new System.Windows.Forms.PictureBox();
            this.P2p = new System.Windows.Forms.PictureBox();
            this.P3p = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.FightSequence = new System.Windows.Forms.TextBox();
            this.OStats = new System.Windows.Forms.TextBox();
            this.E1 = new System.Windows.Forms.Label();
            this.E2 = new System.Windows.Forms.Label();
            this.E3 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.P3 = new System.Windows.Forms.Label();
            this.CState = new System.Windows.Forms.TextBox();
            this.CombatT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.P1p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(430, 226);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lightning Dash";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LDash_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Agony";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Agony_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "God\'s  Wrath";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GodW_Click);
            // 
            // P1p
            // 
            this.P1p.Location = new System.Drawing.Point(87, 39);
            this.P1p.Name = "P1p";
            this.P1p.Size = new System.Drawing.Size(117, 158);
            this.P1p.TabIndex = 7;
            this.P1p.TabStop = false;
            // 
            // P2p
            // 
            this.P2p.Location = new System.Drawing.Point(279, 39);
            this.P2p.Name = "P2p";
            this.P2p.Size = new System.Drawing.Size(110, 158);
            this.P2p.TabIndex = 8;
            this.P2p.TabStop = false;
            // 
            // P3p
            // 
            this.P3p.Location = new System.Drawing.Point(87, 226);
            this.P3p.Name = "P3p";
            this.P3p.Size = new System.Drawing.Size(117, 162);
            this.P3p.TabIndex = 9;
            this.P3p.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(547, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 158);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(741, 39);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 158);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(741, 226);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(108, 162);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // FightSequence
            // 
            this.FightSequence.Location = new System.Drawing.Point(406, 255);
            this.FightSequence.Multiline = true;
            this.FightSequence.Name = "FightSequence";
            this.FightSequence.Size = new System.Drawing.Size(135, 51);
            this.FightSequence.TabIndex = 13;
            // 
            // OStats
            // 
            this.OStats.Location = new System.Drawing.Point(254, 243);
            this.OStats.Multiline = true;
            this.OStats.Name = "OStats";
            this.OStats.Size = new System.Drawing.Size(135, 53);
            this.OStats.TabIndex = 14;
            // 
            // E1
            // 
            this.E1.AutoSize = true;
            this.E1.Location = new System.Drawing.Point(577, 20);
            this.E1.Name = "E1";
            this.E1.Size = new System.Drawing.Size(38, 13);
            this.E1.TabIndex = 15;
            this.E1.Text = "label 1";
            // 
            // E2
            // 
            this.E2.AutoSize = true;
            this.E2.Location = new System.Drawing.Point(784, 20);
            this.E2.Name = "E2";
            this.E2.Size = new System.Drawing.Size(35, 13);
            this.E2.TabIndex = 16;
            this.E2.Text = "label2";
            // 
            // E3
            // 
            this.E3.AutoSize = true;
            this.E3.Location = new System.Drawing.Point(784, 210);
            this.E3.Name = "E3";
            this.E3.Size = new System.Drawing.Size(35, 13);
            this.E3.TabIndex = 17;
            this.E3.Text = "label3";
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Location = new System.Drawing.Point(125, 20);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(35, 13);
            this.P1.TabIndex = 18;
            this.P1.Text = "label1";
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Location = new System.Drawing.Point(320, 20);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(35, 13);
            this.P2.TabIndex = 19;
            this.P2.Text = "label2";
            // 
            // P3
            // 
            this.P3.AutoSize = true;
            this.P3.Location = new System.Drawing.Point(128, 210);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(35, 13);
            this.P3.TabIndex = 20;
            this.P3.Text = "label3";
            // 
            // CState
            // 
            this.CState.Location = new System.Drawing.Point(556, 243);
            this.CState.Multiline = true;
            this.CState.Name = "CState";
            this.CState.Size = new System.Drawing.Size(133, 63);
            this.CState.TabIndex = 21;
            // 
            // CombatT
            // 
            this.CombatT.Location = new System.Drawing.Point(407, 170);
            this.CombatT.Multiline = true;
            this.CombatT.Name = "CombatT";
            this.CombatT.Size = new System.Drawing.Size(134, 50);
            this.CombatT.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(995, 528);
            this.Controls.Add(this.CombatT);
            this.Controls.Add(this.CState);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.E3);
            this.Controls.Add(this.E2);
            this.Controls.Add(this.E1);
            this.Controls.Add(this.OStats);
            this.Controls.Add(this.FightSequence);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.P3p);
            this.Controls.Add(this.P2p);
            this.Controls.Add(this.P1p);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Start);
            this.Name = "Form2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.P1p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox P1p;
        private System.Windows.Forms.PictureBox P2p;
        private System.Windows.Forms.PictureBox P3p;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox FightSequence;
        private System.Windows.Forms.TextBox OStats;
        private System.Windows.Forms.Label E1;
        private System.Windows.Forms.Label E2;
        private System.Windows.Forms.Label E3;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label P3;
        private System.Windows.Forms.TextBox CState;
        private System.Windows.Forms.TextBox CombatT;
    }
}

