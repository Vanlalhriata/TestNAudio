using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NAudio.Midi;

namespace TestNAudio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MidiFile midiFile = new MidiFile("KHB 299.mid");

            for (int i = 0; i < midiFile.Events.Count(); i++)
            {
                foreach (MidiEvent midiEvent in midiFile.Events[i])
                {
                    int a = 10;
                }
            }

            InitializeComponent();

            MessageBox.Show("Meh");
        }
    }
}
