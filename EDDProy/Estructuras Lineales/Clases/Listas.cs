using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    class Listas
    {

        private Nodo Inicio;
        private Nodo Final;
        private ListBox listbox;

        public Listas(ListBox listbox)
        {
            Inicio = null;
            Final = null;
            this.listbox = listbox;
        }

        public void Insertar(int posicion, int dato)
        {
            Nodo Nuevo = new Nodo();
            Nuevo.Dato = dato;
            Nuevo.Sig = null;


            if (Inicio == null && Final == null)
            {
                Inicio = Nuevo;
                Final = Nuevo;
                Mostrar(); // Mostrar la lista
                return;
            }


            if (posicion == 0 || posicion == 1)
            {
                Nuevo.Sig = Inicio;
                Inicio = Nuevo;
                Mostrar();
                return;
            }

            int pos = 0;
            Nodo Aux = Inicio;
            Nodo Previo = null;


            while (pos < posicion && Aux != null)
            {
                Previo = Aux;
                Aux = Aux.Sig;
                pos++;
            }


            if (Previo != null)
            {
                Nuevo.Sig = Aux;
                Previo.Sig = Nuevo;
            }
            else
            {
           
                Final.Sig = Nuevo;
                Final = Nuevo;
            }

            Mostrar();
        }

        public void Mostrar()
        {
            if (listbox != null)
            {
                listbox.Items.Clear();
                Nodo Aux = Inicio;
                while (Aux != null)
                {
                    listbox.Items.Add("<" + Aux.Dato + ">");
                    Aux = Aux.Sig;
                }
            }
        }

        public int Eliminar(int posicion)
        {
        
            if (Inicio == null && Final == null)
            {
                MessageBox.Show("La lista se encuentra vacia");
                return 0;
            }

            int pos = 1;
            Nodo Aux = Inicio;
            Nodo Previo = null;

            while (pos < posicion && Aux != null)
            {
                if (Aux.Sig != null)
                {
                    Previo = Aux;
                    Aux = Aux.Sig;
                }
                else
                {
                    Aux = null;
                }
                pos++;
            }


            if (Aux != null)
            {
            
                if (Aux == Final)
                {
                    Final = Previo;
                }


                if (Previo != null)
                {
                    Previo.Sig = Aux.Sig;
                }
                else
                {

                    Inicio = Inicio.Sig;
                    if (Inicio == null)
                    {
                        Final = null;
                    }
                }

                int dato = Aux.Dato;
                Mostrar();
                return dato;
            }
            else
            {
                MessageBox.Show("No esta");
                return 0;
            }
        }

        public void Buscar(int datoBuscado)
        {
            int posicion = 1;
            Nodo Aux = Inicio;
            while (Aux != null)
            {
                if (Aux.Dato == datoBuscado)
                {
          
                    MessageBox.Show("El dato: " + datoBuscado + " esta en esta posicion " + posicion);
                    return;
                }

                Aux = Aux.Sig;
                posicion++; 
            }
            MessageBox.Show("El dato: " + datoBuscado + " no esta en la lista");
        }
        public void Imprimir()
        {
            if (Inicio == null)
            {
                MessageBox.Show("La lista se encuentra vacia");
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
            {
                if (Inicio == null)
                {
                    MessageBox.Show("La lista ya esta vacia");
                    return;
                }

                while (Inicio != null)
                {
                    Inicio = Inicio.Sig;
                }
                Final = null;
                listbox.Items.Clear();
                MessageBox.Show("La lista se vacio");
            }
        }
    }
}