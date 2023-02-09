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
using practice2.pages;
using System.Speech.Synthesis;

namespace practice2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRes2_Click(object sender, RoutedEventArgs e)
        {
            txblockRes.Text = null;
            txbInput.Text = null;
            txbInput2.Text = null;
            txbInput3.Text = null;
            chb1.IsChecked = false;
        }

        private void btnRes1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double res = double.Parse(txbInput2.Text) * double.Parse(txbInput3.Text) / 100 * double.Parse(txbInput.Text);
                if (chb1.IsChecked.Value)
                {
                    res = res * 2;
                }
                txblockRes.Text = res.ToString();
            }
            catch
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.SpeakAsync("Вам не уйти");
            MessageBox.Show("Вам не уйти.");
        }

        private void txbInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var t = (TextBox)sender;
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")
               && (t.Text.Contains(".")
               && t.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void chb1_Checked(object sender, RoutedEventArgs e)
        {
            var c = (CheckBox)sender;
            try
            {
                if (c.IsChecked.Value)
                {
                    txblockRes.Text = (float.Parse(txblockRes.Text) * 2).ToString();
                }
                else
                {
                    txblockRes.Text = (float.Parse(txblockRes.Text) / 2).ToString();
                }

            }
            catch
            {

            }
        }

        private void chb1_Unchecked(object sender, RoutedEventArgs e)
        {
            var c = (CheckBox)sender;
            try
            {
                if (c.IsChecked.Value == false)
                {
                    txblockRes.Text = (float.Parse(txblockRes.Text) / 2).ToString();
                }
            }
            catch
            {

            }
        }
    }
}
