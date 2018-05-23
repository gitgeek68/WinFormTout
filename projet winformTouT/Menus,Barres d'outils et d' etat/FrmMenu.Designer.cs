namespace Menus_Barres_d_outils_et_d__etat
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActiveWindow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripActiveWindow = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripSplitButtonConnection = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButtonPH1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSplitButtonPH2 = new System.Windows.Forms.ToolStripSplitButton();
            this.TextBoxcheckbox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSplitButtonPH3 = new System.Windows.Forms.ToolStripSplitButton();
            this.TextBoxButTraitement = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSplitButtonWindow = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripTextCascade = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripHorizontal = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripVertical = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonConnection,
            this.toolStripSplitButtonPH1,
            this.toolStripSplitButtonPH2,
            this.toolStripSplitButtonPH3,
            this.toolStripSplitButtonWindow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(938, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDate
            // 
            this.toolStripDate.AutoSize = false;
            this.toolStripDate.Name = "toolStripDate";
            this.toolStripDate.Size = new System.Drawing.Size(118, 17);
            this.toolStripDate.Text = "toolStripStatusLabel1";
            // 
            // ActiveWindow
            // 
            this.ActiveWindow.Name = "ActiveWindow";
            this.ActiveWindow.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripActiveWindow
            // 
            this.toolStripActiveWindow.AutoSize = false;
            this.toolStripActiveWindow.Name = "toolStripActiveWindow";
            this.toolStripActiveWindow.Size = new System.Drawing.Size(120, 17);
            this.toolStripActiveWindow.TextChanged += new System.EventHandler(this.toolStripActiveWindow_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDate,
            this.ActiveWindow,
            this.toolStripStatusLabel2,
            this.toolStripActiveWindow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripSplitButtonConnection
            // 
            this.toolStripSplitButtonConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonConnection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonConnection.Image")));
            this.toolStripSplitButtonConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonConnection.Name = "toolStripSplitButtonConnection";
            this.toolStripSplitButtonConnection.Size = new System.Drawing.Size(85, 22);
            this.toolStripSplitButtonConnection.Text = "Connection";
            this.toolStripSplitButtonConnection.Click += new System.EventHandler(this.toolStripSplitButtonConnection_Click);
            // 
            // toolStripSplitButtonPH1
            // 
            this.toolStripSplitButtonPH1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonPH1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripSplitButtonPH1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonPH1.Image")));
            this.toolStripSplitButtonPH1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonPH1.Name = "toolStripSplitButtonPH1";
            this.toolStripSplitButtonPH1.Size = new System.Drawing.Size(63, 22);
            this.toolStripSplitButtonPH1.Text = "Phase 1";
            this.toolStripSplitButtonPH1.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 23);
            this.toolStripMenuItem1.Text = "Calculatrice";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Calculatrice_Click);
            // 
            // toolStripSplitButtonPH2
            // 
            this.toolStripSplitButtonPH2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonPH2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBoxcheckbox});
            this.toolStripSplitButtonPH2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonPH2.Image")));
            this.toolStripSplitButtonPH2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonPH2.Name = "toolStripSplitButtonPH2";
            this.toolStripSplitButtonPH2.Size = new System.Drawing.Size(63, 22);
            this.toolStripSplitButtonPH2.Text = "Phase 2";
            this.toolStripSplitButtonPH2.Visible = false;
            // 
            // TextBoxcheckbox
            // 
            this.TextBoxcheckbox.Name = "TextBoxcheckbox";
            this.TextBoxcheckbox.ReadOnly = true;
            this.TextBoxcheckbox.Size = new System.Drawing.Size(100, 23);
            this.TextBoxcheckbox.Text = "CheckeBox";
            this.TextBoxcheckbox.Click += new System.EventHandler(this.TextBoxcheckbox_Click_1);
            // 
            // toolStripSplitButtonPH3
            // 
            this.toolStripSplitButtonPH3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonPH3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBoxButTraitement});
            this.toolStripSplitButtonPH3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonPH3.Image")));
            this.toolStripSplitButtonPH3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonPH3.Name = "toolStripSplitButtonPH3";
            this.toolStripSplitButtonPH3.Size = new System.Drawing.Size(63, 22);
            this.toolStripSplitButtonPH3.Text = "Phase 3";
            this.toolStripSplitButtonPH3.Visible = false;
            // 
            // TextBoxButTraitement
            // 
            this.TextBoxButTraitement.Name = "TextBoxButTraitement";
            this.TextBoxButTraitement.ReadOnly = true;
            this.TextBoxButTraitement.Size = new System.Drawing.Size(100, 23);
            this.TextBoxButTraitement.Text = " But de traitement";
            this.TextBoxButTraitement.Click += new System.EventHandler(this.TextBoxButTraitement_Click);
            // 
            // toolStripSplitButtonWindow
            // 
            this.toolStripSplitButtonWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextCascade,
            this.toolStripHorizontal,
            this.toolStripVertical});
            this.toolStripSplitButtonWindow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonWindow.Image")));
            this.toolStripSplitButtonWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonWindow.Name = "toolStripSplitButtonWindow";
            this.toolStripSplitButtonWindow.Size = new System.Drawing.Size(67, 22);
            this.toolStripSplitButtonWindow.Text = "Fenêtres";
            this.toolStripSplitButtonWindow.Visible = false;
            // 
            // toolStripTextCascade
            // 
            this.toolStripTextCascade.Name = "toolStripTextCascade";
            this.toolStripTextCascade.ReadOnly = true;
            this.toolStripTextCascade.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextCascade.Text = "Cascade";
            this.toolStripTextCascade.Click += new System.EventHandler(this.toolStripTextCascade_Click);
            // 
            // toolStripHorizontal
            // 
            this.toolStripHorizontal.Name = "toolStripHorizontal";
            this.toolStripHorizontal.ReadOnly = true;
            this.toolStripHorizontal.Size = new System.Drawing.Size(100, 23);
            this.toolStripHorizontal.Text = "Horizontal";
            this.toolStripHorizontal.Click += new System.EventHandler(this.toolStripHorizontal_Click);
            // 
            // toolStripVertical
            // 
            this.toolStripVertical.Name = "toolStripVertical";
            this.toolStripVertical.ReadOnly = true;
            this.toolStripVertical.Size = new System.Drawing.Size(100, 23);
            this.toolStripVertical.Text = "Vertical";
            this.toolStripVertical.Click += new System.EventHandler(this.toolStripVertical_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 417);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.Text = "Créer des formulaires";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonConnection;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonPH1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonPH2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonPH3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonWindow;
        private System.Windows.Forms.ToolStripTextBox toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox TextBoxcheckbox;
        private System.Windows.Forms.ToolStripTextBox toolStripTextCascade;
        private System.Windows.Forms.ToolStripTextBox TextBoxButTraitement;
        private System.Windows.Forms.ToolStripTextBox toolStripHorizontal;
        private System.Windows.Forms.ToolStripTextBox toolStripVertical;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDate;
        private System.Windows.Forms.ToolStripStatusLabel ActiveWindow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripActiveWindow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
    }
}

