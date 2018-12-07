using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AED_Calculus
{
    class Coordenadas
    {
        private float coorX;
        public float Coorx { get { return (this.coorX); } }
        private float coorY;
        public float CoorY { get { return (this.coorY); } }
        private float area;
        public float Area { get { return (this.area); } }

        public Coordenadas(float x, float y, float area)
        {
            this.coorX = x;
            this.coorY = y;
            this.area = area;
        }
        public Coordenadas()
        {

        }

    }
}
