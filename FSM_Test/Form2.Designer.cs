﻿namespace FSM_Test
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
            this.Attack1 = new System.Windows.Forms.Button();
            this.Attack2 = new System.Windows.Forms.Button();
            this.Attack3 = new System.Windows.Forms.Button();
            this.P1p = new System.Windows.Forms.PictureBox();
            this.P2p = new System.Windows.Forms.PictureBox();
            this.P3p = new System.Windows.Forms.PictureBox();
            this.E1p = new System.Windows.Forms.PictureBox();
            this.E2p = new System.Windows.Forms.PictureBox();
            this.E3p = new System.Windows.Forms.PictureBox();
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
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.P1p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E1p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E2p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E3p)).BeginInit();
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
            // Attack1
            // 
            this.Attack1.Location = new System.Drawing.Point(278, 322);
            this.Attack1.Name = "Attack1";
            this.Attack1.Size = new System.Drawing.Size(111, 23);
            this.Attack1.TabIndex = 1;
            this.Attack1.Text = "Attack 1";
            this.Attack1.UseVisualStyleBackColor = true;
            this.Attack1.Click += new System.EventHandler(this.Attack1_Click);
            // 
            // Attack2
            // 
            this.Attack2.Location = new System.Drawing.Point(418, 322);
            this.Attack2.Name = "Attack2";
            this.Attack2.Size = new System.Drawing.Size(111, 23);
            this.Attack2.TabIndex = 5;
            this.Attack2.Text = "Attack 2";
            this.Attack2.UseVisualStyleBackColor = true;
            this.Attack2.Click += new System.EventHandler(this.Attack2_Click);
            // 
            // Attack3
            // 
            this.Attack3.Location = new System.Drawing.Point(556, 322);
            this.Attack3.Name = "Attack3";
            this.Attack3.Size = new System.Drawing.Size(111, 23);
            this.Attack3.TabIndex = 6;
            this.Attack3.Text = "Attack 3";
            this.Attack3.UseVisualStyleBackColor = true;
            this.Attack3.Click += new System.EventHandler(this.Attack3_Click);
            // 
            // P1p
            // 
            this.P1p.Location = new System.Drawing.Point(87, 39);
            this.P1p.Name = "P1p";
            this.P1p.Size = new System.Drawing.Size(150, 150);
            this.P1p.TabIndex = 7;
            this.P1p.TabStop = false;
            // 
            // P2p
            // 
            this.P2p.Location = new System.Drawing.Point(254, 39);
            this.P2p.Name = "P2p";
            this.P2p.Size = new System.Drawing.Size(150, 150);
            this.P2p.TabIndex = 8;
            this.P2p.TabStop = false;
            // 
            // P3p
            // 
            this.P3p.Location = new System.Drawing.Point(87, 226);
            this.P3p.Name = "P3p";
            this.P3p.Size = new System.Drawing.Size(150, 150);
            this.P3p.TabIndex = 9;
            this.P3p.TabStop = false;
            // 
            // E1p
            // 
            this.E1p.Location = new System.Drawing.Point(547, 39);
            this.E1p.Name = "E1p";
            this.E1p.Size = new System.Drawing.Size(150, 150);
            this.E1p.TabIndex = 10;
            this.E1p.TabStop = false;
            // 
            // E2p
            // 
            this.E2p.Location = new System.Drawing.Point(741, 39);
            this.E2p.Name = "E2p";
            this.E2p.Size = new System.Drawing.Size(150, 150);
            this.E2p.TabIndex = 11;
            this.E2p.TabStop = false;
            // 
            // E3p
            // 
            this.E3p.Location = new System.Drawing.Point(741, 226);
            this.E3p.Name = "E3p";
            this.E3p.Size = new System.Drawing.Size(150, 150);
            this.E3p.TabIndex = 12;
            this.E3p.TabStop = false;
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
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(430, 353);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Save ";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(995, 528);
            this.Controls.Add(this.SaveButton);
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
            this.Controls.Add(this.E3p);
            this.Controls.Add(this.E2p);
            this.Controls.Add(this.E1p);
            this.Controls.Add(this.P3p);
            this.Controls.Add(this.P2p);
            this.Controls.Add(this.P1p);
            this.Controls.Add(this.Attack3);
            this.Controls.Add(this.Attack2);
            this.Controls.Add(this.Attack1);
            this.Controls.Add(this.Start);
            this.Name = "Form2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.P1p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E1p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E2p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E3p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Attack1;
        private System.Windows.Forms.Button Attack2;
        private System.Windows.Forms.Button Attack3;
        private System.Windows.Forms.PictureBox P1p;
        private System.Windows.Forms.PictureBox P2p;
        private System.Windows.Forms.PictureBox P3p;
        private System.Windows.Forms.PictureBox E1p;
        private System.Windows.Forms.PictureBox E2p;
        private System.Windows.Forms.PictureBox E3p;
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
        private System.Windows.Forms.Button SaveButton;
    }
}

