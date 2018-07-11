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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAPIURLHost = new System.Windows.Forms.TextBox();
            this.lblAPIUrlHost = new System.Windows.Forms.Label();
            this.txtJSONDownloadPath = new System.Windows.Forms.TextBox();
            this.lblJSONDownloadPath = new System.Windows.Forms.Label();
            this.txtJSONArchivePath = new System.Windows.Forms.TextBox();
            this.lblJSONArchivePath = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 63);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 9);
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
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Easyfis Integrator";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 78);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time:";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(15, 98);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(350, 22);
            this.txtTime.TabIndex = 2;
            // 
            // txtTimeTrigger
            // 
            this.txtTimeTrigger.Location = new System.Drawing.Point(371, 98);
            this.txtTimeTrigger.Name = "txtTimeTrigger";
            this.txtTimeTrigger.Size = new System.Drawing.Size(336, 22);
            this.txtTimeTrigger.TabIndex = 4;
            // 
            // lblTimeTrigger
            // 
            this.lblTimeTrigger.AutoSize = true;
            this.lblTimeTrigger.Location = new System.Drawing.Point(368, 78);
            this.lblTimeTrigger.Name = "lblTimeTrigger";
            this.lblTimeTrigger.Size = new System.Drawing.Size(93, 17);
            this.lblTimeTrigger.TabIndex = 3;
            this.lblTimeTrigger.Text = "Time Trigger:";
            // 
            // txtActivity
            // 
            this.txtActivity.Enabled = false;
            this.txtActivity.Location = new System.Drawing.Point(14, 265);
            this.txtActivity.Multiline = true;
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(773, 173);
            this.txtActivity.TabIndex = 6;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(14, 245);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(56, 17);
            this.lblActivity.TabIndex = 5;
            this.lblActivity.Text = "Activity:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(713, 96);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 27);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // txtAPIURLHost
            // 
            this.txtAPIURLHost.Location = new System.Drawing.Point(14, 155);
            this.txtAPIURLHost.Name = "txtAPIURLHost";
            this.txtAPIURLHost.Size = new System.Drawing.Size(773, 22);
            this.txtAPIURLHost.TabIndex = 10;
            // 
            // lblAPIUrlHost
            // 
            this.lblAPIUrlHost.AutoSize = true;
            this.lblAPIUrlHost.Location = new System.Drawing.Point(14, 135);
            this.lblAPIUrlHost.Name = "lblAPIUrlHost";
            this.lblAPIUrlHost.Size = new System.Drawing.Size(98, 17);
            this.lblAPIUrlHost.TabIndex = 9;
            this.lblAPIUrlHost.Text = "API URL Host:";
            // 
            // txtJSONDownloadPath
            // 
            this.txtJSONDownloadPath.Location = new System.Drawing.Point(14, 210);
            this.txtJSONDownloadPath.Name = "txtJSONDownloadPath";
            this.txtJSONDownloadPath.Size = new System.Drawing.Size(376, 22);
            this.txtJSONDownloadPath.TabIndex = 12;
            // 
            // lblJSONDownloadPath
            // 
            this.lblJSONDownloadPath.AutoSize = true;
            this.lblJSONDownloadPath.Location = new System.Drawing.Point(14, 190);
            this.lblJSONDownloadPath.Name = "lblJSONDownloadPath";
            this.lblJSONDownloadPath.Size = new System.Drawing.Size(144, 17);
            this.lblJSONDownloadPath.TabIndex = 11;
            this.lblJSONDownloadPath.Text = "JSON Download Path";
            // 
            // txtJSONArchivePath
            // 
            this.txtJSONArchivePath.Location = new System.Drawing.Point(396, 210);
            this.txtJSONArchivePath.Name = "txtJSONArchivePath";
            this.txtJSONArchivePath.Size = new System.Drawing.Size(391, 22);
            this.txtJSONArchivePath.TabIndex = 14;
            // 
            // lblJSONArchivePath
            // 
            this.lblJSONArchivePath.AutoSize = true;
            this.lblJSONArchivePath.Location = new System.Drawing.Point(393, 190);
            this.lblJSONArchivePath.Name = "lblJSONArchivePath";
            this.lblJSONArchivePath.Size = new System.Drawing.Size(129, 17);
            this.lblJSONArchivePath.TabIndex = 13;
            this.lblJSONArchivePath.Text = "JSON Archive Path";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtJSONArchivePath);
            this.Controls.Add(this.lblJSONArchivePath);
            this.Controls.Add(this.txtJSONDownloadPath);
            this.Controls.Add(this.lblJSONDownloadPath);
            this.Controls.Add(this.txtAPIURLHost);
            this.Controls.Add(this.lblAPIUrlHost);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.txtTimeTrigger);
            this.Controls.Add(this.lblTimeTrigger);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormMain";
            this.Text = "Easyfis Integrator V.1.07112018.NOR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAPIURLHost;
        private System.Windows.Forms.Label lblAPIUrlHost;
        private System.Windows.Forms.TextBox txtJSONDownloadPath;
        private System.Windows.Forms.Label lblJSONDownloadPath;
        private System.Windows.Forms.TextBox txtJSONArchivePath;
        private System.Windows.Forms.Label lblJSONArchivePath;
    }
}

