using Facturacion.Models;
using Microsoft.EntityFrameworkCore;

namespace Facturacion.DAL
{
    public class FacturacionDBContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Factura> Facturas { get; set; }

        public DbSet<ItemVenta> ItemsVentas { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public FacturacionDBContext(DbContextOptions<FacturacionDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Categoria> categoriasInit = new();
            categoriasInit.Add(new Categoria() { Id = 1, NombreCategoria = "Navidad" });
            categoriasInit.Add(new Categoria() { Id = 2, NombreCategoria = "Juguetes" });
            categoriasInit.Add(new Categoria() { Id = 3, NombreCategoria = "Tecnología" });

            modelBuilder.Entity<Categoria>(categoria =>
            {
                categoria.ToTable("Categoria");
                categoria.HasKey(c => c.Id);
                categoria.Property(c => c.NombreCategoria).IsRequired().HasMaxLength(150);
                categoria.HasData(categoriasInit);
            });

            List<Cliente> clientesInit = new();
            clientesInit.Add(new Cliente() { Id = 1, Nombre = "MARY", Apellido = "SMITH", Direccion = "1913 Hanoi Way", Telefono = "28303384290", Email = "MARY.SMITH@sakilacustomer.org", FechaNacimiento = new DateTime(1992, 3, 12) });
            clientesInit.Add(new Cliente() { Id = 2, Nombre = "PATRICIA", Apellido = "JOHNSON", Direccion = "1121 Loja Avenue", Telefono = "838635286649", Email = "PATRICIA.JOHNSON@sakilacustomer.org", FechaNacimiento = new DateTime(1997, 5, 16) });
            clientesInit.Add(new Cliente() { Id = 3, Nombre = "LINDA", Apellido = "WILLIAMS", Direccion = "692 Joliet Street", Telefono = "448477190408", Email = "LINDA.WILLIAMS@sakilacustomer.org", FechaNacimiento = new DateTime(1982, 2, 18) });
            clientesInit.Add(new Cliente() { Id = 4, Nombre = "BARBARA", Apellido = "JONES", Direccion = "1566 Inegl Manor", Telefono = "705814003527", Email = "BARBARA.JONES@sakilacustomer.org", FechaNacimiento = new DateTime(1987, 1, 9) });
            clientesInit.Add(new Cliente() { Id = 5, Nombre = "ELIZABETH", Apellido = "BROWN", Direccion = "53 Idfu Parkway", Telefono = "10655648674", Email = "ELIZABETH.BROWN@sakilacustomer.org", FechaNacimiento = new DateTime(1997, 9, 13) });
            clientesInit.Add(new Cliente() { Id = 6, Nombre = "JENNIFER", Apellido = "DAVIS", Direccion = "1795 Santiago de Compostela Way", Telefono = "860452626434", Email = "JENNIFER.DAVIS@sakilacustomer.org", FechaNacimiento = new DateTime(1986, 7, 6) });
            clientesInit.Add(new Cliente() { Id = 7, Nombre = "MARIA", Apellido = "MILLER", Direccion = "900 Santiago de Compostela Parkway", Telefono = "716571220373", Email = "MARIA.MILLER@sakilacustomer.org", FechaNacimiento = new DateTime(1989, 4, 9) });
            clientesInit.Add(new Cliente() { Id = 8, Nombre = "SUSAN", Apellido = "WILSON", Direccion = "478 Joliet Way", Telefono = "657282285970", Email = "SUSAN.WILSON@sakilacustomer.org", FechaNacimiento = new DateTime(1998, 11, 12) });
            clientesInit.Add(new Cliente() { Id = 9, Nombre = "MARGARET", Apellido = "MOORE", Direccion = "613 Korolev Drive", Telefono = "380657522649", Email = "MARGARET.MOORE@sakilacustomer.org", FechaNacimiento = new DateTime(1992, 2, 6) });
            clientesInit.Add(new Cliente() { Id = 10, Nombre = "DOROTHY", Apellido = "TAYLOR", Direccion = "1531 Sal Drive", Telefono = "648856936185", Email = "DOROTHY.TAYLOR@sakilacustomer.org", FechaNacimiento = new DateTime(1996, 9, 22) });
            clientesInit.Add(new Cliente() { Id = 11, Nombre = "LISA", Apellido = "ANDERSON", Direccion = "1542 Tarlac Parkway", Telefono = "635297277345", Email = "LISA.ANDERSON@sakilacustomer.org", FechaNacimiento = new DateTime(1985, 1, 18) });
            clientesInit.Add(new Cliente() { Id = 12, Nombre = "NANCY", Apellido = "THOMAS", Direccion = "808 Bhopal Manor", Telefono = "465887807014", Email = "NANCY.THOMAS@sakilacustomer.org", FechaNacimiento = new DateTime(1991, 4, 1) });
            clientesInit.Add(new Cliente() { Id = 13, Nombre = "KAREN", Apellido = "JACKSON", Direccion = "270 Amroha Parkway", Telefono = "695479687538", Email = "KAREN.JACKSON@sakilacustomer.org", FechaNacimiento = new DateTime(1986, 11, 4) });
            clientesInit.Add(new Cliente() { Id = 14, Nombre = "BETTY", Apellido = "WHITE", Direccion = "770 Bydgoszcz Avenue", Telefono = "517338314235", Email = "BETTY.WHITE@sakilacustomer.org", FechaNacimiento = new DateTime(2001, 4, 17) });
            clientesInit.Add(new Cliente() { Id = 15, Nombre = "HELEN", Apellido = "HARRIS", Direccion = "419 Iligan Lane", Telefono = "990911107354", Email = "HELEN.HARRIS@sakilacustomer.org", FechaNacimiento = new DateTime(1992, 6, 20) });
            clientesInit.Add(new Cliente() { Id = 16, Nombre = "SANDRA", Apellido = "MARTIN", Direccion = "360 Toulouse Parkway", Telefono = "949312333307", Email = "SANDRA.MARTIN@sakilacustomer.org", FechaNacimiento = new DateTime(1993, 6, 19) });
            clientesInit.Add(new Cliente() { Id = 17, Nombre = "DONNA", Apellido = "THOMPSON", Direccion = "270 Toulon Boulevard", Telefono = "407752414682", Email = "DONNA.THOMPSON@sakilacustomer.org", FechaNacimiento = new DateTime(1989, 6, 7) });
            clientesInit.Add(new Cliente() { Id = 18, Nombre = "CAROL", Apellido = "GARCIA", Direccion = "320 Brest Avenue", Telefono = "747791594069", Email = "CAROL.GARCIA@sakilacustomer.org", FechaNacimiento = new DateTime(1999, 8, 15) });
            clientesInit.Add(new Cliente() { Id = 19, Nombre = "RUTH", Apellido = "MARTINEZ", Direccion = "1417 Lancaster Avenue", Telefono = "272572357893", Email = "RUTH.MARTINEZ@sakilacustomer.org", FechaNacimiento = new DateTime(1983, 7, 20) });
            clientesInit.Add(new Cliente() { Id = 20, Nombre = "SHARON", Apellido = "ROBINSON", Direccion = "1688 Okara Way", Telefono = "144453869132", Email = "SHARON.ROBINSON@sakilacustomer.org", FechaNacimiento = new DateTime(1984, 4, 7) });

            modelBuilder.Entity<Cliente>(cliente =>
            {
                cliente.ToTable("Cliente");
                cliente.HasKey(c => c.Id);
                cliente.Property(c => c.Nombre).IsRequired().HasMaxLength(150);
                cliente.Property(c => c.Apellido).IsRequired().HasMaxLength(150);
                cliente.Property(c => c.Direccion).HasMaxLength(350);
                cliente.Property(c => c.Telefono).HasMaxLength(50);
                cliente.Property(c => c.Email).HasMaxLength(350);
                cliente.Property(c => c.FechaNacimiento).IsRequired();
                cliente.HasData(clientesInit);
            });

            List<Producto> productosInit = new();
            productosInit.Add(new Producto() { Id = 1,  Nombre = "RENO NAVIDEÑO DE 53 CM CON FALDA A CUADROS", PrecioUnitario = 59900, CantidadExistencia = 50, CategoriaId = 1 });
            productosInit.Add(new Producto() { Id = 2,  Nombre = "SANTA COLGANTE ROJO - HO!HO!HO!", PrecioUnitario = 54900, CantidadExistencia = 45, CategoriaId = 1 });
            productosInit.Add(new Producto() { Id = 3,  Nombre = "MUÑECO DE NIEVE SENTADO DE 21 CM CON BUSO VERDE", PrecioUnitario = 39900, CantidadExistencia = 47, CategoriaId = 1 });
            productosInit.Add(new Producto() { Id = 4,  Nombre = "PIE DE ÁRBOL BEIGE DE 90 CM, MUÑECO DE NIEVE", PrecioUnitario = 89900, CantidadExistencia = 25, CategoriaId = 1 });
            productosInit.Add(new Producto() { Id = 5,  Nombre = "CORONA NAVIDEÑA VERDE DE 40 CM CON FRUTOS ROJOS, HOJAS Y MANZANAS", PrecioUnitario = 49900, CantidadExistencia = 33, CategoriaId = 1 });
            productosInit.Add(new Producto() { Id = 6,  Nombre = "COJÍN ROJO DE 35.5 CM - HAPPY NEW YEAR", PrecioUnitario = 34900, CantidadExistencia = 44, CategoriaId = 1 });
            productosInit.Add(new Producto() { Id = 7,  Nombre = "RAMA NAVIDEÑA DE FRUTOS ROJOS ESCARCHADA DE 73 CM", PrecioUnitario = 14900, CantidadExistencia = 34, CategoriaId = 1 });
            productosInit.Add(new Producto() { Id = 8,  Nombre = "ÁRBOL DE NAVIDAD DE 180 CM Y 720 PUNTAS", PrecioUnitario = 169900, CantidadExistencia = 10, CategoriaId = 1 });
            productosInit.Add(new Producto() { Id = 9,  Nombre = "ÁRBOL NAVIDEÑO VERDE Y BLANCO DE 1.80 M", PrecioUnitario = 399900, CantidadExistencia = 5, CategoriaId = 1 });
            productosInit.Add(new Producto() { Id = 10, Nombre = "PESEBRE DE 11 FIGURAS EN 1 PIEZA DE 40 X 36 CM CON LUZ Y SONIDO", PrecioUnitario = 409900, CantidadExistencia = 27, CategoriaId = 1 });

            productosInit.Add(new Producto() { Id = 11, Nombre = "PORTÁTIL ACER, INTEL® CORE™ I5 1035G1, RAM 8 GB, 256 GB SSD, A315-57G-59KN, 15.6\" FHD, NEGRO", PrecioUnitario = 1899900, CantidadExistencia = 7, CategoriaId = 2 });
            productosInit.Add(new Producto() { Id = 12, Nombre = "ALL IN ONE HP, AMD RYZEN™ 3, RAM 4 GB, 128 GB SSD, 22-DD0522LA, 21.5” FHD, NEGRO", PrecioUnitario = 1649000, CantidadExistencia = 22, CategoriaId = 2 });
            productosInit.Add(new Producto() { Id = 13, Nombre = "TABLETA LENOVO, RAM 4 GB, 64 GB, TB-X306X TAB M10 HD, 10.1\", GRIS", PrecioUnitario = 699000, CantidadExistencia = 57, CategoriaId = 2 });
            productosInit.Add(new Producto() { Id = 14, Nombre = "TECLADO NUMÉRICO TARGUS DE USB, NEGRO", PrecioUnitario = 55900, CantidadExistencia = 5, CategoriaId = 2 });
            productosInit.Add(new Producto() { Id = 15, Nombre = "COMBO HP DE TECLADO + MOUSE INALÁMBRICO, BLANCO", PrecioUnitario = 189900, CantidadExistencia = 100, CategoriaId = 2 });
            productosInit.Add(new Producto() { Id = 16, Nombre = "GOOGLE WIFI X 3, BLANCO", PrecioUnitario = 959900, CantidadExistencia = 14, CategoriaId = 2 });
            productosInit.Add(new Producto() { Id = 17, Nombre = "MEMORIA USB DE 64 GB MAXELL, NEGRA CON PLATEADO", PrecioUnitario = 29900, CantidadExistencia = 64, CategoriaId = 2 });
            productosInit.Add(new Producto() { Id = 18, Nombre = "HUB USB INFINITO MULTIPUERTO CON HDMI", PrecioUnitario = 149900, CantidadExistencia = 8, CategoriaId = 2 });
            productosInit.Add(new Producto() { Id = 19, Nombre = "MOUSE INALÁMBRICO NIGTHFALL CAMO CON BLUETOOTH, AZUL", PrecioUnitario = 69900, CantidadExistencia = 85, CategoriaId = 2 });
            productosInit.Add(new Producto() { Id = 20, Nombre = "CÁMARA WEB 12 MP, HAVIT HV-NA20G", PrecioUnitario = 289900, CantidadExistencia = 17, CategoriaId = 2 });

            productosInit.Add(new Producto() { Id = 21, Nombre = "FIGURA DE LAS TORTUGAS NINJA DE 51 CM – LEONARDO", PrecioUnitario = 269900, CantidadExistencia = 71, CategoriaId = 3 });
            productosInit.Add(new Producto() { Id = 22, Nombre = "SR. CARA DE PAPA", PrecioUnitario = 69900, CantidadExistencia = 25, CategoriaId = 3 });
            productosInit.Add(new Producto() { Id = 23, Nombre = "IRON MAN", PrecioUnitario = 69900, CantidadExistencia = 58, CategoriaId = 3 });
            productosInit.Add(new Producto() { Id = 24, Nombre = "FIGURA DE IRON SPIDER ENDGAME DE 50 CM", PrecioUnitario = 269900, CantidadExistencia = 65, CategoriaId = 3 });
            productosInit.Add(new Producto() { Id = 25, Nombre = "REMOLQUE HOT WHEELS, DISEÑO TIBURÓN", PrecioUnitario = 109900, CantidadExistencia = 2, CategoriaId = 3 });
            productosInit.Add(new Producto() { Id = 26, Nombre = "CAMIONETA MONSTER JAM RC GRAVE DIGGER", PrecioUnitario = 149900, CantidadExistencia = 19, CategoriaId = 3 });
            productosInit.Add(new Producto() { Id = 27, Nombre = "LANZADOR DE DARDOS SONIC RAPTOR CON 10 DARDOS", PrecioUnitario = 79900, CantidadExistencia = 88, CategoriaId = 3 });
            productosInit.Add(new Producto() { Id = 28, Nombre = "LANZADOR NERF DINOSQUAD RAPTOR-SLASH CON 6 DARDOS", PrecioUnitario = 99900, CantidadExistencia = 35, CategoriaId = 3 });
            productosInit.Add(new Producto() { Id = 29, Nombre = "TIMÓN DIDÁCTICO AZUL CON LUZ Y SONIDO", PrecioUnitario = 59900, CantidadExistencia = 26, CategoriaId = 3 });
            productosInit.Add(new Producto() { Id = 30, Nombre = "BLOQUES LÓGICOS EN CAUCHO ESPUMA, 48 PIEZAS", PrecioUnitario = 33200, CantidadExistencia = 11, CategoriaId = 3 });


            modelBuilder.Entity<Producto>(producto =>
            {
                producto.ToTable("Producto");
                producto.HasKey(p => p.Id);
                producto.Property(p => p.Nombre).IsRequired().HasMaxLength(150);
                producto.Property(p => p.PrecioUnitario).IsRequired();
                producto.Property(p => p.CantidadExistencia).IsRequired();
                producto.Property(p => p.CategoriaId).IsRequired();
                producto.HasOne(p => p.Categoria)
                        .WithMany(c => c.Productos)
                        .HasForeignKey(p => p.CategoriaId);
                producto.HasData(productosInit);
            });

        }
    }
}