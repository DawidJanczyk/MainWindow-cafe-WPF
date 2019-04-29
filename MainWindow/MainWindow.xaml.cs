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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dessert_Menu
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private new void GotFocus(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(1));
            label.BeginAnimation(WidthProperty, animation);
        }

        private new void LostFocus(object sender, RoutedEventArgs e)
        {
            textBox.Text = String.Empty;
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 150;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(1));
            label.BeginAnimation(WidthProperty, animation);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow use = new MainWindow();
            use.Show();
            this.Close();
        }

        private void ButtonRecipe_Click(object sender, RoutedEventArgs e)
        {
            Recipe use = new Recipe();
            use.Show();
            this.Close();
        }

        private void ButtonHash_Click(object sender, RoutedEventArgs e)
        {
            Desserts use = new Desserts();
            use.Show();
            this.Close();
        }
        
        private void ButtonContact_Click(object sender, RoutedEventArgs e)
        {
            Contact use = new Contact();
            use.Show();
            this.Close();
        }
    }
}
