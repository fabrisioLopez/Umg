using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Almacen;

namespace Umg.Datos.Mapping.Almacen
{
  public  class articulo_Mapp
    {
        public void Configure(EntityTypeBuilder<articulo_> builder)
        {
            builder.ToTable("articulo_")
                  .HasKey(ar => ar.idCodigoArticulo);
            


        }
    }
}
