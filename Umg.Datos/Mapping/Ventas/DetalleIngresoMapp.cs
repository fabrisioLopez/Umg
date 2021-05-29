using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
  public  class DetalleIngresoMapp
    {

        public void Configure(EntityTypeBuilder<detalleIngreso> builder)
        {
            builder.ToTable("detalleIngreso")
                  .HasKey(d => d.idDetalleIngreso);
            builder.Property(d => d.idIngreso);

            builder.Property(d => d.idArticulo);

            builder.Property(d => d.cantidadDetalleIngreso);
            builder.Property(d => d.precioDetalleIngreso);
        }
    }
}