using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Prueba_examen
{
    class ConvertidorMaximoTemperatura : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double temperatura = (int)value;
            temperatura = (temperatura - 32) / 1.8;
            temperatura = (int)temperatura;
            return temperatura;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
