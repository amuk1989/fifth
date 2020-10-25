using System.Windows.Forms;

namespace FormProject.FifthHomework
{
    public interface IDrawAPI
    {
        void GetFigure(int centerX, int centerY, int radius, PictureBox pictureBox);
        void GetFigure(int x, int y, int width, int height, PictureBox pictureBox);
        void Draw();
    }
}
