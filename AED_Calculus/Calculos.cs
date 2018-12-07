using AED_Calculus;
using AED_ChartBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AED_Calculus
{
    class Calculos 
    {
       
        private FilaDeCoordenadas fila;
        public  FilaDeCoordenadas Fila { get { return (this.fila); } }
        private float volume;
        private float profundidade;
        private float largura;
        private float cumprimento;
        private float melhorArea;
        public float MelhorArea { get { return (this.melhorArea); } }
        public Calculos(float vol, float prof)
        {
            this.volume = vol;
            this.profundidade = prof;
            this.largura = 2;


        }

        public Calculos(float vol, float prof, float larg)
        {
            this.volume = vol;
            this.largura = larg;
            this.profundidade = prof;
        }
        public void GerarPontos()
        {
            float area = 0;
            this.fila = new FilaDeCoordenadas();
            Coordenadas coordenadas;
            float inicio = largura;
            this.cumprimento = 800000f;
            while(this.cumprimento >= inicio)
            {
                this.cumprimento = this.volume / this.profundidade / this.largura;
                area = (2 * cumprimento * profundidade) + (cumprimento * largura) + (2 * largura * profundidade);
                coordenadas = new Coordenadas(largura, cumprimento, area);
                fila.AddNaFila(coordenadas);
                largura += 0.1f;
            }
        }
    }
}

