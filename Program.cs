namespace TheBuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a simple house (instance)
            Builder simpleHouse = new SimpleHouse();            
            //Ask the director to build this simple house
            Director.BuildHouse(simpleHouse);            
            var sh = simpleHouse.GetHouse();            
            //print the results
            Console.WriteLine(sh);

            
            Console.WriteLine("-------------------");


            //create a wooden house (instance)
            Builder woodenHouse = new WoodenHouse();
            //Ask the director to build this simple house
            Director.BuildHouse(woodenHouse);
            var wh = woodenHouse.GetHouse();
            //print the results
            Console.WriteLine(wh);


            Console.ReadKey();
        }
    }
}