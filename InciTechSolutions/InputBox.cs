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
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {

        }

        public SolicitudReporteDataTable solicitudData;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                SolicitudReporteTableAdapter solicitudAdapter = new SolicitudReporteTableAdapter();
                solicitudData = solicitudAdapter.SolicitudReporte(txtCodigo.Text.ToUpper());

                if (solicitudData.Rows.Count == 1)
                {
                    lblNombreSolicitante.Text = solicitudData.Rows[0][solicitudData.SolicitanteColumn].ToString();
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Solicitud no encontrada","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Text = "";
                    txtCodigo.Focus();
                }
            }
        }
    }
}
