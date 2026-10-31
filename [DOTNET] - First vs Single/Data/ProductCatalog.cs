using _DOTNET____First_vs_Single.Models;

namespace _DOTNET____First_vs_Single.Data;

public static class ProductCatalog
{
    public static IReadOnlyList<Product> Products { get; } =
    [
        new Product
        {
            Id = 1,
            Name = "Café de Colombia",
            Description = "Café molido de tueste medio con notas de chocolate.",
            Category = "Alimentos",
            Price = 8.50m
        },
        new Product
        {
            Id = 2,
            Name = "Aceite de oliva virgen extra",
            Description = "Aceite de oliva español, ideal para ensaladas y cocina.",
            Category = "Alimentos",
            Price = 12.90m
        },
        new Product
        {
            Id = 3,
            Name = "Cuaderno artesanal",
            Description = "Cuaderno de tapas de cartón reciclado con 120 páginas.",
            Category = "Papelería",
            Price = 6.75m
        },
        new Product
        {
            Id = 4,
            Name = "Pluma estilográfica",
            Description = "Pluma con cuerpo metálico y escritura suave.",
            Category = "Papelería",
            Price = 24.00m
        },
        new Product
        {
            Id = 5,
            Name = "Auriculares inalámbricos",
            Description = "Auriculares Bluetooth con estuche de carga compacto.",
            Category = "Tecnología",
            Price = 39.99m
        },
        new Product
        {
            Id = 6,
            Name = "Teclado mecánico",
            Description = "Teclado compacto con iluminación y teclas silenciosas.",
            Category = "Tecnología",
            Price = 69.95m
        },
        new Product
        {
            Id = 7,
            Name = "Botella reutilizable",
            Description = "Botella de acero inoxidable con capacidad de 750 ml.",
            Category = "Hogar",
            Price = 18.50m
        },
        new Product
        {
            Id = 8,
            Name = "Lámpara de escritorio",
            Description = "Lámpara LED regulable para estudiar o trabajar.",
            Category = "Hogar",
            Price = 31.25m
        },
        new Product
        {
            Id = 9,
            Name = "Mochila urbana",
            Description = "Mochila ligera con compartimento acolchado para portátil.",
            Category = "Accesorios",
            Price = 44.90m
        },
        new Product
        {
            Id = 10,
            Name = "Gafas de sol",
            Description = "Gafas de sol con protección UV y montura resistente.",
            Category = "Accesorios",
            Price = 27.80m
        }
    ];
}
