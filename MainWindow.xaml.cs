using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CollorBlock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        byte redColorValue;
        byte greenColorValue;
        byte blueColorValue;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Blue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                blueColorValue = Convert.ToByte(Blue.Text);
                MixedColor.Fill = new SolidColorBrush(Color.FromRgb(redColorValue, greenColorValue, blueColorValue));
            }
            catch
            {
                Blue.Text = "0";
            }
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            string v = Math.Round(BlueSlider.Value, 0).ToString();
            Blue.Text = v;
        }

        private void Red_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                redColorValue = Convert.ToByte(Red.Text);
                MixedColor.Fill = new SolidColorBrush(Color.FromRgb(redColorValue, greenColorValue, blueColorValue));
            }
            catch
            {
                Red.Text = "0";
            }
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            {
                string v = Math.Round(RedSlider.Value, 0).ToString();
                Red.Text = v;
            }
        }

        private void Green_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                greenColorValue = Convert.ToByte(Green.Text);
                MixedColor.Fill = new SolidColorBrush(Color.FromRgb(redColorValue, greenColorValue, blueColorValue));
            }
            catch
            {
                Green.Text = "0";
            }
        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            {
                string v = Math.Round(GreenSlider.Value, 0).ToString();
                Green.Text = v;
            }
        }
    }
}
