﻿using System.Windows;

namespace DAQSystem.Application.UI
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

        private void OnAnimationCompleted(object sender, EventArgs e)
        {
            var dataContext = DataContext as MainWindowViewModel;

            dataContext.IsSettingFadePlaying = false;
            dataContext.IsCalculationFadePlaying = false;
            dataContext.IsGaussianTranslateInPlaying = false;
            dataContext.IsGaussianTranslateOutPlaying = false;
        }
    }
}