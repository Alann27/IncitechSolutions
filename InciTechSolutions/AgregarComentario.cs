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
    public partial class AgregarComentario : Form
    {
        private int idSolicitud=0;
        private bool cancelarFinalizacion = false;
        public AgregarComentario(string Codigo, int IdSolicitud)
        {
            InitializeComponent();
            lblCodigo.Text = Codigo;
            idSolicitud = IdSolicitud;
        }
        public AgregarComentario(string Codigo, int IdSolicitud, bool CancelarFinalizacion)
        {
            InitializeComponent();
            lblCodigo.Text = Codigo;
            idSolicitud = IdSolicitud;
            cancelarFinalizacion = CancelarFinalizacion;
        }

        private void btnAgregarComentario_Click(object sender, EventArgs e)
        {
            if (txtComentario.Text !="")
            {

                tblComentarioTableAdapter comentarioAdapter = new tblComentarioTableAdapter();
                comentarioAdapter.InsertarComentario(idSolicitud, txtComentario.Text.Trim(), cancelarFinalizacion);

                MessageBox.Show("Comentario añadido correctamente", "Comentario agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cancelarFinalizacion == true)
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                    
                }
                txtComentario.Text = "";
                txtComentario.Focus();
            }
            else
            {
                MessageBox.Show("Debe ingresar el comentario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtComentario.Text = "";
            txtComentario.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
