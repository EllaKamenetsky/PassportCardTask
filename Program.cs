IPolicyGenerator policyGenarator = new PolicyGenerator();
IFactoryManager factoryManager = new FactoryManager();
var builder = new RatingEngineBuilder(policyGenarator, factoryManager);
            
var director = new RatingEngineDirector(builder);

director.Rate();          
Console.ReadKey();
  

