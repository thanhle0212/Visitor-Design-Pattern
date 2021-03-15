using Main.ElementClasses;
using Main.VisitorClasses;
using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorBikeInsurace = new MotorBikeInsurance();
            var carInsurance = new CarInsurance();
            var quoteVisitor = new QuoteVisitor();
            var customerCommVisitor = new CustomerCommunicationVisitor();

            motorBikeInsurace.Accept(quoteVisitor);
            carInsurance.Accept(quoteVisitor);

            Console.WriteLine("=========================================");

            motorBikeInsurace.Accept(customerCommVisitor);
            carInsurance.Accept(customerCommVisitor);
            Console.ReadLine();
        }
    }
}
