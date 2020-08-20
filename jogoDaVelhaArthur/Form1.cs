using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoDaVelhaArthur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            limparCampos();
        }

        Boolean vezJogador = true;
        int contarVezes = 0;
        int contarVitoria1 = 0;
        int contarVitoria2 = 0;

        void limparCampos()
        {
            a11.Text = "";
            a12.Text = "";
            a13.Text = "";
            a21.Text = "";
            a22.Text = "";
            a23.Text = "";
            a31.Text = "";
            a32.Text = "";
            a33.Text = "";

            lblVez.Text = "Vez do Jogador 1 (X)";
            contarVezes = 0;
            vezJogador = true;
        }
        
        void ManipularBotoes(Button botao)
        {            
            if (vezJogador == true)
            {
                if(botao.Text == "")
                {
                    botao.Text = "X";
                    vezJogador = false;
                    lblVez.Text = "Vez do Jogador 2 (O)";
                    contarVezes = contarVezes + 1;
                }
            }
            else
            {
                if (botao.Text == "")
                {
                    botao.Text = "O";
                    vezJogador = true;
                    lblVez.Text = "Vez do Jogador 1 (X)";
                    contarVezes = contarVezes + 1;
                }
            }
            verificarVencedor();
        }

        void verificarVencedor()
        {
            if(
                a11.Text == "X" && a12.Text == "X" && a13.Text == "X" ||
                a21.Text == "X" && a22.Text == "X" && a23.Text == "X" ||
                a31.Text == "X" && a32.Text == "X" && a33.Text == "X" ||
                a11.Text == "X" && a21.Text == "X" && a31.Text == "X" ||
                a12.Text == "X" && a22.Text == "X" && a32.Text == "X" ||
                a13.Text == "X" && a23.Text == "X" && a33.Text == "X" ||
                a11.Text == "X" && a22.Text == "X" && a33.Text == "X" ||
                a13.Text == "X" && a22.Text == "X" && a31.Text == "X"
              )
            {
                MessageBox.Show("O JOGADOR 1 VENCEU");
                contarVitoria1 = contarVitoria1 + 1;
                lblPontuacao1.Text = contarVitoria1.ToString();
                limparCampos();
            }else if 
                (
                a11.Text == "O" && a12.Text == "O" && a13.Text == "O" ||
                a21.Text == "O" && a22.Text == "O" && a23.Text == "O" ||
                a31.Text == "O" && a32.Text == "O" && a33.Text == "O" ||
                a11.Text == "O" && a21.Text == "O" && a31.Text == "O" ||
                a12.Text == "O" && a22.Text == "O" && a32.Text == "O" ||
                a13.Text == "O" && a23.Text == "O" && a33.Text == "O" ||
                a11.Text == "O" && a22.Text == "O" && a33.Text == "O" ||
                a13.Text == "O" && a22.Text == "O" && a31.Text == "O"
                ) 
            {
                MessageBox.Show("O JOGADOR 2 VENCEU");
                contarVitoria2 = contarVitoria2 + 1;
                lblPontuacao2.Text = contarVitoria2.ToString();
                limparCampos();
            }else
            {
                if( contarVezes >= 9)
                { 
                    MessageBox.Show("JOGO DEU VELHA");
                    limparCampos();
                }
            }
        }

        private void a11_Click(object sender, EventArgs e)
        {
            ManipularBotoes(a11);

        }

        private void a12_Click(object sender, EventArgs e)
        {
            ManipularBotoes(a12);

        }

        private void a13_Click(object sender, EventArgs e)
        {
            ManipularBotoes(a13);
        }

        private void a21_Click(object sender, EventArgs e)
        {
            ManipularBotoes(a21);
        }

        private void a22_Click(object sender, EventArgs e)
        {
            ManipularBotoes(a22);
        }

        private void a23_Click(object sender, EventArgs e)
        {
            ManipularBotoes(a23);
        }

        private void a31_Click(object sender, EventArgs e)
        {
            ManipularBotoes(a31);
        }

        private void a32_Click(object sender, EventArgs e)
        {
            ManipularBotoes(a32);
        }

        private void a33_Click(object sender, EventArgs e)
        {
            ManipularBotoes(a33);
        }
    }
}
