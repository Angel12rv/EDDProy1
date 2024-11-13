using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        private NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }
        public void Muestra(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            Muestra(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "     ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            Muestra(nivel + 1, nodo.Izq);
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }
        public bool Buscareldato(int valor, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (nodo.Dato == valor)
                return true;

            if (valor < nodo.Dato)
                return Buscareldato(valor, nodo.Izq);

            else
                return Buscareldato(valor, nodo.Der);

        }
        public void PodarArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PodarArbol(ref nodo.Izq);

            PodarArbol(ref nodo.Der);
            nodo = null;
            Raiz = null;
        }

        public NodoBinario BuscaMenor(NodoBinario nodo)
        {
            if (nodo == null)
                return null;
            else if (nodo.Izq == null)
                return nodo;
            else
                return BuscaMenor(nodo.Izq);
        }

        public NodoBinario BuscaMayor(NodoBinario nodo)
        {
            if (nodo == null)
                return null;
            else if (nodo.Der == null)
                return nodo;
            else
                return BuscaMayor(nodo.Der);
        }
        public void EliminarPredecesor(int x, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (x < nodo.Dato)
                EliminarPredecesor(x, ref nodo.Izq);
            else if (x > nodo.Dato)
                EliminarPredecesor(x, ref nodo.Der);
            else
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario mayor = BuscaMayor(nodo.Izq);
                    nodo.Dato = mayor.Dato;
                    EliminarPredecesor(mayor.Dato, ref nodo.Izq);
                }
                else
                {
                    if (nodo == Raiz)
                    {
                        if (nodo.Izq != null)
                            Raiz = nodo.Izq;
                        else if (nodo.Der != null)
                            Raiz = nodo.Der;
                        else
                            Raiz = null;
                    }

                    NodoBinario temp = nodo;
                    if (nodo.Izq == null)
                        nodo = nodo.Der;
                    else if (nodo.Der == null)
                        nodo = nodo.Izq;

                    temp = null;
                }
            }
        }
        public void EliminarSucesor(int x, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (x < nodo.Dato)
                EliminarSucesor(x, ref nodo.Izq);
            else if (x > nodo.Dato)
                EliminarSucesor(x, ref nodo.Der);
            else if (nodo.Izq != null && nodo.Der != null)
            {
                // Caso en que el nodo tiene dos hijos
                NodoBinario menor = BuscaMenor(nodo.Der);
                nodo.Dato = menor.Dato;
                EliminarSucesor(menor.Dato, ref nodo.Der);
            }
            else
            {
                // Caso en que el nodo tiene un solo hijo
                NodoBinario temp = nodo;
                nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                temp = null;
            }
        }
        public int Altura(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            int alturaIzquierda = Altura(nodo.Izq);
            int alturaDerecha = Altura(nodo.Der);

            return 1 + Math.Max(alturaIzquierda, alturaDerecha);
        }
        public int ContarHojas(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
            if (nodo.Izq == null && nodo.Der == null)
                return 1;
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }
        public int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }

        public bool EsLleno(NodoBinario nodo)
        {
            if (nodo == null)
                return true;

            if (nodo.Izq == null && nodo.Der == null)
                return true;

            if (nodo.Izq != null && nodo.Der != null)
                return EsLleno(nodo.Izq) && EsLleno(nodo.Der);
            return false;
        }
 
        public void RecorrerPorNiveles(NodoBinario nodo)
        {
            int altura = Altura(nodo);  // Calcula la altura del árbol

            strRecorrido = ""; // Reinicia el string de recorrido
            for (int i = 1; i <= altura; i++)
            {
                RecorrerNivel(nodo, i);
            }
        }

        // Función auxiliar para recorrer cada nivel recursivamente
        private void RecorrerNivel(NodoBinario nodo, int nivel)
        {
            if (nodo == null)
                return;

            if (nivel == 1)
            {
                strRecorrido += nodo.Dato + ", ";
            }
            else if (nivel > 1)
            {
                RecorrerNivel(nodo.Izq, nivel - 1);
                RecorrerNivel(nodo.Der, nivel - 1);
            }
        }
        public bool EsBinarioCompleto(NodoBinario nodo)
        {
            int cantidadDeNodos = ContarNodos(nodo);  // Usa ContarNodos ya implementado
            return EsCompletoRecursivo(nodo, 0, cantidadDeNodos);
        }

        // Función auxiliar para verificar recursivamente si el árbol es completo
        private bool EsCompletoRecursivo(NodoBinario nodo, int indice, int totalNodos)
        {
            if (nodo == null)
                return true;

            if (indice >= totalNodos)
                return false;

            return EsCompletoRecursivo(nodo.Izq, 2 * indice + 1, totalNodos) &&
                   EsCompletoRecursivo(nodo.Der, 2 * indice + 2, totalNodos);
        }
    }
}