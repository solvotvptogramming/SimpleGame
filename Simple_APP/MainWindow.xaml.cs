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

namespace Simple_APP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        private MediaPlayer media1;
        private MediaPlayer mediaPlayer1;
        public MainWindow()
        {
        InitializeComponent();
            media1 = new MediaPlayer();
            mediaPlayer1 = new MediaPlayer();
            mediaPlayer1.Open(new Uri(@"C:\Users\One\Desktop\Simple_APP\Simple_APP\Simple_APP\bin\Debug\prj_13094802_f3df5d25a360741e8837743f23d3b9a9_1654606128.mp3", UriKind.Absolute));
            mediaPlayer1.Play();
            NavigationService.Navigate(new Entrance());
        this.ShowsNavigationUI = false;

           

        }

    }
}
