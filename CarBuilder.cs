namespace BuilderPractice
{
    public class CarBuilder : IAutoBuilder
    {
        Auto car;
        public Auto GetAuto()
        {
            return car;
        }

        public void CreateAuto()
        {
            car = new Auto();
        }

        public void SetProperties()
        {
            car.Brand = "Ford";
            car.Color = "Red";
            car.Wheels = 4;
            car.Mpg = 30;
        }
    }
}
