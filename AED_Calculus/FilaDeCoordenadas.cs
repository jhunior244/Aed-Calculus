using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AED_Calculus
{
    class FilaDeCoordenadas
    {
        private int tam;
        public int Tam { get { return (this.tam); } }
        private Celula primeiro, ultimo, aux;

        public FilaDeCoordenadas()
        {
            this.tam = 0;
            this.primeiro = new Celula();
            this.primeiro.elemento = null;
            this.ultimo = this.primeiro;
        }

        public bool Vazia()
        {
            return (this.primeiro == this.ultimo);
        }

        public void AddNaFila(Coordenadas obj)
        {
            this.ultimo.prox = new Celula();

            this.ultimo.prox.elemento = obj;
            this.ultimo = this.ultimo.prox;
            this.tam++;
        }

        public Coordenadas RetirarDaFila()
        {
            Coordenadas retirado = null;

            if (!this.Vazia())
            {
                retirado = this.primeiro.prox.elemento;

                this.primeiro.prox = this.primeiro.prox.prox;

                if(this.primeiro.prox == null)
                {
                    this.ultimo = this.primeiro;
                }
                this.tam--;
            }
            return retirado;
        }

    }
}
