using Stick_Ranger_Remasterd.src.controller.interfaces;
using Stick_Ranger_Remasterd.src.model;
using Stick_Ranger_Remasterd.src.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace StickRangerRemasterd.src.controller
{

    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window, IGame
    {

        private bool isRunning = true;

        // constructor
        public Game()
        {
            

        }

        public void start()
        {

            this.view.start();

            while (this.isRunning)
            {

                Thread.Sleep(50);
            }
        }
    }
}
