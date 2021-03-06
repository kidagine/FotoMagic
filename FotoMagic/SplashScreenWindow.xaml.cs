﻿using System;
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
using System.Windows.Shapes;

namespace FotoMagic
{
    /// <summary>
    /// Interaction logic for SplashScreenWindow.xaml
    /// </summary>
    public partial class SplashScreenWindow : Window
    {

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();


        public SplashScreenWindow()
        {
            InitializeComponent();
            StartAnimation();

            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            dispatcherTimer.Start();
        }

        public void StartAnimation()
        {
            imgSplashScreen.Opacity = 0;
            DoubleAnimation animation = new DoubleAnimation(1, TimeSpan.FromSeconds(1f));
            imgSplashScreen.BeginAnimation(ImageBrush.OpacityProperty, animation);
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.Show();

            dispatcherTimer.Stop();
        }
    }
}
