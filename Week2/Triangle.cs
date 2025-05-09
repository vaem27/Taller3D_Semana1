﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1.Week2
{
    internal class Triangle : Shape
    {
        protected float b;
        protected float h;

        public Triangle(string name, float b, float h) : base(name)
        {
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return (b * h) / 2;
        }
        public override string GetData()
        {
            return $"{base.GetData()} - Base: {b} - Altura: {h}";
        }
    }
}
