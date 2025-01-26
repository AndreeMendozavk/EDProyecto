using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_Ejemplo_1_Pila
{
    internal class Pila
    {
        private Nodo primero = null;
        private Nodo ultimo = null;

        private int contador=0;

        //Metodo Apilar

        public void Apilar(string nom)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;
            nuevo.Siguiente = primero;    // El siguiente del nuevo nodo será el nodo que actualmente está en la cima de la pila.
            primero = nuevo;    // Actualizar la referencia al primer nodo (ahora el nuevo nodo es el primero)

            // Si la pila estaba vacía  también debemos actualizar 'ultimo'
            if (contador == 0)
            {
                ultimo = nuevo;
            }
            
            contador++;

        }
        public string Desapilar()
        {
            if (primero == null)
            {
                return null;
            }

            string nom = primero.Nombre;
            primero = primero.Siguiente;

            contador--;

            return nom;
        }

        public void Mostrar(ListBox list)
        {
            Nodo actual = primero;
            while(actual!=null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public int Count()
        {
            return contador;
        }


        public void Clear()
        {
            primero = null;
            ultimo = null;
            contador = 0;
        }

        public string Peek()
        {
            if(primero==null)
            {
                return null;
            }

            return primero.Nombre;
        }
    }
}
