using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InciTechSolutions
{
    public partial class ElegirFecha : Form
    {
        public ElegirFecha()
        {
            try
            {
                InitializeComponent();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechaInicio.Value < dtpFechaFinal.Value)
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("La fecha final debe ser mayor que la fecha inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ElegirFecha_FormClosing(object sender, FormClosingEventArgs e)
        {


        }
    }
}
