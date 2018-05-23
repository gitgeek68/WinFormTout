namespace Menus_Barres_d_outils_et_d__etat
{
    partial class Identification
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.buttonYEP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(109, 20);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.PasswordChar = 'Ѿ';
            this.textBoxMDP.Size = new System.Drawing.Size(100, 20);
            this.textBoxMDP.TabIndex = 1;
            // 
            // buttonYEP
            // 
            this.buttonYEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonYEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYEP.Location = new System.Drawing.Point(225, 17);
            this.buttonYEP.Name = "buttonYEP";
            this.buttonYEP.Size = new System.Drawing.Size(136, 24);
            this.buttonYEP.TabIndex = 2;
            this.buttonYEP.Text = "Let\'s Go!!!!!!!!!!!!!!!";
            this.buttonYEP.UseVisualStyleBackColor = true;
            this.buttonYEP.Click += new System.EventHandler(this.buttonYEP_Click);
            // 
            // Identification
            // 
            this.AcceptButton = this.buttonYEP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 45);
            this.Controls.Add(this.buttonYEP);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.label1);
            this.Name = "Identification";
            this.Text = "Identification";
            this.Load += new System.EventHandler(this.Identification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Button buttonYEP;
    }
}