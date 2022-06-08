using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Voiture : Automobile
    {
        public String couleur { get; set; }
        public String marque { get; set; }
        public String typeV { get; set; }

        public override string ToString()
        {
            return base.ToString() + " couleur = " + couleur + " marque = " + marque + " typeV = " + typeV;
        }

        public Voiture() : base()
        { }

        public Voiture(int annee, String immatriculation, string couleur, string marque, string typeV) : base(annee, immatriculation)
        {
            this.couleur = couleur;
            this.marque = marque;
            this.typeV = typeV;
        }

    }
}
