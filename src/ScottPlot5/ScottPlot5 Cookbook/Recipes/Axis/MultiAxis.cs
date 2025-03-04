﻿namespace ScottPlotCookbook.Recipes.Axis;

public class MultiAxis : ICategory
{
    public string Chapter => "Axis";
    public string CategoryName => "Advanced Axis Features";
    public string CategoryDescription => "Tick mark customization and creation of multi-Axis plots";

    public class RightAxis : RecipeBase
    {
        public override string Name => "Right Axis";
        public override string Description => "New plots have one axis on every side. " +
            "Axes on the right and top are invisible by default. " +
            "To use the right axis, make it visible, then tell a plottable to use it. ";

        [Test]
        public override void Execute()
        {
            // plot data with very different scales
            var sig1 = myPlot.Add.Signal(Generate.Sin(mult: 0.01));
            var sig2 = myPlot.Add.Signal(Generate.Cos(mult: 100));

            // tell each signal plot to use a different axis
            sig1.Axes.YAxis = myPlot.LeftAxis;
            sig2.Axes.YAxis = myPlot.RightAxis;

            // add additional styling options to each axis
            myPlot.LeftAxis.Label.Text = "Left Axis";
            myPlot.RightAxis.Label.Text = "Right Axis";
            myPlot.LeftAxis.Label.ForeColor = sig1.Color;
            myPlot.RightAxis.Label.ForeColor = sig2.Color;
        }
    }

    public class MultiAxisQuickstart : RecipeBase
    {
        public override string Name => "Multi-Axis";
        public override string Description => "Additional axes may be added to plots. " +
            "Plottables are displayed using the coordinate system of the primary axes by default, " +
            "but any plottable can be displayed using any X and Y axis.";

        [Test]
        public override void Execute()
        {
            // plottables use the standard X and Y axes by default
            var sig1 = myPlot.Add.Signal(ScottPlot.Generate.Sin(51, mult: 0.01));
            sig1.Axes.XAxis = myPlot.XAxis; // standard X axis
            sig1.Axes.YAxis = myPlot.YAxis; // standard Y axis
            myPlot.YAxis.Label.Text = "Primary Y Axis";

            // create a second axis and add it to the plot
            var yAxis2 = myPlot.AddLeftAxis();

            // add a new plottable and tell it to use the custom Y axis
            var sig2 = myPlot.Add.Signal(ScottPlot.Generate.Cos(51, mult: 100));
            sig2.Axes.XAxis = myPlot.XAxis; // standard X axis
            sig2.Axes.YAxis = yAxis2; // custom Y axis
            yAxis2.Label.Text = "Secondary Y Axis";
        }
    }
}
