using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model.Geometry
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rect1, Rectangle rect2)
        {
            if (rect1 == null || rect2 == null) return false;

            double halfWidth1 = rect1.Width / 2;
            double halfHeight1 = rect2.Length / 2;
            double halfWidth2 = rect2.Width / 2;
            double halfHeight2 = rect2.Length / 2;

            // Разница координат центров по модулю
            double dx = Math.Abs(rect1.Center.X - rect2.Center.X);
            double dy = Math.Abs(rect1.Center.Y - rect2.Center.Y);

            // Пересечение, если обе разницы меньше суммы половин
            return dx < halfWidth1 + halfWidth2 && dy < halfHeight1 + halfHeight2;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            // Расстояние между центрами
            double dx = ring1.Center.X - ring2.Center.X;
            double dy = ring1.Center.Y - ring2.Center.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            double radius = ring1.OuterRadius + ring2.OuterRadius;
            // Кольца пересекаются, если расстояние меньше суммы внешних радиусов
            return distance < radius;
        }
    }
}
