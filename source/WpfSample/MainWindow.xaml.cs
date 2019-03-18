﻿using System.Windows;
using System.Windows.Media;
using Eyetracking.NET;

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IEyetracker _eyeTracker;

        public MainWindow()
        {
            _eyeTracker = Eyetracker.Desktop;
            InitializeComponent();
            CompositionTarget.Rendering += delegate { Content = $"X: {_eyeTracker.X} Y: {_eyeTracker.Y}"; };
        }

        //private IEyetrackerVr _eyeTracker;

        //public MainWindow()
        //{
        //    _eyeTracker = Eyetracker.VR;
        //    InitializeComponent();
        //    CompositionTarget.Rendering += delegate { Content = $"X: {_eyeTracker.X} Y: {_eyeTracker.Y} Z: {_eyeTracker.Z}"; };
        //}
    }
}
