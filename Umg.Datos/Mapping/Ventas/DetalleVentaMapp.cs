using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
  public  class DetalleVentaMapp
    {

        public void Configure(EntityTypeBuilder<detalleVenta> builder)
        {
            builder.ToTable("detalleVenta")
                  .HasKey(de => de.idDetalleVenta);
            builder.Property(de => de.idArticulo);

            builder.Property(de => de.idVenta);

            builder.Property(de => de.cantidadVentas)
              .HasMaxLength(10);
        }
    }
}
