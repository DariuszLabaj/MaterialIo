using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows;

namespace DariuszLabaj.MaterialIo.Converters
{
    public class ScaleConverter : MarkupExtension, IValueConverter
    {
        private readonly double _scale;
        public ScaleConverter(double scale)
        {
            _scale = scale;
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return DependencyProperty.UnsetValue;
            if (double.TryParse(value.ToString(), out double inputValue))
            {
                return inputValue * _scale;
            }
            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
