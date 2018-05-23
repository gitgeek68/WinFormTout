namespace ControleDeSaisie
{
    partial class LesControles
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
            this.Effacer = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2CP = new System.Windows.Forms.TextBox();
            this.textBox3Montant = new System.Windows.Forms.TextBox();
            this.textBox4Date = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).BeginInit();
            this.SuspendLayout();
            // 
            // Effacer
            // 
            this.Effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Effacer.Location = new System.Drawing.Point(405, 224);
            this.Effacer.Name = "Effacer";
            this.Effacer.Size = new System.Drawing.Size(75, 23);
            this.Effacer.TabIndex = 0;
            this.Effacer.Text = "Effacer";
            this.Effacer.UseVisualStyleBackColor = true;
            this.Effacer.Click += new System.EventHandler(this.Effacer_Click);
            // 
            // Valider
            // 
            this.Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.Location = new System.Drawing.Point(405, 195);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 1;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Montant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Code Postal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "(JJ/MM/AAAA)\r\n";
            // 
            // textBox2CP
            // 
            this.textBox2CP.Location = new System.Drawing.Point(145, 179);
            this.textBox2CP.Name = "textBox2CP";
            this.textBox2CP.Size = new System.Drawing.Size(100, 20);
            this.textBox2CP.TabIndex = 8;
            this.textBox2CP.TextChanged += new System.EventHandler(this.TextBox2CP);
            // 
            // textBox3Montant
            // 
            this.textBox3Montant.Location = new System.Drawing.Point(145, 131);
            this.textBox3Montant.Name = "textBox3Montant";
            this.textBox3Montant.Size = new System.Drawing.Size(150, 20);
            this.textBox3Montant.TabIndex = 9;
            this.textBox3Montant.Leave += new System.EventHandler(this.TextBox3Montant);
            // 
            // textBox4Date
            // 
            this.textBox4Date.Location = new System.Drawing.Point(145, 77);
            this.textBox4Date.Name = "textBox4Date";
            this.textBox4Date.Size = new System.Drawing.Size(150, 20);
            this.textBox4Date.TabIndex = 10;
            this.textBox4Date.TextChanged += new System.EventHandler(this.TextBox4Date);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(145, 20);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(256, 20);
            this.textBoxNom.TabIndex = 11;
            this.textBoxNom.TextChanged += new System.EventHandler(this.TextBoxNom);
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderNom.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderMontant
            // 
            this.errorProviderMontant.ContainerControl = this;
            // 
            // errorProviderCP
            // 
            this.errorProviderCP.ContainerControl = this;
            // 
            // LesControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(497, 262);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBox4Date);
            this.Controls.Add(this.textBox3Montant);
            this.Controls.Add(this.textBox2CP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Effacer);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "LesControles";
            this.Text = "Les contrôles";
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LesControles_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Effacer;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2CP;
        private System.Windows.Forms.TextBox textBox3Montant;
        private System.Windows.Forms.TextBox textBox4Date;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
        private System.Windows.Forms.ErrorProvider errorProviderMontant;
        private System.Windows.Forms.ErrorProvider errorProviderCP;
    }
}

