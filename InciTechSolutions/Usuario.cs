using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciTechSolutions
{
    public class Usuario
    {
        private int idEmpleado;
        private string nombre;
        private string apellidos;
        private int idDepartamento;
        private string departamento;
        private string telefono;
        private string correo;


        public int IdEmpleado
        {
            get { return this.idEmpleado; }
            set { this.idEmpleado = value; }
        }

        public int IdDepartamento
        {
            get { return this.idDepartamento; }
            set { this.idDepartamento = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellidos
        {
            get { return this.apellidos; }
            set { this.apellidos = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }

        public string Departamento
        {
            get { return this.departamento; }
            set { this.departamento = value; }
        }
    }
}
