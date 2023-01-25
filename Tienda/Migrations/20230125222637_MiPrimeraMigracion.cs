using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Tienda.Migrations
{
    public partial class MiPrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrito",
                columns: table => new
                {
                    idCarrito = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    iduario = table.Column<int>(type: "int", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Carrito__488B0B0AA0297D1C", x => x.idCarrito);
                });

            migrationBuilder.CreateTable(
                name: "Carrito_Item",
                columns: table => new
                {
                    itemCarritoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    idCarrito = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    idProducto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CartItem__488B0B0AA0297D1C", x => x.itemCarritoId);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    idcategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nombreCategoria = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__19093A2B46B8DFC9", x => x.idcategoria);
                });

            migrationBuilder.CreateTable(
                name: "DetalleOrdenCliente",
                columns: table => new
                {
                    idDetalleOrden = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    idOrden = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    idProducto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__9DD74DBD81D9221B", x => x.idDetalleOrden);
                });

            migrationBuilder.CreateTable(
                name: "ListaDeseos",
                columns: table => new
                {
                    idListaDeseos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    idusuario = table.Column<int>(type: "int", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ListaDeseos__488B0B0AA0297D1C", x => x.idListaDeseos);
                });

            migrationBuilder.CreateTable(
                name: "ListaDeseosItems",
                columns: table => new
                {
                    idListaDeItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    idListaDeseos = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    idproducto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Wishlist__171E21A16A5148A4", x => x.idListaDeItem);
                });

            migrationBuilder.CreateTable(
                name: "OrdenCliente",
                columns: table => new
                {
                    idOrden = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    fechaCreaciom = table.Column<DateTime>(type: "datetime", nullable: false),
                    totalCarrito = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__C3905BCF96C8F1E7", x => x.idOrden);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    idproducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    cod_producto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    nom_producto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    desc_producto = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    precio_producto = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    cant_producto = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    img_producto = table.Column<string>(type: "varchar(1300)", unicode: false, maxLength: 1300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Producto__488B0B0AA0297D1C", x => x.idproducto);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    idtipousuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nombreTipoUsuario = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TipoUsuario__488B0B0AA0297D1C", x => x.idtipousuario);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    dniUsuario = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    nombresUsuario = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    correoUsuario = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    passwordUsuario = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    celular = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    rol_usuario = table.Column<int>(type: "int", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    region = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserMast__1788CCAC2694A2ED", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carrito");

            migrationBuilder.DropTable(
                name: "Carrito_Item");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "DetalleOrdenCliente");

            migrationBuilder.DropTable(
                name: "ListaDeseos");

            migrationBuilder.DropTable(
                name: "ListaDeseosItems");

            migrationBuilder.DropTable(
                name: "OrdenCliente");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "TipoUsuario");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
