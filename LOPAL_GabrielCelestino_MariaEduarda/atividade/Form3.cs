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
    public partial class Form3 : Form
    {
       

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //declaração de variaveis
            int placar1, placar2, placar3, placar4, placar5, placar6, placar7, placar8, placar9, placar10, placar11, placar12;

            //conversão de valores
            placar1 = int.Parse(txtPlacar1.Text);
            placar2 = int.Parse(txtPlacar2.Text);
            placar3 = int.Parse(txtPlacar3.Text);
            placar4 = int.Parse(txtPlacar4.Text);
            placar5 = int.Parse(txtPlacar5.Text);
            placar6 = int.Parse(txtPlacar6.Text);
            placar7 = int.Parse(txtPlacar7.Text);
            placar8 = int.Parse(txtPlacar8.Text);
            placar9 = int.Parse(txtPlacar9.Text);
            placar10 = int.Parse(txtPlacar10.Text);
            placar11 = int.Parse(txtPlacar11.Text);
            placar12 = int.Parse(txtPlacar12.Text);

            //casos grupo1 vence

            if (placar1 > placar2)
            {
                resultado1.Text = "Grêmio Venceu";
            }

             if (placar3 > placar4)
            {
                resultado2.Text = "Palmeiras Venceu";
            }

             if (placar5 > placar6)
            {
                resultado3.Text = "Corinthians Venceu";
            }

             if (placar7 > placar8)
            {
                resultado4.Text = "Santos Venceu";
            }

            if (placar9 > placar10)
            {
                resultado5.Text = "Ponte Preta Venceu";
            }

             if (placar11 > placar12)
            {
                resultado6.Text = "Flamengo Venceu";
            }


            //grupo 2 vença

            if (placar2 > placar1)
            {
                resultado1.Text = "Juventude Venceu";
            }

            if (placar4 > placar3)
            {
                resultado2.Text = "TDS CPTM)1 Venceu";
            }

            if (placar6 > placar5)
            {
                resultado3.Text = "Botafogo Venceu";
            }

            if (placar8 > placar7)
            {
                resultado4.Text = "Cruzeiro Venceu";
            }

            if (placar10 > placar9)
            {
                resultado5.Text = "Vasco Venceu";
            }

            if (placar12 > placar11)
            {
                resultado6.Text = "Real Madrid Venceu";
            }

            //em caso de empate
           if (placar2 == placar1)
            {
                resultado1.Text = "Empate";
      
            }

            if (placar4 == placar3)
            {
                resultado2.Text = "Empate";
            }

            if (placar6 == placar5)
            {
                resultado3.Text = "Empate";
            }

           if (placar8 == placar7)
            {
                resultado4.Text = "Empate";
            }

            if (placar10 == placar9)
            {
                resultado5.Text = "Empate";
            }

            if(placar12 == placar11)
            {
                resultado6.Text = "Empate";
            }



        }
        //configuração do menu
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Close();
        }
    }
}
