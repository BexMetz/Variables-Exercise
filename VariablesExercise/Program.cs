namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName; //Declaration syntax

            dogName = "Doc"; //Initialized -- assigned a value

            int dogAge = 3; //Declaring and Initializing

            char firstInitial = 'D';

            bool isHungry = true;

            double dogWeight = 82.3;

            decimal dogHeight = 16.7m;

            Console.WriteLine($"Hi! My Dogs name is {dogName} so his first initial is {firstInitial} and he is about to turn {dogAge} years old.");
            Console.WriteLine($"He weighs {dogWeight} pounds and he is {dogHeight} inches tall.");
            Console.WriteLine($"It is {isHungry.ToString().ToLower()} he is always hungry!");
        }
    }
}
