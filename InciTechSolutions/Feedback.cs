using InciTechSolutions.conexionDBTableAdapters;
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
    public partial class Feedback : Form
    {
        private Usuario usuario = new Usuario();
        private int idSolicitud = 0;
        public Feedback(Usuario user, int IdSolicitud, string Codigo)
        {
            InitializeComponent();

            usuario = user;
            idSolicitud = IdSolicitud;
            lblSolicitud.Text += Codigo;

            this.DialogResult = DialogResult.No;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int valoracion = 0;
            bool valoracionEscogida = false;
            foreach (RadioButton rbt in this.Controls.OfType<RadioButton>())
            {
                if (rbt.Checked == true)
                {
                    valoracion = Convert.ToInt32(rbt.Name.Substring(3,1));
                    valoracionEscogida = true;
                }
            }

            if (valoracionEscogida == true)
            {

                if (MessageBox.Show("¿Está seguro que desea ingresar este feedback?\n\nNo podrá cambiarlo despues.","Insertar feedback", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QueriesTableAdapter queriesAdapter = new QueriesTableAdapter();

                    queriesAdapter.InsertarFeedback(idSolicitud, usuario.IdEmpleado, valoracion, txtComentario.Text.Trim());

                    this.DialogResult = DialogResult.Yes;

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Faltan por llenar la valoración","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtComentario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
