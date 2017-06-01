using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna_ele
{
    public partial class Form1 : Form
    {
        int votos_chris = 0, votos_greg = 0, votos_drew = 0, votos_caruso = 0, votos_branco = 0;

        int voto = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Chris_Click(object sender, EventArgs e)
        {
            painelEscolha.Image = Properties.Resources.chris;
            votos_chris += 1;
            cont_chris.Text = Convert.ToString(votos_chris);
        }

        private void Greg_Click(object sender, EventArgs e)
        {
            painelEscolha.Image = Properties.Resources.gregg;
            votos_greg += 1;
             cont_chris.Text = Convert.ToString(votos_chris);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            painelNum.Text += "1";
            if (painelNum.Text.Length == 2)
            {
                voto = Convert.ToInt16(painelNum.Text);
                switch (voto)
                { 
                case 15:
                    painelEscolha.Image = Properties.Resources.chris;
                    break;

                case 20:
                    painelEscolha.Image = Properties.Resources.gregg;
                    break;

                case 25:
                    painelEscolha.Image = Properties.Resources.drew;
                    break;

                case 30:
                    painelEscolha.Image = Properties.Resources.caruso;
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            painelNum.Text += "2";
            if (painelNum.Text.Length == 2)
            {
                voto = Convert.ToInt16(painelNum.Text);
                switch (voto)
                {
                    case 15:
                        painelEscolha.Image = Properties.Resources.chris;
                        break;

                    case 20:
                        painelEscolha.Image = Properties.Resources.gregg;
                        break;

                    case 25:
                        painelEscolha.Image = Properties.Resources.drew;
                        break;

                    case 30:
                        painelEscolha.Image = Properties.Resources.caruso;
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            painelNum.Text += "3";
            if (painelNum.Text.Length == 2)
            {
                voto = Convert.ToInt16(painelNum.Text);
                switch (voto)
                {
                    case 15:
                        painelEscolha.Image = Properties.Resources.chris;
                        break;

                    case 20:
                        painelEscolha.Image = Properties.Resources.gregg;
                        break;

                    case 25:
                        painelEscolha.Image = Properties.Resources.drew;
                        break;

                    case 30:
                        painelEscolha.Image = Properties.Resources.caruso;
                        break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            painelNum.Text += "4";
            if (painelNum.Text.Length == 2)
            {
                voto = Convert.ToInt16(painelNum.Text);
                switch (voto)
                {
                    case 15:
                        painelEscolha.Image = Properties.Resources.chris;
                        break;

                    case 20:
                        painelEscolha.Image = Properties.Resources.gregg;
                        break;

                    case 25:
                        painelEscolha.Image = Properties.Resources.drew;
                        break;

                    case 30:
                        painelEscolha.Image = Properties.Resources.caruso;
                        break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            painelNum.Text += "5";
            if (painelNum.Text.Length == 2)
            {
                voto = Convert.ToInt16(painelNum.Text);
                switch (voto)
                {
                    case 15:
                        painelEscolha.Image = Properties.Resources.chris;
                        break;

                    case 20:
                        painelEscolha.Image = Properties.Resources.gregg;
                        break;

                    case 25:
                        painelEscolha.Image = Properties.Resources.drew;
                        break;

                    case 30:
                        painelEscolha.Image = Properties.Resources.caruso;
                        break;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            painelNum.Text += "6";
            if (painelNum.Text.Length == 2)
            {
                voto = Convert.ToInt16(painelNum.Text);
                switch (voto)
                {
                    case 15:
                        painelEscolha.Image = Properties.Resources.chris;
                        break;

                    case 20:
                        painelEscolha.Image = Properties.Resources.gregg;
                        break;

                    case 25:
                        painelEscolha.Image = Properties.Resources.drew;
                        break;

                    case 30:
                        painelEscolha.Image = Properties.Resources.caruso;
                        break;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            painelNum.Text += "7";
            if (painelNum.Text.Length == 2)
            {
                voto = Convert.ToInt16(painelNum.Text);
                switch (voto)
                {
                    case 15:
                        painelEscolha.Image = Properties.Resources.chris;
                        break;

                    case 20:
                        painelEscolha.Image = Properties.Resources.gregg;
                        break;

                    case 25:
                        painelEscolha.Image = Properties.Resources.drew;
                        break;

                    case 30:
                        painelEscolha.Image = Properties.Resources.caruso;
                        break;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            painelNum.Text += "8";
            if (painelNum.Text.Length == 2)
            {
                voto = Convert.ToInt16(painelNum.Text);
                switch (voto)
                {
                    case 15:
                        painelEscolha.Image = Properties.Resources.chris;
                        break;

                    case 20:
                        painelEscolha.Image = Properties.Resources.gregg;
                        break;

                    case 25:
                        painelEscolha.Image = Properties.Resources.drew;
                        break;

                    case 30:
                        painelEscolha.Image = Properties.Resources.caruso;
                        break;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            painelNum.Text += "9";
            if (painelNum.Text.Length == 2)
            {
                voto = Convert.ToInt16(painelNum.Text);
                switch (voto)
                {
                    case 15:
                        painelEscolha.Image = Properties.Resources.chris;
                        break;

                    case 20:
                        painelEscolha.Image = Properties.Resources.gregg;
                        break;

                    case 25:
                        painelEscolha.Image = Properties.Resources.drew;
                        break;

                    case 30:
                        painelEscolha.Image = Properties.Resources.caruso;
                        break;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            painelNum.Text += "0";
            if (painelNum.Text.Length == 2)
            {
                voto = Convert.ToInt16(painelNum.Text);
                switch (voto)
                {
                    case 15:
                        painelEscolha.Image = Properties.Resources.chris;
                        break;

                    case 20:
                        painelEscolha.Image = Properties.Resources.gregg;
                        break;

                    case 25:
                        painelEscolha.Image = Properties.Resources.drew;
                        break;

                    case 30:
                        painelEscolha.Image = Properties.Resources.caruso;
                        break;
                }
            }
        }

        private void branco_Click(object sender, EventArgs e)
        {
            votos_branco++;
            voto = 1000;// votos = 1000 quando for votado em branco.
            painelEscolha.Image = Properties.Resources.branco;
        }

        private void corrige_Click(object sender, EventArgs e)
        {
            painelNum.Clear();
            painelEscolha.Image = Properties.Resources.nyan_dilma;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            cont_branco.Visible = true;
            cont_caruso.Visible = true;
            cont_chris.Visible = true;
            cont_drew.Visible = true;
            cont_greg.Visible = true;
        }

        private void confirma_Click(object sender, EventArgs e)
        {
            if (voto!=1000)
            voto = Convert.ToInt16(painelNum.Text);
            painelNum.Clear();
            switch (voto)
            {
                case 15:
                    votos_chris +=1;
                    painelEscolha.Image = Properties.Resources.nyan_dilma;
                    cont_chris.Text = Convert.ToString(votos_chris);
                    break;

                case 20:
                    votos_greg += 1;
                    painelEscolha.Image = Properties.Resources.nyan_dilma;
                    cont_greg.Text = Convert.ToString(votos_greg);
                    break;
                    

                case 25:
                    votos_drew += 1;
                    painelEscolha.Image = Properties.Resources.nyan_dilma;
                    cont_drew.Text = Convert.ToString(votos_drew);
                    break;

                case 30:
                    votos_caruso += 1;
                    painelEscolha.Image = Properties.Resources.nyan_dilma;
                    cont_caruso.Text = Convert.ToString(votos_caruso);
                    break;
                    
                case 1000:
                    painelEscolha.Image = Properties.Resources.nyan_dilma;
                    cont_branco.Text = Convert.ToString(votos_branco);
                    break;

            }
        }   
        

        private void Drew_Click(object sender, EventArgs e)
        {
            painelEscolha.Image = Properties.Resources.drew;
            votos_drew += 1;
            cont_drew.Text = Convert.ToString(votos_drew);
        }

        private void Caruso_Click(object sender, EventArgs e)
        {
            painelEscolha.Image = Properties.Resources.caruso;
            votos_caruso += 1;
            cont_caruso.Text = Convert.ToString(votos_caruso);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
