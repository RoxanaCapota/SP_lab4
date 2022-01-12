using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Models
{
    public class Dimension
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Dimension()
        {
            Width = 100;
            Height = 100;
        }

        public Dimension(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
