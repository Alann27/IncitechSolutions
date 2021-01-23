
namespace InciTechSolutions
{
    partial class AgregarSolicitud
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoInconveniente = new System.Windows.Forms.ComboBox();
            this.tiposInconvenientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexionDB1 = new InciTechSolutions.conexionDB();
            this.txtCantAfectados = new System.Windows.Forms.TextBox();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.prioridadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexionDB = new InciTechSolutions.conexionDB();
            this.cbxPrivada = new System.Windows.Forms.CheckBox();
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
            this.gbxSolicitud = new System.Windows.Forms.GroupBox();
            this.btnAyudaPrioridad = new System.Windows.Forms.Button();
            this.btnAgregarSolicitud = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.prioridadesTableAdapter = new InciTechSolutions.conexionDBTableAdapters.PrioridadesTableAdapter();
            this.tiposInconvenientesTableAdapter = new InciTechSolutions.conexionDBTableAdapters.TiposInconvenientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tiposInconvenientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioridadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionDB)).BeginInit();
            this.gbxSolicitante.SuspendLayout();
            this.gbxSolicitud.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(17, 57);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(509, 81);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de inconveniente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de afectados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prioridad";
            // 
            // cboTipoInconveniente
            // 
            this.cboTipoInconveniente.DataSource = this.tiposInconvenientesBindingSource;
            this.cboTipoInconveniente.DisplayMember = "TipoInconveniente";
            this.cboTipoInconveniente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoInconveniente.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoInconveniente.FormattingEnabled = true;
            this.cboTipoInconveniente.Location = new System.Drawing.Point(17, 180);
            this.cboTipoInconveniente.Name = "cboTipoInconveniente";
            this.cboTipoInconveniente.Size = new System.Drawing.Size(284, 29);
            this.cboTipoInconveniente.TabIndex = 1;
            this.cboTipoInconveniente.ValueMember = "IdTipoInconveniente";
            // 
            // tiposInconvenientesBindingSource
            // 
            this.tiposInconvenientesBindingSource.DataMember = "TiposInconvenientes";
            this.tiposInconvenientesBindingSource.DataSource = this.conexionDB1;
            // 
            // conexionDB1
            // 
            this.conexionDB1.DataSetName = "conexionDB";
            this.conexionDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCantAfectados
            // 
            this.txtCantAfectados.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantAfectados.Location = new System.Drawing.Point(194, 229);
            this.txtCantAfectados.Name = "txtCantAfectados";
            this.txtCantAfectados.Size = new System.Drawing.Size(193, 28);
            this.txtCantAfectados.TabIndex = 3;
            this.txtCantAfectados.Text = "1";
            this.txtCantAfectados.TextChanged += new System.EventHandler(this.txtCantAfectados_TextChanged);
            this.txtCantAfectados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantAfectados_KeyPress);
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.DataSource = this.prioridadesBindingSource;
            this.cboPrioridad.DisplayMember = "Descripcion";
            this.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridad.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Location = new System.Drawing.Point(330, 180);
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
            // cbxPrivada
            // 
            this.cbxPrivada.AutoSize = true;
            this.cbxPrivada.Location = new System.Drawing.Point(413, 229);
            this.cbxPrivada.Name = "cbxPrivada";
            this.cbxPrivada.Size = new System.Drawing.Size(84, 25);
            this.cbxPrivada.TabIndex = 4;
            this.cbxPrivada.Text = "Privada";
            this.cbxPrivada.UseVisualStyleBackColor = true;
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
            this.gbxSolicitante.Location = new System.Drawing.Point(12, 75);
            this.gbxSolicitante.Name = "gbxSolicitante";
            this.gbxSolicitante.Size = new System.Drawing.Size(544, 209);
            this.gbxSolicitante.TabIndex = 1000;
            this.gbxSolicitante.TabStop = false;
            this.gbxSolicitante.Text = "Información de solicitante";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.LightGray;
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
            this.txtCorreo.BackColor = System.Drawing.Color.LightGray;
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
            this.txtDepartamento.BackColor = System.Drawing.Color.LightGray;
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
            this.txtApellidos.BackColor = System.Drawing.Color.LightGray;
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
            this.txtNombre.BackColor = System.Drawing.Color.LightGray;
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
            // gbxSolicitud
            // 
            this.gbxSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(213)))));
            this.gbxSolicitud.Controls.Add(this.btnAyudaPrioridad);
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
            this.gbxSolicitud.Location = new System.Drawing.Point(12, 292);
            this.gbxSolicitud.Name = "gbxSolicitud";
            this.gbxSolicitud.Size = new System.Drawing.Size(544, 282);
            this.gbxSolicitud.TabIndex = 0;
            this.gbxSolicitud.TabStop = false;
            this.gbxSolicitud.Text = "Información de la solicitud";
            // 
            // btnAyudaPrioridad
            // 
            this.btnAyudaPrioridad.Image = global::InciTechSolutions.Properties.Resources.Help;
            this.btnAyudaPrioridad.Location = new System.Drawing.Point(401, 144);
            this.btnAyudaPrioridad.Name = "btnAyudaPrioridad";
            this.btnAyudaPrioridad.Size = new System.Drawing.Size(35, 35);
            this.btnAyudaPrioridad.TabIndex = 5;
            this.btnAyudaPrioridad.UseVisualStyleBackColor = true;
            this.btnAyudaPrioridad.Click += new System.EventHandler(this.btnAyudaPrioridad_Click);
            // 
            // btnAgregarSolicitud
            // 
            this.btnAgregarSolicitud.Location = new System.Drawing.Point(47, 592);
            this.btnAgregarSolicitud.Name = "btnAgregarSolicitud";
            this.btnAgregarSolicitud.Size = new System.Drawing.Size(134, 51);
            this.btnAgregarSolicitud.TabIndex = 1;
            this.btnAgregarSolicitud.Text = "Agregar";
            this.btnAgregarSolicitud.UseVisualStyleBackColor = true;
            this.btnAgregarSolicitud.Click += new System.EventHandler(this.btnAgregarSolicitud_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(221, 592);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 51);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(385, 592);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(134, 51);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Coves", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(159, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 35);
            this.label10.TabIndex = 14;
            this.label10.Text = "Agregar Solicitud";
            // 
            // prioridadesTableAdapter
            // 
            this.prioridadesTableAdapter.ClearBeforeFill = true;
            // 
            // tiposInconvenientesTableAdapter
            // 
            this.tiposInconvenientesTableAdapter.ClearBeforeFill = true;
            // 
            // AgregarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(571, 657);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregarSolicitud);
            this.Controls.Add(this.gbxSolicitud);
            this.Controls.Add(this.gbxSolicitante);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AgregarSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Solicitud";
            this.Load += new System.EventHandler(this.AgregarSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiposInconvenientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioridadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionDB)).EndInit();
            this.gbxSolicitante.ResumeLayout(false);
            this.gbxSolicitante.PerformLayout();
            this.gbxSolicitud.ResumeLayout(false);
            this.gbxSolicitud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoInconveniente;
        private System.Windows.Forms.TextBox txtCantAfectados;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.CheckBox cbxPrivada;
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
        private System.Windows.Forms.GroupBox gbxSolicitud;
        private System.Windows.Forms.Button btnAgregarSolicitud;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label10;
        private conexionDB conexionDB;
        private System.Windows.Forms.BindingSource prioridadesBindingSource;
        private conexionDBTableAdapters.PrioridadesTableAdapter prioridadesTableAdapter;
        private conexionDB conexionDB1;
        private System.Windows.Forms.BindingSource tiposInconvenientesBindingSource;
        private conexionDBTableAdapters.TiposInconvenientesTableAdapter tiposInconvenientesTableAdapter;
        private System.Windows.Forms.Button btnAyudaPrioridad;
    }
}