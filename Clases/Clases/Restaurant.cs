using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Restaurant
    {
        public Restaurant()
        {
            nombre = "No se ingreso nombre";
            telefono = 99999999;
            ubicacion = "No se ingreso ubicación";
        }

        public Restaurant(string nombre, int telefono, string ubicacion)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.ubicacion = ubicacion;
        }

        internal string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        internal int Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        internal string Ubicacion
        {
            get
            {
                return this.ubicacion;
            }
            set
            {
                this.ubicacion = value;
            }
        }

        public string getInformacion()
        {
            return "Nombre: " + nombre + "\nTelefono: " + telefono + "\nUbicacion: " + ubicacion;
        }

        public void MostrarCodigoArea()
        {
            this.telefono = 1100000000 + telefono;
        }

        public string getMostrarSinNumero()
        {

            if (telefono == 99999999)
            {
                return "Información incompleta";
            }
            else
            {
                return "Informacion completa";
            }

        }
        private string nombre;
        private int telefono;
        private string ubicacion;
        
        }
        
    }
    
              
