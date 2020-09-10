namespace chromium3
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devFavsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsmybrowsercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedtestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCookiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pContainer = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFoward = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRefresh = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialGo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialClosetab = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialNewtab = new MaterialSkin.Controls.MaterialRaisedButton();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(289, 84);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(558, 22);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.favoritesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(169, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.devFavsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // devFavsToolStripMenuItem
            // 
            this.devFavsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whatsmybrowsercomToolStripMenuItem,
            this.speedtestToolStripMenuItem});
            this.devFavsToolStripMenuItem.Name = "devFavsToolStripMenuItem";
            this.devFavsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devFavsToolStripMenuItem.Text = "Dev_Favs";
            // 
            // whatsmybrowsercomToolStripMenuItem
            // 
            this.whatsmybrowsercomToolStripMenuItem.Name = "whatsmybrowsercomToolStripMenuItem";
            this.whatsmybrowsercomToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.whatsmybrowsercomToolStripMenuItem.Text = "whatsmybrowser.com";
            this.whatsmybrowsercomToolStripMenuItem.Click += new System.EventHandler(this.whatsmybrowsercomToolStripMenuItem_Click);
            // 
            // speedtestToolStripMenuItem
            // 
            this.speedtestToolStripMenuItem.Name = "speedtestToolStripMenuItem";
            this.speedtestToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.speedtestToolStripMenuItem.Text = "speedtest";
            this.speedtestToolStripMenuItem.Click += new System.EventHandler(this.speedtestToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCookiesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // deleteCookiesToolStripMenuItem
            // 
            this.deleteCookiesToolStripMenuItem.Name = "deleteCookiesToolStripMenuItem";
            this.deleteCookiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCookiesToolStripMenuItem.Text = "Delete cookies";
            this.deleteCookiesToolStripMenuItem.Click += new System.EventHandler(this.deleteCookiesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settings_Load);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem1.Text = "settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.favoritesToolStripMenuItem.Text = "Favorites";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Text = "Favorite 1 ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 572);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1116, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.Location = new System.Drawing.Point(12, 423);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1104, 272);
            this.pContainer.TabIndex = 5;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            // 
            // bar
            // 
            this.bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bar.Location = new System.Drawing.Point(106, 710);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(358, 23);
            this.bar.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 717);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Download progress";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(970, 720);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Created by Tomáš Kárník";
            // 
            // materialBack
            // 
            this.materialBack.Depth = 0;
            this.materialBack.Location = new System.Drawing.Point(5, 66);
            this.materialBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBack.Name = "materialBack";
            this.materialBack.Primary = true;
            this.materialBack.Size = new System.Drawing.Size(75, 58);
            this.materialBack.TabIndex = 14;
            this.materialBack.Text = "<";
            this.materialBack.UseVisualStyleBackColor = true;
            this.materialBack.Click += new System.EventHandler(this.materialBack_Click);
            // 
            // materialFoward
            // 
            this.materialFoward.Depth = 0;
            this.materialFoward.Location = new System.Drawing.Point(86, 66);
            this.materialFoward.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFoward.Name = "materialFoward";
            this.materialFoward.Primary = true;
            this.materialFoward.Size = new System.Drawing.Size(75, 57);
            this.materialFoward.TabIndex = 15;
            this.materialFoward.Text = ">";
            this.materialFoward.UseVisualStyleBackColor = true;
            this.materialFoward.Click += new System.EventHandler(this.materialFoward_Click);
            // 
            // materialRefresh
            // 
            this.materialRefresh.Depth = 0;
            this.materialRefresh.Location = new System.Drawing.Point(207, 68);
            this.materialRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRefresh.Name = "materialRefresh";
            this.materialRefresh.Primary = true;
            this.materialRefresh.Size = new System.Drawing.Size(75, 58);
            this.materialRefresh.TabIndex = 16;
            this.materialRefresh.Text = "refresh";
            this.materialRefresh.UseVisualStyleBackColor = true;
            this.materialRefresh.Click += new System.EventHandler(this.materialRefresh_Click);
            // 
            // materialGo
            // 
            this.materialGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialGo.Depth = 0;
            this.materialGo.Location = new System.Drawing.Point(853, 68);
            this.materialGo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialGo.Name = "materialGo";
            this.materialGo.Primary = true;
            this.materialGo.Size = new System.Drawing.Size(75, 57);
            this.materialGo.TabIndex = 17;
            this.materialGo.Text = "go";
            this.materialGo.UseVisualStyleBackColor = true;
            this.materialGo.Click += new System.EventHandler(this.materialGo_Click);
            // 
            // materialClosetab
            // 
            this.materialClosetab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialClosetab.Depth = 0;
            this.materialClosetab.Location = new System.Drawing.Point(969, 68);
            this.materialClosetab.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialClosetab.Name = "materialClosetab";
            this.materialClosetab.Primary = true;
            this.materialClosetab.Size = new System.Drawing.Size(75, 56);
            this.materialClosetab.TabIndex = 18;
            this.materialClosetab.Text = "close tab";
            this.materialClosetab.UseVisualStyleBackColor = true;
            this.materialClosetab.Click += new System.EventHandler(this.materialClosetab_Click);
            // 
            // materialNewtab
            // 
            this.materialNewtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialNewtab.Depth = 0;
            this.materialNewtab.Location = new System.Drawing.Point(1050, 66);
            this.materialNewtab.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialNewtab.Name = "materialNewtab";
            this.materialNewtab.Primary = true;
            this.materialNewtab.Size = new System.Drawing.Size(75, 58);
            this.materialNewtab.TabIndex = 19;
            this.materialNewtab.Text = "new tab";
            this.materialNewtab.UseVisualStyleBackColor = true;
            this.materialNewtab.Click += new System.EventHandler(this.materialNewtab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1128, 739);
            this.Controls.Add(this.materialNewtab);
            this.Controls.Add(this.materialClosetab);
            this.Controls.Add(this.materialGo);
            this.Controls.Add(this.materialRefresh);
            this.Controls.Add(this.materialFoward);
            this.Controls.Add(this.materialBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bybrowser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devFavsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsmybrowsercomToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.ToolStripMenuItem speedtestToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCookiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton materialBack;
        private MaterialSkin.Controls.MaterialRaisedButton materialFoward;
        private MaterialSkin.Controls.MaterialRaisedButton materialRefresh;
        private MaterialSkin.Controls.MaterialRaisedButton materialGo;
        private MaterialSkin.Controls.MaterialRaisedButton materialClosetab;
        private MaterialSkin.Controls.MaterialRaisedButton materialNewtab;
    }
}

