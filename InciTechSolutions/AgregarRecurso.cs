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
    public partial class AgregarRecurso : Form
    {
        private Usuario usuario = new Usuario();
        private int idSolicitud = 0;
        private Metodos metodos = new Metodos();
        public AgregarRecurso(Usuario user, int IdSolicitud)
        {
            InitializeComponent();

            usuario = user;
            idSolicitud = IdSolicitud;

            dgvRecursos.DataSource = recursosDeSolicitudTableAdapter.RecursosDeSolicitud(idSolicitud);
        }

        private void AgregarRecurso_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea agregar este recurso?","Agregar recurso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QueriesTableAdapter queriesAdapter = new QueriesTableAdapter();

                queriesAdapter.AgregarRecurso(idSolicitud, usuario.IdEmpleado, txtRecurso.Text.Trim());

                dgvRecursos.DataSource = recursosDeSolicitudTableAdapter.RecursosDeSolicitud(idSolicitud);

                MessageBox.Show("Recurso agregado correctamente");

                txtRecurso.Text = "";
                txtRecurso.Focus();
            }
        }

        private void txtRecurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloLetrasyNum(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRecurso.Text = "";
            txtRecurso.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
