using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
   public class Ingreso_Mapp
    {

        public void Configure(EntityTypeBuilder<ingreso_> builder)
        {
            builder.ToTable("ingreso_")

                  .HasKey(i => i.idIngreso_);

            builder.Property(i => i.idIngreso);


            builder.Property(i => i.totalIngreso);

            builder.Property(i => i.condicion);



        }
    }
}