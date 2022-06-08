namespace GUI
{
    partial class GarageMain
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
            this.txtAffichageImm = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnRadioVoiture = new System.Windows.Forms.RadioButton();
            this.btnRadioMoto = new System.Windows.Forms.RadioButton();
            this.lbMonGarage = new System.Windows.Forms.Label();
            this.btnChar = new System.Windows.Forms.Button();
            this.txtAffichageAnnee = new System.Windows.Forms.TextBox();
            this.txtAffichageType = new System.Windows.Forms.TextBox();
            this.lbImm = new System.Windows.Forms.Label();
            this.lbAnnee = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lstAffichage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAffichageImm
            // 
            this.txtAffichageImm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAffichageImm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAffichageImm.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAffichageImm.Location = new System.Drawing.Point(897, 168);
            this.txtAffichageImm.Name = "txtAffichageImm";
            this.txtAffichageImm.Size = new System.Drawing.Size(157, 27);
            this.txtAffichageImm.TabIndex = 2;
            this.txtAffichageImm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(33, 481);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(123, 50);
            this.btnAjout.TabIndex = 3;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(172, 481);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(123, 50);
            this.btnSupp.TabIndex = 4;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnRadioVoiture
            // 
            this.btnRadioVoiture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRadioVoiture.Checked = true;
            this.btnRadioVoiture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRadioVoiture.Location = new System.Drawing.Point(33, 66);
            this.btnRadioVoiture.Name = "btnRadioVoiture";
            this.btnRadioVoiture.Size = new System.Drawing.Size(123, 31);
            this.btnRadioVoiture.TabIndex = 5;
            this.btnRadioVoiture.TabStop = true;
            this.btnRadioVoiture.Text = "Voiture";
            this.btnRadioVoiture.UseVisualStyleBackColor = false;
            this.btnRadioVoiture.CheckedChanged += new System.EventHandler(this.btnRadioVoiture_CheckedChanged);
            // 
            // btnRadioMoto
            // 
            this.btnRadioMoto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRadioMoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRadioMoto.Location = new System.Drawing.Point(172, 66);
            this.btnRadioMoto.Name = "btnRadioMoto";
            this.btnRadioMoto.Size = new System.Drawing.Size(123, 31);
            this.btnRadioMoto.TabIndex = 6;
            this.btnRadioMoto.Text = "Moto";
            this.btnRadioMoto.UseVisualStyleBackColor = false;
            this.btnRadioMoto.CheckedChanged += new System.EventHandler(this.btnRadioMoto_CheckedChanged);
            // 
            // lbMonGarage
            // 
            this.lbMonGarage.BackColor = System.Drawing.SystemColors.Info;
            this.lbMonGarage.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonGarage.Location = new System.Drawing.Point(757, 66);
            this.lbMonGarage.Name = "lbMonGarage";
            this.lbMonGarage.Size = new System.Drawing.Size(297, 42);
            this.lbMonGarage.TabIndex = 7;
            this.lbMonGarage.Text = "MON GARAGE";
            this.lbMonGarage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(805, 381);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(198, 33);
            this.btnChar.TabIndex = 8;
            this.btnChar.Text = "Characteristiques";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // txtAffichageAnnee
            // 
            this.txtAffichageAnnee.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAffichageAnnee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAffichageAnnee.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAffichageAnnee.Location = new System.Drawing.Point(897, 223);
            this.txtAffichageAnnee.Name = "txtAffichageAnnee";
            this.txtAffichageAnnee.Size = new System.Drawing.Size(157, 27);
            this.txtAffichageAnnee.TabIndex = 9;
            this.txtAffichageAnnee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAffichageType
            // 
            this.txtAffichageType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAffichageType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAffichageType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAffichageType.Location = new System.Drawing.Point(897, 283);
            this.txtAffichageType.Name = "txtAffichageType";
            this.txtAffichageType.Size = new System.Drawing.Size(157, 27);
            this.txtAffichageType.TabIndex = 10;
            this.txtAffichageType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbImm
            // 
            this.lbImm.AutoSize = true;
            this.lbImm.Location = new System.Drawing.Point(729, 168);
            this.lbImm.Name = "lbImm";
            this.lbImm.Size = new System.Drawing.Size(162, 27);
            this.lbImm.TabIndex = 11;
            this.lbImm.Text = "Immatriculation";
            // 
            // lbAnnee
            // 
            this.lbAnnee.AutoSize = true;
            this.lbAnnee.Location = new System.Drawing.Point(773, 223);
            this.lbAnnee.Name = "lbAnnee";
            this.lbAnnee.Size = new System.Drawing.Size(72, 27);
            this.lbAnnee.TabIndex = 12;
            this.lbAnnee.Text = "Annee";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(773, 283);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(58, 27);
            this.lbType.TabIndex = 13;
            this.lbType.Text = "Type";
            // 
            // lstAffichage
            // 
            this.lstAffichage.FormattingEnabled = true;
            this.lstAffichage.ItemHeight = 27;
            this.lstAffichage.Location = new System.Drawing.Point(33, 93);
            this.lstAffichage.Name = "lstAffichage";
            this.lstAffichage.Size = new System.Drawing.Size(690, 382);
            this.lstAffichage.TabIndex = 14;
            this.lstAffichage.SelectedIndexChanged += new System.EventHandler(this.lstAffichage_SelectedIndexChanged);
            // 
            // GarageMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1103, 572);
            this.Controls.Add(this.lstAffichage);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbAnnee);
            this.Controls.Add(this.lbImm);
            this.Controls.Add(this.txtAffichageType);
            this.Controls.Add(this.txtAffichageAnnee);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.lbMonGarage);
            this.Controls.Add(this.btnRadioMoto);
            this.Controls.Add(this.btnRadioVoiture);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.txtAffichageImm);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GarageMain";
            this.Text = "Mon Garage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAffichageImm;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.RadioButton btnRadioVoiture;
        private System.Windows.Forms.RadioButton btnRadioMoto;
        private System.Windows.Forms.Label lbMonGarage;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.TextBox txtAffichageAnnee;
        private System.Windows.Forms.TextBox txtAffichageType;
        private System.Windows.Forms.Label lbImm;
        private System.Windows.Forms.Label lbAnnee;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ListBox lstAffichage;
    }
}

