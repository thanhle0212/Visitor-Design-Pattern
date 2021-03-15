using System;
using Main.ElementClasses;

namespace Main.VisitorClasses
{
    public class CustomerCommunicationVisitor : IVisitor
    {
        public void VisitCarInsurance(CarInsurance element)
        {
            Console.WriteLine($"Email is sent as the element class is { element.GetType()}");
        }

        public void VisitMotorBikeInsurance(MotorBikeInsurance element)
        {
            Console.WriteLine($"SMS is sent as the element class is { element.GetType()}");
        }
    }
}
