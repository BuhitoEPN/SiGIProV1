namespace SiGIProV1.Modelo
{
    class Proveedor
    {
        private string ruc;
        private string nombre;
        private string direccion;
        private string telefono;
        private string estado;
        private string correo;

        public Proveedor(string ruc, string nombre, string direccion, string telefono, string estado, string correo)
        {
            this.ruc = ruc;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.estado = estado;
            this.correo =   correo;
        }

        public Proveedor() { }

        public string Ruc
        {
            get
            {
                return ruc;
            }
            set
            {
                ruc = value;
            }
        }

        public string Nombre
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

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }
            set
            {
                correo = value;
            }
        }
    }
}
