namespace GUI
{
    partial class AjoutMoto
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
            this.btnAjoutMoto = new System.Windows.Forms.Button();
            this.lbImm = new System.Windows.Forms.Label();
            this.lbAnnee = new System.Windows.Forms.Label();
            this.lbVitesse = new System.Windows.Forms.Label();
            this.lCylindre = new System.Windows.Forms.Label();
            this.txtImm = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtCylindre = new System.Windows.Forms.TextBox();
            this.txtVitesse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjoutMoto
            // 
            this.btnAjoutMoto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAjoutMoto.Location = new System.Drawing.Point(170, 387);
            this.btnAjoutMoto.Name = "btnAjoutMoto";
            this.btnAjoutMoto.Size = new System.Drawing.Size(132, 40);
            this.btnAjoutMoto.TabIndex = 0;
            this.btnAjoutMoto.Text = "Ajouter";
            this.btnAjoutMoto.UseVisualStyleBackColor = true;
            this.btnAjoutMoto.Click += new System.EventHandler(this.btnAjoutMoto_Click);
            // 
            // lbImm
            // 
            this.lbImm.AutoSize = true;
            this.lbImm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImm.Location = new System.Drawing.Point(55, 69);
            this.lbImm.Name = "lbImm";
            this.lbImm.Size = new System.Drawing.Size(142, 25);
            this.lbImm.TabIndex = 1;
            this.lbImm.Text = "Immatriculation";
            // 
            // lbAnnee
            // 
            this.lbAnnee.AutoSize = true;
            this.lbAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnnee.Location = new System.Drawing.Point(55, 130);
            this.lbAnnee.Name = "lbAnnee";
            this.lbAnnee.Size = new System.Drawing.Size(70, 25);
            this.lbAnnee.TabIndex = 2;
            this.lbAnnee.Text = "Annee";
            // 
            // lbVitesse
            // 
            this.lbVitesse.AutoSize = true;
            this.lbVitesse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVitesse.Location = new System.Drawing.Point(55, 265);
            this.lbVitesse.Name = "lbVitesse";
            this.lbVitesse.Size = new System.Drawing.Size(122, 25);
            this.lbVitesse.TabIndex = 3;
            this.lbVitesse.Text = "Vitesse-Max";
            // 
            // lCylindre
            // 
            this.lCylindre.AutoSize = true;
            this.lCylindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCylindre.Location = new System.Drawing.Point(55, 197);
            this.lCylindre.Name = "lCylindre";
            this.lCylindre.Size = new System.Drawing.Size(84, 25);
            this.lCylindre.TabIndex = 4;
            this.lCylindre.Text = "Cylindre";
            // 
            // txtImm
            // 
            this.txtImm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImm.Location = new System.Drawing.Point(223, 66);
            this.txtImm.Name = "txtImm";
            this.txtImm.Size = new System.Drawing.Size(193, 30);
            this.txtImm.TabIndex = 5;
            // 
            // txtAnnee
            // 
            this.txtAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnee.Location = new System.Drawing.Point(223, 125);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(193, 30);
            this.txtAnnee.TabIndex = 6;
            // 
            // txtCylindre
            // 
            this.txtCylindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCylindre.Location = new System.Drawing.Point(223, 192);
            this.txtCylindre.Name = "txtCylindre";
            this.txtCylindre.Size = new System.Drawing.Size(193, 30);
            this.txtCylindre.TabIndex = 7;
            // 
            // txtVitesse
            // 
            this.txtVitesse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVitesse.Location = new System.Drawing.Point(223, 260);
            this.txtVitesse.Name = "txtVitesse";
            this.txtVitesse.Size = new System.Drawing.Size(193, 30);
            this.txtVitesse.TabIndex = 8;
            // 
            // AjoutMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 480);
            this.Controls.Add(this.txtVitesse);
            this.Controls.Add(this.txtCylindre);
            this.Controls.Add(this.txtAnnee);
            this.Controls.Add(this.txtImm);
            this.Controls.Add(this.lCylindre);
            this.Controls.Add(this.lbVitesse);
            this.Controls.Add(this.lbAnnee);
            this.Controls.Add(this.lbImm);
            this.Controls.Add(this.btnAjoutMoto);
            this.Name = "AjoutMoto";
            this.Text = "Nouvelle-Moto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutMoto;
        private System.Windows.Forms.Label lbImm;
        private System.Windows.Forms.Label lbAnnee;
        private System.Windows.Forms.Label lbVitesse;
        private System.Windows.Forms.Label lCylindre;
        private System.Windows.Forms.TextBox txtImm;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtCylindre;
        private System.Windows.Forms.TextBox txtVitesse;
    }
}