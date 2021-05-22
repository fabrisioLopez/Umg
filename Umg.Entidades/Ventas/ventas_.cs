using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Ventas
{
   public class ventas_
    {
        public int idVenta_ { get; set; }

        public int idVenta { get; set; }

        public String tipoComprobanteVenta { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        public bool condicionVenta { get; set; }
    }
}
