
namespace InciTechSolutions
{
    partial class AgregarRecurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.tecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recursosDeSolicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexionDB = new InciTechSolutions.conexionDB();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtRecurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.recursosDeSolicitudTableAdapter = new InciTechSolutions.conexionDBTableAdapters.RecursosDeSolicitudTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosDeSolicitudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tecnicoDataGridViewTextBoxColumn,
            this.recursoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgvRecursos.DataSource = this.recursosDeSolicitudBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecursos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecursos.Location = new System.Drawing.Point(23, 141);
            this.dgvRecursos.MultiSelect = false;
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.ReadOnly = true;
            this.dgvRecursos.RowHeadersVisible = false;
            this.dgvRecursos.RowHeadersWidth = 51;
            this.dgvRecursos.RowTemplate.Height = 48;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(579, 159);
            this.dgvRecursos.TabIndex = 15;
            this.dgvRecursos.TabStop = false;
            // 
            // tecnicoDataGridViewTextBoxColumn
            // 
            this.tecnicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tecnicoDataGridViewTextBoxColumn.DataPropertyName = "Tecnico";
            this.tecnicoDataGridViewTextBoxColumn.HeaderText = "Tecnico";
            this.tecnicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tecnicoDataGridViewTextBoxColumn.Name = "tecnicoDataGridViewTextBoxColumn";
            this.tecnicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tecnicoDataGridViewTextBoxColumn.Width = 89;
            // 
            // recursoDataGridViewTextBoxColumn
            // 
            this.recursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recursoDataGridViewTextBoxColumn.DataPropertyName = "Recurso";
            this.recursoDataGridViewTextBoxColumn.HeaderText = "Recurso";
            this.recursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recursoDataGridViewTextBoxColumn.Name = "recursoDataGridViewTextBoxColumn";
            this.recursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 79;
            // 
            // recursosDeSolicitudBindingSource
            // 
            this.recursosDeSolicitudBindingSource.DataMember = "RecursosDeSolicitud";
            this.recursosDeSolicitudBindingSource.DataSource = this.conexionDB;
            // 
            // conexionDB
            // 
            this.conexionDB.DataSetName = "conexionDB";
            this.conexionDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Coves", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Agregar Recurso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Coves", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Recursos utilizados actualmente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.btnRegresar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtRecurso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Coves", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(23, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar nuevo recurso";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnRegresar.Location = new System.Drawing.Point(434, 171);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(102, 36);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnLimpiar.Location = new System.Drawing.Point(238, 171);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 36);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnAgregar.Location = new System.Drawing.Point(42, 171);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 36);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtRecurso
            // 
            this.txtRecurso.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtRecurso.Location = new System.Drawing.Point(16, 63);
            this.txtRecurso.Multiline = true;
            this.txtRecurso.Name = "txtRecurso";
            this.txtRecurso.Size = new System.Drawing.Size(550, 92);
            this.txtRecurso.TabIndex = 0;
            this.txtRecurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecurso_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Recurso";
            // 
            // recursosDeSolicitudTableAdapter
            // 
            this.recursosDeSolicitudTableAdapter.ClearBeforeFill = true;
            // 
            // AgregarRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(627, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRecursos);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarRecurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Recurso";
            this.Load += new System.EventHandler(this.AgregarRecurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosDeSolicitudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtRecurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource recursosDeSolicitudBindingSource;
        private conexionDB conexionDB;
        private conexionDBTableAdapters.RecursosDeSolicitudTableAdapter recursosDeSolicitudTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}