namespace WebDeployEase
{
    partial class Starter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starter));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatabaseUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatabasePassword = new System.Windows.Forms.TextBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.checkRunSpInBackground = new System.Windows.Forms.CheckBox();
            this.btnOpenFolderPath = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Siyam Rupali", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(282, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web Deploy Ease Installer Tool";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 47);
            this.panel1.TabIndex = 0;
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApplicationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            this.txtApplicationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApplicationName.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApplicationName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtApplicationName.Location = new System.Drawing.Point(350, 102);
            this.txtApplicationName.Multiline = true;
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(341, 26);
            this.txtApplicationName.TabIndex = 2;
            this.txtApplicationName.TextChanged += new System.EventHandler(this.txtApplicationName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(192, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Application Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(192, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Folder Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(192, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "DB User Name";
            // 
            // txtDatabaseUserName
            // 
            this.txtDatabaseUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatabaseUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            this.txtDatabaseUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatabaseUserName.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDatabaseUserName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDatabaseUserName.Location = new System.Drawing.Point(350, 211);
            this.txtDatabaseUserName.Multiline = true;
            this.txtDatabaseUserName.Name = "txtDatabaseUserName";
            this.txtDatabaseUserName.Size = new System.Drawing.Size(341, 26);
            this.txtDatabaseUserName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(192, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Database Name";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatabaseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            this.txtDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatabaseName.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDatabaseName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDatabaseName.Location = new System.Drawing.Point(350, 174);
            this.txtDatabaseName.Multiline = true;
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(341, 26);
            this.txtDatabaseName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(192, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // txtDatabasePassword
            // 
            this.txtDatabasePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatabasePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            this.txtDatabasePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatabasePassword.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDatabasePassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDatabasePassword.Location = new System.Drawing.Point(350, 248);
            this.txtDatabasePassword.Multiline = true;
            this.txtDatabasePassword.Name = "txtDatabasePassword";
            this.txtDatabasePassword.Size = new System.Drawing.Size(341, 26);
            this.txtDatabasePassword.TabIndex = 10;
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInstall.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInstall.Location = new System.Drawing.Point(426, 340);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(119, 38);
            this.btnInstall.TabIndex = 12;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // checkRunSpInBackground
            // 
            this.checkRunSpInBackground.AutoSize = true;
            this.checkRunSpInBackground.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkRunSpInBackground.ForeColor = System.Drawing.SystemColors.Control;
            this.checkRunSpInBackground.Location = new System.Drawing.Point(361, 292);
            this.checkRunSpInBackground.Name = "checkRunSpInBackground";
            this.checkRunSpInBackground.Size = new System.Drawing.Size(243, 24);
            this.checkRunSpInBackground.TabIndex = 14;
            this.checkRunSpInBackground.Text = "Run Store Procedure\'s in Bacground";
            this.checkRunSpInBackground.UseVisualStyleBackColor = true;
            // 
            // btnOpenFolderPath
            // 
            this.btnOpenFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnOpenFolderPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenFolderPath.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFolderPath.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenFolderPath.Location = new System.Drawing.Point(656, 137);
            this.btnOpenFolderPath.Name = "btnOpenFolderPath";
            this.btnOpenFolderPath.Size = new System.Drawing.Size(35, 26);
            this.btnOpenFolderPath.TabIndex = 17;
            this.btnOpenFolderPath.Text = "...";
            this.btnOpenFolderPath.UseVisualStyleBackColor = false;
            this.btnOpenFolderPath.Click += new System.EventHandler(this.btnOpenFolderPath_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            this.txtFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFolderPath.Font = new System.Drawing.Font("Siyam Rupali", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFolderPath.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFolderPath.Location = new System.Drawing.Point(350, 137);
            this.txtFolderPath.Multiline = true;
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(300, 26);
            this.txtFolderPath.TabIndex = 4;
            this.txtFolderPath.TextChanged += new System.EventHandler(this.txtFolderPath_TextChanged);
            // 
            // Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(875, 527);
            this.Controls.Add(this.btnOpenFolderPath);
            this.Controls.Add(this.checkRunSpInBackground);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDatabasePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatabaseUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtApplicationName);
            this.Name = "Starter";
            this.Text = "WebDeployEase Installer";
            this.Load += new System.EventHandler(this.Starter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtApplicationName;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtDatabaseUserName;
        private Label label5;
        private TextBox txtDatabaseName;
        private Label label6;
        private TextBox txtDatabasePassword;
        private Button btnInstall;
        private CheckBox checkRunSpInBackground;
        private Button btnOpenFolderPath;
        private TextBox txtFolderPath;
    }
}