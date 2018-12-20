﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Change the namespace to your project's namespace.
namespace GOLStartUpTemplate3
{
    class GraphicsPanel : Panel
    {
        // Default constructor
        public GraphicsPanel()
        {
            // Turn on double buffering.
            this.DoubleBuffered = true;

            // Allow repainting when the windows is resized.
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }
}
