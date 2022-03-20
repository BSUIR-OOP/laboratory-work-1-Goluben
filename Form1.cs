using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {

        Graphics graphic;
        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);

        public Form1()
        {
            InitializeComponent();
            graphic = CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pen.Width = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            Rectangle rec = new Rectangle(275, 150, 300, 200);
            rec.DrawFigure(pen, graphic);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            Triangle triangle = new Triangle(500, 150, 250, 300, 500, 300);
            triangle.DrawFigure(pen, graphic);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            Line line = new Line(250, 250, 600, 250);
            line.DrawFigure(pen, graphic);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            Ellipse ellipse= new Ellipse(325, 150, 200, 200);
            ellipse.DrawFigure(pen, graphic);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            Trapeze trap = new Trapeze(350, 150, 450, 150, 550, 300, 300, 300);
            trap.DrawFigure(pen, graphic);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            Hexagon hex = new Hexagon(425, 100, 525, 200, 525, 300, 425, 400, 325, 300, 325, 200);
            hex.DrawFigure(pen, graphic);
        }
    }
}
