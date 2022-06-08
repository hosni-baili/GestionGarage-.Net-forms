using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Moto : Automobile
    {
        public int cylindre { get; set; }
        public int vitesseMax { get; set; }

        public Moto() : base()
        {
        }

        public Moto(int annee, String immatriculation, int cylindre, int vitesseMax) : base(annee, immatriculation)
        {
            this.cylindre = cylindre;
            this.vitesseMax = vitesseMax;
        }

        public override string ToString()
        {
            return base.ToString() + " cylindre = " + cylindre + " vitesseMax = " + vitesseMax;
        }


    }
}
