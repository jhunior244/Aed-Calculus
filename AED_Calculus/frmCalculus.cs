using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AED_Calculus
{
    public partial class frmCalculus : AED_ChartBase.drawForm
    {
        public frmCalculus()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            sample();
        }
        private void zerarCaixas()
        {
            textVolume.Text = null;
            textLado.Text = null;
            textFundo.Text = null;
        }
        private void setarRich(float volume, float fundo, float lado)
        {
            float cumprimento = volume / fundo / lado;
            richTextBox1.Text += "Cumprimento inicial: " + cumprimento +"\n" + "\n";
            richTextBox1.Text += "Largura inicial: " + lado + "\n" + "\n";
            richTextBox1.Text += "Profundidade inicial: " + fundo + "\n" + "\n";
            richTextBox1.Text += "Volume inicial: " + volume + "\n" + "\n";
            float area = (2 * cumprimento * fundo) + (cumprimento * lado) + (2 * lado * fundo);
            richTextBox1.Text += "Maior area possivel com esses valores: " + area + "\n" + "\n";       
            lado = (float)Math.Sqrt(volume / fundo);
            area = (2 * lado * fundo) + lado * lado + (2 * lado * fundo);
            richTextBox1.Text += "Menor area possivel com esses valores: " + area + "\n" + "\n";
            richTextBox1.Text += "==============================  ";

        }
        private void setarRich(float volume, float fundo)
        {
            float lado = 2;
            float cumprimento = volume / fundo / lado;
            richTextBox1.Text += "Cumprimento inicial: " + cumprimento + "\n" + "\n";
            richTextBox1.Text += "Largura inicial: " + lado + "\n" + "\n";
            richTextBox1.Text += "Profundidade inicial: " + fundo + "\n" + "\n";
            richTextBox1.Text += "Volume inicial: " + volume + "\n" + "\n";
            float area = (2 * cumprimento * fundo) + (cumprimento * lado) + (2 * lado * fundo);
            richTextBox1.Text += "Maior area possivel com esses valores: " + area + "\n" + "\n";
            lado = (float)Math.Sqrt(volume / fundo);
            area = (2 * lado * fundo) + lado * lado + (2 * lado * fundo);
            richTextBox1.Text += "Menor area possivel com esses valores: " + area + "\n" + "\n";
            richTextBox1.Text += "==============================  ";
        }
        private void calcArea(float largura, float cumprimento, float altura)
        {
            labelArea.Text = "";
            labelArea.Text = "Area no ponto: " + ((2 * cumprimento * altura) + (cumprimento * largura) + (2 * largura * altura)).ToString("0.00");
        }
        private float fundo = 0f;
        private void button1_Click(object sender, EventArgs e)
        {
            Calculos obj = null;
            Coordenadas coordenadas = new Coordenadas();
            if (textVolume.Text != null && textFundo.Text != null && textLado.Text != null)
            {
                try
                {
                    fundo = float.Parse(textFundo.Text);
                    obj = new Calculos(float.Parse(textVolume.Text), float.Parse(textFundo.Text), float.Parse(textLado.Text));
                    setarRich(float.Parse(textVolume.Text), float.Parse(textFundo.Text), float.Parse(textLado.Text));
                    obj.GerarPontos();
                    zerarCaixas();
                }
                catch(Exception)
                {
                    MessageBox.Show("Tipo de valor invalido.");
                    zerarCaixas();
                    return;
                }
                
            }
            else if (textVolume.Text != null && textFundo.Text != null)
            {
                try
                {
                    obj = new Calculos(float.Parse(textVolume.Text), float.Parse(textFundo.Text));
                    setarRich(float.Parse(textVolume.Text), float.Parse(textFundo.Text));
                    obj.GerarPontos();
                    zerarCaixas();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tipo de valor invalido.");
                    zerarCaixas();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos com os valores desejados.");
                zerarCaixas();
                return;
            }
            FilaDeCoordenadas fila = obj.Fila;

            while (coordenadas != null)
            {
                coordenadas = fila.RetirarDaFila();
                if (coordenadas != null)
                {
                    addPoint(coordenadas.Coorx, coordenadas.CoorY);
                }
            }
            draw();
        }

        private void textVolume_MouseClick(object sender, MouseEventArgs e)
        {
            textVolume.Text = "";
        }

        private void textFundo_MouseClick(object sender, MouseEventArgs e)
        {
            textFundo.Text = "";
        }

        private void textLado_MouseClick(object sender, MouseEventArgs e)
        {
            textLado.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textVolume.Text = "VOLUME";
            textFundo.Text = "FUNDO";
            textLado.Text = "LADO";
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                calcArea(float.Parse(txtX.Text), float.Parse(txtY.Text), fundo);
            }
            catch (Exception)
            {
                MessageBox.Show("Tipo de valor invalido.");
            }
        }
        private void txtX_MouseClick(object sender, MouseEventArgs e)
        {
            txtX.Text = "";
        }

        private void txtY_MouseClick(object sender, MouseEventArgs e)
        {
            txtY.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
