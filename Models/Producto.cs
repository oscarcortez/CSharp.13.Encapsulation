using System;

namespace Models
{
    public class Producto
    {
        private string _nombre;
        public string Descripcion { get; set; }

        //public string Nombre
        //{
        //    get { return _nombre; }
        //    set { _nombre = value; }
        //}

        public string GetNombre()
        {
            return _nombre;
        }

        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }
    }
}
