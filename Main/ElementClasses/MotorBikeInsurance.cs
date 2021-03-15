namespace Main.ElementClasses
{
    public class MotorBikeInsurance: IInsurance
    {
        public string RegistrationNumber { get; set; }
        public string PostCode { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int EngineCC { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitMotorBikeInsurance(this);
        }
    }
}
