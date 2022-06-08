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
    public partial class VoitureInfo : Form
    {
        Garage garage = new Garage();

        public VoitureInfo(Voiture aut)
        {
            InitializeComponent();

            
            txtIDVoiture.Text = aut.immatriulation;
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = aut.marque;
            listViewItem.SubItems.Add(aut.couleur);
            listViewItem.SubItems.Add(aut.typeV);
            listView1.Items.Add(listViewItem);
        }
    }
}
