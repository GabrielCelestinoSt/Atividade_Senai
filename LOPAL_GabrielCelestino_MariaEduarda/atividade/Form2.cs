using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade
{
    public partial class Form2 : Form
    {

      
        public Form2()
        {
            InitializeComponent();
        }
        
        //declaração variaveis globais
        double peso, PesoFinal;
        string planeta;

        //configuração do menu
        private void voltarÀTelaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Close();
        }

        private void qualSeuPesoNoEspaçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void tabelaBrasileirão2012ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Close();
        }

        private void btnDescubra_Click(object sender, EventArgs e)
        {
            //declaração de variáveis locais
            peso = double.Parse(txtPeso.Text);
            

            //seleção de planetas
            if (rbnMarte.Checked)
            {
                PesoFinal = peso * 0.38;
                planeta = "Marte";
                
               
            }

            else if (rbnSaturno.Checked)
            {
                PesoFinal = peso * 1.15;
                planeta = "Saturno";

              
            }

            else if (rbnMerc.Checked)
            {
                PesoFinal = peso * 0.37;
                planeta = "Mercúrio";

                
            }

            else if (rbnUran.Checked)
            {
                PesoFinal = peso * 1.17;
                planeta = "Urano";

               
            }

            else if (rbnVenus.Checked)
            {
                PesoFinal = peso * 0.88;
                planeta = "Vênus";

               
            }

            else if (rbnJupiter.Checked)
            {
                PesoFinal = peso * 2.64;
                planeta = "Júpiter";

                
            }

            MessageBox.Show("seu peso em "+ planeta + " é de: " +PesoFinal+ "kg", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
