namespace BuilderPractice
{
    public class AutoMaker
    {
        private readonly IAutoBuilder builder;
        public AutoMaker(IAutoBuilder builder)
        {
            this.builder = builder;
        }

        public Auto BuildAuto()
        {
            builder.CreateAuto();
            builder.SetProperties();
            return builder.GetAuto();
        }
    }
}
