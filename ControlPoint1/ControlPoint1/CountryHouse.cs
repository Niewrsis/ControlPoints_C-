namespace ControlPoint1
{
    class CountryHouse : Immovable
    {
        public CountryHouse(float worth, float area) : base(worth, area) { }

        public override float CalculateTax()
        {
            return base.CalculateTax();
        }
    }
}
