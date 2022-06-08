namespace GUI
{
    partial class AjoutVoiture
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
            this.btnAjoutVoi = new System.Windows.Forms.Button();
            this.lbImm = new System.Windows.Forms.Label();
            this.lbAnn = new System.Windows.Forms.Label();
            this.lbMar = new System.Windows.Forms.Label();
            this.lbCou = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.txtImm = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.txtTypeV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjoutVoi
            // 
            this.btnAjoutVoi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAjoutVoi.Location = new System.Drawing.Point(201, 364);
            this.btnAjoutVoi.Name = "btnAjoutVoi";
            this.btnAjoutVoi.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutVoi.TabIndex = 0;
            this.btnAjoutVoi.Text = "Ajouter";
            this.btnAjoutVoi.UseVisualStyleBackColor = true;
            this.btnAjoutVoi.Click += new System.EventHandler(this.btnAjoutVoi_Click);
            // 
            // lbImm
            // 
            this.lbImm.AutoSize = true;
            this.lbImm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImm.Location = new System.Drawing.Point(46, 58);
            this.lbImm.Name = "lbImm";
            this.lbImm.Size = new System.Drawing.Size(142, 25);
            this.lbImm.TabIndex = 1;
            this.lbImm.Text = "Immatriculation";
            this.lbImm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbAnn
            // 
            this.lbAnn.AutoSize = true;
            this.lbAnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnn.Location = new System.Drawing.Point(46, 105);
            this.lbAnn.Name = "lbAnn";
            this.lbAnn.Size = new System.Drawing.Size(70, 25);
            this.lbAnn.TabIndex = 2;
            this.lbAnn.Text = "Annee";
            this.lbAnn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMar
            // 
            this.lbMar.AutoSize = true;
            this.lbMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMar.Location = new System.Drawing.Point(46, 157);
            this.lbMar.Name = "lbMar";
            this.lbMar.Size = new System.Drawing.Size(79, 25);
            this.lbMar.TabIndex = 3;
            this.lbMar.Text = "Marque";
            this.lbMar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCou
            // 
            this.lbCou.AutoSize = true;
            this.lbCou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCou.Location = new System.Drawing.Point(46, 212);
            this.lbCou.Name = "lbCou";
            this.lbCou.Size = new System.Drawing.Size(81, 25);
            this.lbCou.TabIndex = 4;
            this.lbCou.Text = "Couleur";
            this.lbCou.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(46, 264);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(71, 25);
            this.lbType.TabIndex = 5;
            this.lbType.Text = "TypeV";
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtImm
            // 
            this.txtImm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImm.Location = new System.Drawing.Point(219, 62);
            this.txtImm.Name = "txtImm";
            this.txtImm.Size = new System.Drawing.Size(204, 30);
            this.txtImm.TabIndex = 6;
            // 
            // txtAnnee
            // 
            this.txtAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnee.Location = new System.Drawing.Point(219, 105);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(204, 30);
            this.txtAnnee.TabIndex = 7;
            // 
            // txtMarque
            // 
            this.txtMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarque.Location = new System.Drawing.Point(219, 157);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(204, 30);
            this.txtMarque.TabIndex = 8;
            // 
            // txtCouleur
            // 
            this.txtCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCouleur.Location = new System.Drawing.Point(219, 209);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(204, 30);
            this.txtCouleur.TabIndex = 9;
            // 
            // txtTypeV
            // 
            this.txtTypeV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeV.Location = new System.Drawing.Point(219, 264);
            this.txtTypeV.Name = "txtTypeV";
            this.txtTypeV.Size = new System.Drawing.Size(204, 30);
            this.txtTypeV.TabIndex = 10;
            // 
            // AjoutVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.txtTypeV);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.txtAnnee);
            this.Controls.Add(this.txtImm);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbCou);
            this.Controls.Add(this.lbMar);
            this.Controls.Add(this.lbAnn);
            this.Controls.Add(this.lbImm);
            this.Controls.Add(this.btnAjoutVoi);
            this.Name = "AjoutVoiture";
            this.Text = "Nouvelle_Voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutVoi;
        private System.Windows.Forms.Label lbImm;
        private System.Windows.Forms.Label lbAnn;
        private System.Windows.Forms.Label lbMar;
        private System.Windows.Forms.Label lbCou;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox txtImm;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.TextBox txtTypeV;
    }
}