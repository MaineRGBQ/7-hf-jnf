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

namespace WpfApp32
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRunAway_MouseEnter(object sender, MouseEventArgs e)
        {
            Point buttonPosition = btnRunAway.TranslatePoint(new Point(0, 0), this);

            double newX = buttonPosition.X + 50;
            double newY = buttonPosition.Y + 50;

            btnRunAway.Margin = new Thickness(newX, newY, 0, 0);
        }
    }

}