using Main.ElementClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public interface IInsurance
    {
        void Accept(IVisitor visitor);
    }

    public interface IVisitor
    {
        void VisitCarInsurance(CarInsurance element);
        void VisitMotorBikeInsurance(MotorBikeInsurance element);
    }
}
