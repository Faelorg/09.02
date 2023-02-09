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
using System.Speech.Synthesis;

namespace practice2.pages
{
    /// <summary>
    /// Логика взаимодействия для _1.xaml
    /// </summary>
    public partial class _1 : Page
    {
        public _1()
        {
            InitializeComponent();
        }

        private void btnRes1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRes2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();

            speech.Speak("Вам не уйти");
            MessageBox.Show("Вам не уйти.");
        }
    }
}
