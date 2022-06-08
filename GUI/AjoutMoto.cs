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
    public partial class AjoutMoto : Form
    {
        Moto moto = new Moto();

        public AjoutMoto(Moto newMoto)
        {
            InitializeComponent();
            this.moto = newMoto;

        }

        private void btnAjoutMoto_Click(object sender, EventArgs e)
        {
            this.moto.annee= int.Parse(txtAnnee.Text);
            this.moto.immatriulation = txtImm.Text;
            this.moto.cylindre = int.Parse(txtCylindre.Text);
            this.moto.vitesseMax = int.Parse(txtVitesse.Text);
            this.Close();
            /*
            if (int.Parse(txtAnnee.Text) != 0 && int.Parse(txtAnnee.Text) > 1900 && int.Parse(txtAnnee.Text) < DateTime.Today.Date.Year)
            {
                if (int.Parse(txtCylindre.Text) != 0)
                {
                    if (txtImm.Text != "")
                    {
                        if (int.Parse(txtVitesse.Text) != 0)
                        {

                                Automobile newMoto = new Moto(int.Parse(txtAnnee.Text), txtImm.Text, int.Parse(txtCylindre.Text), int.Parse(txtVitesse.Text));
                                garage.AddAuto(newMoto);
                                MessageBox.Show("moto ajoutee avec succes");
                                this.Close();

                        }
                        else
                            MessageBox.Show("Entrez la marque de la moto");
                    }
                    else
                        MessageBox.Show("Entrez l'immatriculation de la moto");
                }
                else
                    MessageBox.Show("Entrez le nombre de cylindre de la moto");

            }
            else
                MessageBox.Show("Entrez une annee valide de la moto");
            */
        }
    }
}
