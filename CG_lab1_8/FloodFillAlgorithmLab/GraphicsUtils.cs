using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodFillAlgorithmLab
{
    static class GraphicsUtils
    {
        // Задайте цвет границы и цвет закраски
        static Color borderColor = Color.Black;
        static Color fillColor = Color.Maroon;

        public static void FloodFillAlgorithm(Bitmap sourceImage, Bitmap resultImage, int startX, int startY)
        {
            // Получение цвета исходного пикселя, с которого начинается заливка
            Color targetColor = sourceImage.GetPixel(startX, startY);

            // Если точка уже имеет цвет заполнения -> выход
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            // стек для хранения координат пикселей, подлежащих проверке
            Stack<Point> stack = new Stack<Point>();

            // добавление исходной точкм в стек
            stack.Push(new Point(startX, startY));

            while (stack.Count > 0)
            {
                Point currentPoint = stack.Pop();

                // Получение текущих координат
                int currentX = currentPoint.X;
                int currentY = currentPoint.Y;

                // Если текущий пиксель уже имеет цвет заполнения -> пропуск
                if (resultImage.GetPixel(currentX, currentY).ToArgb() == fillColor.ToArgb())
                    continue;

                // Если текущий пиксель имеет цвет границы -> пропуск
                if (sourceImage.GetPixel(currentX, currentY).ToArgb() == borderColor.ToArgb())
                    continue;

                // цвет текущего пикселя в цвет заполнения
                resultImage.SetPixel(currentX, currentY, fillColor);

                // добавление соседних пикселей в стек для проверки
                if (IsInsideBoundary(sourceImage, currentX + 1, currentY) && 
                    sourceImage.GetPixel(currentX + 1, currentY).ToArgb() == targetColor.ToArgb())
                    stack.Push(new Point(currentX + 1, currentY));

                if (IsInsideBoundary(sourceImage, currentX - 1, currentY) && 
                    sourceImage.GetPixel(currentX - 1, currentY).ToArgb() == targetColor.ToArgb())
                    stack.Push(new Point(currentX - 1, currentY));

                if (IsInsideBoundary(sourceImage, currentX, currentY + 1) && 
                    sourceImage.GetPixel(currentX, currentY + 1).ToArgb() == targetColor.ToArgb())
                    stack.Push(new Point(currentX, currentY + 1));

                if (IsInsideBoundary(sourceImage, currentX, currentY - 1) && 
                    sourceImage.GetPixel(currentX, currentY - 1).ToArgb() == targetColor.ToArgb())
                    stack.Push(new Point(currentX, currentY - 1));
            }
        }


        private static bool IsInsideBoundary(Bitmap bitmap, int x, int y)
        {
            return x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height;
        }
    }
}
