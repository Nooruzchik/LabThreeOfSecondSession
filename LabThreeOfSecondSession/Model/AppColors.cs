using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    public static class AppColors
    {
        /// <summary>
        /// Цвет фона поля при корректном значении
        /// </summary>
        public static Color ValidInputBackColor { get; } = Color.White;

        /// <summary>
        /// Цвет фона поля при ошибке валидации
        /// </summary>
        public static Color InvalidInputBackColor { get; } = Color.LightPink;

        /// <summary>
        /// Цвет прямоугольника, который не пересекается с другими
        /// </summary>
        public static Color NonCollisionRectangleColor { get; } = Color.FromArgb(127, 127, 255, 127); // зелёный

        /// <summary>
        /// Цвет прямоугольника, который пересекается с другим
        /// </summary>
        public static Color CollisionRectangleColor { get; } = Color.FromArgb(127, 255, 127, 127); // красный

        /// <summary>
        /// Цвет для зимы (голубой)
        /// </summary>
        public static Color WinterColor { get; } = Color.FromArgb(80, 152, 215);

        /// <summary>
        /// Цвет для весны (зелёный)
        /// </summary>
        public static Color SpringColor { get; } = Color.FromArgb(85, 156, 69);

        /// <summary>
        /// Цвет для лета (жёлтый)
        /// </summary>
        public static Color SummerColor { get; } = Color.FromArgb(236, 228, 61);

        /// <summary>
        /// Цвет для осени (оранжевый)
        /// </summary>
        public static Color AutumnColor { get; } = Color.FromArgb(226, 156, 59);

    }
}
