﻿using System.Windows;
using ScottPlot;

namespace Sandbox.WPF;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Loaded += (s, e) =>
        {
            WpfPlot1.Plot.Add.Signal(Generate.Sin());
            WpfPlot1.Plot.Add.Signal(Generate.Cos());
            WpfPlot1.Refresh();
        };
    }
}
