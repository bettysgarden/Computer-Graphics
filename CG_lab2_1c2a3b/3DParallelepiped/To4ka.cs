using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace KG2
{
    class To4ka
    {
        public double X, Y, Z;
        public double W;
        public To4ka Vcam;

        public To4ka(double aX, double aY, double aZ, double aW = 1)
        {
            X = aX;
            Y = aY;
            Z = aZ;
            W = aW;
            Vcam = null;
        }

        public To4ka(String str)
        {
            string[] coords = str.Split(' ');
            X = Double.Parse(coords[0]);
            Y = Double.Parse(coords[1]);
            Z = Double.Parse(coords[2]);
            W = 1;
            Vcam = null;
        }

        public To4ka(Point pnt)
        {
            X = pnt.X;
            Y = pnt.Y;
            Z = 0;
            W = 1;
            Vcam = null;
        }

        public double getX()
        {
            return X / W;
        }

        public double getY()
        {
            return Y / W;
        }

        public double getZ()
        {
            return Z / W;
        }

        public double getW()
        {
            return W;
        }

        public double length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }

        public void Normalize()
        {
            double len = length;
            X = X / len;
            Y = Y / len;
            Z = Z / len;
        }

        // Векторное произведение на вектор src
        public To4ka getVectorMult(To4ka src)
        {
            double ax, ay, az;
            ax = getY() * src.getZ() - getZ() * src.getY();
            ay = getZ() * src.getX() - getX() * src.getZ();
            az = getX() * src.getY() - getY() * src.getX();
            return new To4ka(ax, ay, az);
        }

        public To4ka applyMatrix(Matrix matr)
        {
            To4ka result = new To4ka(0,0,0,0);
            double[] input = { X, Y, Z, W };
            for (int i = 0; i < 4; i++)
            {
                result.X += input[i] * matr.fields[i, 0];
                result.Y += input[i] * matr.fields[i, 1];
                result.Z += input[i] * matr.fields[i, 2];
                result.W += input[i] * matr.fields[i, 3];
            }
            return result;
        }

        // Находит угол между двумя веторами
        public double findAngle(To4ka src)
        {
            if (length == 0 || src.length == 0)
                return 0;
            double cos=(getX()*src.getX()+getY()*src.getY()+getZ()*src.getZ())/(length*src.length);
            return Math.Acos(cos);
        }

        // Считаем координаты точки относительно камеры
        public void rotateForCam(Camera cam)
        {
            Vcam = applyMatrix(cam.toRotate);
        }

        public To4ka minus(To4ka src)
        {
            return new To4ka(getX() - src.getX(), getY() - src.getY(), getZ() - src.getZ());
        }

        public To4ka plus(To4ka src)
        {
            return new To4ka(getX() + src.getX(), getY() + src.getY(), getZ() + src.getZ());
        }

        public To4ka scale(double mnozh)
        {
            return new To4ka(getX() * mnozh, getY() * mnozh, getZ() * mnozh);
        }
    }
}
