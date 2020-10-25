using System.Windows.Forms;

namespace FormProject.FifthHomework
{
    public class Rect: IDrawAPI
    {
        private int x;
        private int y;
        private int width;
        private int height;

        private PictureBox pictureBox;

        public Rect()
        {

        }

        public void GetFigure(int x,int y,int width, int height, PictureBox pictureBox)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.pictureBox = pictureBox;
            Draw();
        }

        public void GetFigure(int centerX, int centerY, int radius, PictureBox pictureBox)
        {

        }

        public void Draw()
        {

            Initialization.Graphics(pictureBox).DrawRectangle(Initialization.Pen(), x, y, width, height);

        }
    }
}
