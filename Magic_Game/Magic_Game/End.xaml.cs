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
using System.Windows.Shapes;

namespace Magic_Game
{
    public partial class End : Window
    {
        public End(int result)
        {
            InitializeComponent();
            Answer.Content = result;
        }

        private void Replay_Click(object sender, RoutedEventArgs e)
        {
            MainWindow new_game = new MainWindow();
            new_game.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
