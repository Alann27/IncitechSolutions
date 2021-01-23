using InciTechSolutions.conexionDBTableAdapters;
using Microsoft.Reporting.WinForms;
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
    public partial class Menu : Form
    {
        private Usuario usuario = new Usuario();
        private bool sinIniciar = true;
        public Menu(Usuario user, string userName)
        {
            InitializeComponent();
            usuario = user;

            lblLogin.Text = $"¡Bienvenido,\n{userName}!";
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conexionDB.SolicitudesPresentables' table. You can move, or remove it, as needed.
            this.solicitudesPresentablesTableAdapter.Fill(this.conexionDB.SolicitudesPresentables);
            // TODO: This line of code loads data into the 'conexionDB.SolicitudesPresentables' table. You can move, or remove it, as needed.
            this.solicitudesPresentablesTableAdapter.Fill(this.conexionDB.SolicitudesPresentables);
            // TODO: This line of code loads data into the 'conexionDB.tblSolicitud' table. You can move, or remove it, as needed.

            Dash();

            txtApellidos.Text = usuario.Apellidos;
            txtCorreo.Text = usuario.Correo;
            lblDepartamentoInicio.Text += usuario.Departamento;
            txtNombre.Text = usuario.Nombre;
            txtTelefono.Text = usuario.Telefono;


            if (usuario.Departamento != "Tecnología")
            {
                btnManejoDeSolicitudes.Visible = false;
                pnlManejoSolicitudes.Visible = false;
                btnReportes.Location = btnManejoDeSolicitudes.Location;
                lblLineaMenu2.Location = new Point(lblLineaMenu2.Location.X, lblLineaMenu2.Location.Y - 55);
            }
            this.rpvResumen.RefreshReport();
            this.rpvDetalle.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarSolicitud_Click(object sender, EventArgs e)
        {
            AgregarSolicitud agregarSolicitud = new AgregarSolicitud(usuario);
            DialogResult resultado = agregarSolicitud.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                SolicitudesPresentablesTableAdapter solicitudesAdapter = new SolicitudesPresentablesTableAdapter();
                dgvSolicitudesUsuario.DataSource = solicitudesAdapter.SolicitudesDeUsuario(usuario.IdEmpleado);
                dgvSolicitudesDepartamento.DataSource = solicitudesAdapter.SolicitudesDeDepartamento(usuario.IdDepartamento);
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSolicitudesGen_Click(object sender, EventArgs e)
        {
            if (pnlSolicitudesGen.Visible == false)
            {
                finalizarSolicitudes();

                SolicitudesPresentablesTableAdapter solicitudesAdapter = new SolicitudesPresentablesTableAdapter();
                dgvSolicitudesUsuario.DataSource = solicitudesAdapter.SolicitudesDeUsuario(usuario.IdEmpleado);
                dgvSolicitudesDepartamento.DataSource = solicitudesAdapter.SolicitudesDeDepartamento(usuario.IdDepartamento);

                pnlManejoSolicitudes.Visible = false;
                pnlInicio.Visible = false;
                pnlReportes.Visible = false;
                pnlSolicitudesGen.Visible = true;
            }
        }

        private void finalizarSolicitudes()
        {
            SolicitudesPresentablesTableAdapter solicitudesAdapter = new SolicitudesPresentablesTableAdapter();

            SolicitudesPresentablesDataTable solicitudesData = solicitudesAdapter.solicitudesPorFinalizar(usuario.IdEmpleado);

            tblSolicitudTableAdapter cambiarEstadoAdapter = new tblSolicitudTableAdapter();

            foreach (SolicitudesPresentablesRow solicitudes in solicitudesData)
            {
                cambiarEstadoAdapter.CambiarDeEstado(solicitudes.IdSolicitud);
            }
        }

        private void btnAgregarComentario_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudesUsuario.SelectedRows.Count == 1)
            {
                int idSolicitud = Convert.ToInt32(dgvSolicitudesUsuario.SelectedRows[0].Cells["idSolicitudU"].Value.ToString());
                string codigo = dgvSolicitudesUsuario.SelectedRows[0].Cells["codigoU"].Value.ToString();

                if (codigo != "Finalizada")
                {
                    AgregarComentario agregarComentario = new AgregarComentario(codigo, idSolicitud);
                    agregarComentario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Esta solicitud ya fue finalizada","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDetallarSolicitud_Click(object sender, EventArgs e)
        {
            DetallarSolicitud(dgvSolicitudesUsuario);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (pnlInicio.Visible == false)
            {
                Dash();
                pnlManejoSolicitudes.Visible = false;
                pnlReportes.Visible = false;
                pnlSolicitudesGen.Visible = false;
                pnlInicio.Visible = true;
            }

        }

        private void Dash()
        {
            FuncionesTableAdapter funcionesAdapter = new FuncionesTableAdapter();

            lblSolicitudesActivas.Text = Convert.ToInt32(funcionesAdapter.SolicitudesActivas()[0].Valor).ToString();
            lblSusSolicitudesActivas.Text = Convert.ToInt32(funcionesAdapter.SolicitudesActivasEmp(usuario.IdEmpleado)[0].Valor).ToString();
            lblSolicitudesDep.Text = Convert.ToInt32(funcionesAdapter.SolicitudesActivasDep(usuario.IdDepartamento)[0].Valor).ToString();

            UltimaSolicitudTableAdapter ultimaAdapter = new UltimaSolicitudTableAdapter();

            lblUltimaSolicitud.Text = ultimaAdapter.GetData(usuario.IdEmpleado)[0].Fecha.ToString();
        }

        private void btnManejoDeSolicitudes_Click(object sender, EventArgs e)
        {
            if (pnlManejoSolicitudes.Visible == false)
            {
                SolicitudesPresentablesTableAdapter solicitudesAdapter = new SolicitudesPresentablesTableAdapter();
                dgvSolicSinIniciar.DataSource = solicitudesAdapter.SolicitudesSinIniciar(usuario.IdEmpleado);
                dgvSolicEnProceso.DataSource = solicitudesAdapter.SolicitudesEnTrabajo(usuario.IdEmpleado);

                pnlReportes.Visible = false;
                pnlSolicitudesGen.Visible = false;
                pnlInicio.Visible = false;
                pnlManejoSolicitudes.Visible = true;

                

                if (dgvSolicEnProceso.Rows.Count > 0)
                {
                    dgvSolicEnProceso.Focus();
                    dgvSolicEnProceso.Rows[0].Selected = true;
                }
            }
        }

        private void dgvSolicSinIniciar_Enter(object sender, EventArgs e)
        {
            if (dgvSolicSinIniciar.Rows.Count > 0)
            {
                sinIniciar = true;
                dgvSolicSinIniciar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSolicSinIniciar.DefaultCellStyle = dgvSolicitudesUsuario.DefaultCellStyle;
                dgvSolicEnProceso.DefaultCellStyle = dgvSolicitudesDepartamento.DefaultCellStyle;
                dgvSolicEnProceso.SelectionMode = DataGridViewSelectionMode.CellSelect;

                if (dgvSolicSinIniciar.SelectedRows.Count == 0)
                {
                    dgvSolicSinIniciar.Rows[0].Selected = true;
                }

                btnCambiarDeEstado.Enabled = false;
                btnAgregarRecurso.Enabled = false;
                btnFinalizarSolicitud.Enabled = false;
                btnAceptarSolicitud.Enabled = true;
                btnDetallarSolicitudMan.Enabled = true;
            }

        }

        private void dgvSolicEnProceso_Enter(object sender, EventArgs e)
        {
            if (dgvSolicEnProceso.Rows.Count > 0)
            {
                sinIniciar = false;
                dgvSolicEnProceso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSolicSinIniciar.DefaultCellStyle = dgvSolicitudesDepartamento.DefaultCellStyle;
                dgvSolicEnProceso.DefaultCellStyle = dgvSolicitudesUsuario.DefaultCellStyle;
                dgvSolicSinIniciar.SelectionMode = DataGridViewSelectionMode.CellSelect;

                if (dgvSolicEnProceso.SelectedRows.Count == 0)
                {
                    dgvSolicEnProceso.Rows[0].Selected = true;
                }

                btnAceptarSolicitud.Enabled = false;
                btnAgregarRecurso.Enabled = true;
                btnDetallarSolicitudMan.Enabled = true;
            }

        }

        private void btnDetallarSolicitudMan_Click(object sender, EventArgs e)
        {
            if (sinIniciar == true)
            {
                DetallarSolicitud(dgvSolicSinIniciar);
            }
            else
            {
                DetallarSolicitud(dgvSolicEnProceso);
            }
        }

        private void DetallarSolicitud(DataGridView dgv)
        {
            int idSolicitud = Convert.ToInt32(dgv.SelectedRows[0].Cells[9].Value.ToString());
            string codigo = dgv.SelectedRows[0].Cells[0].Value.ToString();
            string estado = dgv.SelectedRows[0].Cells[7].Value.ToString();

            DetallarSolicitud detallarSolicitud = new DetallarSolicitud(usuario, idSolicitud, codigo, estado);
            detallarSolicitud.ShowDialog();
        }

        private void btnAceptarSolicitud_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea aceptar esta solicitud?","Aceptar solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idSolicitud = Convert.ToInt32(dgvSolicSinIniciar.SelectedRows[0].Cells[9].Value.ToString());

                FuncionesTableAdapter funcionesAdapter = new FuncionesTableAdapter();
                decimal validacion = funcionesAdapter.ValidarAsignacionTecnico(idSolicitud)[0].Valor;

                if (validacion == 1)
                {
                    QueriesTableAdapter queriesAdapter = new QueriesTableAdapter();


                    string codigo = dgvSolicSinIniciar.SelectedRows[0].Cells[0].Value.ToString();

                    queriesAdapter.AsignarTecnico(idSolicitud, usuario.IdEmpleado);

                    SolicitudesPresentablesTableAdapter solicitudesAdapter = new SolicitudesPresentablesTableAdapter();
                    dgvSolicSinIniciar.DataSource = solicitudesAdapter.SolicitudesSinIniciar(usuario.IdEmpleado);
                    dgvSolicEnProceso.DataSource = solicitudesAdapter.SolicitudesEnTrabajo(usuario.IdEmpleado);

                    MessageBox.Show($"Solicitud {codigo} aceptada correctamente", "Aceptar solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Esta solicitud ya fue aceptada por el número máximo de técnicos posible, por lo que no puede trabajar en ella", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarRecurso_Click(object sender, EventArgs e)
        {
            int idSolicitud = Convert.ToInt32(dgvSolicEnProceso.SelectedRows[0].Cells[9].Value.ToString());

            AgregarRecurso agregarRecurso = new AgregarRecurso(usuario, idSolicitud);
            agregarRecurso.ShowDialog();
        }

        private void dgvSolicEnProceso_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSolicEnProceso_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSolicEnProceso.Rows.Count > 0)
            {
                string estado = dgvSolicEnProceso.CurrentRow.Cells[7].Value.ToString();

                if (estado == "En proceso")
                {
                    btnFinalizarSolicitudMan.Enabled = true;
                    btnCambiarDeEstado.Enabled = false;
                }
                else
                {
                    btnCambiarDeEstado.Enabled = true;
                    btnFinalizarSolicitudMan.Enabled = false;
                }
            }

        }

        private void btnCambiarDeEstado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cambiar de estado la solicitud a 'En proceso?'","Cambiar de estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblSolicitudTableAdapter solicitudAdapter = new tblSolicitudTableAdapter();
                SolicitudesPresentablesTableAdapter solicitudesAdapter = new SolicitudesPresentablesTableAdapter();

                int idSolicitud = Convert.ToInt32(dgvSolicEnProceso.SelectedRows[0].Cells[9].Value.ToString());

                solicitudAdapter.CambiarDeEstado(idSolicitud);

                dgvSolicEnProceso.DataSource = solicitudesAdapter.SolicitudesEnTrabajo(usuario.IdEmpleado);

                MessageBox.Show("Solicitud cambiada de estado a 'En proceso' exitosamente", "Cambiar de estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnFinalizarSolicitudMan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea finalizar provisionalmente la solicitud?", "Finalizar solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblSolicitudTableAdapter solicitudAdapter = new tblSolicitudTableAdapter();
                SolicitudesPresentablesTableAdapter solicitudesAdapter = new SolicitudesPresentablesTableAdapter();

                int idSolicitud = Convert.ToInt32(dgvSolicEnProceso.SelectedRows[0].Cells[9].Value.ToString());
                string codigo = dgvSolicEnProceso.SelectedRows[0].Cells[0].Value.ToString();
                Feedback feedback = new Feedback(usuario, idSolicitud, codigo);

                DialogResult resultado = feedback.ShowDialog();

                if (resultado == DialogResult.Yes)
                {
                    solicitudAdapter.CambiarDeEstado(idSolicitud);

                    dgvSolicEnProceso.DataSource = solicitudesAdapter.SolicitudesEnTrabajo(usuario.IdEmpleado);

                    MessageBox.Show("Solicitud finalizada provisionalmente correctamente", "Finalizar solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe ingresar el feedback para poder finalizar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvSolicitudesUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSolicitudesUsuario.Rows.Count > 0)
            {
                string estado = dgvSolicitudesUsuario.CurrentRow.Cells[7].Value.ToString();

                if (estado == "Eventualmente finalizada")
                {
                    btnFinalizarSolicitud.Enabled = true;
                    btnSolicitudNoFinalizad.Enabled = true;
                    btnAgregarComentario.Enabled = false;
                    btnReactivarSolicitud.Enabled = false;
                }
                else if(estado == "Finalizada")
                {
                    btnFinalizarSolicitud.Enabled = false;
                    btnSolicitudNoFinalizad.Enabled = false;
                    btnAgregarComentario.Enabled = false;
                    btnReactivarSolicitud.Enabled = true;
                }
                else
                {
                    btnSolicitudNoFinalizad.Enabled = false;
                    btnFinalizarSolicitud.Enabled = false;
                    btnReactivarSolicitud.Enabled = false;
                    btnAgregarComentario.Enabled = true;
                }
            }
        }

        private void btnReactivarSolicitud_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea reiniciada la solicitud?", "Reiniciar solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idSolicitud = Convert.ToInt32(dgvSolicitudesUsuario.SelectedRows[0].Cells[9].Value.ToString());

                FuncionesTableAdapter funcionesAdapter = new FuncionesTableAdapter();

                decimal validacion = funcionesAdapter.ValidarReactivacion(idSolicitud)[0].Valor;

                if (validacion <= 7)
                {
                    tblSolicitudTableAdapter solicitudAdapter = new tblSolicitudTableAdapter();
                    SolicitudesPresentablesTableAdapter solicitudesAdapter = new SolicitudesPresentablesTableAdapter();

                    solicitudAdapter.CambiarDeEstado(idSolicitud);

                    dgvSolicitudesUsuario.DataSource = solicitudesAdapter.SolicitudesDeUsuario(usuario.IdEmpleado);
                    dgvSolicitudesDepartamento.DataSource = solicitudesAdapter.SolicitudesDeDepartamento(usuario.IdDepartamento);

                    MessageBox.Show("Solicitud reiniciada correctamente", "Reiniciar solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pasó el tiempo en el que podía reactivar esta solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFinalizarSolicitud_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea finalizar la solicitud?", "Finalizar solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblSolicitudTableAdapter solicitudAdapter = new tblSolicitudTableAdapter();
                SolicitudesPresentablesTableAdapter solicitudesAdapter = new SolicitudesPresentablesTableAdapter();

                int idSolicitud = Convert.ToInt32(dgvSolicitudesUsuario.SelectedRows[0].Cells[9].Value.ToString());
                string codigo = dgvSolicitudesUsuario.SelectedRows[0].Cells[0].Value.ToString();
                Feedback feedback = new Feedback(usuario, idSolicitud, codigo);

                DialogResult resultado = feedback.ShowDialog();

                if (resultado == DialogResult.Yes)
                {
                    solicitudAdapter.CambiarDeEstado(idSolicitud);

                    dgvSolicitudesUsuario.DataSource = solicitudesAdapter.SolicitudesDeUsuario(usuario.IdEmpleado);
                    dgvSolicitudesDepartamento.DataSource = solicitudesAdapter.SolicitudesDeDepartamento(usuario.IdDepartamento);

                    MessageBox.Show("Solicitud finalizada correctamente", "Finalizar solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe ingresar el feedback para poder finalizar la solicitud","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSolicitudNoFinalizad_Click(object sender, EventArgs e)
        {
            tblSolicitudTableAdapter solicitudAdapter = new tblSolicitudTableAdapter();
            SolicitudesPresentablesTableAdapter solicitudesAdapter = new SolicitudesPresentablesTableAdapter();

            int idSolicitud = Convert.ToInt32(dgvSolicitudesUsuario.SelectedRows[0].Cells[9].Value.ToString());
            string codigo = dgvSolicitudesUsuario.SelectedRows[0].Cells[0].Value.ToString();

            AgregarComentario agregarComentario = new AgregarComentario(codigo, idSolicitud, true);

            DialogResult resultado = agregarComentario.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                solicitudAdapter.SolicitudAProceso(idSolicitud);

                dgvSolicitudesUsuario.DataSource = solicitudesAdapter.SolicitudesDeUsuario(usuario.IdEmpleado);
                dgvSolicitudesDepartamento.DataSource = solicitudesAdapter.SolicitudesDeDepartamento(usuario.IdDepartamento);

                MessageBox.Show("La solicitud no fue finalizada", "Cancelar finalización", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe ingresar el comentario especificando porque aun no finaliza la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (pnlReportes.Visible == false)
            {
                CargarResumenReporte(DateTime.Today, DateTime.Now.AddHours(4));
 
                pnlSolicitudesGen.Visible = false;
                pnlInicio.Visible = false;
                pnlManejoSolicitudes.Visible = false;
                pnlReportes.Visible = true;

            }
        }

        private void CargarResumenReporte(DateTime fechaInicio, DateTime fechaFin)
        {
            RSolicitudesFinalizadasTableAdapter solicitudesFinalizadasAdap = new RSolicitudesFinalizadasTableAdapter();
            RSolicitudesEnDesarrolloTableAdapter solicitudesDesarrolloAdap = new RSolicitudesEnDesarrolloTableAdapter();
            RSolicitudesSinIniciarTableAdapter solicitudesSinIniciarAdap = new RSolicitudesSinIniciarTableAdapter();

            FuncionesTableAdapter funcionesAdapter = new FuncionesTableAdapter();

            ReportDataSource sourceFinalizadas = new ReportDataSource();
            ReportDataSource sourceDesarrollo = new ReportDataSource();
            ReportDataSource sourceSinIniciar = new ReportDataSource();


            if (usuario.Departamento == "Gerencía")
            {
                sourceFinalizadas = new ReportDataSource("SolicitudesFinalizadas", (DataTable) solicitudesFinalizadasAdap.RSolicitudesFinalizadas(fechaInicio, fechaFin));
                sourceDesarrollo = new ReportDataSource("SolicitudesEnDesarrollo", (DataTable)solicitudesDesarrolloAdap.RSolicitudesEnDesarrollo(fechaInicio, fechaFin));
                sourceSinIniciar = new ReportDataSource("SolicitudesSinIniciar", (DataTable)solicitudesSinIniciarAdap.RSolicitudesSinIniciar(fechaInicio, fechaFin));
            }
            else if (usuario.Departamento == "Tecnología")
            {
                sourceFinalizadas = new ReportDataSource("SolicitudesFinalizadas", (DataTable)solicitudesFinalizadasAdap.RSolicitudesFinPorTec(usuario.IdEmpleado,fechaInicio, fechaFin));
                sourceDesarrollo = new ReportDataSource("SolicitudesEnDesarrollo", (DataTable)solicitudesDesarrolloAdap.RSolicitudesEnDesPorTec(usuario.IdEmpleado,fechaInicio, fechaFin));
                sourceSinIniciar = new ReportDataSource("SolicitudesSinIniciar", (DataTable)solicitudesSinIniciarAdap.RSolicitudesSinIniPorDep(usuario.IdDepartamento,fechaInicio, fechaFin));
            }
            else
            {
                sourceFinalizadas = new ReportDataSource("SolicitudesFinalizadas", (DataTable)solicitudesFinalizadasAdap.RSolicitudesFinPorDep(usuario.IdDepartamento, fechaInicio, fechaFin));
                sourceDesarrollo = new ReportDataSource("SolicitudesEnDesarrollo", (DataTable)solicitudesDesarrolloAdap.RSolicitudesEnDesPorDep(usuario.IdDepartamento, fechaInicio, fechaFin));
                sourceSinIniciar = new ReportDataSource("SolicitudesSinIniciar", (DataTable)solicitudesSinIniciarAdap.RSolicitudesSinIniPorDep(usuario.IdDepartamento, fechaInicio, fechaFin));
            }

            string fechaReporte = "";

            if (fechaInicio.Date == fechaFin.Date)
            {
                fechaReporte = $"Solicitud del día {fechaFin.ToString("dd/MM/yyyy")}";
            }
            else
            {
                fechaReporte = $"Solicitudes entre los días {fechaInicio.ToString("dd/MM/yyyy")} al {fechaFin.ToString("dd/MM/yyyy")}";
            }

            rpvResumen.LocalReport.DataSources.Clear();

            ReportParameter[] resumenParametros = new ReportParameter[3];

            resumenParametros[0] = new ReportParameter("solicitante", $"{usuario.Nombre} {usuario.Apellidos}");
            resumenParametros[1] = new ReportParameter("departamento", usuario.Departamento);
            resumenParametros[2] = new ReportParameter("fecha", fechaReporte);

            rpvResumen.LocalReport.SetParameters(resumenParametros);

            rpvResumen.LocalReport.DataSources.Add(sourceFinalizadas);
            rpvResumen.LocalReport.DataSources.Add(sourceDesarrollo);
            rpvResumen.LocalReport.DataSources.Add(sourceSinIniciar);

            rpvResumen.RefreshReport();


        }

        private void btnHoyR_Click(object sender, EventArgs e)
        {
            CargarResumenReporte(DateTime.Today, DateTime.Now.AddHours(4));
        }

        private void btn15DiasR_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DateTime.Today.AddDays(-15);
            CargarResumenReporte(fechaInicio, DateTime.Now.AddHours(4));
        }

        private void btnMesR_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            CargarResumenReporte(fechaInicio, DateTime.Now.AddHours(4));
        }

        private void btn30DiasR_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DateTime.Today.AddDays(-30);
            CargarResumenReporte(fechaInicio, DateTime.Now.AddHours(4));
        }

        private void btnAnoR_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = new DateTime(DateTime.Today.Year, 1, 1);
            CargarResumenReporte(fechaInicio, DateTime.Now.AddHours(4));
        }

        private void btnElegirDiaR_Click(object sender, EventArgs e)
        {
            try
            {
                FechaEspecifica fechaEspecifica = new FechaEspecifica();

                DialogResult resultado = fechaEspecifica.ShowDialog();

                if (resultado == DialogResult.Yes)
                {
                    DateTime fechaDTP = fechaEspecifica.dtpFechaDia.Value;
                    DateTime fechaInicio = fechaDTP.Date;
                    DateTime fechaFinal = new DateTime(fechaDTP.Year, fechaDTP.Month, fechaDTP.Day, 23, 59, 59);
                    CargarResumenReporte(fechaInicio, fechaFinal);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCustomR_Click(object sender, EventArgs e)
        {
            try
            {
                ElegirFecha elegirFecha = new ElegirFecha();

                DialogResult resultado = elegirFecha.ShowDialog();

                if (resultado == DialogResult.Yes)
                {
                    CargarResumenReporte(elegirFecha.dtpFechaInicio.Value, elegirFecha.dtpFechaFinal.Value);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblDetalle_Click(object sender, EventArgs e)
        {
            if (pnlDetalle.Visible == false)
            {
                InputBox inputBox = new InputBox();
                DialogResult resultado = inputBox.ShowDialog();

                if (resultado == DialogResult.Yes)
                {
                    FuncionesTableAdapter funcionesAdapter = new FuncionesTableAdapter();
                    int idSolicitud = Convert.ToInt32(funcionesAdapter.IdSolicitudPorCodigo(inputBox.txtCodigo.Text.ToUpper())[0].Valor);

                    TecnicosDeSolicitudPresentableTableAdapter tecnicosAdapter = new TecnicosDeSolicitudPresentableTableAdapter();
                    TecnicosDeSolicitudPresentableDataTable tecnicosData = tecnicosAdapter.TecnicosDeSolicitudPresentable(idSolicitud);

                    bool tecnico = false;

                    foreach (TecnicosDeSolicitudPresentableRow item in tecnicosData)
                    {
                        if (item.Nombre + " " + item.Apellidos == usuario.Nombre + " " + usuario.Apellidos)
                        {
                            tecnico = true;
                        }
                    }

                    if (usuario.Nombre + " " + usuario.Apellidos == inputBox.lblNombreSolicitante.Text || usuario.Departamento == "Gerencía" || tecnico == true)
                    {
                        CargarDetalleSolicitud(inputBox.txtCodigo.Text.ToUpper(), idSolicitud, tecnicosData, inputBox.solicitudData);

                        lblDetalle.BackColor = Color.White;
                        lblDetalle.BorderStyle = BorderStyle.None;

                        lblResumen.BorderStyle = BorderStyle.FixedSingle;
                        lblResumen.BackColor = Color.NavajoWhite;

                        pnlResumen.Visible = false;
                        pnlDetalle.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No cuenta con los permisos para ver esta solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void CargarDetalleSolicitud(string codigo, int idSolicitud, TecnicosDeSolicitudPresentableDataTable tecnicosData, SolicitudReporteDataTable solicitudData)
        {
            EstadosDeSolicitudTableAdapter estadosAdapter = new EstadosDeSolicitudTableAdapter();
            tblComentarioTableAdapter comentariosAdap = new tblComentarioTableAdapter();
            RecursosDeSolicitudTableAdapter recursosAdap = new RecursosDeSolicitudTableAdapter();


            FuncionesTableAdapter funcionesAdapter = new FuncionesTableAdapter();

            ReportDataSource sourceEstados = new ReportDataSource();
            ReportDataSource sourceComentarios = new ReportDataSource();
            ReportDataSource sourceRecursos = new ReportDataSource();
            ReportDataSource sourceTecnicos = new ReportDataSource();
            ReportDataSource sourceSolicitud = new ReportDataSource();

            sourceEstados = new ReportDataSource("Estados", (DataTable) estadosAdapter.EstadosDeSolicitud(idSolicitud));
            sourceComentarios = new ReportDataSource("Comentarios", (DataTable) comentariosAdap.ComentarioPorSolicitud(idSolicitud));
            sourceRecursos = new ReportDataSource("Recursos", (DataTable)recursosAdap.RecursosDeSolicitud(idSolicitud));
            sourceTecnicos = new ReportDataSource("Tecnicos",(DataTable)tecnicosData);
            sourceSolicitud = new ReportDataSource("SolicitudReporte", (DataTable)solicitudData);
            
            rpvDetalle.LocalReport.DataSources.Clear();

            ReportParameter[] resumenParametros = new ReportParameter[3];

            resumenParametros[0] = new ReportParameter("solicitante", $"{usuario.Nombre} {usuario.Apellidos}");
            resumenParametros[1] = new ReportParameter("departamento", usuario.Departamento);
            resumenParametros[2] = new ReportParameter("solicitud", $"Solicitud: {codigo}");

            rpvDetalle.LocalReport.SetParameters(resumenParametros);

            rpvDetalle.LocalReport.DataSources.Add(sourceTecnicos);
            rpvDetalle.LocalReport.DataSources.Add(sourceEstados);
            rpvDetalle.LocalReport.DataSources.Add(sourceRecursos);
            rpvDetalle.LocalReport.DataSources.Add(sourceComentarios);
            rpvDetalle.LocalReport.DataSources.Add(sourceSolicitud);

            rpvDetalle.RefreshReport();
        }

        private void lblResumen_Click(object sender, EventArgs e)
        {
            if (pnlResumen.Visible == false)
            {
                CargarResumenReporte(DateTime.Today, DateTime.Now.AddHours(4));
                pnlDetalle.Visible = false;
                pnlResumen.Visible = true;

                lblDetalle.BackColor = Color.NavajoWhite;
                lblDetalle.BorderStyle = BorderStyle.FixedSingle;

                lblResumen.BorderStyle = BorderStyle.None;
                lblResumen.BackColor = Color.White;
            }
        }

        private void btnBusqPersonalizada_Click(object sender, EventArgs e)
        {
            BusquedaPersonalizad b = new BusquedaPersonalizad(usuario);
            DialogResult resultado = b.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                CargarResumenPersonalizado(b.prioridad, b.departamento, b.afectados, b.privada, b.tipoInconveniente, b.dptFechaInicio.Value, b.dptFechaFinal.Value);
            }
        }

        private void CargarResumenPersonalizado(int prioridad, int departamento, int afectados, int privada, int inconveniene, DateTime fechaInicio, DateTime fechaFin)
        {
            RSolicitudesFinalizadasTableAdapter solicitudesFinalizadasAdap = new RSolicitudesFinalizadasTableAdapter();
            RSolicitudesEnDesarrolloTableAdapter solicitudesDesarrolloAdap = new RSolicitudesEnDesarrolloTableAdapter();
            RSolicitudesSinIniciarTableAdapter solicitudesSinIniciarAdap = new RSolicitudesSinIniciarTableAdapter();

            FuncionesTableAdapter funcionesAdapter = new FuncionesTableAdapter();

            ReportDataSource sourceFinalizadas = new ReportDataSource();
            ReportDataSource sourceDesarrollo = new ReportDataSource();
            ReportDataSource sourceSinIniciar = new ReportDataSource();

            sourceFinalizadas = new ReportDataSource("SolicitudesFinalizadas", (DataTable)solicitudesFinalizadasAdap.Personalizada(departamento, inconveniene, prioridad, privada, afectados, fechaInicio, fechaFin));
            sourceDesarrollo = new ReportDataSource("SolicitudesEnDesarrollo", (DataTable)solicitudesDesarrolloAdap.Personalizada(departamento, inconveniene, prioridad, privada, afectados, fechaInicio, fechaFin));
            sourceSinIniciar = new ReportDataSource("SolicitudesSinIniciar", (DataTable)solicitudesSinIniciarAdap.Personalizada(departamento, inconveniene, prioridad, privada, afectados, fechaInicio, fechaFin));


            string fechaReporte = "";

            if (fechaInicio.Date == fechaFin.Date)
            {
                fechaReporte = $"Solicitud del día {fechaFin.ToString("dd/MM/yyyy")}";
            }
            else
            {
                fechaReporte = $"Solicitudes entre los días {fechaInicio.ToString("dd/MM/yyyy")} al {fechaFin.ToString("dd/MM/yyyy")}";
            }

            rpvResumen.LocalReport.DataSources.Clear();

            ReportParameter[] resumenParametros = new ReportParameter[3];

            resumenParametros[0] = new ReportParameter("solicitante", $"{usuario.Nombre} {usuario.Apellidos}");
            resumenParametros[1] = new ReportParameter("departamento", usuario.Departamento);
            resumenParametros[2] = new ReportParameter("fecha", fechaReporte);

            rpvResumen.LocalReport.SetParameters(resumenParametros);

            rpvResumen.LocalReport.DataSources.Add(sourceFinalizadas);
            rpvResumen.LocalReport.DataSources.Add(sourceDesarrollo);
            rpvResumen.LocalReport.DataSources.Add(sourceSinIniciar);

            rpvResumen.RefreshReport();


        }
    }
}
