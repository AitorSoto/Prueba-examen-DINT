using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Prueba_examen
{
    class ConverterImagen : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valor = value as string;
            switch (valor)
            {
                case "sol":
                    valor = "sunny.png";
                    break;
                case "nubes":
                    valor = "cloudy.png";
                    break;
                case "nieve":
                    valor = "snow.png";
                    break;
                default:
                    break;
            }
            return valor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
