using System;
using Main.ElementClasses;

namespace Main.VisitorClasses
{
    public class QuoteVisitor : IVisitor
    {
        public void VisitCarInsurance(CarInsurance element)
        {
            Console.WriteLine($"Get Quote for Car as the element is { element.GetType()}");
        }

        public void VisitMotorBikeInsurance(MotorBikeInsurance element)
        {
            Console.WriteLine($"Get Quote for Motor Bike as the element is { element.GetType()}");
        }
    }
}
