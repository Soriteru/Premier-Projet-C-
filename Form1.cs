using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierProjet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables globales
        string[] tabNoms = new string[100];
        string[] tabSexes = new string[100];
        int[] tabNaissances = new int[100];
        int[] tabFautes = new int[100];
        int nbCandidats, nbCandidatsM, nbCandidatsF;

        //au lancement
        private void Form1_Load(object sender, EventArgs e)
        {
            nbCandidats = 0;
            nbCandidatsF = 0;
            nbCandidatsM = 0;
        }

        private void buttonEnregCandidat_Click(object sender, EventArgs e)
        {
            tabNoms[nbCandidats] = TextBoxNom.Text;
            tabNaissances[nbCandidats] = Convert.ToInt16(TextBoxAnnee.Text);
            if(radioButtonM.Checked)
            {
                tabSexes[nbCandidats] = "masculin";
                nbCandidatsM++;
            }
            else
            {
                tabSexes[nbCandidats] = "féminin";
                nbCandidatsF++;
            }
            labelNumero.Text = Convert.ToString(nbCandidats);
            nbCandidats++;
        }

        private void buttonEnregResultat_Click(object sender, EventArgs e)
        {
            int numeroCandidat = Convert.ToInt16(textBoxNumero.Text);
            tabFautes[numeroCandidat] = Convert.ToInt16(textBoxFautes.Text);
        }

        private void buttonAffichRecus_Click(object sender, EventArgs e)
        {
            int nbRecus, nbRecusM, nbRecusF;
            nbRecus = 0;
            nbRecusM = 0;
            nbRecusF = 0;

            for(int i = 0; i < nbCandidats; i++)
            {
                if (tabFautes[i] <= 5)
                {
                    listBoxRecus.Items.Add(tabNoms[i]);
                    nbRecus++;
                    if (tabSexes[i] == "masculin")
                        nbRecusM++;
                    else
                        nbRecusF++;
                }
            }
            if(nbCandidats!= 0)
                labelPourcent.Text = Convert.ToString((nbRecus / nbCandidats)*100);
            if(nbCandidatsM!= 0)
                labelPourcentM.Text = Convert.ToString((nbRecusM / nbCandidatsM)*100);
            if(nbCandidatsF!= 0)
                labelPourcentF.Text = Convert.ToString((nbRecusF / nbCandidatsF)*100);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
