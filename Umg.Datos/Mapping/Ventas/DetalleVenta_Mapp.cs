using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
   public class DetalleVenta_Mapp
    {

        public void Configure(EntityTypeBuilder<Detalleventa_> builder)
        {
            builder.ToTable("Detalleventa_")
                  .HasKey(det => det.idDetalleventa_);
            builder.Property(det => det.idDetalleVenta);

            builder.Property(det => det.precioVenta);

            builder.Property(det => det.descuentoVenta);

        }
    }
}