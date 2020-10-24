using System.Windows;
using System.Windows.Controls;

namespace Actividad4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cuadroTexto.Text.Length >= 140)
                cuadroTexto.IsReadOnly = true;
            contador.Text = cuadroTexto.Text.Length.ToString() + "/140";
        }
    }
}
