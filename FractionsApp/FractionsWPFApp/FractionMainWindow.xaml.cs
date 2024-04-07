using FractionsLibrary;
using System.Windows;
using System.Windows.Media.Imaging;


namespace FractionsWPFApp
{
    public partial class MainWindow : Window
    {
        private Fraction fraction1 = new Fraction();
        private Fraction fraction2 = new Fraction();
        private Fraction result = new Fraction();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {            
            txtNumerator2.Visibility = Visibility.Visible;
            txtDenominator2.Visibility = Visibility.Visible;
            txtFraction2.Visibility = Visibility.Visible;
            dashLineFraction2.Visibility = Visibility.Visible;
            imgSign.Source = new BitmapImage(new Uri("images/add.png", UriKind.Relative));
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            txtNumerator2.Visibility = Visibility.Visible;
            txtDenominator2.Visibility = Visibility.Visible;
            txtFraction2.Visibility = Visibility.Visible;
            dashLineFraction2.Visibility = Visibility.Visible;
            imgSign.Source = new BitmapImage(new Uri("images/subtract.png", UriKind.Relative));
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            txtNumerator2.Visibility = Visibility.Visible;
            txtDenominator2.Visibility = Visibility.Visible;
            txtFraction2.Visibility = Visibility.Visible;
            dashLineFraction2.Visibility = Visibility.Visible;
            imgSign.Source = new BitmapImage(new Uri("images/multiply.png", UriKind.Relative));
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            txtNumerator2.Visibility = Visibility.Visible;
            txtDenominator2.Visibility = Visibility.Visible;
            txtFraction2.Visibility = Visibility.Visible;
            dashLineFraction2.Visibility = Visibility.Visible;
            imgSign.Source = new BitmapImage(new Uri("Images/divide.png", UriKind.Relative)); 
        }

        private void btnReciprocal_Click(object sender, RoutedEventArgs e)
        {
            txtNumerator2.Visibility = Visibility.Collapsed;
            txtDenominator2.Visibility = Visibility.Collapsed;
            txtFraction2.Visibility = Visibility.Collapsed;
            dashLineFraction2.Visibility = Visibility.Collapsed;
            imgSign.Source = new BitmapImage(new Uri("Images/reciprocal.png", UriKind.Relative));
        }

        private void btnInvert_Click(object sender, RoutedEventArgs e)
        {
            txtNumerator2.Visibility = Visibility.Collapsed;
            txtDenominator2.Visibility = Visibility.Collapsed;
            txtFraction2.Visibility = Visibility.Collapsed;
            dashLineFraction2.Visibility = Visibility.Collapsed;
            imgSign.Source = new BitmapImage(new Uri("Images/invert.png", UriKind.Relative));
        }
        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            txtNumerator1.Clear();
            txtDenominator1.Clear();
            txtNumerator2.Clear();
            txtDenominator2.Clear();
            txtNumeratorResult.Text = "";
            txtDenominatorResult.Text = "";
            imgSign.Source = null;
            txtNumerator2.Visibility = Visibility.Visible;
            txtDenominator2.Visibility = Visibility.Visible;
            txtFraction2.Visibility = Visibility.Visible;
            dashLineFraction2.Visibility = Visibility.Visible;
            txtResult.Visibility = Visibility.Visible;
            dashLineResult.Visibility = Visibility.Visible;

        }
        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                fraction1.Numerator = int.Parse(txtNumerator1.Text);
                fraction1.Denominator = int.Parse(txtDenominator1.Text);
                if (fraction1.Denominator == 0)
                {
                    throw new ArgumentException("Denominator cannot be zero.");
                }
                else if (imgSign.Source.ToString().Contains("reciprocal"))
                {
                    result = fraction1.Reciprocal();
                }
                else if (imgSign.Source.ToString().Contains("invert"))
                {
                    result = fraction1.Invert();
                }
                else
                {
                    fraction2.Numerator = int.Parse(txtNumerator2.Text);
                    fraction2.Denominator = int.Parse(txtDenominator2.Text);

                    if (fraction2.Denominator == 0)
                    {
                        throw new ArgumentException("Denominator cannot be zero.");
                    }
                    else if (imgSign.Source.ToString().Contains("add"))
                    {
                        result = fraction1.Add(fraction2);
                    }
                    else if (imgSign.Source.ToString().Contains("subtract"))
                    {
                        result = fraction1.Subtract(fraction2);
                    }
                    else if (imgSign.Source.ToString().Contains("multiply"))
                    {
                        result = fraction1.Multiply(fraction2);
                    }
                    else if (imgSign.Source.ToString().Contains("divide"))
                    {
                        result = fraction1.Divide(fraction2);
                    }
                }
                txtNumeratorResult.Text = result.Numerator.ToString();
                if (result.Denominator == 1)
                {
                    txtResult.Visibility = Visibility.Collapsed;
                    dashLineResult.Visibility = Visibility.Collapsed;
                }
                else
                {
                    txtResult.Visibility = Visibility.Visible;
                    dashLineResult.Visibility = Visibility.Visible;
                }
                txtDenominatorResult.Text = result.Denominator.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

