namespace Menus_Barres_d_outils_et_d__etat
{
    partial class But2Traitements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(But2Traitements));
            this.LabelName = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.LabelCapital = new System.Windows.Forms.Label();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.groupBoxTauxInteret = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.LabelMoiRemboursement = new System.Windows.Forms.Label();
            this.hScrollBarMois = new System.Windows.Forms.HScrollBar();
            this.LabelMois = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.listBoxPeriodRemboursement = new System.Windows.Forms.ListBox();
            this.labelPriodRembour = new System.Windows.Forms.Label();
            this.labelDureeRemboursement = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCapital = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelRemboursement = new System.Windows.Forms.Label();
            this.groupBoxTauxInteret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCapital)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(13, 13);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(54, 24);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(180, 12);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.Text = " ";
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // LabelCapital
            // 
            this.LabelCapital.AutoSize = true;
            this.LabelCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCapital.Location = new System.Drawing.Point(17, 55);
            this.LabelCapital.Name = "LabelCapital";
            this.LabelCapital.Size = new System.Drawing.Size(148, 20);
            this.LabelCapital.TabIndex = 2;
            this.LabelCapital.Text = "Capital Emprunté";
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(180, 54);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapital.TabIndex = 3;
            this.textBoxCapital.TextChanged += new System.EventHandler(this.textBoxCapital_TextChanged);
            // 
            // groupBoxTauxInteret
            // 
            this.groupBoxTauxInteret.BackColor = System.Drawing.Color.White;
            this.groupBoxTauxInteret.Controls.Add(this.radioButton9);
            this.groupBoxTauxInteret.Controls.Add(this.radioButton8);
            this.groupBoxTauxInteret.Controls.Add(this.radioButton7);
            this.groupBoxTauxInteret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTauxInteret.Location = new System.Drawing.Point(484, 12);
            this.groupBoxTauxInteret.Name = "groupBoxTauxInteret";
            this.groupBoxTauxInteret.Size = new System.Drawing.Size(86, 134);
            this.groupBoxTauxInteret.TabIndex = 4;
            this.groupBoxTauxInteret.TabStop = false;
            this.groupBoxTauxInteret.Text = "Taux d \' interet";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(29, 98);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(52, 24);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9%";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(29, 68);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(52, 24);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8%";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(29, 38);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(52, 24);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7%";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // LabelMoiRemboursement
            // 
            this.LabelMoiRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMoiRemboursement.Location = new System.Drawing.Point(21, 101);
            this.LabelMoiRemboursement.Name = "LabelMoiRemboursement";
            this.LabelMoiRemboursement.Size = new System.Drawing.Size(132, 33);
            this.LabelMoiRemboursement.TabIndex = 5;
            this.LabelMoiRemboursement.Text = "Durée en mois du remboursement";
            // 
            // hScrollBarMois
            // 
            this.hScrollBarMois.Location = new System.Drawing.Point(249, 110);
            this.hScrollBarMois.Maximum = 264;
            this.hScrollBarMois.Minimum = 1;
            this.hScrollBarMois.Name = "hScrollBarMois";
            this.hScrollBarMois.Size = new System.Drawing.Size(154, 17);
            this.hScrollBarMois.TabIndex = 6;
            this.hScrollBarMois.Value = 1;
            this.hScrollBarMois.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarMois_Scroll);
            this.hScrollBarMois.ValueChanged += new System.EventHandler(this.hScrollBarMois_ValueChanged);
            // 
            // LabelMois
            // 
            this.LabelMois.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMois.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LabelMois.Location = new System.Drawing.Point(180, 110);
            this.LabelMois.Name = "LabelMois";
            this.LabelMois.Size = new System.Drawing.Size(57, 17);
            this.LabelMois.TabIndex = 7;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(638, 32);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(82, 25);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "Calculer";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(638, 80);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(82, 29);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // listBoxPeriodRemboursement
            // 
            this.listBoxPeriodRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPeriodRemboursement.FormattingEnabled = true;
            this.listBoxPeriodRemboursement.ItemHeight = 20;
            this.listBoxPeriodRemboursement.Items.AddRange(new object[] {
            "Mensuelle",
            "Bimestrielle",
            "Trimestrielle",
            "Semestrielle",
            "Annuelle"});
            this.listBoxPeriodRemboursement.Location = new System.Drawing.Point(21, 200);
            this.listBoxPeriodRemboursement.Name = "listBoxPeriodRemboursement";
            this.listBoxPeriodRemboursement.Size = new System.Drawing.Size(160, 64);
            this.listBoxPeriodRemboursement.TabIndex = 10;
            this.listBoxPeriodRemboursement.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriodRemboursement_SelectedIndexChanged);
            // 
            // labelPriodRembour
            // 
            this.labelPriodRembour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriodRembour.Location = new System.Drawing.Point(21, 148);
            this.labelPriodRembour.Name = "labelPriodRembour";
            this.labelPriodRembour.Size = new System.Drawing.Size(144, 45);
            this.labelPriodRembour.TabIndex = 11;
            this.labelPriodRembour.Text = "Périodicité de remboursement";
            // 
            // labelDureeRemboursement
            // 
            this.labelDureeRemboursement.AutoSize = true;
            this.labelDureeRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDureeRemboursement.Location = new System.Drawing.Point(436, 174);
            this.labelDureeRemboursement.Name = "labelDureeRemboursement";
            this.labelDureeRemboursement.Size = new System.Drawing.Size(119, 16);
            this.labelDureeRemboursement.TabIndex = 12;
            this.labelDureeRemboursement.Text = "nbre echeances";
            // 
            // errorName
            // 
            this.errorName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorName.ContainerControl = this;
            this.errorName.Icon = ((System.Drawing.Icon)(resources.GetObject("errorName.Icon")));
            // 
            // errorCapital
            // 
            this.errorCapital.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorCapital.ContainerControl = this;
            this.errorCapital.Icon = ((System.Drawing.Icon)(resources.GetObject("errorCapital.Icon")));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Remboursements";
            // 
            // labelRemboursement
            // 
            this.labelRemboursement.AutoSize = true;
            this.labelRemboursement.Location = new System.Drawing.Point(603, 224);
            this.labelRemboursement.Name = "labelRemboursement";
            this.labelRemboursement.Size = new System.Drawing.Size(71, 13);
            this.labelRemboursement.TabIndex = 14;
            this.labelRemboursement.Text = "reboursement";
            this.labelRemboursement.Click += new System.EventHandler(this.labelRemboursement_Click);
            // 
            // But2Traitements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 271);
            this.Controls.Add(this.labelRemboursement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDureeRemboursement);
            this.Controls.Add(this.labelPriodRembour);
            this.Controls.Add(this.listBoxPeriodRemboursement);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.LabelMois);
            this.Controls.Add(this.hScrollBarMois);
            this.Controls.Add(this.LabelMoiRemboursement);
            this.Controls.Add(this.groupBoxTauxInteret);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.LabelCapital);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.LabelName);
            this.Name = "But2Traitements";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTauxInteret.ResumeLayout(false);
            this.groupBoxTauxInteret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCapital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label LabelCapital;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.GroupBox groupBoxTauxInteret;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label LabelMoiRemboursement;
        private System.Windows.Forms.HScrollBar hScrollBarMois;
        private System.Windows.Forms.Label LabelMois;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ListBox listBoxPeriodRemboursement;
        private System.Windows.Forms.Label labelPriodRembour;
        private System.Windows.Forms.Label labelDureeRemboursement;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorCapital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRemboursement;
    }
}

