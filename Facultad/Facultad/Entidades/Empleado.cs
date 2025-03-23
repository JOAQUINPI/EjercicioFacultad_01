using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public class Empleado : Persona
    {
        //ATRIBUTOS
        private DateTime _fechaIngreso;
        private int _legajo;

        // Propiedades
        protected DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        protected int Legajo { get => _legajo; set => _legajo = value; }

        // PROPERTIES HEREDADAS
        public DateTime FechaNacimiento { get => FechaNac; set => FechaNac = value; }

        // PROPERTIES CUSTOM
        public int Antiguedad { get => (DateTime.Now - _fechaIngreso).Days / 365; }

        // METODOS
        protected override void GetCredencial()
        {

        }

    }
}
