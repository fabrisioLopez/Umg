using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
   public class Telefono_Mapp
    {

        public void Configure(EntityTypeBuilder<telefono_> builder)
        {
            builder.ToTable("telefono_")
                  .HasKey(t => t.idTelefono);
            builder.Property(t => t.idPersona);
                
            builder.Property(t => t.telefonoPersonal)
                .HasMaxLength(8);
            builder.Property(t => t.telefonoCasa)
                 .HasMaxLength(8);
            builder.Property(t => t.telefonoLaboral)
              .HasMaxLength(8);

        }
    }
}