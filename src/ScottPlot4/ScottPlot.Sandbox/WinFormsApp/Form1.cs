﻿using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            formsPlot1.Plot.AddSignal(ScottPlot.Generate.Sin());
            formsPlot1.Plot.AddSignal(ScottPlot.Generate.Cos());

            formsPlot1.Plot.XAxis.SetZoomInLimit(1);

            formsPlot1.Render();
        }
    }
}
