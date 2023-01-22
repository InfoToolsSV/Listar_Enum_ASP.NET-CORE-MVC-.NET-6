using System.ComponentModel;

namespace Enumeracion.Enums
{
    public enum CategoriasProducto
    {
        [Description("Electrónica")]
        Electronica = 1,
        [Description("Moda y Estilo")]
        Moda,
        [Description("Hogar y Jardín")]
        HogaryJardin,
        [Description("Deportes y Aire Libre")]
        DeportesAireLibre,
        [Description("Herramientas Bricolaje")]
        HerramientasBricolaje
    }
}