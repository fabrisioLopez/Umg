using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Almacen;

namespace Umg.Entidades.Ventas
{
 public  class detalleIngreso
    {
        public int idDetalleIngreso { get; set; }

        public int idIngreso { get; set; } //f

        public int idArticulo { get; set; } //f

        public int cantidadDetalleIngreso { get; set; }
        [required]

        public decimal precioDetalleIngreso { get; set; }
        [required]
    }
}
