using System.ComponentModel;
using System.Reflection;

namespace Enumeracion.Enums
{
    public static class EnumExtensions
    {
        public static string ObtenerDescripcion(this CategoriasProducto valor)
        {
            var campo = valor.GetType().GetField(valor.ToString());
            var atributo = campo?.GetCustomAttribute<DescriptionAttribute>();
            return atributo?.Description ?? "Otra categoría";
        }
    }
}