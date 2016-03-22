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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Party";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateParty_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(574, 242);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(574, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "LoadButton";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 164);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.Form1_Load_1);
            // 
            // P2NBox
            // 
            this.P2NBox.Location = new System.Drawing.Point(22, 168);
            this.P2NBox.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2NBox.Name = "P2NBox";
            this.P2NBox.Size = new System.Drawing.Size(100, 20);
            this.P2NBox.TabIndex = 8;
            // 
            // P2hp
            // 
            this.P2hp.Location = new System.Drawing.Point(22, 194);
            this.P2hp.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2hp.Name = "P2hp";
            this.P2hp.Size = new System.Drawing.Size(100, 20);
            this.P2hp.TabIndex = 9;
            // 
            // P2armor
            // 
            this.P2armor.Location = new System.Drawing.Point(22, 244);
            this.P2armor.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2armor.Name = "P2armor";
            this.P2armor.Size = new System.Drawing.Size(100, 20);
            this.P2armor.TabIndex = 10;
            // 
            // P2Spd
            // 
            this.P2Spd.Location = new System.Drawing.Point(22, 272);
            this.P2Spd.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2Spd.Name = "P2Spd";
            this.P2Spd.Size = new System.Drawing.Size(100, 20);
            this.P2Spd.TabIndex = 11;
            // 
            // P3NBox
            // 
            this.P3NBox.Location = new System.Drawing.Point(163, 3);
            this.P3NBox.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3NBox.Name = "P3NBox";
            this.P3NBox.Size = new System.Drawing.Size(100, 20);
            this.P3NBox.TabIndex = 12;
            // 
            // P3hp
            // 
            this.P3hp.Location = new System.Drawing.Point(163, 29);
            this.P3hp.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3hp.Name = "P3hp";
            this.P3hp.Size = new System.Drawing.Size(100, 20);
            this.P3hp.TabIndex = 13;
            // 
            // P3armor
            // 
            this.P3armor.Location = new System.Drawing.Point(163, 81);
            this.P3armor.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3armor.Name = "P3armor";
            this.P3armor.Size = new System.Drawing.Size(100, 20);
            this.P3armor.TabIndex = 14;
            // 
            // P3Spd
            // 
            this.P3Spd.Location = new System.Drawing.Point(163, 107);
            this.P3Spd.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3Spd.Name = "P3Spd";
            this.P3Spd.Size = new System.Drawing.Size(100, 20);
            this.P3Spd.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(350, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Confirm Party";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.ConfirmParty_Check);
            // 
            // P3dmg
            // 
            this.P3dmg.Location = new System.Drawing.Point(163, 55);
            this.P3dmg.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3dmg.Name = "P3dmg";
            this.P3dmg.Size = new System.Drawing.Size(100, 20);
            this.P3dmg.TabIndex = 17;
            // 
            // P3lvl
            // 
            this.P3lvl.Location = new System.Drawing.Point(163, 133);
            this.P3lvl.MaximumSize = new System.Drawing.Size(100, 20);
            this.P3lvl.Name = "P3lvl";
            this.P3lvl.Size = new System.Drawing.Size(100, 20);
            this.P3lvl.TabIndex = 18;
            // 
            // P2lvl
            // 
            this.P2lvl.Location = new System.Drawing.Point(22, 298);
            this.P2lvl.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2lvl.Name = "P2lvl";
            this.P2lvl.Size = new System.Drawing.Size(100, 20);
            this.P2lvl.TabIndex = 19;
            // 
            // P2dmg
            // 
            this.P2dmg.Location = new System.Drawing.Point(22, 220);
            this.P2dmg.MaximumSize = new System.Drawing.Size(100, 20);
            this.P2dmg.Name = "P2dmg";
            this.P2dmg.Size = new System.Drawing.Size(100, 20);
            this.P2dmg.TabIndex = 20;
            // 
            // P1NBox
            // 
            this.P1NBox.Location = new System.Drawing.Point(22, 3);
            this.P1NBox.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1NBox.Name = "P1NBox";
            this.P1NBox.Size = new System.Drawing.Size(100, 20);
            this.P1NBox.TabIndex = 21;
            // 
            // P1hp
            // 
            this.P1hp.Location = new System.Drawing.Point(22, 29);
            this.P1hp.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1hp.Name = "P1hp";
            this.P1hp.Size = new System.Drawing.Size(100, 20);
            this.P1hp.TabIndex = 22;
            // 
            // P1dmg
            // 
            this.P1dmg.Location = new System.Drawing.Point(22, 55);
            this.P1dmg.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1dmg.Name = "P1dmg";
            this.P1dmg.Size = new System.Drawing.Size(100, 20);
            this.P1dmg.TabIndex = 23;
            // 
            // P1armor
            // 
            this.P1armor.Location = new System.Drawing.Point(22, 81);
            this.P1armor.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1armor.Name = "P1armor";
            this.P1armor.Size = new System.Drawing.Size(100, 20);
            this.P1armor.TabIndex = 24;
            // 
            // P1Spd
            // 
            this.P1Spd.Location = new System.Drawing.Point(22, 107);
            this.P1Spd.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1Spd.Name = "P1Spd";
            this.P1Spd.Size = new System.Drawing.Size(100, 20);
            this.P1Spd.TabIndex = 25;
            // 
            // P1lvl
            // 
            this.P1lvl.Location = new System.Drawing.Point(22, 133);
            this.P1lvl.MaximumSize = new System.Drawing.Size(100, 20);
            this.P1lvl.Name = "P1lvl";
            this.P1lvl.Size = new System.Drawing.Size(100, 20);
            this.P1lvl.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 320);
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
    }
}