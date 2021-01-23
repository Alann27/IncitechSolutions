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
    public partial class Login : Form
    {
        Usuario usuario = new Usuario();
        public Login()
        {
            InitializeComponent();

        }

        private void btnIniciar_Click(object sender, EventArgs e)//metodo que se ejecuta cuando se le da click al boton Iniciar
        {
            if (txtUsuario.Text != "" && txtContrasena.Text != "") //verifica que hayan datos ingresados en los textbox usuario y contrasena
            {
                LoginConEmpleadoTableAdapter loginAdapter = new LoginConEmpleadoTableAdapter();
                LoginConEmpleadoDataTable loginData = loginAdapter.LoginConEmpleado(txtUsuario.Text.Trim());

                if (loginData.Rows.Count == 1)
                {

                    if (txtContrasena.Text == loginData[0][loginData.ContrasenaColumn].ToString())
                    {
                        usuario.Nombre = loginData[0][loginData.NombreColumn].ToString(); ;
                        usuario.Apellidos = loginData[0][loginData.ApellidosColumn].ToString();
                        usuario.IdEmpleado = Convert.ToInt32(loginData[0][loginData.IdEmpleadoColumn].ToString());
                        usuario.IdDepartamento = Convert.ToInt32(loginData[0][loginData.IdDepartamentoColumn].ToString());
                        usuario.Telefono = loginData[0][loginData.TelefonoColumn].ToString();
                        usuario.Correo = loginData[0][loginData.CorreoColumn].ToString();
                        usuario.Departamento = loginData[0][loginData.DepartamentoColumn].ToString();

                        MessageBox.Show("Ha iniciado sesión correctamente.\n\n ¡Bienvenido!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu frmMenu = new Menu(usuario, txtUsuario.Text.Trim());

                        this.Hide();
                        frmMenu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario y/o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de usuario y/o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else //Si hay uno de los textbox usuario y contrasena vacios
            {
                string mensaje = "Faltan los siguientes campos por llenar:\n\n"; //es el mensaje inicial

                if (txtUsuario.Text == "")//verifica si el textbox Usuario está vacío
                {
                    mensaje += "    - Nombre de usuario\n";//agrega al mensaje que el nombre de usuario no se ha ingresado
                }
                if (txtContrasena.Text == "")//verifica si el textbox Contrasena está vacío
                {
                    mensaje += "    - Contraseña\n";//agrega al mensaje que la contrasena no se ha ingresado
                }

                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//muestra el mensaje al usuario notificandole lo que falta por ingresar
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e) // Este metodo se ejecuta cada vez que se presiona una tecla estando el txtUsuario en focus, se ejecuta antes de proceder a mostrar en el txt la tecla presionada        
        {
            try //para que cuando haya un error no explote el programa
            {
                if (!(char.IsLetter(e.KeyChar)) && //verifica si no la tecla presionada no es una letra, un numero, la barra de espacio, backspace (borrar), un guion (-), una raya baja (_) o un punto (.)
                   (!(char.IsNumber(e.KeyChar))) &&
                   (e.KeyChar != (char)Keys.Back) &&
                   (e.KeyChar != (char)Keys.Space) &&
                   (e.KeyChar != '-') &&
                   (e.KeyChar != '_') &&
                   (e.KeyChar != '.'))
                {
                    e.Handled = true;//si no es una de las teclas mencionadas arriba, no se escribe en la caja de texto
                    return; //para salir del metodo
                }
            }
            catch (Exception error)// captura el error
            {
                //log.Error($"Error: {error.Message}", error);//guarda el error en los logs del software
                MessageBox.Show($"Error: {error.Message}");//muestra el mensaje del error
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)//metodo que se ejecuta cuando se le da click al boton Salir
        {
            try //para que cuando haya un error no explote el programa
            {
                this.Close(); //cierra el software
            }
            catch (Exception error)// captura el error
            {
                //log.Error($"Error: {error.Message}", error);//guarda el error en los logs del software
                MessageBox.Show($"Error: {error.Message}");//muestra el mensaje del error
            }
        }
    }
}
