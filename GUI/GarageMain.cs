using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;


namespace GUI
{
    public partial class GarageMain : Form
    {
        //public String immatriculation ="", annee ="", type = "";
        Garage garage = new Garage();
        
        public GarageMain()
        {
            InitializeComponent();
            remplirListBox();

        }

        public void remplirListBox()
        {
            lstAffichage.Items.Clear();
            if (btnRadioMoto.Checked)
            {
                List<Automobile> motos = garage.AfficherAutomoiles(SubType.Moto);
                if (motos != null && motos.Count != 0)
                {
                    foreach (Automobile moto in motos)
                    {
                        lstAffichage.Items.Add(moto);
                    }
                }
                else
                    lstAffichage.Items.Add("Pas de motos");
            }else if (btnRadioVoiture.Checked)
            {
                //lstAffichage.Items.Clear();
                List<Automobile> voitures = garage.AfficherAutomoiles(SubType.Voiture);
                if (voitures != null && voitures.Count != 0)
                {
                    foreach (Automobile voiture in voitures)
                    {
                        lstAffichage.Items.Add(voiture);
                    }
                }
                else
                    lstAffichage.Items.Add("Pas de voitures");
            }
            
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (btnRadioMoto.Checked == true)
            {
                Moto newMoto = new Moto();
                AjoutMoto ajoutMoto = new AjoutMoto(newMoto);
                if (ajoutMoto.ShowDialog() == DialogResult.OK)
                {
                    if (garage.GetAuto(newMoto.immatriulation) == null)
                    {
                        garage.AddAuto(newMoto);
                        lstAffichage.Items.Clear();
                        foreach (Moto moto in garage.AfficherAutomoiles(SubType.Moto))
                        {
                            lstAffichage.Items.Add(moto);
                        }
                    }
                    else
                        MessageBox.Show("Moto existe deja avec la meme immatriculation");

                }
            }
            else if (btnRadioVoiture.Checked == true)
            {
                Voiture newVoiture = new Voiture();
                AjoutVoiture ajoutVoiture = new AjoutVoiture(newVoiture);
                if (ajoutVoiture.ShowDialog() == DialogResult.OK)
                {
                    if (garage.GetAuto(newVoiture.immatriulation) == null)
                    {
                        garage.AddAuto(newVoiture);
                        lstAffichage.Items.Clear();
                        foreach (Voiture voiture in garage.AfficherAutomoiles(SubType.Voiture))
                        {
                            lstAffichage.Items.Add(voiture);
                        }
                    }
                    else
                        MessageBox.Show("Voiture existe deja avec la meme immatrculation");


                }
            }
        }

        private void btnRadioVoiture_CheckedChanged(object sender, EventArgs e)
        {
            lstAffichage.Items.Clear();
            List<Automobile> voitures = garage.AfficherAutomoiles(SubType.Voiture);
            if (voitures != null && voitures.Count != 0)
            {
                foreach (Automobile voiture in voitures)
                {
                    lstAffichage.Items.Add(voiture);
                }
            }
            else
                lstAffichage.Items.Add("Pas de voitures");
        }

        private void btnRadioMoto_CheckedChanged(object sender, EventArgs e)
        {
            lstAffichage.Items.Clear();
            List <Automobile> motos = garage.AfficherAutomoiles(SubType.Moto);
            if (motos!= null&&motos.Count!=0)
            {
                foreach (Automobile moto in motos)
                {
                    lstAffichage.Items.Add(moto);
                }
            }
            else
                lstAffichage.Items.Add("Pas de motos");
        }

        private void txtAjout_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
 
            if (lstAffichage.SelectedItem != null)
            {
                Automobile aut = (Automobile)lstAffichage.SelectedItem;
                garage.DeleteAuto(aut.immatriulation);
                remplirListBox();
            }
            else
                MessageBox.Show("Vous devez selectionner un object");
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            if (lstAffichage.SelectedItem != null)
            {
                Automobile aut = (Automobile)lstAffichage.SelectedItem;

                txtAffichageAnnee.Text = aut.annee.ToString();
                txtAffichageImm.Text = aut.immatriulation.ToString();
                if (aut is Voiture)
                {
                    txtAffichageType.Text = "Voiture";
                    VoitureInfo voitureInfo = new VoitureInfo((Voiture)aut);
                    voitureInfo.Show();
                }
                else if (aut is Moto)
                {
                    txtAffichageType.Text = "Moto";
                    MotoInfo motoInfo = new MotoInfo((Moto)aut);
                    motoInfo.Show();
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un object");
            }
            
        }

        private void lstAffichage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstAffichage.SelectedItem != null)
            {
                Automobile auto = (Automobile)lstAffichage.SelectedItem;
                txtAffichageImm.Text = auto.immatriulation.ToString();
                txtAffichageAnnee.Text = auto.annee.ToString();
                if (auto is Voiture)
                    txtAffichageType.Text = "Voiture";
                }else
                txtAffichageType.Text = "Moto";
        }
        }
    }
