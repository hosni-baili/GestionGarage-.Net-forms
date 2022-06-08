using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AjoutVoiture : Form
    {
        Garage garage = new Garage();
        Voiture voiture = new Voiture();
        public AjoutVoiture(Voiture newVoiture)
        {
            InitializeComponent();
            this.voiture = newVoiture;

        }

        private void btnAjoutVoi_Click(object sender, EventArgs e)
        {
            this.voiture.annee = int.Parse(txtAnnee.Text);
            this.voiture.immatriulation = txtImm.Text;
            this.voiture.couleur = txtCouleur.Text;
            this.voiture.marque = txtMarque.Text;
            this.voiture.typeV = txtTypeV.Text;
            this.Close();
            /*
            if (int.Parse(txtAnnee.Text)!=0&& int.Parse(txtAnnee.Text)>1900&& int.Parse(txtAnnee.Text) < DateTime.Today.Date.Year)
            {

                if (txtCouleur.Text != "")
                {
                    if (txtImm.Text != "")
                    {
                        if (txtMarque.Text != "")
                        {
                            if (txtTypeV.Text != "")
                            {
                                Automobile newVoiture = new Voiture(int.Parse(txtAnnee.Text), txtImm.Text, txtCouleur.Text, txtMarque.Text, txtTypeV.Text);
                                garage.AddAuto(newVoiture);
                                MessageBox.Show("Voiture ajoutee avec succes");
                                this.Close();
                            }
                            else
                                MessageBox.Show("Entrez le type de la voiture");
                        }
                        else
                            MessageBox.Show("Entrez la marque de la voiture");
                    }
                    else
                        MessageBox.Show("Entrez l'immatriculation de la voiture");
                }
                else
                    MessageBox.Show("Entrez la Couleur de la voiture");

            }
            else
                MessageBox.Show("Entrez une annee valide de la voiture");
            */
        }
    }
}
