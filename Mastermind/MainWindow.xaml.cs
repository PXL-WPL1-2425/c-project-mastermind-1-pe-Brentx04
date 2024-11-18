using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer StartCountDown = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            StartCountDown.Tick += Timer_Tick;
            StartCountDown.Interval = new TimeSpan(0, 0, 1);
            StartCountDown.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        
        {
             textBoxTime.Text = $"{DateTime.Now.ToLongTimeString()}";
        }
        
    

        public void debug(ToggleButton toggledebug) 
        {
            if (debug)
            {
                toggledebug = Key.LeftCtrl Key.F12;
            }
        }

        private void checkCode_Click(object sender, RoutedEventArgs e)
        {
            if (StartCountDown = TimeSpan (0, 0, 10))
            {
                StartCountDown.Stop();
            }
            //push 5

            string[] colors = { "rood", "geel", "oranje", "wit", "groen", "blauw" };
            Random random = new Random();
            string colorCode = $"{colors[random.Next(colors.Length)]}, " +
                               $"{colors[random.Next(colors.Length)]}, " +
                               $"{colors[random.Next(colors.Length)]}, " +
                               $"{colors[random.Next(colors.Length)]}";

            TextBox1.Text = $"{colorCode}";
            int attempts = 1;

            do
            {
                attempts++;
            }
            while (attempts > 1);
            
                
            
            this.Title = $"Kleurencode: {colorCode}";
            this.Title = $"Poging: {attempts}";
            string[] userColors = new string[]
            {
                GetComboBoxValue(comboBox1),
                GetComboBoxValue(comboBox2),
                GetComboBoxValue(comboBox3),
                GetComboBoxValue(comboBox4)
            };

          
            for (int i = 0; i < userColors.Length; i++)
            {
                string userColor = userColors[i];
                Label label = FindLabel(i + 1);

                if (userColor == colorCode)
                {
                   
                    label.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                    label.BorderThickness = new Thickness(3);
                }
                else if (colorCode.Contains(userColor))
                {
                    
                    label.BorderBrush = new SolidColorBrush(Colors.Wheat);
                    label.BorderThickness = new Thickness(3);
                }
                else
                {
                    
                    label.BorderBrush = null;
                    label.BorderThickness = new Thickness(0);
                }
            }
        }
        private string GetComboBoxValue(ComboBox comboBox)
        {
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                return selectedItem.Content.ToString().Trim().ToLower();
            }
            return string.Empty;
        }

        private Label FindLabel(int index)
        {
            
            return (Label)this.FindName($"Label{index}");
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBox box = (ComboBox)sender;
            if (box != null)
            {

                ComboBoxItem item = box.SelectedItem as ComboBoxItem;

                switch (item.Content.ToString().Trim())
                {
                    case "Wit":
                        Label1.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        Label1.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        Label1.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        Label1.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        Label1.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        Label1.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    default:

                        break;
                }
            }
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (box != null)
            {

                ComboBoxItem item = box.SelectedItem as ComboBoxItem;

                switch (item.Content.ToString().Trim())
                {
                    case "Wit":
                        Label2.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        Label2.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        Label2.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        Label2.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        Label2.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        Label2.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    default:

                        break;
                }
            }
        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (box != null)
            {

                ComboBoxItem item = box.SelectedItem as ComboBoxItem;

                switch (item.Content.ToString().Trim())
                {
                    case "Wit":
                        Label3.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        Label3.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        Label3.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        Label3.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        Label3.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        Label3.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    default:

                        break;
                }
            }
        }

        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (box != null)
            {

                ComboBoxItem item = box.SelectedItem as ComboBoxItem;

                switch (item.Content.ToString().Trim())
                {
                    case "Wit":
                        Label4.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        Label4.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        Label4.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        Label4.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        Label4.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        Label4.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    default:

                        break;
                }
            }

        }
    }
}