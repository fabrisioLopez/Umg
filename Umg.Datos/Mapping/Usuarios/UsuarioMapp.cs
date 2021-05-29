using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
   public class UsuarioMapp
    {
        public void Configure(EntityTypeBuilder<usuario> builder)
        {
            builder.ToTable("usuario")
                  .HasKey(u => u.idUsuario);

            builder.Property(u => u.idRol);

            builder.Property(u => u.idTelefono);

            builder.Property(u => u.nombreUsuario)
                .HasMaxLength(100);

            builder.Property(u => u.emailUsuario)
               .HasMaxLength(70);

            builder.Property(u => u.passwordHash);

            builder.Property(u => u.passwordSalt);


        }
    }
}