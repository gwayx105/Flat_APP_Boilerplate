namespace Flat_APP_Boilerplate
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenuContainer = new MetroFramework.Controls.MetroPanel();
            this.pnlIndicator = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnVersion = new System.Windows.Forms.Button();
            this.btnPlatform = new System.Windows.Forms.Button();
            this.btnDataConnection = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlMaster = new MetroFramework.Controls.MetroPanel();
            this.pnlMenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuContainer
            // 
            this.pnlMenuContainer.Controls.Add(this.pnlIndicator);
            this.pnlMenuContainer.Controls.Add(this.picLogo);
            this.pnlMenuContainer.Controls.Add(this.btnVersion);
            this.pnlMenuContainer.Controls.Add(this.btnPlatform);
            this.pnlMenuContainer.Controls.Add(this.btnDataConnection);
            this.pnlMenuContainer.Controls.Add(this.btnShare);
            this.pnlMenuContainer.Controls.Add(this.btnSave);
            this.pnlMenuContainer.Controls.Add(this.btnMessages);
            this.pnlMenuContainer.Controls.Add(this.btnHome);
            this.pnlMenuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuContainer.HorizontalScrollbarBarColor = true;
            this.pnlMenuContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenuContainer.HorizontalScrollbarSize = 10;
            this.pnlMenuContainer.Location = new System.Drawing.Point(1, 30);
            this.pnlMenuContainer.Name = "pnlMenuContainer";
            this.pnlMenuContainer.Size = new System.Drawing.Size(281, 949);
            this.pnlMenuContainer.TabIndex = 1;
            this.pnlMenuContainer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlMenuContainer.VerticalScrollbarBarColor = true;
            this.pnlMenuContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenuContainer.VerticalScrollbarSize = 10;
            // 
            // pnlIndicator
            // 
            this.pnlIndicator.BackColor = System.Drawing.Color.Red;
            this.pnlIndicator.Location = new System.Drawing.Point(3, 158);
            this.pnlIndicator.Name = "pnlIndicator";
            this.pnlIndicator.Size = new System.Drawing.Size(17, 64);
            this.pnlIndicator.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(272, 146);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // btnVersion
            // 
            this.btnVersion.BackColor = System.Drawing.Color.Transparent;
            this.btnVersion.FlatAppearance.BorderSize = 0;
            this.btnVersion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVersion.Image = ((System.Drawing.Image)(resources.GetObject("btnVersion.Image")));
            this.btnVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVersion.Location = new System.Drawing.Point(19, 578);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(256, 64);
            this.btnVersion.TabIndex = 2;
            this.btnVersion.Text = "     Version   ";
            this.btnVersion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVersion.UseVisualStyleBackColor = false;
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            // 
            // btnPlatform
            // 
            this.btnPlatform.BackColor = System.Drawing.Color.Transparent;
            this.btnPlatform.FlatAppearance.BorderSize = 0;
            this.btnPlatform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPlatform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlatform.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlatform.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlatform.Image = ((System.Drawing.Image)(resources.GetObject("btnPlatform.Image")));
            this.btnPlatform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlatform.Location = new System.Drawing.Point(19, 508);
            this.btnPlatform.Name = "btnPlatform";
            this.btnPlatform.Size = new System.Drawing.Size(256, 64);
            this.btnPlatform.TabIndex = 2;
            this.btnPlatform.Text = "     Platform      ";
            this.btnPlatform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlatform.UseVisualStyleBackColor = false;
            this.btnPlatform.Click += new System.EventHandler(this.btnPlatform_Click);
            // 
            // btnDataConnection
            // 
            this.btnDataConnection.BackColor = System.Drawing.Color.Transparent;
            this.btnDataConnection.FlatAppearance.BorderSize = 0;
            this.btnDataConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDataConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataConnection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataConnection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDataConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnDataConnection.Image")));
            this.btnDataConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataConnection.Location = new System.Drawing.Point(19, 438);
            this.btnDataConnection.Name = "btnDataConnection";
            this.btnDataConnection.Size = new System.Drawing.Size(256, 64);
            this.btnDataConnection.TabIndex = 2;
            this.btnDataConnection.Text = "     Database ";
            this.btnDataConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDataConnection.UseVisualStyleBackColor = false;
            this.btnDataConnection.Click += new System.EventHandler(this.btnDataConnection_Click);
            // 
            // btnShare
            // 
            this.btnShare.BackColor = System.Drawing.Color.Transparent;
            this.btnShare.FlatAppearance.BorderSize = 0;
            this.btnShare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShare.Image = ((System.Drawing.Image)(resources.GetObject("btnShare.Image")));
            this.btnShare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShare.Location = new System.Drawing.Point(19, 368);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(256, 64);
            this.btnShare.TabIndex = 2;
            this.btnShare.Text = "     Share       ";
            this.btnShare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShare.UseVisualStyleBackColor = false;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(19, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(256, 64);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "     Save         ";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.Color.Transparent;
            this.btnMessages.FlatAppearance.BorderSize = 0;
            this.btnMessages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMessages.Image = ((System.Drawing.Image)(resources.GetObject("btnMessages.Image")));
            this.btnMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessages.Location = new System.Drawing.Point(19, 228);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(256, 64);
            this.btnMessages.TabIndex = 2;
            this.btnMessages.Text = "     Messages ";
            this.btnMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMessages.UseVisualStyleBackColor = false;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(19, 158);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(256, 64);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "      Home ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlMaster
            // 
            this.pnlMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMaster.HorizontalScrollbarBarColor = true;
            this.pnlMaster.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMaster.HorizontalScrollbarSize = 10;
            this.pnlMaster.Location = new System.Drawing.Point(282, 30);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(1208, 949);
            this.pnlMaster.TabIndex = 2;
            this.pnlMaster.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlMaster.VerticalScrollbarBarColor = true;
            this.pnlMaster.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMaster.VerticalScrollbarSize = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 980);
            this.Controls.Add(this.pnlMaster);
            this.Controls.Add(this.pnlMenuContainer);
            this.DisplayHeader = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(1, 30, 1, 1);
            this.Resizable = false;
            this.Text = "Flat APP";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel pnlMenuContainer;
        private MetroFramework.Controls.MetroPanel pnlMaster;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnVersion;
        private System.Windows.Forms.Button btnPlatform;
        private System.Windows.Forms.Button btnDataConnection;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlIndicator;
    }
}

