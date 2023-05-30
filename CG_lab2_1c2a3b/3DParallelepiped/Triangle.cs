using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace KG2
{
    class Triangle
    {

        To4ka fv0, fv1, fv2;
        public Color color;

        public Triangle(To4ka av0, To4ka av1, To4ka av2, Color aColor)
        {
            fv0 = av0;
            fv1 = av1;
            fv2 = av2;
            color = aColor;
        }

        public To4ka v0
        {
            get { return fv0; }
        }

        public To4ka v1
        {
            get { return fv1; }
        }

        public To4ka v2
        {
            get { return fv2; }
        }

        /// возвращает вектор нормали для плоскости
        public To4ka normal
        {
            get { return v1.minus(v0).getVectorMult(v2.minus(v0)); }
        }

        public To4ka normalCam
        {
            get { return v1.Vcam.minus(v0.Vcam).getVectorMult(v2.Vcam.minus(v0.Vcam)); }
        }
    }
}
