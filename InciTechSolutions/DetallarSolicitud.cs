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
using static InciTechSolutions.conexionDB;

namespace InciTechSolutions
{
    public partial class DetallarSolicitud : Form
    {
        private int idSolicitud = 0;
        Usuario usuario = new Usuario();
        public DetallarSolicitud(Usuario user, int IdSolicitud, string Codigo, string Estado)
        {
            InitializeComponent();

            usuario = user;

            idSolicitud = IdSolicitud;
            lblCodigo.Text += Codigo;
            txtEstado.Text = Estado;
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void DetallarSolicitud_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conexionDB.tblComentario' table. You can move, or remove it, as needed.
            this.tblComentarioTableAdapter.Fill(this.conexionDB.tblComentario);
            // TODO: This line of code loads data into the 'conexionDB.Prioridades' table. You can move, or remove it, as needed.
            this.prioridadesTableAdapter.Fill(this.conexionDB.Prioridades);
            // TODO: This line of code loads data into the 'conexionDB.TiposInconvenientes' table. You can move, or remove it, as needed.
            this.tiposInconvenientesTableAdapter.Fill(this.conexionDB.TiposInconvenientes);

            tblComentarioTableAdapter comentarioAdapter = new tblComentarioTableAdapter();
            dgvComentarios.DataSource = comentarioAdapter.ComentarioPorSolicitud(idSolicitud);

            TecnicosDeSolicitudPresentableTableAdapter tecnicosAdapter = new TecnicosDeSolicitudPresentableTableAdapter();
            dgvTecnicos.DataSource = tecnicosAdapter.TecnicosDeSolicitudPresentable(idSolicitud);

            RecursosDeSolicitudTableAdapter recursosAdapter = new RecursosDeSolicitudTableAdapter();
            dgvRecursos.DataSource = recursosAdapter.RecursosDeSolicitud(idSolicitud);

            tblSolicitudTableAdapter solicitudAdapter = new tblSolicitudTableAdapter();
            tblSolicitudRow solicitudData = solicitudAdapter.SolicitudOriginalPorId(idSolicitud)[0];

            EstadosDeSolicitudTableAdapter estadoAdapter = new EstadosDeSolicitudTableAdapter();
            dgvEstados.DataSource = estadoAdapter.EstadosDeSolicitud(idSolicitud);

            txtApellidos.Text = usuario.Apellidos;
            txtCantAfectados.Text = solicitudData.EmpleadosAfectados.ToString();
            txtCorreo.Text = usuario.Correo;
            txtDepartamento.Text = usuario.Departamento;
            txtDescripcion.Text = solicitudData.Descripcion;
            txtNombre.Text = usuario.Nombre;
            txtTelefono.Text = usuario.Telefono;
            cbxPrivada.Checked = solicitudData.Privada;
            cboPrioridad.SelectedValue = solicitudData.IdPrioridad;
            cboTipoInconveniente.SelectedValue = solicitudData.IdTipoInconveniente;
        }
    }
}
