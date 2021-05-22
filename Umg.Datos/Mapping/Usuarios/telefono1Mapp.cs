using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Umg.Datos.Mapping.Usuarios
{
    public class telefono1Mapp
    {
        public void Configure(EntityTypeBuilder<telefono1> builder)
        {
            builder.ToTable("categoria")
                  .HasKey(c => c.idCategoria);
            builder.Property(c => c.nombreCategoria)
                .HasMaxLength(50);
            builder.Property(c => c.descripcion)
                .HasMaxLength(256);


        }
    }
}
