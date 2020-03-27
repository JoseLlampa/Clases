using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Futbolista
    {
        internal string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        internal int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        internal string Nacionalidad
        {
            get
            {
                return nacionalidad;
            }
            set
            {
                nacionalidad = value;
            }
        }

        internal string Club
        {
            get
            {
                return club;
            }
            set
            {
                club = value;
            }
        } 

        private string nombre;
        private int edad;
        private string nacionalidad;
        private string club;
    }
}
