using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Alumno
    {
        // ATRIBUTOS
        private int _codigo;

        // PROPIEDADES
        public int Codigo { get => _codigo; set => _codigo = value; }

        // METODOS
        public override string GetCredencial()
        {
            return string.Format("Código {0}) {1}, {2}", this._codigo, this.Apellido, this.Nombre);
        }

        public string toString()
        {
            return GetCredencial();
        }
    }
}
