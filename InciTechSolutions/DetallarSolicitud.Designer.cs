
namespace InciTechSolutions
{
    partial class DetallarSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxSolicitud = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxPrivada = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.prioridadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexionDB = new InciTechSolutions.conexionDB();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantAfectados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoInconveniente = new System.Windows.Forms.ComboBox();
            this.tiposInconvenientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxSolicitante = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTecnicos = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnicosDeSolicitudPresentableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.dgvComentarios = new System.Windows.Forms.DataGridView();
            this.idComentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblComentarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.estadosDeSolicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.tecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recursosDeSolicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.tiposInconvenientesTableAdapter = new InciTechSolutions.conexionDBTableAdapters.TiposInconvenientesTableAdapter();
            this.prioridadesTableAdapter = new InciTechSolutions.conexionDBTableAdapters.PrioridadesTableAdapter();
            this.tecnicosDeSolicitudPresentableTableAdapter = new InciTechSolutions.conexionDBTableAdapters.TecnicosDeSolicitudPresentableTableAdapter();
            this.tblComentarioTableAdapter = new InciTechSolutions.conexionDBTableAdapters.tblComentarioTableAdapter();
            this.recursosDeSolicitudTableAdapter = new InciTechSolutions.conexionDBTableAdapters.RecursosDeSolicitudTableAdapter();
            this.estadosDeSolicitudTableAdapter = new InciTechSolutions.conexionDBTableAdapters.EstadosDeSolicitudTableAdapter();
            this.nombreEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prioridadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposInconvenientesBindingSource)).BeginInit();
            this.gbxSolicitante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosDeSolicitudPresentableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblComentarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosDeSolicitudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosDeSolicitudBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSolicitud
            // 
            this.gbxSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(213)))));
            this.gbxSolicitud.Controls.Add(this.txtEstado);
            this.gbxSolicitud.Controls.Add(this.label13);
            this.gbxSolicitud.Controls.Add(this.label1);
            this.gbxSolicitud.Controls.Add(this.txtDescripcion);
            this.gbxSolicitud.Controls.Add(this.cbxPrivada);
            this.gbxSolicitud.Controls.Add(this.label2);
            this.gbxSolicitud.Controls.Add(this.cboPrioridad);
            this.gbxSolicitud.Controls.Add(this.label3);
            this.gbxSolicitud.Controls.Add(this.txtCantAfectados);
            this.gbxSolicitud.Controls.Add(this.label4);
            this.gbxSolicitud.Controls.Add(this.cboTipoInconveniente);
            this.gbxSolicitud.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSolicitud.Location = new System.Drawing.Point(12, 351);
            this.gbxSolicitud.Name = "gbxSolicitud";
            this.gbxSolicitud.Size = new System.Drawing.Size(544, 282);
            this.gbxSolicitud.TabIndex = 5;
            this.gbxSolicitud.TabStop = false;
            this.gbxSolicitud.Text = "Información de la solicitud";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEstado.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(194, 243);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(332, 28);
            this.txtEstado.TabIndex = 6;
            this.txtEstado.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "Estado de la solicitud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(17, 54);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(509, 81);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.TabStop = false;
            // 
            // cbxPrivada
            // 
            this.cbxPrivada.AutoSize = true;
            this.cbxPrivada.Enabled = false;
            this.cbxPrivada.Location = new System.Drawing.Point(418, 208);
            this.cbxPrivada.Name = "cbxPrivada";
            this.cbxPrivada.Size = new System.Drawing.Size(84, 25);
            this.cbxPrivada.TabIndex = 4;
            this.cbxPrivada.TabStop = false;
            this.cbxPrivada.Text = "Privada";
            this.cbxPrivada.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de inconveniente";
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.BackColor = System.Drawing.Color.Gainsboro;
            this.cboPrioridad.DataSource = this.prioridadesBindingSource;
            this.cboPrioridad.DisplayMember = "Descripcion";
            this.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridad.Enabled = false;
            this.cboPrioridad.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Location = new System.Drawing.Point(330, 166);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(196, 29);
            this.cboPrioridad.TabIndex = 2;
            this.cboPrioridad.ValueMember = "IdPrioridad";
            // 
            // prioridadesBindingSource
            // 
            this.prioridadesBindingSource.DataMember = "Prioridades";
            this.prioridadesBindingSource.DataSource = this.conexionDB;
            // 
            // conexionDB
            // 
            this.conexionDB.DataSetName = "conexionDB";
            this.conexionDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de afectados";
            // 
            // txtCantAfectados
            // 
            this.txtCantAfectados.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCantAfectados.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantAfectados.Location = new System.Drawing.Point(194, 206);
            this.txtCantAfectados.Name = "txtCantAfectados";
            this.txtCantAfectados.ReadOnly = true;
            this.txtCantAfectados.Size = new System.Drawing.Size(193, 28);
            this.txtCantAfectados.TabIndex = 3;
            this.txtCantAfectados.TabStop = false;
            this.txtCantAfectados.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prioridad";
            // 
            // cboTipoInconveniente
            // 
            this.cboTipoInconveniente.BackColor = System.Drawing.Color.Gainsboro;
            this.cboTipoInconveniente.DataSource = this.tiposInconvenientesBindingSource;
            this.cboTipoInconveniente.DisplayMember = "TipoInconveniente";
            this.cboTipoInconveniente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoInconveniente.Enabled = false;
            this.cboTipoInconveniente.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoInconveniente.FormattingEnabled = true;
            this.cboTipoInconveniente.Location = new System.Drawing.Point(17, 166);
            this.cboTipoInconveniente.Name = "cboTipoInconveniente";
            this.cboTipoInconveniente.Size = new System.Drawing.Size(284, 29);
            this.cboTipoInconveniente.TabIndex = 1;
            this.cboTipoInconveniente.ValueMember = "IdTipoInconveniente";
            // 
            // tiposInconvenientesBindingSource
            // 
            this.tiposInconvenientesBindingSource.DataMember = "TiposInconvenientes";
            this.tiposInconvenientesBindingSource.DataSource = this.conexionDB;
            // 
            // gbxSolicitante
            // 
            this.gbxSolicitante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            this.gbxSolicitante.Controls.Add(this.txtTelefono);
            this.gbxSolicitante.Controls.Add(this.label9);
            this.gbxSolicitante.Controls.Add(this.txtCorreo);
            this.gbxSolicitante.Controls.Add(this.label8);
            this.gbxSolicitante.Controls.Add(this.label7);
            this.gbxSolicitante.Controls.Add(this.txtDepartamento);
            this.gbxSolicitante.Controls.Add(this.txtApellidos);
            this.gbxSolicitante.Controls.Add(this.txtNombre);
            this.gbxSolicitante.Controls.Add(this.label6);
            this.gbxSolicitante.Controls.Add(this.label5);
            this.gbxSolicitante.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSolicitante.Location = new System.Drawing.Point(12, 109);
            this.gbxSolicitante.Name = "gbxSolicitante";
            this.gbxSolicitante.Size = new System.Drawing.Size(544, 209);
            this.gbxSolicitante.TabIndex = 6;
            this.gbxSolicitante.TabStop = false;
            this.gbxSolicitante.Text = "Información de solicitante";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTelefono.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(216, 170);
            this.txtTelefono.Mask = "000-000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(176, 28);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Teléfono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCorreo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(219, 126);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(307, 28);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Apellidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Correo";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDepartamento.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(17, 126);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(190, 28);
            this.txtDepartamento.TabIndex = 2;
            this.txtDepartamento.TabStop = false;
            this.txtDepartamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.Gainsboro;
            this.txtApellidos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(219, 60);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(307, 28);
            this.txtApellidos.TabIndex = 1;
            this.txtApellidos.TabStop = false;
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(17, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(190, 28);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // dgvTecnicos
            // 
            this.dgvTecnicos.AllowUserToAddRows = false;
            this.dgvTecnicos.AllowUserToDeleteRows = false;
            this.dgvTecnicos.AllowUserToResizeColumns = false;
            this.dgvTecnicos.AllowUserToResizeRows = false;
            this.dgvTecnicos.AutoGenerateColumns = false;
            this.dgvTecnicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTecnicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecnicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgvTecnicos.DataSource = this.tecnicosDeSolicitudPresentableBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTecnicos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTecnicos.Location = new System.Drawing.Point(579, 69);
            this.dgvTecnicos.MultiSelect = false;
            this.dgvTecnicos.Name = "dgvTecnicos";
            this.dgvTecnicos.ReadOnly = true;
            this.dgvTecnicos.RowHeadersVisible = false;
            this.dgvTecnicos.RowHeadersWidth = 51;
            this.dgvTecnicos.RowTemplate.Height = 24;
            this.dgvTecnicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTecnicos.Size = new System.Drawing.Size(282, 177);
            this.dgvTecnicos.TabIndex = 7;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombreDataGridViewTextBoxColumn.Width = 73;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.apellidosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apellidosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaDataGridViewTextBoxColumn.Width = 56;
            // 
            // tecnicosDeSolicitudPresentableBindingSource
            // 
            this.tecnicosDeSolicitudPresentableBindingSource.DataMember = "TecnicosDeSolicitudPresentable";
            this.tecnicosDeSolicitudPresentableBindingSource.DataSource = this.conexionDB;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 42);
            this.label10.TabIndex = 8;
            this.label10.Text = "Técnicos que trabajan \r\nen la solicitud";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvComentarios
            // 
            this.dgvComentarios.AllowUserToAddRows = false;
            this.dgvComentarios.AllowUserToDeleteRows = false;
            this.dgvComentarios.AllowUserToResizeColumns = false;
            this.dgvComentarios.AllowUserToResizeRows = false;
            this.dgvComentarios.AutoGenerateColumns = false;
            this.dgvComentarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvComentarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComentarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvComentarios.ColumnHeadersHeight = 29;
            this.dgvComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComentarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComentarioDataGridViewTextBoxColumn,
            this.idSolicitudDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn1});
            this.dgvComentarios.DataSource = this.tblComentarioBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComentarios.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvComentarios.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvComentarios.Location = new System.Drawing.Point(579, 279);
            this.dgvComentarios.MultiSelect = false;
            this.dgvComentarios.Name = "dgvComentarios";
            this.dgvComentarios.ReadOnly = true;
            this.dgvComentarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComentarios.RowHeadersVisible = false;
            this.dgvComentarios.RowHeadersWidth = 51;
            this.dgvComentarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvComentarios.RowTemplate.Height = 24;
            this.dgvComentarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComentarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvComentarios.ShowCellErrors = false;
            this.dgvComentarios.ShowCellToolTips = false;
            this.dgvComentarios.ShowEditingIcon = false;
            this.dgvComentarios.ShowRowErrors = false;
            this.dgvComentarios.Size = new System.Drawing.Size(579, 159);
            this.dgvComentarios.TabIndex = 9;
            // 
            // idComentarioDataGridViewTextBoxColumn
            // 
            this.idComentarioDataGridViewTextBoxColumn.DataPropertyName = "IdComentario";
            this.idComentarioDataGridViewTextBoxColumn.HeaderText = "IdComentario";
            this.idComentarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idComentarioDataGridViewTextBoxColumn.Name = "idComentarioDataGridViewTextBoxColumn";
            this.idComentarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idComentarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idComentarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idComentarioDataGridViewTextBoxColumn.Visible = false;
            this.idComentarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSolicitudDataGridViewTextBoxColumn
            // 
            this.idSolicitudDataGridViewTextBoxColumn.DataPropertyName = "IdSolicitud";
            this.idSolicitudDataGridViewTextBoxColumn.HeaderText = "IdSolicitud";
            this.idSolicitudDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSolicitudDataGridViewTextBoxColumn.Name = "idSolicitudDataGridViewTextBoxColumn";
            this.idSolicitudDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSolicitudDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idSolicitudDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idSolicitudDataGridViewTextBoxColumn.Visible = false;
            this.idSolicitudDataGridViewTextBoxColumn.Width = 125;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.comentarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.comentarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.comentarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            this.fechaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaDataGridViewTextBoxColumn1.Width = 56;
            // 
            // tblComentarioBindingSource
            // 
            this.tblComentarioBindingSource.DataMember = "tblComentario";
            this.tblComentarioBindingSource.DataSource = this.conexionDB;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(588, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Comentarios de la solicitud";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Coves", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(20, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(384, 42);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Detalle de la solicitud: ";
            // 
            // dgvEstados
            // 
            this.dgvEstados.AllowUserToAddRows = false;
            this.dgvEstados.AllowUserToDeleteRows = false;
            this.dgvEstados.AllowUserToResizeColumns = false;
            this.dgvEstados.AllowUserToResizeRows = false;
            this.dgvEstados.AutoGenerateColumns = false;
            this.dgvEstados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEstadoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn3});
            this.dgvEstados.DataSource = this.estadosDeSolicitudBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstados.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEstados.Location = new System.Drawing.Point(876, 69);
            this.dgvEstados.MultiSelect = false;
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.ReadOnly = true;
            this.dgvEstados.RowHeadersVisible = false;
            this.dgvEstados.RowHeadersWidth = 51;
            this.dgvEstados.RowTemplate.Height = 24;
            this.dgvEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEstados.Size = new System.Drawing.Size(282, 177);
            this.dgvEstados.TabIndex = 12;
            // 
            // estadosDeSolicitudBindingSource
            // 
            this.estadosDeSolicitudBindingSource.DataMember = "EstadosDeSolicitud";
            this.estadosDeSolicitudBindingSource.DataSource = this.conexionDB;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(942, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 42);
            this.label12.TabIndex = 13;
            this.label12.Text = "Registro de estados\r\nde la solicitud";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AllowUserToDeleteRows = false;
            this.dgvRecursos.AllowUserToResizeColumns = false;
            this.dgvRecursos.AllowUserToResizeRows = false;
            this.dgvRecursos.AutoGenerateColumns = false;
            this.dgvRecursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tecnicoDataGridViewTextBoxColumn,
            this.recursoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn2});
            this.dgvRecursos.DataSource = this.recursosDeSolicitudBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecursos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRecursos.Location = new System.Drawing.Point(579, 474);
            this.dgvRecursos.MultiSelect = false;
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.ReadOnly = true;
            this.dgvRecursos.RowHeadersVisible = false;
            this.dgvRecursos.RowHeadersWidth = 51;
            this.dgvRecursos.RowTemplate.Height = 48;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(579, 159);
            this.dgvRecursos.TabIndex = 14;
            // 
            // tecnicoDataGridViewTextBoxColumn
            // 
            this.tecnicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tecnicoDataGridViewTextBoxColumn.DataPropertyName = "Tecnico";
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tecnicoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.tecnicoDataGridViewTextBoxColumn.HeaderText = "Técnico";
            this.tecnicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tecnicoDataGridViewTextBoxColumn.Name = "tecnicoDataGridViewTextBoxColumn";
            this.tecnicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tecnicoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tecnicoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tecnicoDataGridViewTextBoxColumn.Width = 66;
            // 
            // recursoDataGridViewTextBoxColumn
            // 
            this.recursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recursoDataGridViewTextBoxColumn.DataPropertyName = "Recurso";
            this.recursoDataGridViewTextBoxColumn.HeaderText = "Recurso";
            this.recursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recursoDataGridViewTextBoxColumn.Name = "recursoDataGridViewTextBoxColumn";
            this.recursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.recursoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.recursoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaDataGridViewTextBoxColumn2
            // 
            this.fechaDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn2.Name = "fechaDataGridViewTextBoxColumn2";
            this.fechaDataGridViewTextBoxColumn2.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaDataGridViewTextBoxColumn2.Width = 56;
            // 
            // recursosDeSolicitudBindingSource
            // 
            this.recursosDeSolicitudBindingSource.DataMember = "RecursosDeSolicitud";
            this.recursosDeSolicitudBindingSource.DataSource = this.conexionDB;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(588, 446);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 21);
            this.label14.TabIndex = 15;
            this.label14.Text = "Recursos de la solicitud";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tiposInconvenientesTableAdapter
            // 
            this.tiposInconvenientesTableAdapter.ClearBeforeFill = true;
            // 
            // prioridadesTableAdapter
            // 
            this.prioridadesTableAdapter.ClearBeforeFill = true;
            // 
            // tecnicosDeSolicitudPresentableTableAdapter
            // 
            this.tecnicosDeSolicitudPresentableTableAdapter.ClearBeforeFill = true;
            // 
            // tblComentarioTableAdapter
            // 
            this.tblComentarioTableAdapter.ClearBeforeFill = true;
            // 
            // recursosDeSolicitudTableAdapter
            // 
            this.recursosDeSolicitudTableAdapter.ClearBeforeFill = true;
            // 
            // estadosDeSolicitudTableAdapter
            // 
            this.estadosDeSolicitudTableAdapter.ClearBeforeFill = true;
            // 
            // nombreEstadoDataGridViewTextBoxColumn
            // 
            this.nombreEstadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreEstadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEstado";
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nombreEstadoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.nombreEstadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.nombreEstadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreEstadoDataGridViewTextBoxColumn.Name = "nombreEstadoDataGridViewTextBoxColumn";
            this.nombreEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEstadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreEstadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaDataGridViewTextBoxColumn3
            // 
            this.fechaDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDataGridViewTextBoxColumn3.DataPropertyName = "Fecha";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.fechaDataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn3.Name = "fechaDataGridViewTextBoxColumn3";
            this.fechaDataGridViewTextBoxColumn3.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechaDataGridViewTextBoxColumn3.Width = 56;
            // 
            // DetallarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvRecursos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvEstados);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvComentarios);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvTecnicos);
            this.Controls.Add(this.gbxSolicitud);
            this.Controls.Add(this.gbxSolicitante);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DetallarSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detallar Solicitud";
            this.Load += new System.EventHandler(this.DetallarSolicitud_Load);
            this.gbxSolicitud.ResumeLayout(false);
            this.gbxSolicitud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prioridadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposInconvenientesBindingSource)).EndInit();
            this.gbxSolicitante.ResumeLayout(false);
            this.gbxSolicitante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicosDeSolicitudPresentableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblComentarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosDeSolicitudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosDeSolicitudBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox cbxPrivada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantAfectados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoInconveniente;
        private System.Windows.Forms.GroupBox gbxSolicitante;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTecnicos;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvComentarios;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.Label label14;
        private conexionDB conexionDB;
        private System.Windows.Forms.BindingSource tiposInconvenientesBindingSource;
        private conexionDBTableAdapters.TiposInconvenientesTableAdapter tiposInconvenientesTableAdapter;
        private System.Windows.Forms.BindingSource prioridadesBindingSource;
        private conexionDBTableAdapters.PrioridadesTableAdapter prioridadesTableAdapter;
        private System.Windows.Forms.BindingSource tecnicosDeSolicitudPresentableBindingSource;
        private conexionDBTableAdapters.TecnicosDeSolicitudPresentableTableAdapter tecnicosDeSolicitudPresentableTableAdapter;
        private System.Windows.Forms.BindingSource tblComentarioBindingSource;
        private conexionDBTableAdapters.tblComentarioTableAdapter tblComentarioTableAdapter;
        private System.Windows.Forms.BindingSource recursosDeSolicitudBindingSource;
        private conexionDBTableAdapters.RecursosDeSolicitudTableAdapter recursosDeSolicitudTableAdapter;
        private System.Windows.Forms.BindingSource estadosDeSolicitudBindingSource;
        private conexionDBTableAdapters.EstadosDeSolicitudTableAdapter estadosDeSolicitudTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSolicitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn3;
    }
}