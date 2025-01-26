using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_Ejemplo_1_Pila
{
    public partial class Form1 : Form
    {
        Pila p = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != null && textBoxNombre.Text != "")
            {
                p.Apilar(textBoxNombre.Text);
                listBoxNombres.Items.Add(textBoxNombre.Text);
                listBoxNombres.Items.Clear();
                p.Mostrar(listBoxNombres);
            }
            else
            {
                MessageBox.Show("DATO NO VALIDO");
            }
            textBoxNombre.Clear();
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {                        
            if(p.Count()>0)
            {
                p.Desapilar();
                MessageBox.Show("Se ha desapilado correctamente ");
                listBoxNombres.Items.Clear();
                p.Mostrar(listBoxNombres);
            }

            else
            {
                MessageBox.Show("----La pila esta vacia----");
            }
        }
        private void btnVistazo_Click(object sender, EventArgs e)
        {
            string prim = p.Peek();

            if (prim != null)
            {
                MessageBox.Show("Primero: " + prim);
            }

            else
            {
                MessageBox.Show("----La pila esta vacia----");
            }
        }

        private void btnElementos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de elementos: " + p.Count());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            p.Clear();
            listBoxNombres.Items.Clear();
        }
    }
}
