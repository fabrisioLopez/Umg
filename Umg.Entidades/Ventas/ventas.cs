using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Ventas
{
  public  class ventas
    {
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public int idPersona { get; set; }

        public String serieComprobanteVenta { get; set; }

        public DateTime fechaHora { get; set; }
    }
}
