using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Ventas
{
   public class ingreso
    {
        public int idIngreso { get; set; }

        public int idProveedor { get; set; }
        public int idUsuario { get; set; }

        public String tipoComprobanteIngreso { get; set; }

        public String serieComprobanteIngreso { get; set; }

        public String numComprobante { get; set; }

        public DateTime fechaHoraIngreso { get; set; }

        public decimal impuestoIngreso { get; set; }
    }
}
