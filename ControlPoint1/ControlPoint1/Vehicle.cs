namespace ControlPoint1
{
    class Vehicle : Property
    {
        protected float engineVolume;

        public Vehicle(float worth, float engineVolume) : base(worth)
        {
            this.engineVolume = engineVolume;
        }

        public override float CalculateTax()
        {
            return worth * engineVolume / 3000;
        }

        public override string ToString()
        {
            return $"Стоимость - {worth}, налог - {CalculateTax()}, объём двигателя - {engineVolume} см.куб";
        }
    }
}
