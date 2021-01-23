
namespace InciTechSolutions
{
    partial class BusquedaPersonalizad
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboInconveniente = new System.Windows.Forms.ComboBox();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboPrivada = new System.Windows.Forms.ComboBox();
            this.cboAfectados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxDepartamento = new System.Windows.Forms.CheckBox();
            this.cbxPrioridad = new System.Windows.Forms.CheckBox();
            this.cbxPrivada = new System.Windows.Forms.CheckBox();
            this.cbxInconveniente = new System.Windows.Forms.CheckBox();
            this.cbxAfectados = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.conexionDB = new InciTechSolutions.conexionDB();
            this.tblDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDepartamentoTableAdapter = new InciTechSolutions.conexionDBTableAdapters.tblDepartamentoTableAdapter();
            this.tiposInconvenientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposInconvenientesTableAdapter = new InciTechSolutions.conexionDBTableAdapters.TiposInconvenientesTableAdapter();
            this.prioridadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prioridadesTableAdapter = new InciTechSolutions.conexionDBTableAdapters.PrioridadesTableAdapter();
            this.dptFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dptFechaFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.conexionDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposInconvenientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioridadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Coves", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda personalizada";
            // 
            // cboInconveniente
            // 
            this.cboInconveniente.DataSource = this.tiposInconvenientesBindingSource;
            this.cboInconveniente.DisplayMember = "TipoInconveniente";
            this.cboInconveniente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInconveniente.FormattingEnabled = true;
            this.cboInconveniente.Location = new System.Drawing.Point(31, 215);
            this.cboInconveniente.Name = "cboInconveniente";
            this.cboInconveniente.Size = new System.Drawing.Size(199, 29);
            this.cboInconveniente.TabIndex = 1;
            this.cboInconveniente.ValueMember = "IdTipoInconveniente";
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.DataSource = this.prioridadesBindingSource;
            this.cboPrioridad.DisplayMember = "Descripcion";
            this.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Location = new System.Drawing.Point(288, 135);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(205, 29);
            this.cboPrioridad.TabIndex = 2;
            this.cboPrioridad.ValueMember = "IdPrioridad";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DataSource = this.tblDepartamentoBindingSource;
            this.cboDepartamento.DisplayMember = "NombreDepartamento";
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.Enabled = false;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(31, 135);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(199, 29);
            this.cboDepartamento.TabIndex = 3;
            this.cboDepartamento.ValueMember = "IdDepartamento";
            // 
            // cboPrivada
            // 
            this.cboPrivada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrivada.FormattingEnabled = true;
            this.cboPrivada.Items.AddRange(new object[] {
            "No",
            "Sí"});
            this.cboPrivada.Location = new System.Drawing.Point(288, 215);
            this.cboPrivada.Name = "cboPrivada";
            this.cboPrivada.Size = new System.Drawing.Size(205, 29);
            this.cboPrivada.TabIndex = 4;
            // 
            // cboAfectados
            // 
            this.cboAfectados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAfectados.FormattingEnabled = true;
            this.cboAfectados.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboAfectados.Location = new System.Drawing.Point(31, 298);
            this.cboAfectados.Name = "cboAfectados";
            this.cboAfectados.Size = new System.Drawing.Size(205, 29);
            this.cboAfectados.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inconveniente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prioridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Privada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "# de Afectados";
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.AutoSize = true;
            this.cbxDepartamento.Enabled = false;
            this.cbxDepartamento.Location = new System.Drawing.Point(158, 104);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(72, 25);
            this.cbxDepartamento.TabIndex = 11;
            this.cbxDepartamento.Text = "Todos";
            this.cbxDepartamento.UseVisualStyleBackColor = true;
            this.cbxDepartamento.CheckedChanged += new System.EventHandler(this.cbxDepartamento_CheckedChanged);
            // 
            // cbxPrioridad
            // 
            this.cbxPrioridad.AutoSize = true;
            this.cbxPrioridad.Location = new System.Drawing.Point(421, 104);
            this.cbxPrioridad.Name = "cbxPrioridad";
            this.cbxPrioridad.Size = new System.Drawing.Size(72, 25);
            this.cbxPrioridad.TabIndex = 12;
            this.cbxPrioridad.Text = "Todos";
            this.cbxPrioridad.UseVisualStyleBackColor = true;
            this.cbxPrioridad.CheckedChanged += new System.EventHandler(this.cbxPrioridad_CheckedChanged);
            // 
            // cbxPrivada
            // 
            this.cbxPrivada.AutoSize = true;
            this.cbxPrivada.Location = new System.Drawing.Point(421, 184);
            this.cbxPrivada.Name = "cbxPrivada";
            this.cbxPrivada.Size = new System.Drawing.Size(72, 25);
            this.cbxPrivada.TabIndex = 13;
            this.cbxPrivada.Text = "Todos";
            this.cbxPrivada.UseVisualStyleBackColor = true;
            this.cbxPrivada.CheckedChanged += new System.EventHandler(this.cbxPrivada_CheckedChanged);
            // 
            // cbxInconveniente
            // 
            this.cbxInconveniente.AutoSize = true;
            this.cbxInconveniente.Location = new System.Drawing.Point(158, 187);
            this.cbxInconveniente.Name = "cbxInconveniente";
            this.cbxInconveniente.Size = new System.Drawing.Size(72, 25);
            this.cbxInconveniente.TabIndex = 14;
            this.cbxInconveniente.Text = "Todos";
            this.cbxInconveniente.UseVisualStyleBackColor = true;
            this.cbxInconveniente.CheckedChanged += new System.EventHandler(this.cbxInconveniente_CheckedChanged);
            // 
            // cbxAfectados
            // 
            this.cbxAfectados.AutoSize = true;
            this.cbxAfectados.Location = new System.Drawing.Point(164, 267);
            this.cbxAfectados.Name = "cbxAfectados";
            this.cbxAfectados.Size = new System.Drawing.Size(72, 25);
            this.cbxAfectados.TabIndex = 15;
            this.cbxAfectados.Text = "Todos";
            this.cbxAfectados.UseVisualStyleBackColor = true;
            this.cbxAfectados.CheckedChanged += new System.EventHandler(this.cbxAfectados_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(264, 347);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 53);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(387, 347);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(106, 53);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // conexionDB
            // 
            this.conexionDB.DataSetName = "conexionDB";
            this.conexionDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepartamentoBindingSource
            // 
            this.tblDepartamentoBindingSource.DataMember = "tblDepartamento";
            this.tblDepartamentoBindingSource.DataSource = this.conexionDB;
            // 
            // tblDepartamentoTableAdapter
            // 
            this.tblDepartamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tiposInconvenientesBindingSource
            // 
            this.tiposInconvenientesBindingSource.DataMember = "TiposInconvenientes";
            this.tiposInconvenientesBindingSource.DataSource = this.conexionDB;
            // 
            // tiposInconvenientesTableAdapter
            // 
            this.tiposInconvenientesTableAdapter.ClearBeforeFill = true;
            // 
            // prioridadesBindingSource
            // 
            this.prioridadesBindingSource.DataMember = "Prioridades";
            this.prioridadesBindingSource.DataSource = this.conexionDB;
            // 
            // prioridadesTableAdapter
            // 
            this.prioridadesTableAdapter.ClearBeforeFill = true;
            // 
            // dptFechaInicio
            // 
            this.dptFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptFechaInicio.Location = new System.Drawing.Point(288, 298);
            this.dptFechaInicio.Name = "dptFechaInicio";
            this.dptFechaInicio.Size = new System.Drawing.Size(205, 28);
            this.dptFechaInicio.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha de Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha Final";
            // 
            // dptFechaFinal
            // 
            this.dptFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptFechaFinal.Location = new System.Drawing.Point(31, 372);
            this.dptFechaFinal.Name = "dptFechaFinal";
            this.dptFechaFinal.Size = new System.Drawing.Size(205, 28);
            this.dptFechaFinal.TabIndex = 20;
            // 
            // BusquedaPersonalizad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(528, 428);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dptFechaFinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dptFechaInicio);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxAfectados);
            this.Controls.Add(this.cbxInconveniente);
            this.Controls.Add(this.cbxPrivada);
            this.Controls.Add(this.cbxPrioridad);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAfectados);
            this.Controls.Add(this.cboPrivada);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.cboPrioridad);
            this.Controls.Add(this.cboInconveniente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusquedaPersonalizad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Personalizada";
            this.Load += new System.EventHandler(this.BusquedaPersonalizad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conexionDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposInconvenientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioridadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboInconveniente;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboPrivada;
        private System.Windows.Forms.ComboBox cboAfectados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxDepartamento;
        private System.Windows.Forms.CheckBox cbxPrioridad;
        private System.Windows.Forms.CheckBox cbxPrivada;
        private System.Windows.Forms.CheckBox cbxInconveniente;
        private System.Windows.Forms.CheckBox cbxAfectados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegresar;
        private conexionDB conexionDB;
        private System.Windows.Forms.BindingSource tblDepartamentoBindingSource;
        private conexionDBTableAdapters.tblDepartamentoTableAdapter tblDepartamentoTableAdapter;
        private System.Windows.Forms.BindingSource tiposInconvenientesBindingSource;
        private conexionDBTableAdapters.TiposInconvenientesTableAdapter tiposInconvenientesTableAdapter;
        private System.Windows.Forms.BindingSource prioridadesBindingSource;
        private conexionDBTableAdapters.PrioridadesTableAdapter prioridadesTableAdapter;
        public System.Windows.Forms.DateTimePicker dptFechaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dptFechaFinal;
    }
}