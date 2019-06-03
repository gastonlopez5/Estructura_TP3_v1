using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    
    public partial class Form1 : Form
    {
        Pilas p;
        Stack<int> pilaA;
        Stack<int> pilaB;
        Stack<int> pilaC;
        int a;
        bool aa;

        public Form1()
        {
            InitializeComponent();
            pilaA = new Stack<int>();
            pilaB = new Stack<int>();
            pilaC = new Stack<int>();
            p = new Pilas();

        }


        private void BtCargar_Click(object sender, EventArgs e)
        {
            
            if (tbElemento.Text != string.Empty)
            {
                pilaA = p.cargaPila(pilaA, Convert.ToInt16(tbElemento.Text));
                tbElemento.Clear();
                tbElemento.Focus();

                lvPilaA.Items.Clear();
                foreach (int elem in pilaA)
                {
                    lvPilaA.Items.Add(Convert.ToString(elem));
                }
            }
        }

        
        private void BtPasar_Click(object sender, EventArgs e)
        {
            pilaB = p.pasaPila(pilaA);

            lvPilaB.Items.Clear();
            lvPilaA.Items.Clear();

            foreach (int elem in pilaB)
            {
                lvPilaB.Items.Add(Convert.ToString(elem));
            }
        }

        private void BtContiene_Click(object sender, EventArgs e)
        {
            tbContener.Clear();
            a = Convert.ToInt32(tbElemento.Text);
            aa = p.contieneE(pilaA, a);

            if (aa == true)
            {
                tbContener.Text = "Si";
            }
            else
            {
                tbContener.Text = "No";
            }
            
        }

        private void BtSeparar_Click(object sender, EventArgs e)
        {
            pilaB.Clear();
            pilaC.Clear();

            (pilaB, pilaC) = p.separarPi(pilaA);

            lvPilaB.Items.Clear();
            lvPilaC.Items.Clear();

            foreach (int elem in pilaB)
            {
                lvPilaB.Items.Add(Convert.ToString(elem));
            }

            foreach (int elem in pilaC)
            {
                lvPilaC.Items.Add(Convert.ToString(elem));
            }
        }

        private void BtInvertir_Click(object sender, EventArgs e)
        {
            pilaB.Clear();
            pilaB = p.invierte(pilaA);

            lvPilaB.Items.Clear();
            lvPilaC.Items.Clear();

            foreach (int elem in pilaB)
            {
                lvPilaB.Items.Add(Convert.ToString(elem));
            }
        }

        private void BtQuitar_Click(object sender, EventArgs e)
        {
            if (pilaA.Count != 0)
            {
                pilaA.Pop();
            }
            else
            {
                MessageBox.Show("Pila A vacia", "Información");
            }

            lvPilaA.Items.Clear();

            foreach (int elem in pilaA)
            {
                lvPilaA.Items.Add(Convert.ToString(elem));
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            pilaA.Clear();
            pilaB.Clear();
            pilaC.Clear();

            lvPilaA.Items.Clear();
            lvPilaB.Items.Clear();
            lvPilaC.Items.Clear();

        }
    }

    public class Pilas
    {
        int[] array1;
        int aux1;
        int aux2;
        bool aux3 = false;

        Stack<int> pilaAux1 = new Stack<int>();
        Stack<int> pilaAux2 = new Stack<int>();

        public Stack<int> cargaPila(Stack<int> pilaA, int a)
        {
            pilaA.Push(a);
            return pilaA;
            
        }

        public Stack<int> pasaPila(Stack<int> pilaA)
        {
            pilaAux1.Clear();

            aux1 = pilaA.Count();

            for (int i = 0; i < aux1; i++)
            {
                aux2 = pilaA.Pop();
                pilaAux1.Push(aux2);
            }

            return pilaAux1;
        }

        public bool contieneE(Stack<int> pilaA, int b)
        {
            aux1 = pilaA.Count();
            array1 = new int[aux1];
            array1 = pilaA.ToArray();
            aux3 = false;
            
            for (int i = 0; i < aux1; i++)
            {
                if (array1[i] == b)
                {
                    aux3 = true;                   
                }
            }

            return aux3;
        }

        public (Stack<int>, Stack<int>) separarPi(Stack<int> pilaA)
        {
            pilaAux1.Clear();
            pilaAux2.Clear();
           
            aux1 = pilaA.Count();
            array1 = pilaA.ToArray();

            for (int i = 0; i < aux1; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    pilaAux1.Push(array1[i]);
                }
                else
                {
                    pilaAux2.Push(array1[i]);
                }
            }

            return (pilaAux1, pilaAux2); 
        }

        public Stack<int> invierte(Stack<int> pilaA)
        {
            pilaAux1.Clear();
            
            aux1 = pilaA.Count();
            array1 = pilaA.ToArray();

            for (int i = aux1-1; i >= 0; i--)
            {
                pilaAux1.Push(array1[i]);
            }

            return pilaAux1;
        }

    }


}
