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

        public static void crearArbol(String expresion)
        {
            String operadorCentral;
            String cadenaIzquierda;
            String cadenaDerecha;
            int pos;
            Nodo nvo;

            expresion = quitarEspacios(expresion);

            if (hayParentesisExternos(expresion))
            {
                expresion = quitarParentesisExternos(expresion);
            }

            pos = encontrarOperadorCentral(expresion);
            operadorCentral = expresion.Substring(pos, 1);
            nvo = new Nodo(operadorCentral);
            raiz = nvo;

            cadenaIzquierda = expresion.Substring(0, pos);
            cadenaDerecha = expresion.Substring(pos + 1, (expresion.Length - pos - 1));

            nvo = new Nodo(cadenaIzquierda);
            raiz.setIzq(nvo);

            nvo = new Nodo(cadenaDerecha);
            raiz.setDer(nvo);

            metodoRecursivo(raiz.getIzq());
            metodoRecursivo(raiz.getDer());

        }


        public static void metodoRecursivo(Nodo actual)
        {

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

        public static int encontrarOperadorCentral(String cadena)
        {
            int cont = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == '(')
                {
                    cont = cont + 1;
                }
                else if (cadena[i] == ')')
                {
                    cont = cont - 1;
                }

                if (cont == 0)
                {
                    return i + 1; ;
                }

            }

            return -1;
        }


        private static bool hayParentesisExternos(String cadena)
        {
            int cont = 0;
            int cuantos = 0;

            foreach (char c in cadena)
            {
                if (c == '(')
                {
                    cont = cont + 1;
                }
                else if (c == ')')
                {
                    cont = cont - 1;
                }

                if (cont == 0)
                {
                    cuantos++;
                }
            }

            if (cuantos == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static String quitarParentesisExternos(String cadena)
        {
            quitarEspacios(cadena);
            bool tiene = false;

            tiene = hayParentesisExternos(cadena);

            if (tiene)
            {
               
                 cadena = cadena.Substring(1, cadena.Length - 2);
                
               // cadena = cadena.Replace("(", "");
               // cadena = cadena.Replace(")", "");

            }

            return cadena;
        }

        public static String quitarEspacios(String pCadena)
        {
            String cadena = "";

            cadena = pCadena.Replace(" ", "");
            

            return cadena;
        }

        public static String hacerOperaciones(String operacion)
        {
            String resultado= "0";
            if(operacion.Equals(null))
            {
                throw new Exception("No hay nada para operar");
            }
            ////AND
            else if (operacion.Equals("0*0"))
            {
                resultado = "0";
            }
            else if(operacion.Equals("0*1"))
            {
                resultado = "0";
            }
            else if (operacion.Equals("1*0"))
            {
                resultado = "0";
            }
            else if (operacion.Equals("1*1"))
            {
                resultado = "1";
            }
            ////OR
            else if (operacion.Equals("0+0"))
            {
                resultado = "0";
            }
            else if (operacion.Equals("0+1"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("1+0"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("1+1"))
            {
                resultado = "1";
            }
            ////NAND
            else if (operacion.Equals("0&0"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("0%1"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("1&0"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("1&1"))
            {
                resultado = "0";
            }
            ////NOR
            else if (operacion.Equals("0%0"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("0%1"))
            {
                resultado = "0";
            }
            else if (operacion.Equals("1%0"))
            {
                resultado = "0";
            }
            else if (operacion.Equals("1%1"))
            {
                resultado = "0";
            }
            ////XOR
            else if (operacion.Equals("0#0"))
            {
                resultado = "0";
            }
            else if (operacion.Equals("0#1"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("1#0"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("1#1"))
            {
                resultado = "0";
            }
            ////XNOR
            else if (operacion.Equals("0/0"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("0/1"))
            {
                resultado = "0";
            }
            else if (operacion.Equals("1/0"))
            {
                resultado = "0";
            }
            else if (operacion.Equals("1/1"))
            {
                resultado = "0";
            }
            ////MAT
            else if (operacion.Equals("0$0"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("0$1"))
            {
                resultado = "0";
            }
            else if (operacion.Equals("1$0"))
            {
                resultado = "1";
            }
            else if (operacion.Equals("1$1"))
            {
                resultado = "0";
            }
            else
            {
                throw new Exception("No se pudo hacer la operación");    
            }

            return resultado;

        }

        public static bool verificarSiEsAtomica(String cad)
        {
            int cont = 0;
            String cadena = quitarParentesisExternos(cad);

            for (int i = 0; i < cad.Length; i++)
            {
                if (cad.Contains('%') || cad.Contains('$') || cad.Contains('&') ||
                    cad.Contains('#') || cad.Contains("/") || cad.Contains("*") || cad.Contains("+"))
                {
                    cont++;
                    return true;
                }
                else
                {
                    throw new Exception("Esta operación no es atómica");
                }
            }
            return false;
        }
    }
 
    

}

