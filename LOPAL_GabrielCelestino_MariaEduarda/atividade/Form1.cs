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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //declaração de variáveis
            double n1, n2, n3;

            n1 = int.Parse(txtV1.Text);
            n2 = int.Parse(txtV2.Text);
            n3 = int.Parse(txtV3.Text);

            //condicionamento para número maior
            if (n1>n2 && n1 > n3)
            {
                lblmaior.Text = "Maior: " + n1.ToString();
            }

            else if (n2 > n1 && n2 > n3)
            {
                lblmaior.Text = "Maior: " + n2.ToString();
            }

            else 
            {
                lblmaior.Text = "Maior: " + n3.ToString();
            }
           
            //condicionamento para número menor

            if (n1 < n2 && n1 < n3)
            {
                lblMenor.Text = "Menor: " + n1.ToString();
            }

            else if (n2 < n1 && n2 < n3)
            {
                lblMenor.Text = "Menor: " + n2.ToString();
            }

            else
            {
                lblMenor.Text = "Menor: " + n3.ToString();
            }



        }
        //configuração do menu
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Close();
        }
    }
}
