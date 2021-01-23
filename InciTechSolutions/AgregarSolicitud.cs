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
    public partial class AgregarSolicitud : Form
    {
        Metodos metodos = new Metodos();
        Usuario usuario = new Usuario();
        public AgregarSolicitud(Usuario user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void AgregarSolicitud_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conexionDB1.TiposInconvenientes' table. You can move, or remove it, as needed.
            this.tiposInconvenientesTableAdapter.Fill(this.conexionDB1.TiposInconvenientes);
            // TODO: This line of code loads data into the 'conexionDB.Prioridades' table. You can move, or remove it, as needed.
            this.prioridadesTableAdapter.Fill(this.conexionDB.Prioridades);

            txtNombre.Text = usuario.Nombre;
            txtApellidos.Text = usuario.Apellidos;
            txtTelefono.Text = usuario.Telefono;
            txtDepartamento.Text = usuario.Departamento;
            txtCorreo.Text = usuario.Correo;
        }

        private void btnAgregarSolicitud_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "" && txtCantAfectados.Text != "" && Convert.ToInt32(txtCantAfectados.Text) != 0)
            {
                if (MessageBox.Show("¿Está seguro que desea realizar esta solicitud?","Hacer solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblSolicitudTableAdapter solicitudAdapter = new tblSolicitudTableAdapter();
                    FuncionesTableAdapter funcionesAdapter = new FuncionesTableAdapter();

                    solicitudAdapter.InsertarSolicitud(usuario.IdEmpleado, Convert.ToInt32(cboPrioridad.SelectedValue), Convert.ToInt32(cboTipoInconveniente.SelectedValue), txtDescripcion.Text, cbxPrivada.Checked, Convert.ToInt32(txtCantAfectados.Text));


                    decimal horasEspera = funcionesAdapter.PromedioDePrioridad(Convert.ToInt32(cboPrioridad.SelectedValue))[0].Valor;

                    MessageBox.Show($"Solicitud agregada correctamente!!\n\n     Horas estimadas de espera :{(horasEspera > 0 ? $"{horasEspera}":"SIN DATOS")}");
                    Limpiar();
                    this.DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                string mensaje = "Faltan por llenar los siguientes campos:\n\n";
                if (txtDescripcion.Text == "")
                {
                    mensaje += "Descripción\n";
                }
                if (txtCantAfectados.Text == "")
                {
                    mensaje += "Cantidad de afectados\n";
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtCantAfectados.Text = "1";
            cboPrioridad.SelectedIndex = 0;
            cboTipoInconveniente.SelectedIndex = 0;
            cbxPrivada.Checked = false;
            cbxPrivada.Enabled = true;
            txtDescripcion.Focus();
        }

        private void txtCantAfectados_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloNumeros(sender, e);
        }

        private void txtCantAfectados_TextChanged(object sender, EventArgs e)
        {
            if (txtCantAfectados.Text != "")
            {
                int afectados = Convert.ToInt32(txtCantAfectados.Text);

                if (afectados > 1)
                {
                    cbxPrivada.Checked = false;
                    cbxPrivada.Enabled = false;
                }
                else if (afectados == 1)
                {
                    cbxPrivada.Enabled = true;
                }
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloLetrasyNum(sender, e);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAyudaPrioridad_Click(object sender, EventArgs e)
        {
            EjemploPrioridad ejemploPrioridad = new EjemploPrioridad();
            ejemploPrioridad.ShowDialog();
        }
    }
}
