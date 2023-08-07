IPolicyGenerator policyGenerator = new PolicyGenerator();
IFactoryManager factoryManager = new FactoryManager();
var builder = new RatingEngineBuilder(policyGenerator, factoryManager);
            
var director = new RatingEngineDirector(builder);

director.Rate();          
Console.ReadKey();
  

