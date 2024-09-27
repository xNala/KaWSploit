
namespace KaWSploit
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.accountStatusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.twoFactorBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.targetStatusLabel = new System.Windows.Forms.Label();
            this.searchPlayerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.attackBtn = new System.Windows.Forms.Button();
            this.assassinateBtn = new System.Windows.Forms.Button();
            this.scoutBtn = new System.Windows.Forms.Button();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.stealBtn = new System.Windows.Forms.Button();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 16);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email:";
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.Control;
            this.emailBox.Location = new System.Drawing.Point(90, 13);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(487, 20);
            this.emailBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountStatusLabel
            // 
            this.accountStatusLabel.AutoSize = true;
            this.accountStatusLabel.Location = new System.Drawing.Point(12, 96);
            this.accountStatusLabel.Name = "accountStatusLabel";
            this.accountStatusLabel.Size = new System.Drawing.Size(139, 13);
            this.accountStatusLabel.TabIndex = 3;
            this.accountStatusLabel.Text = "STATUS: UNCONNECTED";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.twoFactorBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.accountStatusLabel);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 124);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "2FA Code:";
            // 
            // twoFactorBox
            // 
            this.twoFactorBox.BackColor = System.Drawing.SystemColors.Control;
            this.twoFactorBox.Location = new System.Drawing.Point(90, 65);
            this.twoFactorBox.Name = "twoFactorBox";
            this.twoFactorBox.Size = new System.Drawing.Size(486, 20);
            this.twoFactorBox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 42);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordBox.Location = new System.Drawing.Point(90, 39);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(486, 20);
            this.passwordBox.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.HotPink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 5);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 3);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel4.Controls.Add(this.targetStatusLabel);
            this.panel4.Controls.Add(this.searchPlayerBtn);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.attackBtn);
            this.panel4.Controls.Add(this.assassinateBtn);
            this.panel4.Controls.Add(this.scoutBtn);
            this.panel4.Controls.Add(this.playerNameLabel);
            this.panel4.Controls.Add(this.stealBtn);
            this.panel4.Controls.Add(this.playerNameTextBox);
            this.panel4.Location = new System.Drawing.Point(0, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 148);
            this.panel4.TabIndex = 5;
            // 
            // targetStatusLabel
            // 
            this.targetStatusLabel.AutoSize = true;
            this.targetStatusLabel.Location = new System.Drawing.Point(12, 36);
            this.targetStatusLabel.Name = "targetStatusLabel";
            this.targetStatusLabel.Size = new System.Drawing.Size(141, 13);
            this.targetStatusLabel.TabIndex = 9;
            this.targetStatusLabel.Text = "Target Status: NOT FOUND";
            // 
            // searchPlayerBtn
            // 
            this.searchPlayerBtn.Location = new System.Drawing.Point(454, 11);
            this.searchPlayerBtn.Name = "searchPlayerBtn";
            this.searchPlayerBtn.Size = new System.Drawing.Size(123, 23);
            this.searchPlayerBtn.TabIndex = 8;
            this.searchPlayerBtn.Text = "SEARCH";
            this.searchPlayerBtn.UseVisualStyleBackColor = true;
            this.searchPlayerBtn.Click += new System.EventHandler(this.searchPlayerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Action:";
            // 
            // attackBtn
            // 
            this.attackBtn.Location = new System.Drawing.Point(67, 119);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(123, 23);
            this.attackBtn.TabIndex = 5;
            this.attackBtn.Text = "ATTACK";
            this.attackBtn.UseVisualStyleBackColor = true;
            this.attackBtn.Click += new System.EventHandler(this.attackBtn_Click);
            // 
            // assassinateBtn
            // 
            this.assassinateBtn.Location = new System.Drawing.Point(196, 118);
            this.assassinateBtn.Name = "assassinateBtn";
            this.assassinateBtn.Size = new System.Drawing.Size(123, 23);
            this.assassinateBtn.TabIndex = 4;
            this.assassinateBtn.Text = "ASSASSINATE";
            this.assassinateBtn.UseVisualStyleBackColor = true;
            this.assassinateBtn.Click += new System.EventHandler(this.assassinateBtn_Click);
            // 
            // scoutBtn
            // 
            this.scoutBtn.Location = new System.Drawing.Point(325, 119);
            this.scoutBtn.Name = "scoutBtn";
            this.scoutBtn.Size = new System.Drawing.Size(123, 23);
            this.scoutBtn.TabIndex = 3;
            this.scoutBtn.Text = "SCOUT";
            this.scoutBtn.UseVisualStyleBackColor = true;
            this.scoutBtn.Click += new System.EventHandler(this.scoutBtn_Click);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(12, 16);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(72, 13);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "Target Name:";
            // 
            // stealBtn
            // 
            this.stealBtn.Location = new System.Drawing.Point(454, 119);
            this.stealBtn.Name = "stealBtn";
            this.stealBtn.Size = new System.Drawing.Size(123, 23);
            this.stealBtn.TabIndex = 2;
            this.stealBtn.Text = "STEAL";
            this.stealBtn.UseVisualStyleBackColor = true;
            this.stealBtn.Click += new System.EventHandler(this.stealBtn_Click);
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.playerNameTextBox.Location = new System.Drawing.Point(90, 13);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(358, 20);
            this.playerNameTextBox.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(2, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(590, 3);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 302);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(588, 83);
            this.panel6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(413, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bernstein, and Moxie, and Turing, and Grace... One day my name go in that databas" +
    "e.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Worship a list of the greats - Kernighan, Ritchie, Woz, Thompson, and Gates...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "@BobFagget - Howdy partner! I\'ll release mine if you release yours.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(478, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "This game is FULL of botters and cheaters. Anyone who says otherwise is full of c" +
    "opium or cheating.";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.HotPink;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(588, 5);
            this.panel7.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "KaW PvP Exploit Example";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label3_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(588, 385);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(588, 400);
            this.MinimumSize = new System.Drawing.Size(588, 360);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "KaW PvP Exploit";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label accountStatusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.Button assassinateBtn;
        private System.Windows.Forms.Button scoutBtn;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Button stealBtn;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox twoFactorBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label targetStatusLabel;
        private System.Windows.Forms.Button searchPlayerBtn;
        private System.Windows.Forms.Label label3;
    }
}

