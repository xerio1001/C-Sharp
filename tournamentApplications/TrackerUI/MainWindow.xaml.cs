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

namespace TrackerUI
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

        private void BtnScore_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BtnScore.Background = new SolidColorBrush(Color.FromArgb(0, 102, 102, 102));
        }

        private void BtnScore_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BtnScore.Background = new SolidColorBrush(Color.FromArgb(0, 242, 242, 242));
        }
    }
}
