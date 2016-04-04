namespace FSM_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.P2NBox = new System.Windows.Forms.TextBox();
            this.P2hp = new System.Windows.Forms.TextBox();
            this.P2armor = new System.Windows.Forms.TextBox();
            this.P2Spd = new System.Windows.Forms.TextBox();
            this.P3NBox = new System.Windows.Forms.TextBox();
            this.P3hp = new System.Windows.Forms.TextBox();
            this.P3armor = new System.Windows.Forms.TextBox();
            this.P3Spd = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.P3dmg = new System.Windows.Forms.TextBox();
            this.P3lvl = new System.Windows.Forms.TextBox();
            this.P2lvl = new System.Windows.Forms.TextBox();
            this.P2dmg = new System.Windows.Forms.TextBox();
            this.P1NBox = new System.Windows.Forms.TextBox();
            this.P1hp = new System.Windows.Forms.TextBox();
            this.P1dmg = new System.Windows.Forms.TextBox();
            this.P1armor = new System.Windows.Forms.TextBox();
            this.P1Spd = new System.Windows.Forms.TextBox();
            this.P1lvl = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Party";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateParty_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(577, 295);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "LoadButton";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 229);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 164);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.Form1_Load_1);
            // 
            // P2NBox
            // 
            this.P2NBox.Enabled = false;
            this.P2NBox.Location = new System.Drawing.Point(57, 295);
            this.P2NBox.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2NBox.Name = "P2NBox";
            this.P2NBox.Size = new System.Drawing.Size(29, 20);
            this.P2NBox.TabIndex = 8;
            // 
            // P2hp
            // 
            this.P2hp.Enabled = false;
            this.P2hp.Location = new System.Drawing.Point(57, 322);
            this.P2hp.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2hp.Name = "P2hp";
            this.P2hp.Size = new System.Drawing.Size(29, 20);
            this.P2hp.TabIndex = 9;
            this.P2hp.TextChanged += new System.EventHandler(this.P2hp_TextChanged);
            // 
            // P2armor
            // 
            this.P2armor.Enabled = false;
            this.P2armor.Location = new System.Drawing.Point(57, 373);
            this.P2armor.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2armor.Name = "P2armor";
            this.P2armor.Size = new System.Drawing.Size(29, 20);
            this.P2armor.TabIndex = 10;
            // 
            // P2Spd
            // 
            this.P2Spd.Enabled = false;
            this.P2Spd.Location = new System.Drawing.Point(57, 398);
            this.P2Spd.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2Spd.Name = "P2Spd";
            this.P2Spd.Size = new System.Drawing.Size(29, 20);
            this.P2Spd.TabIndex = 11;
            // 
            // P3NBox
            // 
            this.P3NBox.Enabled = false;
            this.P3NBox.Location = new System.Drawing.Point(327, 2);
            this.P3NBox.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3NBox.Name = "P3NBox";
            this.P3NBox.Size = new System.Drawing.Size(29, 20);
            this.P3NBox.TabIndex = 12;
            this.P3NBox.TextChanged += new System.EventHandler(this.P3NBox_TextChanged);
            // 
            // P3hp
            // 
            this.P3hp.Enabled = false;
            this.P3hp.Location = new System.Drawing.Point(327, 29);
            this.P3hp.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3hp.Name = "P3hp";
            this.P3hp.Size = new System.Drawing.Size(29, 20);
            this.P3hp.TabIndex = 13;
            // 
            // P3armor
            // 
            this.P3armor.Enabled = false;
            this.P3armor.Location = new System.Drawing.Point(327, 81);
            this.P3armor.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3armor.Name = "P3armor";
            this.P3armor.Size = new System.Drawing.Size(29, 20);
            this.P3armor.TabIndex = 14;
            // 
            // P3Spd
            // 
            this.P3Spd.Enabled = false;
            this.P3Spd.Location = new System.Drawing.Point(327, 107);
            this.P3Spd.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3Spd.Name = "P3Spd";
            this.P3Spd.Size = new System.Drawing.Size(29, 20);
            this.P3Spd.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(406, 401);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Confirm Party";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.ConfirmParty_Check);
            // 
            // P3dmg
            // 
            this.P3dmg.Enabled = false;
            this.P3dmg.Location = new System.Drawing.Point(327, 55);
            this.P3dmg.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3dmg.Name = "P3dmg";
            this.P3dmg.Size = new System.Drawing.Size(29, 20);
            this.P3dmg.TabIndex = 17;
            // 
            // P3lvl
            // 
            this.P3lvl.Enabled = false;
            this.P3lvl.Location = new System.Drawing.Point(327, 129);
            this.P3lvl.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3lvl.Name = "P3lvl";
            this.P3lvl.Size = new System.Drawing.Size(29, 20);
            this.P3lvl.TabIndex = 18;
            // 
            // P2lvl
            // 
            this.P2lvl.Location = new System.Drawing.Point(57, 424);
            this.P2lvl.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2lvl.Name = "P2lvl";
            this.P2lvl.Size = new System.Drawing.Size(29, 20);
            this.P2lvl.TabIndex = 19;
            // 
            // P2dmg
            // 
            this.P2dmg.Location = new System.Drawing.Point(57, 347);
            this.P2dmg.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2dmg.Name = "P2dmg";
            this.P2dmg.Size = new System.Drawing.Size(29, 20);
            this.P2dmg.TabIndex = 20;
            // 
            // P1NBox
            // 
            this.P1NBox.Location = new System.Drawing.Point(57, 3);
            this.P1NBox.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1NBox.Name = "P1NBox";
            this.P1NBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.P1NBox.Size = new System.Drawing.Size(29, 20);
            this.P1NBox.TabIndex = 21;
            this.P1NBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // P1hp
            // 
            this.P1hp.Location = new System.Drawing.Point(57, 29);
            this.P1hp.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1hp.Name = "P1hp";
            this.P1hp.Size = new System.Drawing.Size(29, 20);
            this.P1hp.TabIndex = 22;
            // 
            // P1dmg
            // 
            this.P1dmg.Location = new System.Drawing.Point(57, 55);
            this.P1dmg.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1dmg.Name = "P1dmg";
            this.P1dmg.Size = new System.Drawing.Size(29, 20);
            this.P1dmg.TabIndex = 23;
            // 
            // P1armor
            // 
            this.P1armor.Location = new System.Drawing.Point(57, 81);
            this.P1armor.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1armor.Name = "P1armor";
            this.P1armor.Size = new System.Drawing.Size(29, 20);
            this.P1armor.TabIndex = 24;
            // 
            // P1Spd
            // 
            this.P1Spd.Location = new System.Drawing.Point(57, 107);
            this.P1Spd.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1Spd.Name = "P1Spd";
            this.P1Spd.Size = new System.Drawing.Size(29, 20);
            this.P1Spd.TabIndex = 25;
            // 
            // P1lvl
            // 
            this.P1lvl.Location = new System.Drawing.Point(57, 133);
            this.P1lvl.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1lvl.Name = "P1lvl";
            this.P1lvl.Size = new System.Drawing.Size(29, 20);
            this.P1lvl.TabIndex = 26;
            this.P1lvl.TextChanged += new System.EventHandler(this.P1lvl_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(92, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(92, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(362, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Damage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Armor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Spd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Health";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Damage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Armor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Spd";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Level";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(274, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Health";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Damage";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(287, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Armor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(288, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Spd";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(288, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 512);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.P1lvl);
            this.Controls.Add(this.P1Spd);
            this.Controls.Add(this.P1armor);
            this.Controls.Add(this.P1dmg);
            this.Controls.Add(this.P1hp);
            this.Controls.Add(this.P1NBox);
            this.Controls.Add(this.P2dmg);
            this.Controls.Add(this.P2lvl);
            this.Controls.Add(this.P3lvl);
            this.Controls.Add(this.P3dmg);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.P3Spd);
            this.Controls.Add(this.P3armor);
            this.Controls.Add(this.P3hp);
            this.Controls.Add(this.P3NBox);
            this.Controls.Add(this.P2Spd);
            this.Controls.Add(this.P2armor);
            this.Controls.Add(this.P2hp);
            this.Controls.Add(this.P2NBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox P2NBox;
        private System.Windows.Forms.TextBox P2hp;
        private System.Windows.Forms.TextBox P2armor;
        private System.Windows.Forms.TextBox P2Spd;
        private System.Windows.Forms.TextBox P3NBox;
        private System.Windows.Forms.TextBox P3hp;
        private System.Windows.Forms.TextBox P3armor;
        private System.Windows.Forms.TextBox P3Spd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox P3dmg;
        private System.Windows.Forms.TextBox P3lvl;
        private System.Windows.Forms.TextBox P2lvl;
        private System.Windows.Forms.TextBox P2dmg;
        private System.Windows.Forms.TextBox P1NBox;
        private System.Windows.Forms.TextBox P1hp;
        private System.Windows.Forms.TextBox P1dmg;
        private System.Windows.Forms.TextBox P1armor;
        private System.Windows.Forms.TextBox P1Spd;
        private System.Windows.Forms.TextBox P1lvl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}