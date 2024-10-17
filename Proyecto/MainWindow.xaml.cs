using Proyecto.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Este método se ejecuta cuando haces clic en el botón de login
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Crear una instancia de la ventana Inicio
            Inicio inicioVentana = new Inicio();

            // Mostrar la nueva ventana
            inicioVentana.Show();

            // Cerrar la ventana de login actual
            this.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}