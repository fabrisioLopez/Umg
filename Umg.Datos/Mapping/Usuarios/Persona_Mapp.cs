using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
   public class Persona_Mapp
    {

        public void Configure(EntityTypeBuilder<persona_> builder)
        {
            builder.ToTable("persona_")
                  .HasKey(pe => pe.idPersona_);
            builder.Property(pe => pe.idPersona );

            builder.Property(pe => pe.tipoDePersona)
                .HasMaxLength(50);
            builder.Property(pe => pe.tipoDocumento)
                .HasMaxLength(3);
            builder.Property(pe => pe.direccion)
               .HasMaxLength(50);


        }
    }
}

