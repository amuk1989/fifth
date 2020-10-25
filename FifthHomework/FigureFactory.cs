using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.FifthHomework
{
    public class FigureFactory
    {
        static Dictionary<string, IDrawAPI> Figures = new Dictionary<string,IDrawAPI>();

        public static IDrawAPI GetFigure(string FigureType)
        {
            switch (FigureType)
            {
                case "Circle":
                    if (!Figures.ContainsKey("Circle")) Figures["Circle"] = new Circle();
                    return Figures["Circle"];
                case "Rectangle":
                    if (!Figures.ContainsKey("Rectangle")) Figures["Rectangle"] = new Rect();
                    return Figures["Rectangle"];
                default:
                    break;

            }
            return null;
        }

    }
}
