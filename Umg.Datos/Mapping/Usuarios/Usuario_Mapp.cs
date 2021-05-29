using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
    public class Usuario_Mapp
    {
        public void Configure(EntityTypeBuilder<usuario_> builder)
        {
            builder.ToTable("usuario_")
                  .HasKey(us => us.idUsuario_);


            builder.Property(us => us.idUsuario);

            builder.Property(us => us.direccionUsuario)
                .HasMaxLength(70);

            builder.Property(us => us.condicion);
             


        }
    }
}