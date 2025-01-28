using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_Proyecto_Arbol_Binario_Ejemplo {
    public partial class Form1: Form {

        Arbol a=new Arbol();
        Nodo raiz;
        public Form1() {
            InitializeComponent();
        }

        private void btnRaiz_Click(object sender,EventArgs e) {
            try
            {
                int num = int.Parse(textNumero.Text);

                if (num==0&&num<=20)
                {
                    raiz=a.insertar(null,int.Parse(textNumero.Text));
                    treeView1.Nodes.Clear();
                    a.Mostrar(raiz,treeView1,null);
                    textNumero.Clear();
                } else {
                    MessageBox.Show("Solamente se permiten numeros de 0-20");
                }

            }
            catch (Exception) 
            {
                MessageBox.Show("Solo se puede insertar numeros");
            }
        }

        private void btnRamas_Click(object sender,EventArgs e) 
        {
            if(raiz!=null) 
            {
                if (int.TryParse(textNumero.Text,out int num ) && num<=20) 
                {

                }

                if(radioIzquierda.Checked==true || radioDerecha.Checked==true) 
                {
                    if (radioIzquierda.Checked==true) 
                    {
                        seleccionado.izquierda=a.insertar;
                        (seleccionado.izquierda.intParse(textNumero.Text));

                    } else if(radioDerecha.Checked==true)
                    {
                        seleccionado.derecha=a.insertar;
                        (seleccionado.derecha.intParse(textNumero.Text));


                    }

                    treeView1.Nodes.Clear();
                    a.Mostrar(raiz,treeView1,null);
                    treeView1.Expandir();
                    textNumero.Clear();


                }
         }
            else {
                MessageBox.Show("Primero inserte la raiz");
            }
        }

        private void btnAltura_Click(object sender,EventArgs e) {
            MessageBox("Altura"a.altura "es como resultado");
        }
    }
}
