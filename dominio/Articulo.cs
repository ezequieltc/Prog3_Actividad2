﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        private decimal _precio;
        public int Id {  get; set; }
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get { return _precio; } set { _precio = decimal.Round(value, 2); } }

        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }
    }
}
