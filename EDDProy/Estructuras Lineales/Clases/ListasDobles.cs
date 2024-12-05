using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListasDobles
    {
        private Nodo Inicio;
        private Nodo Final;
        private ListBox listBox;


        public ListasDobles(ListBox listBox)
        {
            this.listBox = listBox;
            Inicio = null;
            Final = null;
        }

        public void Insertar(int posicion, int dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = dato;
            nuevo.Sig = null;
            nuevo.Ant = null;

            if (Inicio == null && Final == null)
            {
                Inicio = nuevo;
                Final = nuevo;
                Mostrar();
                return;
            }

            if (posicion == 0 || posicion == 1)
            {
                nuevo.Sig = Inicio;
                if (Inicio != null) Inicio.Ant = nuevo;
                Inicio = nuevo;
                if (Final == null) Final = nuevo;
                Mostrar();
                return;
            }

            int pos = 1;
            Nodo aux = Inicio;

            while (pos < posicion && aux != null)
            {
                if (aux.Sig != null)
                {
                    aux = aux.Sig;
                }
                else
                {
                    aux = null;
                }
                pos++;
            }

            if (aux != null)
            {
                nuevo.Sig = aux;
                nuevo.Ant = aux.Ant;

                if (aux.Ant != null)
                {
                    aux.Ant.Sig = nuevo;
                }
                aux.Ant = nuevo;
            }
            else
            {
                Final.Sig = nuevo;
                nuevo.Ant = Final;
                Final = nuevo;
            }

            Mostrar();
        }
        public void Mostrar()
        {
            listBox.Items.Clear();
            Nodo aux = Inicio;
            while (aux != null)
            {
                listBox.Items.Add(aux.ToString());
                aux = aux.Sig;
            }
        }

        public bool Eliminar(int posicion)
        {
            if (Inicio == null && Final == null)
            {
                MessageBox.Show("Lista vacía");
                return false;
            }

            int pos = 1;
            Nodo aux = Inicio;

            while (pos < posicion && aux != null)
            {
                aux = aux.Sig;
                pos++;
            }

            if (aux != null)
            {
                if (Inicio == Final && Inicio == aux)
                {
                    Inicio = null;
                    Final = null;
                }
                else if (aux == Inicio)
                {
                    Inicio = Inicio.Sig;
                    if (Inicio != null)
                        Inicio.Ant = null;
                }
                else if (aux == Final)
                {
                    Final = Final.Ant;
                    if (Final != null)
                        Final.Sig = null;
                }
                else
                {
                    aux.Ant.Sig = aux.Sig;
                    aux.Sig.Ant = aux.Ant;
                }

                Mostrar();
                return true;
            }

            MessageBox.Show("No se encontró la posición especificada");
            return false;
        }
        public void Buscar(int datoBuscado)
        {
            int posicion = 1;
            Nodo Aux = Inicio;

            while (Aux != null)
            {
                if (Aux.Dato == datoBuscado)
                {

                    MessageBox.Show("El dato: " + datoBuscado + " está en la posición " + posicion);
                    return;
                }

                Aux = Aux.Sig;
                posicion++;
            }

            MessageBox.Show("El dato: " + datoBuscado + " no se encontro en la lista");
        }

        public void Imprimir()
        {
            if (Inicio == null)
            {
                MessageBox.Show("La lista está vacía");
                return;
            }

            Nodo Aux = Inicio;
            StringBuilder valores = new StringBuilder();


            while (Aux != null)
            {
                valores.Append("<" + Aux.Dato + "> ");
                Aux = Aux.Sig;
            }


            MessageBox.Show("Valores que estan en la lista: " + valores.ToString());
        }

        public void Vaciar()
        {

            if (Inicio == null)
            {
                MessageBox.Show("Lista vacia");
                return;
            }

            while (Inicio != null)
            {
                Nodo aux = Inicio;
                Inicio = Inicio.Sig;


                if (Inicio != null)
                {
                    Inicio.Ant = null;
                }

                aux.Sig = null;
                aux.Ant = null;
            }

            Final = null;
            listBox.Items.Clear();
            MessageBox.Show("Se vacio la lista");
        }
    }
}