﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
   public class RolMapp
    {

        public void Configure(EntityTypeBuilder<rol> builder)
        {
            builder.ToTable("rol")
                  .HasKey(r => r.idRol);
            builder.Property(r => r.nombreRol)
                .HasMaxLength(50);
            builder.Property(r => r.descripcionRol)
                .HasMaxLength(100);


        }
    }
}
