using System.Drawing;
using System.Windows.Forms;

namespace FormProject.FifthHomework
{
    public static class Initialization
    {
        private static Graphics graphics;
        public static Pen Pen()
        {
            return new Pen(Color.Black, 3);
        }

        public static Graphics Graphics(PictureBox pictureBox)
        {
            graphics = pictureBox.CreateGraphics();
            //graphics.Clear(Color.White);
            return graphics;
        }
    }
}
