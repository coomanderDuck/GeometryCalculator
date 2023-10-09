using System.ComponentModel.DataAnnotations;

namespace GeometryCalculator.Models
{
    public abstract class Shape
    {      
        protected internal abstract double GetArea();
        protected internal abstract void Validate();
    }
}
