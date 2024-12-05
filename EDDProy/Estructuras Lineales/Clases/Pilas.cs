using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public class Pilas
    {
        public Nodo top = new Nodo();
        private ListBox listBox; 
        private int posicion;

        public Pilas(ListBox listBox)
        {
            top = null;
            this.listBox = listBox;
        }
        public void AsignarValor(ListBox listBox)
        {
            this.listBox = listBox;
        }
        public void Push(int Dato)
        {
            Nodo Nuevo = new Nodo();
            Nuevo.Dato = Dato;
            Nuevo.Sig = top;
            top = Nuevo;
            Mostrar();

        }


        public void Mostrar()
        {
            if (listBox != null)
            {

                Nodo Aux = new Nodo();
                listBox.Items.Clear();
                Aux = top;
                if (top != null)
                {
                    while (Aux != null)
                    {

                        listBox.Items.Add("<" + Aux.Dato + ">");
                        Aux = Aux.Sig;

                    }

                }
            }
            else { MessageBox.Show("La pila está vacía"); }
        }

        public int? Pop()
        {
            if (top == null)
            {
                MessageBox.Show("Pila vacía");
                return null;
            }
            else
            {
                Nodo Aux = top;
                top = top.Sig;
                int Dato = Aux.Dato;
                MessageBox.Show("Dato eliminado " + Dato);
                Aux = null;
                Mostrar();
                return Dato; 
            }
        }
        public void Recorrer(int posicion)
        {
            int pos = 0;
            Nodo Aux = top;

            while (Aux != null)
            {
                pos++;
                if (Aux.Dato == posicion)
                {

                    MessageBox.Show("El dato " + posicion + " está en la posición " + pos);
                    return;  
                }
                Aux = Aux.Sig;
            }

            MessageBox.Show("El dato no esta");
        }
        public void Imprimir()
        {
            if (top == null)
            {
                MessageBox.Show("La pila se encuentra vacia");
                return;
            }

            Nodo Aux = top;
            StringBuilder valores = new StringBuilder();

            while (Aux != null)
            {
                valores.Append("<" + Aux.Dato + "> ");
                Aux = Aux.Sig;
            }


            MessageBox.Show("Valores que estan en la pila: " + valores.ToString());
        }

        public void VaciarPila()
        {
            if (top == null)
            { return; }
            else
            {
                Nodo Aux;
                while (top != null)
                {
                    Aux = top;
                    top = top.Sig;
                }
                Aux = null;
            }
            Mostrar();
        }
    }
}