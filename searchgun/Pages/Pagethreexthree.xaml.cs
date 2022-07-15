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

namespace searchgun.Pages
{
    /// <summary>
    /// Логика взаимодействия для Pagethreexthree.xaml
    /// </summary>
    public partial class Pagethreexthree : Page
    {
        public Pagethreexthree()
        {
            InitializeComponent();
            
            seximage.Source = new BitmapImage Properties.Resources.intel;
        }
    }
}
