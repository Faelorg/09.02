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

namespace _2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RadioButton rb;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int num = 6;
                try
                {
                    for (int i = 0; i < lbxMass.Items.Count; i++)
                    {
                        if (lbxMass.Items[i] == rb)
                        {
                            num = i;
                            break;
                        }
                    }

                    txbRes.Text = Math.Round(new Format().Count(num, double.Parse(txbInput1.Text)), 2).ToString();
                }
                catch (Exception)
                {


                }
            }
            catch (Exception)
            {

                
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            rb = (RadioButton)sender;
            int num = 6;
            try
            {
                for (int i = 0; i < lbxMass.Items.Count; i++)
                {
                    if (lbxMass.Items[i] == rb)
                    {
                        num = i;
                        break;
                    }
                }

                txbRes.Text =Math.Round(new Format().Count(num, double.Parse(txbInput1.Text)),2).ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void txbInput1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var t = (TextBox)sender;
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")
               && (t.Text.Contains(",")
               && t.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }
    }

    public class Format{
        public double Count(int num, double value)
        {
            double res;
            switch (num)
            {
                case 0:
                    res = value / 454;
                    return res;
                case 1:
                    res = value / 16830;
                    return res;
                case 2:
                    res = value / 28.35;
                    return res;
                case 3:
                    res = value / 1.772;
                    return res;
                case 4:
                    res = value / 0.0648;
                    return res;
            }

            return 0;
        }
    }
}
