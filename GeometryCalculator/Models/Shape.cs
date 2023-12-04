using System.ComponentModel.DataAnnotations;

namespace GeometryCalculator.Models
{
    public abstract class Shape
    {
        protected Shape(params double[] args)
        {
            Validate(args);
        }

        protected internal abstract double GetArea();
        protected internal abstract void Validate(params double[] args);
    }
}
