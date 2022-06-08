using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Automobile
    {
        public int annee { get; set; }
        public String immatriulation { get; set; }


        public Automobile() { }

        public Automobile(int annee, string immatriulation)
        {
            this.annee = annee;
            this.immatriulation = immatriulation;
        }

        public override string ToString()
        {
            return "Annee = " + annee + "  immatriculation = " + immatriulation;
        }
    }
}
