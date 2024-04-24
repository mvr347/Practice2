using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Practice2.Pages
{
    /// <summary>
    /// Логика взаимодействия для CalculatorPage.xaml
    /// </summary>
    public partial class CalculatorPage : Page
    {
        public CalculatorPage()
        {
            InitializeComponent();
        }

        private async void ButtonCountEnergyClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double inLineKW, frontKW;
                double.TryParse(InLineKW.Text, out inLineKW);
                double.TryParse(FrontKW.Text, out frontKW);

                if (inLineKW < frontKW)
                {
                    InLineKW.BorderBrush = FrontKW.BorderBrush = Brushes.Red;

                    HandyControl.Controls.MessageBox.Show("In-line higher than front!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    InLineKW.ClearValue(Border.BorderBrushProperty);
                    FrontKW.ClearValue(Border.BorderBrushProperty);

                    return;
                }

                double price;

                if (DayTariff.IsSelected)
                {
                    price = inLineKW <= 100 ? inLineKW * 0.9 : inLineKW * 1.68;
                }
                else if (NightTariff.IsSelected)
                {
                    price = inLineKW * 0.36;
                }
                else
                {
                    throw new InvalidOperationException("Please select a tariff.");
                }


                double difference = inLineKW - frontKW;

                DifferentEnergy.Text = $"{difference}";

                LabelPriceEnergy.Content = $"Price: {price} HRN";
            }
            catch (FormatException ex)
            {
                HandyControl.Controls.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (InvalidOperationException ex)
            {
                HandyControl.Controls.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void ButtonCountWaterClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double inLineCM, frontCM;
                double.TryParse(InLineCM.Text, out inLineCM);
                double.TryParse(FrontCM.Text, out frontCM);

                if (inLineCM < frontCM)
                {
                    InLineKW.BorderBrush = FrontKW.BorderBrush = Brushes.Red;

                    HandyControl.Controls.MessageBox.Show("In-line higher than front!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    InLineKW.ClearValue(Border.BorderBrushProperty);
                    FrontKW.ClearValue(Border.BorderBrushProperty);

                    return;
                }

                double price;

                price = inLineCM * 22.99;


                double difference = inLineCM - frontCM;

                DifferentWater.Text = $"{difference}";

                LabelPriceWater.Content = $"Price: {price} HRN";
            }
            catch (FormatException ex)
            {
                HandyControl.Controls.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (InvalidOperationException ex)
            {
                HandyControl.Controls.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void ButtonCountGasClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double inLineCM, frontCM;
                double.TryParse(InLineGCM.Text, out inLineCM);
                double.TryParse(FrontGCM.Text, out frontCM);

                if (inLineCM < frontCM)
                {
                    InLineKW.BorderBrush = FrontKW.BorderBrush = Brushes.Red;

                    HandyControl.Controls.MessageBox.Show("In-line higher than front!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    InLineKW.ClearValue(Border.BorderBrushProperty);
                    FrontKW.ClearValue(Border.BorderBrushProperty);

                    return;
                }

                double price;

                price = inLineCM * 7.8;


                double difference = inLineCM - frontCM;

                DifferentGas.Text = $"{difference}";

                LabelPriceGas.Content = $"Price: {price} HRN";
            }
            catch (FormatException ex)
            {
                HandyControl.Controls.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (InvalidOperationException ex)
            {
                HandyControl.Controls.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
