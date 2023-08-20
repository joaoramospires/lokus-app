using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_redicionamento
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }


        // ------------- BOTÃO DE MAIS (+) -----------------------------------------------------------------
        private void Btt_maisOpcoes_Click(object sender, EventArgs e)
        {
            btt_AutoCarros.Visible = true;
            btt_Paragens.Visible = true;
            btt_Favotito.Visible = true;
        }

        private void Btt_maisOpcoes_MouseDown(object sender, MouseEventArgs e)
        {
            // Aqui ele armazena a poseção  
            Point originalLocation = Btt_maisOpcoes.Location;

            // Calcula o deslocamento necessário para manter o controle no centro enquanto cresce
            int xOffset = (50 - Btt_maisOpcoes.Width) / 2;
            int yOffset = (50 - Btt_maisOpcoes.Height) / 2;

            // Atualiza a posição e o tamanho do controle
            Btt_maisOpcoes.Location = new Point(originalLocation.X - xOffset, originalLocation.Y - yOffset);
            Btt_maisOpcoes.Size = new Size(50, 50);
        }
        private void Btt_maisOpcoes_MouseUp(object sender, MouseEventArgs e)
        {
            Point originalLocation = Btt_maisOpcoes.Location;

            // Calcula o deslocamento necessário para manter o controle no centro enquanto diminui
            int xOffset = (Btt_maisOpcoes.Width - 45) / 2;
            int yOffset = (Btt_maisOpcoes.Height - 45) / 2;

            // Atualiza a posição e o tamanho do controle
            Btt_maisOpcoes.Location = new Point(originalLocation.X + xOffset, originalLocation.Y + yOffset);
            Btt_maisOpcoes.Size = new Size(45, 45);
        }

       



        //----------- Botão Auto Carro ----------------------------------------
        private void btt_AutoCarros_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void btt_AutoCarros_MouseEnter(object sender, EventArgs e)
        {
            // Aqui faço a alteração do fundo(azul escuro) e da letra(Branco) 
            Color color = System.Drawing.ColorTranslator.FromHtml("#141223");
            btt_AutoCarros.BackColor = color;

            btt_AutoCarros.TextColor = Color.White;
        }
        private void btt_AutoCarros_MouseLeave(object sender, EventArgs e)
        {
            // Aqui faço a alteração do fundo(transparente) e da letra(azul escuro)
            Color color = System.Drawing.ColorTranslator.FromHtml("#141223");
            btt_AutoCarros.TextColor = color;

            btt_AutoCarros.BackColor = Color.Transparent;
        }





        //----------- Botão Paragens ----------------------------------------
        private void btt_Paragens_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }

        private void btt_Paragens_MouseEnter(object sender, EventArgs e)
        {
            // Aqui faço a alteração do fundo(azul escuro) e da letra(Branco) 
            Color color = System.Drawing.ColorTranslator.FromHtml("#141223");
            btt_Paragens.BackColor = color;

            btt_Paragens.TextColor = Color.White;
        }
        private void btt_Paragens_MouseLeave(object sender, EventArgs e)
        {
            // Aqui faço a alteração do fundo(transparente) e da letra(azul escuro)
            Color color = System.Drawing.ColorTranslator.FromHtml("#141223");
            btt_Paragens.TextColor = color;

            btt_Paragens.BackColor = Color.Transparent;
        }





        //----------- Botão Favoritos ----------------------------------------
        private void btt_Favotito_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void btt_Favotito_MouseEnter(object sender, EventArgs e)
        {
            // Aqui faço a alteração do fundo(azul escuro) e da letra(Branco) 
            Color color = System.Drawing.ColorTranslator.FromHtml("#141223");
            btt_Favotito.BackColor = color;

            btt_Favotito.TextColor = Color.White;
        }

        private void btt_Favotito_MouseLeave(object sender, EventArgs e)
        {
            // Aqui faço a alteração do fundo(transparente) e da letra(azul escuro)
            Color color = System.Drawing.ColorTranslator.FromHtml("#141223");
            btt_Favotito.TextColor = color;

            btt_Favotito.BackColor = Color.Transparent;
        }
    }
}
