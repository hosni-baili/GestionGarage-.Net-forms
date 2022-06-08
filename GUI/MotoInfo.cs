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
    public partial class MotoInfo : Form
    {
        Garage garage = new Garage();
        public MotoInfo()
        {
            InitializeComponent();
        }

        public MotoInfo(Moto moto)
        {
            InitializeComponent();
            txtIDMoto.Text = moto.immatriulation;
            ListViewItem listViewMoto=new ListViewItem();
            listViewMoto.Text=moto.vitesseMax.ToString();
            listViewMoto.SubItems.Add(moto.cylindre.ToString());
            listView1.Items.Add(listViewMoto);
            //listViewMoto.Items.Add("hello");
        }
    }
}
