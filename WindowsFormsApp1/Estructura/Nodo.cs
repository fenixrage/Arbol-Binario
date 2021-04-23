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
        private Nodo padre;

        public Nodo(String pContenido)
        {
            contenido = pContenido;
            izq = null;
            der = null;
            padre = null;
        }

        public String getContenido()
        {
            return contenido;
        }

        public void setContenido(String pContenido)
        {
            contenido = pContenido;
        }

        public Nodo getIzq()
        {
            return izq;
        }

        public Nodo getDer()
        {
            return der;
        }

        public Nodo getPadre()
        {
            return padre;
        }

        public void setPadre(Nodo pPadre)
        {
            padre = pPadre;
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
