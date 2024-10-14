namespace ControlPoint1
{
    abstract class Property
    {
        protected float worth;

        public Property(float worth)
        {
            this.worth = worth;
        }

        public abstract float CalculateTax();
    }
}
