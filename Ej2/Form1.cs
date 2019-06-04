using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MisClases;

namespace Ej2
{
    public partial class Form1 : Form
    {
        clsAuto oAuto;
        clsArreglo oArr = new clsArreglo();
        double tarifa = 0.5;
        DateTime horaSalida;
        DateTime horaEntrada;
        double minutos;
        string placa;
        string propietario;
        double importe;
        int lugaresLibres = 10;
        int topePila = 9;
        int tope = -1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            oAuto = new clsAuto();
            oAuto.Placa = tbPlaca.Text;
            oAuto.Propietario = tbPropietario.Text;
            oAuto.HoraDeEntrada = DateTime.Now;

            tope++;

            if (tbPlaca.Text != string.Empty && tbPropietario.Text != string.Empty)
            {
                if (tope < 10)  //oArr.agregar(oAuto) NO IMPLEMENTA LA PILA (ver clsArreglo) 
                {
                    int i = dgvAutos.Rows.Count;
                    dgvAutos.Rows.Add();
                    dgvAutos.Rows[i].Cells["Placa"].Value = oAuto.Placa;
                    dgvAutos.Rows[i].Cells["Propietario"].Value = oAuto.Propietario;
                    dgvAutos.Rows[i].Cells["Hora Entrada"].Value = oAuto.HoraDeEntrada;
                    MessageBox.Show("Auto Agregado", "Entrada de Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSalir.Enabled = true;

                    lugaresLibres--;
                    lblLugares.Text = "";
                    lblTope.Text = "";
                    lblLugares.Text = Convert.ToString(lugaresLibres);
                    lblTope.Text = Convert.ToString(tope);
                }
                else
                {
                    MessageBox.Show("Estacionamiento Completo", "Entrada de Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAgregar.Enabled = false;
                    tope--;
                }
                
            } 
            else
            {
                MessageBox.Show("Datos Inválidos", "Entrada de Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

            seteo();
        }

        void seteo()
        {
            tbPlaca.Clear();
            tbPropietario.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAutos.Columns.Add("Placa", "Placa");
            dgvAutos.Columns.Add("Propietario", "Propietario");
            dgvAutos.Columns.Add("Hora Entrada", "Hora Entrada");

            dgvAutos.AllowUserToAddRows = false;
            lblLugares.Text = Convert.ToString(lugaresLibres);
            btnSalir.Enabled = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (tope >= 0)
            {
                horaSalida = DateTime.Now;

                horaEntrada = DateTime.Parse(dgvAutos.Rows[tope].Cells["Hora Entrada"].Value.ToString());
                placa = dgvAutos.Rows[tope].Cells["Placa"].Value.ToString();
                propietario = dgvAutos.Rows[tope].Cells["Propietario"].Value.ToString();

                minutos = horaSalida.Minute - horaEntrada.Minute;
                importe = minutos * tarifa;
                MessageBox.Show("Placa: " + placa + "\n\nPropietario: " + propietario + "\n\nHora de entrada: " + horaEntrada.ToString() + "\n\nHora de salida: " + horaSalida.ToString() + "\n\nTiempo: " + minutos.ToString() + " minutos" + "\n\nImporte: " + Convert.ToString(importe), "Salida de Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                dgvAutos.Rows.RemoveAt(tope);
                topePila--;
                btnAgregar.Enabled = true;

                lugaresLibres++;
                tope--;
                lblLugares.Text = "";
                lblTope.Text = "";
                lblLugares.Text = Convert.ToString(lugaresLibres);
                if (tope == -1)
                {
                    lblTope.Text = "";
                    MessageBox.Show("Estacionamiento Vacio", "Salida de Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSalir.Enabled = false;
                }
                else lblTope.Text = Convert.ToString(tope);
            }
            //else
            //{
            //    MessageBox.Show("Estacionamiento Vacio", "Salida de Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    btnSalir.Enabled = false;
            //    lblTope.Text = "";
            //}

            //Linea 105 NO IMPLEMENTA LA PILA
            //dgvAutos.Rows.Remove(dgvAutos.CurrentRow);
            
        }
        //********ESTE EVENTO NO IMPLEMENTA LA PILA*********//

        //private void DgvAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int ind = e.RowIndex;
        //    if (ind != -1)
        //    {
        //        horaEntrada = DateTime.Parse(dgvAutos.Rows[ind].Cells["Hora Entrada"].Value.ToString());
        //        placa = dgvAutos.Rows[ind].Cells["Placa"].Value.ToString();
        //        propietario = dgvAutos.Rows[ind].Cells["Propietario"].Value.ToString();
        //    }
        //}
    }
}
