﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottPlot.Control
{
    public interface IPlotInteraction
    {
        ContextMenuItem[] ContextMenuItems { get; }

        string DefaultSaveImageFilename { get; }

        /// <summary>
        /// Disable all mouse interactivity
        /// </summary>
        void Disable();

        /// <summary>
        /// Enable mouse interactivity using the default mouse actions
        /// </summary>
        void Enable();

        /// <summary>
        /// Enable mouse interactivity using custom mouse actions
        /// </summary>
        void Enable(PlotActions customActions);

        void OnMouseMove(Pixel newPosition);

        void KeyUp(Key key);

        void KeyDown(Key key);

        void MouseDown(Pixel position, MouseButton button);

        void MouseUp(Pixel position, MouseButton button);

        void DoubleClick();

        void MouseWheelVertical(Pixel pixel, float delta);
    }
}
