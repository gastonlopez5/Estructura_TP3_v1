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

            if (oArr.agregar(oAuto))
            {
                if (tbPlaca.Text != string.Empty && tbPropietario.Text != string.Empty)
                {
                    int i = dgvAutos.Rows.Count;
                    dgvAutos.Rows.Add();
                    dgvAutos.Rows[i].Cells["Placa"].Value = oAuto.Placa;
                    dgvAutos.Rows[i].Cells["Propietario"].Value = oAuto.Propietario;
                    dgvAutos.Rows[i].Cells["Hora Entrada"].Value = oAuto.HoraDeEntrada;
                    MessageBox.Show("Auto Agregado");

                    lugaresLibres--;
                    lblTope.Text = "";
                    lblTope.Text = Convert.ToString(lugaresLibres);
                }
                else
                {
                    MessageBox.Show("Datos Inválidos");
                }
                
            } 
            else
            {
                MessageBox.Show("Estacionamiento Completo");
                btnAgregar.Enabled = false;
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
            lblTope.Text = Convert.ToString(lugaresLibres);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            horaSalida = DateTime.Now;
            minutos = horaSalida.Minute - horaEntrada.Minute;
            importe = minutos * 0.5;
            MessageBox.Show("Placa: " + placa + "\n\nPropietario: " + propietario + "\n\nHora de entrada: " + horaEntrada.ToString() + "\n\nHora de salida: " + horaSalida.ToString() + "\n\nTiempo: " + minutos.ToString() + " minutos" + "\n\nImporte: " + Convert.ToString(importe), "Salida de Auto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dgvAutos.Rows.Remove(dgvAutos.CurrentRow);

            lugaresLibres++;
            lblTope.Text = "";
            lblTope.Text = Convert.ToString(lugaresLibres);
        }

        private void DgvAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            if (ind != -1)
            {
                horaEntrada = DateTime.Parse(dgvAutos.Rows[ind].Cells["Hora Entrada"].Value.ToString());
                placa = dgvAutos.Rows[ind].Cells["Placa"].Value.ToString();
                propietario = dgvAutos.Rows[ind].Cells["Propietario"].Value.ToString();
            }
        }
    }
}
