using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        // The universe array
        bool[,] universe = new bool[20, 20];
        
        //bool End = false;
        Body head;
        HashSet<Body> hash = new HashSet<Body>();
        
        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();
        //int delay = 0;
        // Generation count
        //int generations = 0;

        public Form1()
        {
            InitializeComponent();
            //create 1 snake
            head = new Body(2, 2);


            // Init Timer
            timer.Interval = 750;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Game_Update();

            graphicsPanel1.Invalidate();
            //NextGeneration();
        }

        void Game_Update()
        {
            head.BeginUpdate();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // The width and height of each cell in pixels
            int cellWidth = 100;
            int cellHeight = 100;

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);
            Brush snakeBrush = new SolidBrush(Color.SeaGreen);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush
                    if (head.HasPoint(x, y))
                    {
                        e.Graphics.FillRectangle(snakeBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
