using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
   public class PersonaMapp
    {

        public void Configure(EntityTypeBuilder<persona> builder)
        {
            builder.ToTable("persona")
                  .HasKey(p => p.idPersona);
            builder.Property(p => p.nombrePersona)
                .HasMaxLength(50);
            builder.Property(p => p.emailPersona)
                .HasMaxLength(50);


        }
    }
}

    }
}
