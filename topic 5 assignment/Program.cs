namespace topic_5_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 1
            string planet;
            double weightearth;
            Console.WriteLine("What is your weight on earth?");
            double.TryParse(Console.ReadLine(), out weightearth);
            Console.WriteLine("oh wow, youre only " +weightearth);
            Console.WriteLine("what planet do you want to box on?");
            Console.WriteLine("1. Venus 2. Mars 3. Jupiter 4. Saturn 5. Uranus 6. Neptune");
            planet = Console.ReadLine();
            if (planet == "1" )
            {
                Console.WriteLine("your weight on venis is " + (weightearth * 0.78));
            }
            if (planet == "2")
            {
                Console.WriteLine("your weight on mars is " + (weightearth * 0.39));
            }
            if (planet == "3")
            {
                Console.WriteLine("your weight on jupiter is " + (weightearth * 2.65));
            }
            if (planet == "4")
            {
                Console.WriteLine("your weight on saturn is " + (weightearth * 1.17));
            }
            if (planet == "5")
            {
                Console.WriteLine("your weight on uranus is " + (weightearth * 1.05));
            }
            if (planet == "6")
            {
                Console.WriteLine("your weight on neptune is " + (weightearth * 1.23));
            }
            // part 2
            double number;
            Console.WriteLine("chose a number in between 1 and 10");
            double.TryParse(Console.ReadLine() , out number);
            if (number == 4)
            {
                Console.WriteLine("congrats you got it right!");
            }
            else
            {
                Console.WriteLine("false, the number was 4");
            }
            // part 3
            int answer, answer1;
            string answer2, answer3;
            int score = 0;
            Console.WriteLine("time to do a quiz!");
            Console.WriteLine("if raine has 10 bananas and his friend has 5, raine gives his friend 4, how many bananas does his friend have?");
            int.TryParse(Console.ReadLine(), out answer);
            if (answer == 9)
            {
                Console.WriteLine("that's true! raines friend has 9 bananas");
                score += 1;
            }
            else
            {
                Console.WriteLine("did you skip grade 3 math? how did you get that wrong");
            }
            Console.WriteLine("what animal has the highest population?");
            Console.WriteLine("1. Fish, 2. Birds, 3. insects, 4. human");
            int.TryParse(Console.ReadLine(), out answer1);
            if (answer1 == 1)
            {
                Console.WriteLine("false, there's about 3.5 trillion fish in the world");
            }
            else if (answer1 == 2)
            {
                Console.WriteLine(" false, there's only 50 billion birds on earth");

            }
            else if (answer1 == 3)
            {
                Console.WriteLine("yay! you got it, there's 10 quintillion insects in the world");
                score += 1;
            }
            else if (answer1 == 4)
            {
                Console.WriteLine(" false, theres only 7.94 billion humans");
            }
            Console.WriteLine("true or false, raine is going to fail this course");
            answer2 = Console.ReadLine();
            if (answer2.ToLower() == "true")
            {
                Console.WriteLine("wow i cant believe you think raines going to fail");
            }
            else
            {
                Console.WriteLine(" i bet raines happy you think hes going to pass, thats correct hes not going to fail");
                score += 1;
            }
            Console.WriteLine("true or false, coding is hard");
            answer3 = Console.ReadLine();
            if (answer3.ToLower() == "true")
            {
                Console.WriteLine("correct, coding is very hard");
                score += 1;
            }
            else
            {
                Console.WriteLine("false you nerd, coding is hard");
            }
            Console.WriteLine("congrats you are done the quiz");
            if (score == 0)
            { Console.WriteLine("wow, how did you manage do get a 0, that's 0%");
            }
            else if (score == 1)
            { Console.WriteLine("dont be proud of yourself, you only got 1 right, that is a horible score, only a 25%, thats a fail");
            }
            else if (score == 2)
            { Console.WriteLine("well i guess 2 isnt bad, you still passed but just barely with a 50%");
            }
            else if (score == 3)
            { Console.WriteLine("wow, a 3/4, pretty good, a 75%");
            }
            else if (score == 4)
            { Console.WriteLine("nerd. you got 100%");
            }
        }
    }
}
