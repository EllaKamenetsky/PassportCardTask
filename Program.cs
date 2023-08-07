using TestRatingNew.Services;
using TestRatingNew.Services.Factories;

namespace TestRatingNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPolicyGenerator policyGenarator = new PolicyGenerator();
            IFactoryManager factoryManager = new FactoryManager();
            var builder = new RatingEngineBuilder(policyGenarator, factoryManager);
            
            var director = new RatingEngineDirector(builder);

            director.Rate();          
            Console.ReadKey();
        }
    }
}