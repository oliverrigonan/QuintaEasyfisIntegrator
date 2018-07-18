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
            this.label14 = new System.Windows.Forms.Label();
            this.cboTerm = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboWTax = new System.Windows.Forms.ComboBox();
            this.lblVatInput = new System.Windows.Forms.Label();
            this.cboVatInput = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboDiscount = new System.Windows.Forms.ComboBox();
            this.lblDefaultVatOutput = new System.Windows.Forms.Label();
            this.cboVatOutput = new System.Windows.Forms.ComboBox();
            this.txtAPIURLHostEasyfis = new System.Windows.Forms.TextBox();
            this.lblAPIUrlHostEasyfis = new System.Windows.Forms.Label();
            this.txtAPIURLHostSource = new System.Windows.Forms.TextBox();
            this.lblAPIUrlHostSource = new System.Windows.Forms.Label();
            this.txtJSONArchivePath = new System.Windows.Forms.TextBox();
            this.lblJSONArchivePath = new System.Windows.Forms.Label();
            this.txtJSONDownloadPath = new System.Windows.Forms.TextBox();
            this.lblJSONDownloadPath = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtJSONReturnPath = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.tabIntegrator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.tabSettings.Controls.Add(this.txtJSONReturnPath);
            this.tabSettings.Controls.Add(this.label15);
            this.tabSettings.Controls.Add(this.label14);
            this.tabSettings.Controls.Add(this.cboTerm);
            this.tabSettings.Controls.Add(this.label13);
            this.tabSettings.Controls.Add(this.cboWTax);
            this.tabSettings.Controls.Add(this.lblVatInput);
            this.tabSettings.Controls.Add(this.cboVatInput);
            this.tabSettings.Controls.Add(this.label12);
            this.tabSettings.Controls.Add(this.cboDiscount);
            this.tabSettings.Controls.Add(this.lblDefaultVatOutput);
            this.tabSettings.Controls.Add(this.cboVatOutput);
            this.tabSettings.Controls.Add(this.txtAPIURLHostEasyfis);
            this.tabSettings.Controls.Add(this.lblAPIUrlHostEasyfis);
            this.tabSettings.Controls.Add(this.txtAPIURLHostSource);
            this.tabSettings.Controls.Add(this.lblAPIUrlHostSource);
            this.tabSettings.Controls.Add(this.txtJSONArchivePath);
            this.tabSettings.Controls.Add(this.lblJSONArchivePath);
            this.tabSettings.Controls.Add(this.txtJSONDownloadPath);
            this.tabSettings.Controls.Add(this.lblJSONDownloadPath);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(560, 413);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings and Defaults";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Default Term";
            // 
            // cboTerm
            // 
            this.cboTerm.FormattingEnabled = true;
            this.cboTerm.Location = new System.Drawing.Point(275, 302);
            this.cboTerm.Name = "cboTerm";
            this.cboTerm.Size = new System.Drawing.Size(268, 24);
            this.cboTerm.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Default WTax";
            // 
            // cboWTax
            // 
            this.cboWTax.FormattingEnabled = true;
            this.cboWTax.Location = new System.Drawing.Point(6, 359);
            this.cboWTax.Name = "cboWTax";
            this.cboWTax.Size = new System.Drawing.Size(263, 24);
            this.cboWTax.TabIndex = 29;
            // 
            // lblVatInput
            // 
            this.lblVatInput.AutoSize = true;
            this.lblVatInput.Location = new System.Drawing.Point(6, 282);
            this.lblVatInput.Name = "lblVatInput";
            this.lblVatInput.Size = new System.Drawing.Size(113, 17);
            this.lblVatInput.TabIndex = 28;
            this.lblVatInput.Text = "Default Vat Input";
            // 
            // cboVatInput
            // 
            this.cboVatInput.FormattingEnabled = true;
            this.cboVatInput.Location = new System.Drawing.Point(6, 302);
            this.cboVatInput.Name = "cboVatInput";
            this.cboVatInput.Size = new System.Drawing.Size(263, 24);
            this.cboVatInput.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Default Discount";
            // 
            // cboDiscount
            // 
            this.cboDiscount.FormattingEnabled = true;
            this.cboDiscount.Location = new System.Drawing.Point(275, 247);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(268, 24);
            this.cboDiscount.TabIndex = 25;
            // 
            // lblDefaultVatOutput
            // 
            this.lblDefaultVatOutput.AutoSize = true;
            this.lblDefaultVatOutput.Location = new System.Drawing.Point(6, 227);
            this.lblDefaultVatOutput.Name = "lblDefaultVatOutput";
            this.lblDefaultVatOutput.Size = new System.Drawing.Size(125, 17);
            this.lblDefaultVatOutput.TabIndex = 24;
            this.lblDefaultVatOutput.Text = "Default Vat Output";
            // 
            // cboVatOutput
            // 
            this.cboVatOutput.FormattingEnabled = true;
            this.cboVatOutput.Location = new System.Drawing.Point(6, 247);
            this.cboVatOutput.Name = "cboVatOutput";
            this.cboVatOutput.Size = new System.Drawing.Size(263, 24);
            this.cboVatOutput.TabIndex = 23;
            // 
            // txtAPIURLHostEasyfis
            // 
            this.txtAPIURLHostEasyfis.Location = new System.Drawing.Point(275, 33);
            this.txtAPIURLHostEasyfis.Name = "txtAPIURLHostEasyfis";
            this.txtAPIURLHostEasyfis.Size = new System.Drawing.Size(268, 22);
            this.txtAPIURLHostEasyfis.TabIndex = 22;
            // 
            // lblAPIUrlHostEasyfis
            // 
            this.lblAPIUrlHostEasyfis.AutoSize = true;
            this.lblAPIUrlHostEasyfis.Location = new System.Drawing.Point(275, 13);
            this.lblAPIUrlHostEasyfis.Name = "lblAPIUrlHostEasyfis";
            this.lblAPIUrlHostEasyfis.Size = new System.Drawing.Size(157, 17);
            this.lblAPIUrlHostEasyfis.TabIndex = 21;
            this.lblAPIUrlHostEasyfis.Text = "API URL Host (Easyfis):";
            // 
            // txtAPIURLHostSource
            // 
            this.txtAPIURLHostSource.Location = new System.Drawing.Point(6, 33);
            this.txtAPIURLHostSource.Name = "txtAPIURLHostSource";
            this.txtAPIURLHostSource.Size = new System.Drawing.Size(263, 22);
            this.txtAPIURLHostSource.TabIndex = 20;
            // 
            // lblAPIUrlHostSource
            // 
            this.lblAPIUrlHostSource.AutoSize = true;
            this.lblAPIUrlHostSource.Location = new System.Drawing.Point(6, 13);
            this.lblAPIUrlHostSource.Name = "lblAPIUrlHostSource";
            this.lblAPIUrlHostSource.Size = new System.Drawing.Size(157, 17);
            this.lblAPIUrlHostSource.TabIndex = 19;
            this.lblAPIUrlHostSource.Text = "API URL Host (Source):";
            // 
            // txtJSONArchivePath
            // 
            this.txtJSONArchivePath.Location = new System.Drawing.Point(6, 141);
            this.txtJSONArchivePath.Name = "txtJSONArchivePath";
            this.txtJSONArchivePath.Size = new System.Drawing.Size(537, 22);
            this.txtJSONArchivePath.TabIndex = 18;
            // 
            // lblJSONArchivePath
            // 
            this.lblJSONArchivePath.AutoSize = true;
            this.lblJSONArchivePath.Location = new System.Drawing.Point(3, 121);
            this.lblJSONArchivePath.Name = "lblJSONArchivePath";
            this.lblJSONArchivePath.Size = new System.Drawing.Size(129, 17);
            this.lblJSONArchivePath.TabIndex = 17;
            this.lblJSONArchivePath.Text = "JSON Archive Path";
            // 
            // txtJSONDownloadPath
            // 
            this.txtJSONDownloadPath.Location = new System.Drawing.Point(6, 87);
            this.txtJSONDownloadPath.Name = "txtJSONDownloadPath";
            this.txtJSONDownloadPath.Size = new System.Drawing.Size(537, 22);
            this.txtJSONDownloadPath.TabIndex = 16;
            // 
            // lblJSONDownloadPath
            // 
            this.lblJSONDownloadPath.AutoSize = true;
            this.lblJSONDownloadPath.Location = new System.Drawing.Point(3, 67);
            this.lblJSONDownloadPath.Name = "lblJSONDownloadPath";
            this.lblJSONDownloadPath.Size = new System.Drawing.Size(144, 17);
            this.lblJSONDownloadPath.TabIndex = 15;
            this.lblJSONDownloadPath.Text = "JSON Download Path";
            // 
            // tabAbout
            // 
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Developer: Easyfis Corporation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Version: 1.07112018.NOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Easy Financial Information System Integrator";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(469, 527);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 34);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(388, 527);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 34);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtJSONReturnPath
            // 
            this.txtJSONReturnPath.Location = new System.Drawing.Point(6, 195);
            this.txtJSONReturnPath.Name = "txtJSONReturnPath";
            this.txtJSONReturnPath.Size = new System.Drawing.Size(537, 22);
            this.txtJSONReturnPath.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "JSON Return Path";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 567);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tabIntegrator);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 614);
            this.MinimumSize = new System.Drawing.Size(574, 614);
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
        private System.Windows.Forms.TextBox txtAPIURLHostSource;
        private System.Windows.Forms.Label lblAPIUrlHostSource;
        private System.Windows.Forms.TextBox txtJSONArchivePath;
        private System.Windows.Forms.Label lblJSONArchivePath;
        private System.Windows.Forms.TextBox txtJSONDownloadPath;
        private System.Windows.Forms.Label lblJSONDownloadPath;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAPIURLHostEasyfis;
        private System.Windows.Forms.Label lblAPIUrlHostEasyfis;
        private System.Windows.Forms.ComboBox cboVatOutput;
        private System.Windows.Forms.Label lblDefaultVatOutput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboDiscount;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblVatInput;
        private System.Windows.Forms.ComboBox cboVatInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboWTax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboTerm;
        private System.Windows.Forms.TextBox txtJSONReturnPath;
        private System.Windows.Forms.Label label15;
    }
}

