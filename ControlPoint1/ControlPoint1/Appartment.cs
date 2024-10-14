namespace ControlPoint1
{
    class Appartment : Immovable
    {
        public Appartment(float worth, float area) : base(worth, area) { }

        public override float CalculateTax()
        {
            return base.CalculateTax();
        }
    }
}
