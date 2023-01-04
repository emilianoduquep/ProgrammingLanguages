using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.clases
{
    internal class Persona
    {
        private string nombreCompleto;
        private int id;

        protected List<Curso> ListaCursosGeneral = new List<Curso>();
        
        

        public Persona(string nombreCompleto, int id)
        {
            this.nombreCompleto= nombreCompleto;
            this.id = id;   
        }

        public string NombreCompleto
        {
            get { return this.nombreCompleto; }
            set { this.nombreCompleto = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public override string ToString()
        {
            return "Persona {" + "Nombre Completo: " + this.nombreCompleto + "Id: " + this.id + "}";
        }
    }
}
