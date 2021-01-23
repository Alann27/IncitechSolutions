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
    public partial class BusquedaPersonalizad : Form
    {
        Usuario usuario = new Usuario();
        public int prioridad = 0, afectados = 0, privada = 0, departamento = 0, tipoInconveniente = 0;

        private void cbxInconveniente_CheckedChanged(object sender, EventArgs e)
        {
            cboInconveniente.Enabled = !cbxInconveniente.Checked;
        }

        private void cbxAfectados_CheckedChanged(object sender, EventArgs e)
        {
            cboAfectados.Enabled = !cbxAfectados.Checked;
        }

        private void cbxPrioridad_CheckedChanged(object sender, EventArgs e)
        {
            cboPrioridad.Enabled = !cbxPrioridad.Checked;
        }

        private void cbxPrivada_CheckedChanged(object sender, EventArgs e)
        {
            cboPrivada.Enabled = !cbxPrivada.Checked;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxDepartamento_CheckedChanged(object sender, EventArgs e)
        {
            cboDepartamento.Enabled = !cbxDepartamento.Checked;
        }

        public BusquedaPersonalizad(Usuario user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void BusquedaPersonalizad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conexionDB.Prioridades' table. You can move, or remove it, as needed.
            this.prioridadesTableAdapter.Fill(this.conexionDB.Prioridades);
            // TODO: This line of code loads data into the 'conexionDB.TiposInconvenientes' table. You can move, or remove it, as needed.
            this.tiposInconvenientesTableAdapter.Fill(this.conexionDB.TiposInconvenientes);
            // TODO: This line of code loads data into the 'conexionDB.tblDepartamento' table. You can move, or remove it, as needed.
            this.tblDepartamentoTableAdapter.Fill(this.conexionDB.tblDepartamento);

            cboDepartamento.SelectedValue = usuario.IdDepartamento;
            cboPrivada.SelectedIndex = 0;
            cboAfectados.SelectedIndex = 0;

            if (usuario.Departamento == "Gerencía")
            {
                cboDepartamento.Enabled = true;
                cbxDepartamento.Enabled = true;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dptFechaFinal.Value < dptFechaInicio.Value)
            {
                MessageBox.Show("Las fechas final debe ser mayor","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                prioridad = cbxPrioridad.Checked == true ? 0 : Convert.ToInt32(cboPrioridad.SelectedValue);
                privada = cbxPrivada.Checked == true ? 0 : cboPrivada.SelectedIndex;
                departamento = cbxDepartamento.Checked == true ? 0 : Convert.ToInt32(cboDepartamento.SelectedValue);
                afectados = cbxAfectados.Checked == true ? 0 : Convert.ToInt32(cboAfectados.Text);
                tipoInconveniente = cbxInconveniente.Checked == true ? 0 : Convert.ToInt32(cboInconveniente.SelectedValue);

                this.DialogResult = DialogResult.Yes;
            }

        }
    }
}
