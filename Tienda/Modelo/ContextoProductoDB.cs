using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Tienda.Modelo
{
    public partial class ContextoProductoDB : DbContext
    {
        public ContextoProductoDB()
        {

        }

        public ContextoProductoDB(DbContextOptions<ContextoProductoDB> options) : base(options)
        {

        }

        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Carrito> Carrito { get; set; }
        public virtual DbSet<CarritoItem> Carrito_Item { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<DetalleOrdenCliente> DetalleOrdenCliente { get; set; }
        public virtual DbSet<OrdenCliente> OrdenCliente { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.idproducto).HasName("PK__Producto__488B0B0AA0297D1C");

                entity.Property(e => e.idproducto).HasColumnName("idproducto");

                entity.Property(e => e.cod_producto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.nom_producto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.desc_producto)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.precio_producto).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.cant_producto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.img_producto)
                    .HasMaxLength(1300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Carrito>(entity =>
            {
                entity.HasKey(e => e.idCarrito).HasName("PK__Carrito__488B0B0AA0297D1C");

                entity.Property(e => e.idCarrito)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.fechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.idUsuario).HasColumnName("iduario");
            });

            modelBuilder.Entity<CarritoItem>(entity =>
            {
                entity.HasKey(e => e.itemCarritoId)
                    .HasName("PK__CartItem__488B0B0AA0297D1C");

                entity.Property(e => e.idCarrito)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.idCategoria)
                    .HasName("PK__Categori__19093A2B46B8DFC9");

                entity.Property(e => e.idCategoria).HasColumnName("idcategoria");

                entity.Property(e => e.nombreCategoria)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetalleOrdenCliente>(entity =>
            {
                entity.HasKey(e => e.idDetalleOrden)
                    .HasName("PK__Customer__9DD74DBD81D9221B");

                entity.Property(e => e.idOrden)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.precio).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<OrdenCliente>(entity =>
            {
                entity.HasKey(e => e.idOrden)
                    .HasName("PK__Customer__C3905BCF96C8F1E7");

                entity.Property(e => e.idOrden)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.totalCarrito).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.fechaCreaciom).HasColumnType("datetime");

                entity.Property(e => e.idUsuario).HasColumnName("UserID");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.idUsuario)
                    .HasName("PK__UserMast__1788CCAC2694A2ED");

                entity.Property(e => e.idUsuario).HasColumnName("UserID");

                entity.Property(e => e.dniUsuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.nombresUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.correoUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.passwordUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.celular)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.rolUsuario).HasColumnName("rol_usuario");

                entity.Property(e => e.fechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.region)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.idTipoUsuario).HasName("PK__TipoUsuario__488B0B0AA0297D1C");
                entity.Property(e => e.idTipoUsuario).HasColumnName("idtipousuario");

                entity.Property(e => e.nombreTipoUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListaDeseos>(entity =>
            {
                entity.HasKey(e => e.idListaDeseos).HasName("PK__ListaDeseos__488B0B0AA0297D1C");

                entity.Property(e => e.idListaDeseos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.fechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.idUsuario).HasColumnName("idusuario");
            });

            modelBuilder.Entity<ListaDeseosItems>(entity =>
            {
                entity.HasKey(e => e.idListaDeItem)
                    .HasName("PK__Wishlist__171E21A16A5148A4");

                entity.Property(e => e.idListaDeseos)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
