using System.Drawing;
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

namespace gyakorlas_11_13
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

        private void btnFelvesz_Click(object sender, RoutedEventArgs e)
        {

            string text = nameBox.Text;
            string color;
            
            if (text == "")
            {
                MessageBox.Show("Írj be szöveget!");
            }
            else
            {
                if (rbRed.IsChecked == true)
                {
                    color = "Red";
                }
                else if (rbBlue.IsChecked == true)
                {
                    color = "Blue";
                }
                else
                {
                    color = "Green";
                }
                nameList.Items.Add($"{text} ({color})");
            }
        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (nameList.SelectedItem == null)
            {
                MessageBox.Show("Válassz egyet!");
                return;
            }
            nameList.Items.Remove(nameList.SelectedItem);
        }

        private void nameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int wordsCount = nameBox.Text.Split().Length;
            lblName.Content = $"Név hossza: {nameBox.Text.Length},Szavak száma: {wordsCount} ";
        }
    }
}