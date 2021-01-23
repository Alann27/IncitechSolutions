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
    public partial class FechaEspecifica : Form
    {
        public FechaEspecifica()
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
                this.DialogResult = DialogResult.Yes;

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

        private void FechaEspecifica_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                if (this.DialogResult != DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                }


            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
