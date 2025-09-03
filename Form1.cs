using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ColasWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Queue<int> Cola = new Queue<int>();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumEncolar.Text.Trim() != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtNumEncolar.Text, "^[0-9]*$"))
                {
                    int v_NumEncolar = Convert.ToInt16(txtNumEncolar.Text);
                    Cola.Enqueue(v_NumEncolar);

                    txtNumEncolar.Text = string.Empty;
                    MessageBox.Show("Se encolo el numero " + v_NumEncolar + " con exito.");

                }
                else
                {

                    MessageBox.Show("Por favor ingrese solo numeros.");
                    txtNumEncolar.Text = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero.");
            }
            txtNumEncolar.Clear();
           

        }

        public void txtNum_TextChanged(object sender, EventArgs e)
        {
            int num = txtNumEncolar.Text.Length;
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (Cola.Count > 0)
            {
                
                MessageBox.Show("El elemento "+ Cola.Dequeue() +" fue eliminado con exito.");
            }
            else
            {
                MessageBox.Show("La cola esta vacia, por favor ingrese datos.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Cola.Count > 0)
            {
                MessageBox.Show(" El valor del primer elemento es: " + Cola.Peek());
            }
            else
            {
                MessageBox.Show("La cola esta vacia, por favor ingrese datos.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Cola.Count > 0)
            {
                string datos = "";
                foreach (var item in Cola)
                {
                    datos = datos + item.ToString() + ",";
                }
                MessageBox.Show("La cola contiene los siguientes datos: " + datos);
            }
            else
            {
                MessageBox.Show("La cola esta vacia");
            }
        }
    }
}
