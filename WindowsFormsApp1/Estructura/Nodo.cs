using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Estructura
{
    class Nodo
    {
        private String contenido;
        private Nodo izq;
        private Nodo der;

        public Nodo(String pContenido)
        {
            contenido = pContenido;
            izq = null;
            der = null;
        }

        public String getContenido()
        {
            return contenido;
        }


        public Nodo getIzq()
        {
            return izq;
        }

        public Nodo getDer()
        {
            return der;
        }


        public void setIzq(Nodo pIzq)
        {
            izq = pIzq;
        }


        public void setDer(Nodo pDer)
        {
            der = pDer;
        }
    }
}
