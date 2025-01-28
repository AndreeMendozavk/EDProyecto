using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_Proyecto_Arbol_Binario_Ejemplo {
    internal class Arbol 
    {
        public Nodo insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);

            if (actual==null) {
                return nuevo;

            } else if (actual.izquierda!=null||actual.derecha==null && actual.izquierda==null||actual.derecha!=null)
            {
                MessageBox.Show("Nodo Ocupado");

            }else if(actual.izquierda!=null)
            {
                return actual.izquierda=nuevo;

            } else 
            {
                return actual.derecha=nuevo;
            }

            return actual;
        }   

        public void Mostrar(Nodo actual, TreeView tree, TreeNode padre) 
        {
            TreeNode cabe = new TreeNode(actual.numero.ToString());

            if (padre==null) //tallo
            {
                tree.Nodes.Add(cabe);
            }
            else //hojas
            {
                padre.Nodes.Add(cabe);
            }

            if (actual.izquierda!=null)
            { 
                Mostrar(actual.izquierda,tree,cabe);
            }
            if(actual.derecha!=null) 
            {
                Mostrar(actual.derecha,tree,cabe);
            }

        }

            public  int altura(Nodo actual)
            {
                if(actual==null) {
                    return 0;
            } else {
                int alturaIzquierda = altura(actual.izquierda);
                int alturaDerecha = altura(actual.derecha);

                return altura(alturaIzquierda,alturaDerecha);
            }

            }
    }
}
