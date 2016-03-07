namespace BuilderPractice
{
    class MotorcycleBuilder : IAutoBuilder
    {
        private Auto auto;
        public void CreateAuto()
        {
            auto = new Auto();
        }

        public Auto GetAuto()
        {
            return auto;
        }

        public void SetProperties()
        {
            auto.Brand = "Harley";
            auto.Mpg = 1;
            auto.Wheels = 2;
            auto.Color = "Blue";
        }
    }
}
