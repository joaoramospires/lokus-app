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
    public partial class Form1 : Form
    {
        private int timeCounter = 0;

        public Form1()
        {
            InitializeComponent();

            // Torna o controle PictureBox visível
            pictureBox1.Visible = true;

            // Inicia o Timer para atualizar a label a cada segundo
            timer1.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Incrementa o contador de tempo
            timeCounter++;

            // Atualiza a label com o tempo atualizado
            label2.Text = timeCounter.ToString() + "%";

            // label2.Text = timeCounter.

            // Se o tempo chegar a 10 segundos, redireciona para o outro formulário

            if (timeCounter > 10)
            {
                timer1.Interval = 15;

                if (timeCounter > 30)
                {
                    timer1.Interval = 15;

                    if (timeCounter > 60)
                    {
                        timer1.Interval = 15;

                        if (timeCounter > 90)
                        {
                            timer1.Interval = 15;

                            if (timeCounter == 100)
                            {
                                // Para o Timer
                                timer1.Stop();

                                var a = new Form2();
                                a.Location = this.Location;
                                a.StartPosition = FormStartPosition.Manual;
                                a.FormClosing += delegate { this.Show(); };
                                a.Show();
                                this.Hide();

                                //// Redireciona para o outro formulário (Form2)

                                //Form2 form2 = new Form2();
                                //form2.ShowDialog();

                                //// Fecha o formulário atual (Form1)
                                //Form1 form1 = new Form1();
                                //form1.Visible = false;

                            }
                        }
                    }
                }
            }
        }
    }
}
