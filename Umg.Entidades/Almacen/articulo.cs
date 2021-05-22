using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Almacen
{
   public  class articulo
    {
        public int idArticulo { get; set; }

        public int idCodigoArticulo { get; set; } // llave foranea

        public int idCategoria { get; set; } // llave foranea

        public String nombreArticulo { get; set; }

        public String descripcionArticulo { get; set; }

        public bool condicionArticulo { get; set; }




    }
}
