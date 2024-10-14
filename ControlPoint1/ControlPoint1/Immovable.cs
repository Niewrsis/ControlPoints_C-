namespace ControlPoint1
{
    class Immovable : Property
    {
        protected float area;

        public Immovable(float worth, float area) : base(worth)
        {
            this.area = area;
        }

        public double CostPerSquareMeter()
        {
            return worth / area;
        }

        public override string ToString()
        {
            return $"Стоимость - {worth}, налог - {CalculateTax()}, площадь - {area} кв.м";
        }

        public override float CalculateTax()
        {
            if (area < 100)
                return worth / 500;
            else if (area >= 100 && area < 300)
                return worth / 350;
            else
                return worth / 250;
        }
    }
}
