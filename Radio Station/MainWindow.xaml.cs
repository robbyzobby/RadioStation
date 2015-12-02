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
using Radio_Station_Library;

namespace Radio_Station
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      public MainWindow()
        {   
            this.InitializeComponent();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            var musicplaying = new MusicPlaying();
            var contex = new Context(musicplaying);
            contex.TutnOn();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Voice_Click(object sender, RoutedEventArgs e)
        {
            var voiceplaying = new VoicePlaying();
            var contex = new Context(voiceplaying);
            contex.TutnOn();
        }
    }
}
