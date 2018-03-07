namespace BurningMac
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.currentMAC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteAllMac = new System.Windows.Forms.Button();
            this.deleteMac = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.macB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMAC = new System.Windows.Forms.Button();
            this.macE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.macLV = new System.Windows.Forms.ListView();
            this.ShowMessage = new System.Windows.Forms.TextBox();
            this.HttpWrite = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dealProgress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.addMacAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IPPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.macLV);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(631, 240);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.currentMAC);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.deleteAllMac);
            this.groupBox3.Controls.Add(this.deleteMac);
            this.groupBox3.Location = new System.Drawing.Point(400, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 95);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete MAC";
            // 
            // currentMAC
            // 
            this.currentMAC.AutoSize = true;
            this.currentMAC.Location = new System.Drawing.Point(99, 23);
            this.currentMAC.Name = "currentMAC";
            this.currentMAC.Size = new System.Drawing.Size(126, 14);
            this.currentMAC.TabIndex = 19;
            this.currentMAC.Text = "00:00:00:00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Selected MAC: ";
            // 
            // deleteAllMac
            // 
            this.deleteAllMac.Location = new System.Drawing.Point(115, 51);
            this.deleteAllMac.Name = "deleteAllMac";
            this.deleteAllMac.Size = new System.Drawing.Size(101, 33);
            this.deleteAllMac.TabIndex = 20;
            this.deleteAllMac.Text = "Delete All";
            this.deleteAllMac.UseVisualStyleBackColor = true;
            this.deleteAllMac.Click += new System.EventHandler(this.deleteAllMac_Click);
            // 
            // deleteMac
            // 
            this.deleteMac.Location = new System.Drawing.Point(10, 51);
            this.deleteMac.Name = "deleteMac";
            this.deleteMac.Size = new System.Drawing.Size(102, 33);
            this.deleteMac.TabIndex = 16;
            this.deleteMac.Text = "Delete";
            this.deleteMac.UseVisualStyleBackColor = true;
            this.deleteMac.Click += new System.EventHandler(this.deleteDB);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.macB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addMAC);
            this.groupBox1.Controls.Add(this.macE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(400, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 111);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add MAC";
            // 
            // macB
            // 
            this.macB.Location = new System.Drawing.Point(82, 18);
            this.macB.Name = "macB";
            this.macB.Size = new System.Drawing.Size(134, 23);
            this.macB.TabIndex = 1;
            this.macB.Text = "7C:CB:E2:E1:19:9E";
            this.macB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAC Begin:";
            // 
            // addMAC
            // 
            this.addMAC.Location = new System.Drawing.Point(37, 76);
            this.addMAC.Name = "addMAC";
            this.addMAC.Size = new System.Drawing.Size(146, 28);
            this.addMAC.TabIndex = 0;
            this.addMAC.Text = "Add MAC";
            this.addMAC.UseVisualStyleBackColor = true;
            this.addMAC.Click += new System.EventHandler(this.addMACClick);
            // 
            // macE
            // 
            this.macE.Location = new System.Drawing.Point(82, 47);
            this.macE.Name = "macE";
            this.macE.Size = new System.Drawing.Size(134, 23);
            this.macE.TabIndex = 4;
            this.macE.Text = "7C:CB:E2:E1:19:A4";
            this.macE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "MAC End:";
            // 
            // macLV
            // 
            this.macLV.GridLines = true;
            this.macLV.Location = new System.Drawing.Point(13, 22);
            this.macLV.Name = "macLV";
            this.macLV.Size = new System.Drawing.Size(378, 212);
            this.macLV.TabIndex = 14;
            this.macLV.UseCompatibleStateImageBehavior = false;
            this.macLV.View = System.Windows.Forms.View.Details;
            this.macLV.SelectedIndexChanged += new System.EventHandler(this.macLV_SelectedIndexChanged);
            // 
            // ShowMessage
            // 
            this.ShowMessage.Location = new System.Drawing.Point(13, 20);
            this.ShowMessage.Multiline = true;
            this.ShowMessage.Name = "ShowMessage";
            this.ShowMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ShowMessage.Size = new System.Drawing.Size(498, 142);
            this.ShowMessage.TabIndex = 8;
            // 
            // HttpWrite
            // 
            this.HttpWrite.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HttpWrite.Location = new System.Drawing.Point(518, 20);
            this.HttpWrite.Name = "HttpWrite";
            this.HttpWrite.Size = new System.Drawing.Size(106, 142);
            this.HttpWrite.TabIndex = 7;
            this.HttpWrite.Text = "Write";
            this.HttpWrite.UseVisualStyleBackColor = true;
            this.HttpWrite.Click += new System.EventHandler(this.HttpWrite_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dealProgress);
            this.groupBox2.Controls.Add(this.HttpWrite);
            this.groupBox2.Controls.Add(this.ShowMessage);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 202);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Message";
            // 
            // dealProgress
            // 
            this.dealProgress.Location = new System.Drawing.Point(13, 170);
            this.dealProgress.Name = "dealProgress";
            this.dealProgress.Size = new System.Drawing.Size(611, 23);
            this.dealProgress.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(654, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // addMacAddressToolStripMenuItem
            // 
            this.addMacAddressToolStripMenuItem.Name = "addMacAddressToolStripMenuItem";
            this.addMacAddressToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // partNumberToolStripMenuItem
            // 
            this.partNumberToolStripMenuItem.Name = "partNumberToolStripMenuItem";
            this.partNumberToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.IPAddress);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.IPPort);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(12, 283);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(631, 50);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "HTTP Settings";
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(219, 18);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(135, 21);
            this.IPAddress.TabIndex = 1;
            this.IPAddress.Text = "192.168.1.202";
            this.IPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP Address";
            // 
            // IPPort
            // 
            this.IPPort.Location = new System.Drawing.Point(441, 19);
            this.IPPort.Name = "IPPort";
            this.IPPort.Size = new System.Drawing.Size(46, 21);
            this.IPPort.TabIndex = 4;
            this.IPPort.Text = "80";
            this.IPPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "IP Port";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 565);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BurningMac";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label currentMAC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteAllMac;
        private System.Windows.Forms.Button deleteMac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox macB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMAC;
        private System.Windows.Forms.TextBox macE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView macLV;
        private System.Windows.Forms.TextBox ShowMessage;
        private System.Windows.Forms.Button HttpWrite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMacAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partNumberToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar dealProgress;
    }
}

