namespace EasyfisIntegrator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtTimeTrigger = new System.Windows.Forms.TextBox();
            this.lblTimeTrigger = new System.Windows.Forms.Label();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.tabIntegrator = new System.Windows.Forms.TabControl();
            this.tabActivity = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.txtAPIURLHost = new System.Windows.Forms.TextBox();
            this.lblAPIUrlHost = new System.Windows.Forms.Label();
            this.txtJSONArchivePath = new System.Windows.Forms.TextBox();
            this.lblJSONArchivePath = new System.Windows.Forms.Label();
            this.txtJSONDownloadPath = new System.Windows.Forms.TextBox();
            this.lblJSONDownloadPath = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabIntegrator.SuspendLayout();
            this.tabActivity.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 67);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Easyfis Integrator";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(6, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time:";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(6, 33);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(264, 22);
            this.txtTime.TabIndex = 2;
            // 
            // txtTimeTrigger
            // 
            this.txtTimeTrigger.Location = new System.Drawing.Point(276, 33);
            this.txtTimeTrigger.Name = "txtTimeTrigger";
            this.txtTimeTrigger.Size = new System.Drawing.Size(267, 22);
            this.txtTimeTrigger.TabIndex = 4;
            // 
            // lblTimeTrigger
            // 
            this.lblTimeTrigger.AutoSize = true;
            this.lblTimeTrigger.Location = new System.Drawing.Point(273, 13);
            this.lblTimeTrigger.Name = "lblTimeTrigger";
            this.lblTimeTrigger.Size = new System.Drawing.Size(93, 17);
            this.lblTimeTrigger.TabIndex = 3;
            this.lblTimeTrigger.Text = "Time Trigger:";
            // 
            // txtActivity
            // 
            this.txtActivity.Enabled = false;
            this.txtActivity.Location = new System.Drawing.Point(6, 88);
            this.txtActivity.Multiline = true;
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(537, 311);
            this.txtActivity.TabIndex = 6;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(6, 68);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(84, 17);
            this.lblActivity.TabIndex = 5;
            this.lblActivity.Text = "Activity Log:";
            // 
            // tabIntegrator
            // 
            this.tabIntegrator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabIntegrator.Controls.Add(this.tabActivity);
            this.tabIntegrator.Controls.Add(this.tabSettings);
            this.tabIntegrator.Controls.Add(this.tabAbout);
            this.tabIntegrator.Location = new System.Drawing.Point(-3, 77);
            this.tabIntegrator.Name = "tabIntegrator";
            this.tabIntegrator.Padding = new System.Drawing.Point(3, 3);
            this.tabIntegrator.SelectedIndex = 0;
            this.tabIntegrator.Size = new System.Drawing.Size(568, 442);
            this.tabIntegrator.TabIndex = 15;
            // 
            // tabActivity
            // 
            this.tabActivity.Controls.Add(this.txtTimeTrigger);
            this.tabActivity.Controls.Add(this.lblTime);
            this.tabActivity.Controls.Add(this.txtTime);
            this.tabActivity.Controls.Add(this.lblTimeTrigger);
            this.tabActivity.Controls.Add(this.lblActivity);
            this.tabActivity.Controls.Add(this.txtActivity);
            this.tabActivity.Location = new System.Drawing.Point(4, 25);
            this.tabActivity.Name = "tabActivity";
            this.tabActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabActivity.Size = new System.Drawing.Size(560, 413);
            this.tabActivity.TabIndex = 0;
            this.tabActivity.Text = "Activity";
            this.tabActivity.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.txtAPIURLHost);
            this.tabSettings.Controls.Add(this.lblAPIUrlHost);
            this.tabSettings.Controls.Add(this.txtJSONArchivePath);
            this.tabSettings.Controls.Add(this.lblJSONArchivePath);
            this.tabSettings.Controls.Add(this.txtJSONDownloadPath);
            this.tabSettings.Controls.Add(this.lblJSONDownloadPath);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(560, 413);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // txtAPIURLHost
            // 
            this.txtAPIURLHost.Location = new System.Drawing.Point(6, 32);
            this.txtAPIURLHost.Name = "txtAPIURLHost";
            this.txtAPIURLHost.Size = new System.Drawing.Size(537, 22);
            this.txtAPIURLHost.TabIndex = 20;
            // 
            // lblAPIUrlHost
            // 
            this.lblAPIUrlHost.AutoSize = true;
            this.lblAPIUrlHost.Location = new System.Drawing.Point(6, 12);
            this.lblAPIUrlHost.Name = "lblAPIUrlHost";
            this.lblAPIUrlHost.Size = new System.Drawing.Size(98, 17);
            this.lblAPIUrlHost.TabIndex = 19;
            this.lblAPIUrlHost.Text = "API URL Host:";
            // 
            // txtJSONArchivePath
            // 
            this.txtJSONArchivePath.Location = new System.Drawing.Point(6, 140);
            this.txtJSONArchivePath.Name = "txtJSONArchivePath";
            this.txtJSONArchivePath.Size = new System.Drawing.Size(537, 22);
            this.txtJSONArchivePath.TabIndex = 18;
            // 
            // lblJSONArchivePath
            // 
            this.lblJSONArchivePath.AutoSize = true;
            this.lblJSONArchivePath.Location = new System.Drawing.Point(3, 120);
            this.lblJSONArchivePath.Name = "lblJSONArchivePath";
            this.lblJSONArchivePath.Size = new System.Drawing.Size(129, 17);
            this.lblJSONArchivePath.TabIndex = 17;
            this.lblJSONArchivePath.Text = "JSON Archive Path";
            // 
            // txtJSONDownloadPath
            // 
            this.txtJSONDownloadPath.Location = new System.Drawing.Point(6, 86);
            this.txtJSONDownloadPath.Name = "txtJSONDownloadPath";
            this.txtJSONDownloadPath.Size = new System.Drawing.Size(537, 22);
            this.txtJSONDownloadPath.TabIndex = 16;
            // 
            // lblJSONDownloadPath
            // 
            this.lblJSONDownloadPath.AutoSize = true;
            this.lblJSONDownloadPath.Location = new System.Drawing.Point(3, 66);
            this.lblJSONDownloadPath.Name = "lblJSONDownloadPath";
            this.lblJSONDownloadPath.Size = new System.Drawing.Size(144, 17);
            this.lblJSONDownloadPath.TabIndex = 15;
            this.lblJSONDownloadPath.Text = "JSON Download Path";
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.label10);
            this.tabAbout.Controls.Add(this.label11);
            this.tabAbout.Controls.Add(this.label8);
            this.tabAbout.Controls.Add(this.label9);
            this.tabAbout.Controls.Add(this.label7);
            this.tabAbout.Controls.Add(this.label6);
            this.tabAbout.Controls.Add(this.label5);
            this.tabAbout.Controls.Add(this.label4);
            this.tabAbout.Controls.Add(this.label3);
            this.tabAbout.Controls.Add(this.label2);
            this.tabAbout.Location = new System.Drawing.Point(4, 25);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(560, 413);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "09234561789";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "SUN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "09234561789";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "SUN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "09234561789";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "SUN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contact Support:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Developer: Easyfis Corporation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Version: 1.07112018.NOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Easy Financial Information System Integrator";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 509);
            this.Controls.Add(this.tabIntegrator);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 556);
            this.MinimumSize = new System.Drawing.Size(574, 556);
            this.Name = "FormMain";
            this.Text = "Easyfis Integrator V.1.07112018.NOR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabIntegrator.ResumeLayout(false);
            this.tabActivity.ResumeLayout(false);
            this.tabActivity.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtTimeTrigger;
        private System.Windows.Forms.Label lblTimeTrigger;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.TabControl tabIntegrator;
        private System.Windows.Forms.TabPage tabActivity;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TextBox txtAPIURLHost;
        private System.Windows.Forms.Label lblAPIUrlHost;
        private System.Windows.Forms.TextBox txtJSONArchivePath;
        private System.Windows.Forms.Label lblJSONArchivePath;
        private System.Windows.Forms.TextBox txtJSONDownloadPath;
        private System.Windows.Forms.Label lblJSONDownloadPath;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

