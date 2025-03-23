using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public abstract class Persona
    {

        // ATRIBUTOS
        private string _apellido;
        private DateTime _fechaNac;
        private string _nombre;

        //PROPIEDADES - Lo que te permite esta capa es tener una manipulación sobre el acceso de los atributos.
        protected string Apellido { get => _apellido; set => _apellido = value; }
        protected DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        protected string Nombre { get => _nombre; set => _nombre = value; }

        // Firma de un metodo y sus componentes
        protected abstract void GetCredencial();

        protected virtual void GetNombreCompleto()
        {

        }
        protected void GetSaludoInformal()
        {

        }


    }

}



