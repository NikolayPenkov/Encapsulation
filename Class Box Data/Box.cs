using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box_Data
{
    public class Box
    {
        private const int MinimalValue = 0;
        private const string ArgumentZeroOrNegative = "{0} cannot be zero or negative.";
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }
        public double Lenght
        {
            get 
            { 
                return this.lenght;
            }
            set
            {
                if (value <= MinimalValue)
                {
                    throw new ArgumentException(String.Format(ArgumentZeroOrNegative, nameof(this.Lenght)));
                }
                this.lenght = value; 
            }
        }
        public double Width 
        {
            get 
            {
                return this.width; 
            }
            set
            {
                if (value <= MinimalValue)
                {
                    throw new ArgumentException(string.Format(ArgumentZeroOrNegative, nameof(this.Width)));
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= MinimalValue)
                {
                    throw new ArgumentException(string.Format(ArgumentZeroOrNegative, nameof(this.Height)));
                }
                this.height = value;
            }
        }
        public double SurfaceArea()
        {
            double sum = (2 * this.Lenght * this.Height) + (2 * this.Height * this.Width) + (2 * this.Lenght * this.Width);
            return sum;
        }
        public double LateralSurfaceArea()
        {
            double sum = (2 * this.Lenght * this.Height) + (2 * this.Height * this.Width);
            return sum;
        }
        public double Volume()
        {
            double sum = this.Lenght * this.Width * this.Height;
            return sum;
        }
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {this.Volume():f2}");
            return sb.ToString().TrimEnd();
        }
    }
}
