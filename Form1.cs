using System;
using System.Windows.Forms;
using FormProject.FifthHomework;

namespace FormProject
{
    public partial class DrawForm : Form
    {
        private Random random = new Random();
        public DrawForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDrawAPI circle = FigureFactory.GetFigure("Circle");
            circle.GetFigure(GetRandom(200), GetRandom(200), GetRandom(200), PictureBox);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDrawAPI rectangle = FigureFactory.GetFigure("Rectangle");
            rectangle.GetFigure(GetRandom(200), GetRandom(200), GetRandom(200), GetRandom(200), PictureBox);
        }

        private int GetRandom(int number)
        {
            return random.Next(number);
        }
    }
}
