using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Ventas
{
   public class detalleVenta
    {
        public int idDetalleVenta { get; set; }

        public int idArticulo { get; set; } //forenea

        public int idVenta { get; set; } // forenea

        public String cantidadVentas { get; set; }
    }
}
