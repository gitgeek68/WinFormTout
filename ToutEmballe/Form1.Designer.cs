namespace ToutEmballe
{
    partial class Production2Caisses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Production2Caisses));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SplitButtonFichier = new System.Windows.Forms.ToolStripSplitButton();
            this.Quiter = new System.Windows.Forms.ToolStripTextBox();
            this.ButtonProduction = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemDemarrer = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdA = new System.Windows.Forms.ToolStripTextBox();
            this.ProdB = new System.Windows.Forms.ToolStripTextBox();
            this.ProdC = new System.Windows.Forms.ToolStripTextBox();
            this.MenuItemArreter = new System.Windows.Forms.ToolStripMenuItem();
            this.StopA = new System.Windows.Forms.ToolStripTextBox();
            this.StopB = new System.Windows.Forms.ToolStripTextBox();
            this.StopC = new System.Windows.Forms.ToolStripTextBox();
            this.Continue = new System.Windows.Forms.ToolStripMenuItem();
            this.ContinueA = new System.Windows.Forms.ToolStripTextBox();
            this.ContinueB = new System.Windows.Forms.ToolStripTextBox();
            this.ContinueC = new System.Windows.Forms.ToolStripTextBox();
            this.TabControle = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxDefaultSinceStartA = new System.Windows.Forms.TextBox();
            this.textBoxDefaultPerHourA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSinceStartupA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxDefaultSinceStartB = new System.Windows.Forms.TextBox();
            this.textBoxDefaultPerHourB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSinceStartupB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxDefaultSinceStartC = new System.Windows.Forms.TextBox();
            this.textBoxDefaultPerHourC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSinceStartupC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.labelProgressA = new System.Windows.Forms.Label();
            this.labelProgressB = new System.Windows.Forms.Label();
            this.labelProgressC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.TabControle.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SplitButtonFichier,
            this.ButtonProduction});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SplitButtonFichier
            // 
            this.SplitButtonFichier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SplitButtonFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quiter});
            this.SplitButtonFichier.Image = ((System.Drawing.Image)(resources.GetObject("SplitButtonFichier.Image")));
            this.SplitButtonFichier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SplitButtonFichier.Name = "SplitButtonFichier";
            this.SplitButtonFichier.Size = new System.Drawing.Size(58, 22);
            this.SplitButtonFichier.Text = "Fichier";
            // 
            // Quiter
            // 
            this.Quiter.Name = "Quiter";
            this.Quiter.Size = new System.Drawing.Size(100, 23);
            this.Quiter.Text = "Quitter";
            this.Quiter.Click += new System.EventHandler(this.Quiter_Click_1);
            // 
            // ButtonProduction
            // 
            this.ButtonProduction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonProduction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDemarrer,
            this.MenuItemArreter,
            this.Continue});
            this.ButtonProduction.Image = ((System.Drawing.Image)(resources.GetObject("ButtonProduction.Image")));
            this.ButtonProduction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonProduction.Name = "ButtonProduction";
            this.ButtonProduction.Size = new System.Drawing.Size(79, 22);
            this.ButtonProduction.Text = "Production";
            // 
            // MenuItemDemarrer
            // 
            this.MenuItemDemarrer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdA,
            this.ProdB,
            this.ProdC});
            this.MenuItemDemarrer.Name = "MenuItemDemarrer";
            this.MenuItemDemarrer.Size = new System.Drawing.Size(152, 22);
            this.MenuItemDemarrer.Text = "Demarrer";
            // 
            // ProdA
            // 
            this.ProdA.Name = "ProdA";
            this.ProdA.Size = new System.Drawing.Size(100, 23);
            this.ProdA.Text = "A";
            this.ProdA.Click += new System.EventHandler(this.ProdA_DemarrerClick);
            // 
            // ProdB
            // 
            this.ProdB.Name = "ProdB";
            this.ProdB.Size = new System.Drawing.Size(100, 23);
            this.ProdB.Text = "B";
            this.ProdB.Click += new System.EventHandler(this.ProdB_DemarrerClick);
            // 
            // ProdC
            // 
            this.ProdC.Name = "ProdC";
            this.ProdC.Size = new System.Drawing.Size(100, 23);
            this.ProdC.Text = "C";
            this.ProdC.Click += new System.EventHandler(this.ProdC_DemarrerClick);
            // 
            // MenuItemArreter
            // 
            this.MenuItemArreter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StopA,
            this.StopB,
            this.StopC});
            this.MenuItemArreter.Name = "MenuItemArreter";
            this.MenuItemArreter.Size = new System.Drawing.Size(152, 22);
            this.MenuItemArreter.Text = "Arreter";
            // 
            // StopA
            // 
            this.StopA.Name = "StopA";
            this.StopA.Size = new System.Drawing.Size(100, 23);
            this.StopA.Text = "A";
            this.StopA.Click += new System.EventHandler(this.StopA_Click);
            // 
            // StopB
            // 
            this.StopB.Name = "StopB";
            this.StopB.Size = new System.Drawing.Size(100, 23);
            this.StopB.Text = "B";
            this.StopB.Click += new System.EventHandler(this.StopB_Click);
            // 
            // StopC
            // 
            this.StopC.Name = "StopC";
            this.StopC.Size = new System.Drawing.Size(100, 23);
            this.StopC.Text = "C";
            this.StopC.Click += new System.EventHandler(this.StopC_Click);
            // 
            // Continue
            // 
            this.Continue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContinueA,
            this.ContinueB,
            this.ContinueC});
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(152, 22);
            this.Continue.Text = "Continuer";
            // 
            // ContinueA
            // 
            this.ContinueA.Name = "ContinueA";
            this.ContinueA.Size = new System.Drawing.Size(100, 23);
            this.ContinueA.Text = "A";
            this.ContinueA.Click += new System.EventHandler(this.ContinueA_Click);
            // 
            // ContinueB
            // 
            this.ContinueB.Name = "ContinueB";
            this.ContinueB.Size = new System.Drawing.Size(100, 23);
            this.ContinueB.Text = "B";
            this.ContinueB.Click += new System.EventHandler(this.ContinueB_Click);
            // 
            // ContinueC
            // 
            this.ContinueC.Name = "ContinueC";
            this.ContinueC.Size = new System.Drawing.Size(100, 23);
            this.ContinueC.Text = "C";
            this.ContinueC.Click += new System.EventHandler(this.ContinueC_Click);
            // 
            // TabControle
            // 
            this.TabControle.Controls.Add(this.tabPage1);
            this.TabControle.Controls.Add(this.tabPage2);
            this.TabControle.Controls.Add(this.tabPage3);
            this.TabControle.Location = new System.Drawing.Point(12, 73);
            this.TabControle.Name = "TabControle";
            this.TabControle.SelectedIndex = 0;
            this.TabControle.Size = new System.Drawing.Size(660, 194);
            this.TabControle.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxDefaultSinceStartA);
            this.tabPage1.Controls.Add(this.textBoxDefaultPerHourA);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxSinceStartupA);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TypeA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxDefaultSinceStartA
            // 
            this.textBoxDefaultSinceStartA.Location = new System.Drawing.Point(496, 106);
            this.textBoxDefaultSinceStartA.Name = "textBoxDefaultSinceStartA";
            this.textBoxDefaultSinceStartA.Size = new System.Drawing.Size(100, 26);
            this.textBoxDefaultSinceStartA.TabIndex = 11;
            // 
            // textBoxDefaultPerHourA
            // 
            this.textBoxDefaultPerHourA.Location = new System.Drawing.Point(496, 68);
            this.textBoxDefaultPerHourA.Name = "textBoxDefaultPerHourA";
            this.textBoxDefaultPerHourA.Size = new System.Drawing.Size(100, 26);
            this.textBoxDefaultPerHourA.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Taux de defaut depuis le debut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Taux de defaut par heures";
            // 
            // textBoxSinceStartupA
            // 
            this.textBoxSinceStartupA.Location = new System.Drawing.Point(496, 29);
            this.textBoxSinceStartupA.Name = "textBoxSinceStartupA";
            this.textBoxSinceStartupA.Size = new System.Drawing.Size(100, 26);
            this.textBoxSinceStartupA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombres de caisses depuis le demarrage";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxDefaultSinceStartB);
            this.tabPage2.Controls.Add(this.textBoxDefaultPerHourB);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxSinceStartupB);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TypeB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxDefaultSinceStartB
            // 
            this.textBoxDefaultSinceStartB.Location = new System.Drawing.Point(496, 106);
            this.textBoxDefaultSinceStartB.Name = "textBoxDefaultSinceStartB";
            this.textBoxDefaultSinceStartB.Size = new System.Drawing.Size(100, 26);
            this.textBoxDefaultSinceStartB.TabIndex = 17;
            // 
            // textBoxDefaultPerHourB
            // 
            this.textBoxDefaultPerHourB.Location = new System.Drawing.Point(496, 68);
            this.textBoxDefaultPerHourB.Name = "textBoxDefaultPerHourB";
            this.textBoxDefaultPerHourB.Size = new System.Drawing.Size(100, 26);
            this.textBoxDefaultPerHourB.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Taux de defaut depuis le debut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Taux de defaut par heures";
            // 
            // textBoxSinceStartupB
            // 
            this.textBoxSinceStartupB.Location = new System.Drawing.Point(496, 29);
            this.textBoxSinceStartupB.Name = "textBoxSinceStartupB";
            this.textBoxSinceStartupB.Size = new System.Drawing.Size(100, 26);
            this.textBoxSinceStartupB.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombres de caisses depuis le demarrage";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxDefaultSinceStartC);
            this.tabPage3.Controls.Add(this.textBoxDefaultPerHourC);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBoxSinceStartupC);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(652, 161);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TypeC";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxDefaultSinceStartC
            // 
            this.textBoxDefaultSinceStartC.Location = new System.Drawing.Point(496, 106);
            this.textBoxDefaultSinceStartC.Name = "textBoxDefaultSinceStartC";
            this.textBoxDefaultSinceStartC.Size = new System.Drawing.Size(100, 26);
            this.textBoxDefaultSinceStartC.TabIndex = 17;
            // 
            // textBoxDefaultPerHourC
            // 
            this.textBoxDefaultPerHourC.Location = new System.Drawing.Point(496, 68);
            this.textBoxDefaultPerHourC.Name = "textBoxDefaultPerHourC";
            this.textBoxDefaultPerHourC.Size = new System.Drawing.Size(100, 26);
            this.textBoxDefaultPerHourC.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Taux de defaut depuis le debut";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Taux de defaut par heures";
            // 
            // textBoxSinceStartupC
            // 
            this.textBoxSinceStartupC.Location = new System.Drawing.Point(496, 29);
            this.textBoxSinceStartupC.Name = "textBoxSinceStartupC";
            this.textBoxSinceStartupC.Size = new System.Drawing.Size(100, 26);
            this.textBoxSinceStartupC.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(338, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombres de caisses depuis le demarrage";
            // 
            // progressBarA
            // 
            this.progressBarA.Location = new System.Drawing.Point(312, 274);
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(356, 23);
            this.progressBarA.TabIndex = 2;
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(312, 313);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(356, 23);
            this.progressBarB.TabIndex = 3;
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(312, 351);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(356, 23);
            this.progressBarC.TabIndex = 4;
            // 
            // labelProgressA
            // 
            this.labelProgressA.AutoSize = true;
            this.labelProgressA.Location = new System.Drawing.Point(16, 283);
            this.labelProgressA.Name = "labelProgressA";
            this.labelProgressA.Size = new System.Drawing.Size(112, 20);
            this.labelProgressA.TabIndex = 5;
            this.labelProgressA.Text = "Production A";
            // 
            // labelProgressB
            // 
            this.labelProgressB.AutoSize = true;
            this.labelProgressB.Location = new System.Drawing.Point(16, 322);
            this.labelProgressB.Name = "labelProgressB";
            this.labelProgressB.Size = new System.Drawing.Size(112, 20);
            this.labelProgressB.TabIndex = 6;
            this.labelProgressB.Text = "Production B";
            // 
            // labelProgressC
            // 
            this.labelProgressC.AutoSize = true;
            this.labelProgressC.Location = new System.Drawing.Point(16, 360);
            this.labelProgressC.Name = "labelProgressC";
            this.labelProgressC.Size = new System.Drawing.Size(112, 20);
            this.labelProgressC.TabIndex = 7;
            this.labelProgressC.Text = "Production C";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Production2Caisses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 454);
            this.Controls.Add(this.labelProgressC);
            this.Controls.Add(this.labelProgressB);
            this.Controls.Add(this.labelProgressA);
            this.Controls.Add(this.progressBarC);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.progressBarA);
            this.Controls.Add(this.TabControle);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Production2Caisses";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_close);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TabControle.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton SplitButtonFichier;
        private System.Windows.Forms.ToolStripDropDownButton ButtonProduction;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDemarrer;
        private System.Windows.Forms.ToolStripTextBox ProdA;
        private System.Windows.Forms.ToolStripTextBox ProdB;
        private System.Windows.Forms.ToolStripTextBox ProdC;
        private System.Windows.Forms.ToolStripMenuItem MenuItemArreter;
        private System.Windows.Forms.ToolStripTextBox StopA;
        private System.Windows.Forms.ToolStripTextBox StopB;
        private System.Windows.Forms.ToolStripTextBox StopC;
        private System.Windows.Forms.ToolStripMenuItem Continue;
        private System.Windows.Forms.ToolStripTextBox ContinueA;
        private System.Windows.Forms.ToolStripTextBox ContinueB;
        private System.Windows.Forms.ToolStripTextBox ContinueC;
        private System.Windows.Forms.TabControl TabControle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ProgressBar progressBarA;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.Label labelProgressA;
        private System.Windows.Forms.Label labelProgressB;
        private System.Windows.Forms.Label labelProgressC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxDefaultSinceStartA;
        private System.Windows.Forms.TextBox textBoxDefaultPerHourA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSinceStartupA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDefaultSinceStartB;
        private System.Windows.Forms.TextBox textBoxDefaultPerHourB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSinceStartupB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDefaultSinceStartC;
        private System.Windows.Forms.TextBox textBoxDefaultPerHourC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSinceStartupC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripTextBox Quiter;
    }
}

