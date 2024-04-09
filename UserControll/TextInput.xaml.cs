using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DariuszLabaj.MaterialIo.UserControll
{
    /// <summary>
    /// Interaction logic for TextInput.xaml
    /// </summary>
    public partial class TextInput : UserControl
    {
        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(TextInput), new PropertyMetadata(null));
        public static readonly DependencyProperty SupportingTextProperty = DependencyProperty.Register("SupportingText", typeof(string), typeof(TextInput), new PropertyMetadata(null));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public string SupportingText
        {
            get { return (string)(GetValue(SupportingTextProperty)); }
            set { SetValue(SupportingTextProperty, value); }
        }

        public TextInput()
        {
            InitializeComponent();
        }
    }
}
