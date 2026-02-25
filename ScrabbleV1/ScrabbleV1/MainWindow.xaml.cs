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

namespace ScrabbleV1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // variables de la classe MainWindow
		// utiles pour les évolutions EVO02 et EVO03
		int totalPoints = 0;                // nombre total de points du joueur
		int nbMots = 0;                     // nombre de mots proposés par le joueur
		string[] lesMots = new string[10];  // tableau contenant les mots proposés par le joueur
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            string lemot = txtMot.Text;
            int nbpoints = Utilitaire.PointsMot(lemot);
            txtPoints.Text = nbpoints.ToString();
        }

        private void btnAutre_Click(object sender, RoutedEventArgs e)
        {
            txtMot.Clear();
            txtPoints.Text="";
            txtMot.Focus();
        }
    }
}