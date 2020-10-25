using System.Windows.Forms;

namespace FormProject.FifthHomework
{
    class Circle: IDrawAPI
    {
        private int centerX;
        private int centerY;
        private int radius;
        private PictureBox pictureBox;

        public Circle()
        {

        }
        public void GetFigure(int centerX, int centerY, int radius, PictureBox pictureBox)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
            this.pictureBox = pictureBox;
            Draw();
        }
        public void GetFigure(int x, int y, int width, int height, PictureBox pictureBox)
        {

        }
        public void Draw()
        {
            Initialization.Graphics(pictureBox).DrawEllipse(Initialization.Pen(), 
                                                            centerX - radius, centerY - radius, centerX + radius, centerY + radius);
        }
    }
}
