using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Almacen;

namespace Umg.Datos.Mapping.Almacen
{
   public class ArticuloMapp  :IEntityTypeConfigution<articulo>
    {
        public void Configure(EntityTypeBuilder<articulo> builder)
        {
            builder.ToTable ("articulo")
                  .HasKey(a => a.idArticulo);

            builder.Property(a => a.idCodigoArticulo);
                
            builder.Property(a => a.nombreArticulo )
                .HasMaxLength(50);
            builder.Property(a => a.descripcionArticulo)
                .HasMaxLength(256);


        }
    }
}
