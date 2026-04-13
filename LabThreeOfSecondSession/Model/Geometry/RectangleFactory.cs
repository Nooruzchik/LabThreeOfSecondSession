using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model.Geometry
{
    public static class RectangleFactory
    {
        private static Random _random = new Random();

        public static Rectangle Randomize(int canvasWidth, int canvasHeight)
        {
            int margin = 15;
            double width = _random.Next(30, 101);
            double height = _random.Next(30, 101);

            // Безопасные границы для центра
            int minCenterX = margin + (int)(width / 2);
            int maxCenterX = canvasWidth - margin - (int)(width / 2);
            int minCenterY = margin + (int)(height / 2);
            int maxCenterY = canvasHeight - margin - (int)(height / 2);

            // Защита от отрицательных диапазонов
            if (maxCenterX <= minCenterX) maxCenterX = minCenterX + 10;
            if (maxCenterY <= minCenterY) maxCenterY = minCenterY + 10;

            int centerX = _random.Next(minCenterX, maxCenterX + 1);
            int centerY = _random.Next(minCenterY, maxCenterY + 1);

            string color = "Green";

            return new Rectangle(height, width, color, centerX, centerY);
        }
    }
}
