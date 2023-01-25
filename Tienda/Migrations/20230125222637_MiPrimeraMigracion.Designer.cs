﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tienda.Modelo;

namespace Tienda.Migrations
{
    [DbContext(typeof(ContextoProductoDB))]
    [Migration("20230125222637_MiPrimeraMigracion")]
    partial class MiPrimeraMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Tienda.Modelo.Carrito", b =>
                {
                    b.Property<string>("idCarrito")
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("fechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int")
                        .HasColumnName("iduario");

                    b.HasKey("idCarrito")
                        .HasName("PK__Carrito__488B0B0AA0297D1C");

                    b.ToTable("Carrito");
                });

            modelBuilder.Entity("Tienda.Modelo.CarritoItem", b =>
                {
                    b.Property<int>("itemCarritoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<string>("idCarrito")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("idProducto")
                        .HasColumnType("int");

                    b.HasKey("itemCarritoId")
                        .HasName("PK__CartItem__488B0B0AA0297D1C");

                    b.ToTable("Carrito_Item");
                });

            modelBuilder.Entity("Tienda.Modelo.Categoria", b =>
                {
                    b.Property<int>("idCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idcategoria");

                    b.Property<string>("nombreCategoria")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("idCategoria")
                        .HasName("PK__Categori__19093A2B46B8DFC9");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Tienda.Modelo.DetalleOrdenCliente", b =>
                {
                    b.Property<int>("idDetalleOrden")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<string>("idOrden")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("idProducto")
                        .HasColumnType("int");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("idDetalleOrden")
                        .HasName("PK__Customer__9DD74DBD81D9221B");

                    b.ToTable("DetalleOrdenCliente");
                });

            modelBuilder.Entity("Tienda.Modelo.ListaDeseos", b =>
                {
                    b.Property<string>("idListaDeseos")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("fechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int")
                        .HasColumnName("idusuario");

                    b.HasKey("idListaDeseos")
                        .HasName("PK__ListaDeseos__488B0B0AA0297D1C");

                    b.ToTable("ListaDeseos");
                });

            modelBuilder.Entity("Tienda.Modelo.ListaDeseosItems", b =>
                {
                    b.Property<int>("idListaDeItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("idListaDeseos")
                        .IsRequired()
                        .HasMaxLength(36)
                        .IsUnicode(false)
                        .HasColumnType("varchar(36)");

                    b.Property<int>("idproducto")
                        .HasColumnType("int");

                    b.HasKey("idListaDeItem")
                        .HasName("PK__Wishlist__171E21A16A5148A4");

                    b.ToTable("ListaDeseosItems");
                });

            modelBuilder.Entity("Tienda.Modelo.OrdenCliente", b =>
                {
                    b.Property<string>("idOrden")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("fechaCreaciom")
                        .HasColumnType("datetime");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<decimal>("totalCarrito")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("idOrden")
                        .HasName("PK__Customer__C3905BCF96C8F1E7");

                    b.ToTable("OrdenCliente");
                });

            modelBuilder.Entity("Tienda.Modelo.Producto", b =>
                {
                    b.Property<int>("idproducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idproducto");

                    b.Property<int>("cant_producto")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("int");

                    b.Property<string>("cod_producto")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("desc_producto")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("img_producto")
                        .HasMaxLength(1300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1300)");

                    b.Property<string>("nom_producto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("precio_producto")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("idproducto")
                        .HasName("PK__Producto__488B0B0AA0297D1C");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Tienda.Modelo.TipoUsuario", b =>
                {
                    b.Property<int>("idTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idtipousuario");

                    b.Property<string>("nombreTipoUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("idTipoUsuario")
                        .HasName("PK__TipoUsuario__488B0B0AA0297D1C");

                    b.ToTable("TipoUsuario");
                });

            modelBuilder.Entity("Tienda.Modelo.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<string>("celular")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("correoUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("dniUsuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("fechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<string>("nombresUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("passwordUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("region")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("rolUsuario")
                        .HasColumnType("int")
                        .HasColumnName("rol_usuario");

                    b.HasKey("idUsuario")
                        .HasName("PK__UserMast__1788CCAC2694A2ED");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
