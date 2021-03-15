using System;
using System.Collections.Generic;
using System.Text;

namespace Main.ElementClasses
{
    public class CarInsurance: IInsurance
    {
        public string RegistrationNumber { get; set; }
        public string PostCode { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int EngineCC { get; set; }
        public bool IsLeftHandDrive { get; set; }
        public bool IsModified { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCarInsurance(this);
        }
    }
}
