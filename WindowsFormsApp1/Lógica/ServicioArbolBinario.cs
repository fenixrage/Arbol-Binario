using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Estructura;

namespace WindowsFormsApp1.Lógica
{
    class ServicioArbolBinario
    {
        private static Nodo raiz;


        public static Nodo getRaiz()
        {
            return raiz;
        }


        public void setRaiz(Nodo n)
        {
            raiz = n;
        }



        public static void procesarExpresion(String expresion)
        {
            String cadenaIzq = "";
            String cadenaDer = "";
            int pos;

            expresion = expresion.Trim();
            expresion = expresion.Replace(" ", "");

            if (tieneParentesisExternos(expresion))
            {
                expresion = expresion.Substring(1, expresion.Length - 2);
            }

            if (esExpresionAtomica(expresion))
            {
                pos = getPosicionNodoCentral(expresion);
                raiz = new Nodo(expresion[pos].ToString());
                Nodo nuevoIzq = new Nodo(expresion.Substring(0, pos));
                Nodo nuevoDer = new Nodo(expresion.Substring(pos + 1, expresion.Length - 2));
                raiz.setIzq(nuevoIzq);
                raiz.setDer(nuevoDer);
                return;
            }
            pos = getPosicionNodoCentral(expresion);
            Console.WriteLine("Posicion = " + pos);
            raiz = new Nodo(expresion[pos].ToString());

            cadenaIzq = expresion.Substring(0, pos);
            cadenaDer = expresion.Substring(pos + 1, (expresion.Length - pos - 1));

            llenarArbolExpresion(raiz, cadenaIzq);
            llenarArbolExpresion(raiz, cadenaDer);

        }
        public static bool esUnSoloValor(String expresion)
        {
            expresion = expresion.Trim();
            int bandera = 0;

            bandera = expresion.IndexOf("(");
            if (bandera > 0)
            {
                return false;
            }

            bandera = expresion.IndexOf(")");
            if (bandera >= 0)
            {
                return false;
            }

            bandera = expresion.IndexOf("*");
            if (bandera >= 0)
            {
                return false;
            }

            bandera = expresion.IndexOf("+");
            if (bandera >= 0)
            {
                return false;
            }

            bandera = expresion.IndexOf("&");
            if (bandera >= 0)
            {
                return false;
            }

            bandera = expresion.IndexOf("%");
            if (bandera >= 0)
            {
                return false;
            }

            bandera = expresion.IndexOf("#");
            if (bandera >= 0)
            {
                return false;
            }

            bandera = expresion.IndexOf("/");
            if (bandera >= 0)
            {
                return false;
            }

            bandera = expresion.IndexOf("$");
            if (bandera >= 0)
            {
                return false;
            }

            return true;
        }

        public static void llenarArbolExpresion(Nodo actual, String expresion)
        {
            int pos = -1;
            if (esUnSoloValor(expresion))
            {
                Nodo nuevo = new Nodo(expresion);
                nuevo.setPadre(actual);
                if (actual.getIzq() == null)
                {
                    actual.setIzq(nuevo);
                }
                else
                {
                    actual.setDer(nuevo);
                }
                return;
            }

            if (tieneParentesisExternos(expresion))
            {
                expresion = expresion.Substring(1, expresion.Length - 2);
            }

            if (esVariableAtomica(expresion))
            {
                Nodo nuevo = new Nodo(expresion);
                nuevo.setPadre(actual);
                if (actual.getIzq() == null)
                {
                    actual.setIzq(nuevo);
                }
                else
                {
                    actual.setDer(nuevo);
                }
                return;
            }

            if (esExpresionAtomica(expresion))
            {
                pos = getPosicionNodoCentral(expresion);
                Nodo nuevo = new Nodo(expresion[pos].ToString());
                nuevo.setPadre(actual);
                if (actual.getIzq() == null)
                {
                    actual.setIzq(nuevo);
                }
                else
                {
                    actual.setDer(nuevo);
                }
                Nodo nuevoIzq = new Nodo(expresion.Substring(0, pos));
                Nodo nuevoDer = new Nodo(expresion.Substring(pos + 1, expresion.Length - 2));
                nuevo.setIzq(nuevoIzq);
                nuevo.setDer(nuevoDer);
                return;
            }
            pos = getPosicionNodoCentral(expresion);
            Nodo n = new Nodo(expresion[pos].ToString());
            n.setPadre(actual);
            if (actual.getIzq() == null)
            {
                actual.setIzq(n);
            }
            else
            {
                actual.setDer(n);
            }
            llenarArbolExpresion(n, expresion.Substring(0, pos));
            llenarArbolExpresion(n, expresion.Substring(pos + 1, expresion.Length - 2));
        }



        public static String recorrePreOrden(Nodo actual, String cad)
        {
            if (actual == null)
            {
                return cad;
            }

            cad = cad + actual.getContenido() + "-";
            cad = recorrePreOrden(actual.getIzq(), cad);
            cad = recorrePreOrden(actual.getDer(), cad);

            return cad;
        }

        public static String recorreInOrden(Nodo actual, String cad)
        {
            if (actual == null)
            {
                return cad;
            }

            cad = recorreInOrden(actual.getIzq(), cad);
            cad = cad + actual.getContenido() + "-";
            cad = recorreInOrden(actual.getDer(), cad);

            return cad;
        }

        public static String recorrePostOrden(Nodo actual, String cad)
        {
            if (actual == null)
            {
                return cad;
            }

            cad = recorrePostOrden(actual.getIzq(), cad);
            cad = recorrePostOrden(actual.getDer(), cad);
            cad = cad + actual.getContenido() + "-";

            return cad;
        }

        public static int getPosicionNodoCentral(String expresion)
        {
            int contIzq = 0;
            int contDer = 0;

            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i] == '(')
                {
                    contIzq++;
                }
                else if (expresion[i] == ')')
                {
                    contDer++;
                }
                else if ((expresion[i] == '*') || (expresion[i] == '+') || (expresion[i] == '&') || (expresion[i] == '$') || (expresion[i] == '/') || (expresion[i] == '#') || (expresion[i] == '%'))
                {
                    if (contIzq == 0)
                    {
                        return i;
                    }
                }

                if (((contIzq - contDer) == 0 && ((expresion[i] == '*') || (expresion[i] == '+') || (expresion[i] == '&') || (expresion[i] == '$') || (expresion[i] == '/') || (expresion[i] == '#') || (expresion[i] == '%'))))
                {
                    return i;
                }

            }

            return -1;
        }

        public static bool esVariableAtomica(String expresion)
        {
            int cont = 0;

            for (int i = 0; i < expresion.Length; i++)
            {
                if ((expresion[i] == '*') || (expresion[i] == '+') || (expresion[i] == '&') || (expresion[i] == '$') || (expresion[i] == '/') || (expresion[i] == '#') || (expresion[i] == '%'))
                {
                    cont++;
                }
                if (cont > 0)
                {
                    return false;
                }
            }
            return true;
        }



        private static bool tieneParentesisExternos(String expresion)
        {
            int contIzq = 0;
            int contDer = 0;

            if (expresion[0] != '(')
            {
                return false;
            }
            for (int i = 1; i < expresion.Length; i++)
            {
                if (expresion[i] == '(')
                {
                    contIzq++;
                }
                else if (expresion[i] == ')')
                {
                    contDer++;
                }

                if ((contIzq - contDer == 0) && (i != expresion.Length - 1))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool esExpresionAtomica(String expresion)
        {
            int contIzq = 0;
            int contDer = 0;

            for (int i = 1; i < expresion.Length; i++)
            {
                if (expresion[i] == '(')
                {
                    contIzq++;
                }
                else if (expresion[i] == ')')
                {
                    contDer++;
                }

            }
            if (contIzq == 0 && contDer == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double evaluarArbolExpresion()
        {
            procesarEvaluarArbolExpresion(raiz);
            return Double.Parse(raiz.getContenido());
        }

        public static bool esHoja(Nodo actual)
        {
            if (actual.getIzq() == null && actual.getDer() == null)
            {
                return true;
            }
            return false;
        }

        public static void procesarEvaluarArbolExpresion(Nodo actual)
        {
            if (actual == null)
            {
                return;
            }

            procesarEvaluarArbolExpresion(actual.getIzq());
            procesarEvaluarArbolExpresion(actual.getDer());

            if (esHoja(actual))
            {
                return;
            }

            int x = Int32.Parse(actual.getIzq().getContenido());
            int y = Int32.Parse(actual.getDer().getContenido());

            if (actual.getContenido() == "*")
            {
                int z = calcularAND(x, y);
                actual.setContenido(z.ToString());
                return;
            }
            else if (actual.getContenido() == "+")
            {
                int z = calcularOR(x, y);
                actual.setContenido(z.ToString());
                return;
            }
            else if (actual.getContenido() == "&")
            {
                int z = calcularNAND(x, y);
                actual.setContenido(z.ToString());
                return;
            }
            else if (actual.getContenido() == "%")
            {
                int z = calcularNOR(x, y);
                actual.setContenido(z.ToString());
                return;
            }
            else if (actual.getContenido() == "#")
            {
                int z = calcularXOR(x, y);
                actual.setContenido(z.ToString());
                return;
            }
            else if (actual.getContenido() == "/")
            {
                int z = calcularXNOR(x, y);
                actual.setContenido(z.ToString());
                return;
            }
            else if (actual.getContenido() == "$")
            {
                int z = calcularMAT(x, y);
                actual.setContenido(z.ToString());
                return;
            }
        }

        private static int calcularAND(int p, int q)
        {
            int res = 0;
            if (p == 1 && q == 1)
            {
                res = 1;
            }
            return res;
        }

        private static int calcularNAND(int p, int q)
        {
            int res = 1;
            if (p == 1 && q == 1)
            {
                res = 0;
            }
            return res;
        }

        private static int calcularOR(int p, int q)
        {
            int res = 1;
            if (p == 0 && q == 0)
            {
                res = 0;
            }
            return res;
        }

        private static int calcularNOR(int p, int q)
        {
            int res = 0;
            if (p == 0 && q == 0)
            {
                res = 1;
            }
            return res;
        }

        private static int calcularXOR(int p, int q)
        {
            int res = 0;
            if ((p == 0 && q == 1) || (p == 1 && q == 0))
            {
                res = 1;
            }
            return res;
        }

        private static int calcularXNOR(int p, int q)
        {
            int res = 1;
            if ((p == 0 && q == 1) || (p == 1 && q == 0))
            {
                res = 0;
            }
            return res;
        }
        private static int calcularMAT(int p, int q)
        {
            int res = 0;
            if ((p == 0 && q == 0) || (p == 1 && q == 0))
            {
                res = 1;
            }
            return res;
        }

    }



}

