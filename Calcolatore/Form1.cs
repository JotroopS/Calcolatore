using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatore
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calcola_Click(object sender, EventArgs e)
        {
            int nhost = int.Parse(NHost.Text), nreti = int.Parse(NReti.Text); int Cdir = Convert.ToInt32(Math.Log(nhost + 2, 2) + Math.Log(nreti, 2));
            if (Cdir <= 8)
            {
                Classe.Text = "Classe C";
                CDIR.Text = "/8";
                SubnetDef.Text = "255.255.255.0";
            }
            else if (Cdir <= 16)
            {
                Classe.Text = "Classe B";
                CDIR.Text = "/16";
                SubnetDef.Text = "255.255.0.0";
            }
            else if (Cdir <= 24)
            {
                Classe.Text = "Classe A";
                CDIR.Text = "/24";
                SubnetDef.Text = "255.0.0.0";
            }
            else if (Cdir > 24)
            {
                MessageBox.Show("Hai inserito troppi host");
                NHost.Clear();
                NReti.Clear();
                Classe.Clear();
                CDIR.Clear();
                SubnetDef.Clear();
            }

        }
    }
}
