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
            int nhost = int.Parse(NHost.Text), nreti = int.Parse(NReti.Text); int classe = Convert.ToInt32(Math.Log(nhost + 2, 2) + Math.Log(nreti, 2));
            string classef = TrovaClasse(classe);
            Classe.Text = classef;
            Privato.Text = IndirizzoPrivato(classef);
            int bit = CalcolaBit(nhost);
            CDIR.Text = $"/{bit.ToString()}";
            Subnet.Text = CalcolaSubnet(bit);
        }
        private int CalcolaBit(int nhost)
        {
            int bit = 0;
            while ((int)Math.Pow(2, bit) - 2 < nhost)
            {
                bit++;
            }
            return bit;
        }
        private string CalcolaSubnet(int bit)
        {
            int[] subnet = new int[4];
            for (int i = 0; i < subnet.Length; i++)
            {
                if (bit >= 8)
                {
                    subnet[i] = 255;
                    bit -= 8;
                }
                else
                {
                    subnet[i] = (int)(255 - (Math.Pow(2, 8 - bit) - 1));
                    bit = 0;
                }
            }
            return $"{subnet[0]}.{subnet[1]}.{subnet[2]}.{subnet[3]}";
        }
        private string TrovaClasse(int classe)
        {
            if (classe >= 24)
            {
                return "C";
            }
            else if (classe >= 16)
            {
                return "B";

            }
            else
            {
                return "A";
            }
        }
        private string IndirizzoPrivato(string classef)
        {
            if (classef == "C")
            {
                return "192.168.0.0";
            }
            else if (classef == "B")
            {
                return "172.16.0.0";
            }
            else
            {
                return "10.0.0.0";
            }
        }
    }
}

