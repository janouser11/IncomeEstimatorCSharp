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

namespace IncomeEstimator
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

        private void button_Click(object sender, RoutedEventArgs e)
        {


            try {

                int hourlyWage = int.Parse(textBox1.Text);
                int weeklyHours = int.Parse(textBox2.Text);

                Calculate calculate = new Calculate(hourlyWage, weeklyHours);

                calculatedBlock.Text = "Yearly Pay: $" + calculate.arrayOfWages[0] + ".00" + "\nMonthly Pay: $" + calculate.arrayOfWages[1] + ".00" + "\nWeekly Pay: $" + calculate.arrayOfWages[2] +  ".00";
            }

            catch (Exception err)
            {
                MyWipedText.Visibility = Visibility.Visible;
            }
        }
    }
}
