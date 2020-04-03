using System;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // vacationType and groupSize variables declared
            
            string vacationType = "";

            int groupSize = 0;

            Console.WriteLine("What kind of trip would you like to go on? Musical, Tropical, or Adventurous?");

            // Gets user input and places it in vacationType

            vacationType = Console.ReadLine();

            Console.WriteLine("How many are in your group?");

            // Gets user input, then converts the input into an int and places it into groupSize

            string input = Console.ReadLine();

            groupSize = int.Parse(input);

            // Declares variables to get the destination and travel type

            string vacationOutput = "" ;

            string groupOutput = "";

            // vacationType is checked against each type of vacation. Variable vacationOutput is filled with the correct destination.

            if (vacationType == "Musical") {

                vacationOutput = "New Orleans";

            }

            if (vacationType == "Tropical")
            {
                vacationOutput = "a Beach Vacation in Mexico";
            }

            if (vacationType == "Adventurous")
            {
                vacationOutput = "Whitewater Rafting in the Grand Canyon";
            }

            // Uses relational operators to find the correct travel type. Inputs the travel type into groupOutput

            if (groupSize >= 6)
            {
                groupOutput = "Charter Flight";

            }
            else if (groupSize >= 3)
            {
                groupOutput = "Helicopter";
            }
            else if (groupSize >= 1)
            {
                groupOutput = "First Class Flight";
            }

            // Variable result is declared and filled with the final sentence. Sentence contains all four variables.

            string result = "Since you are in a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + groupOutput + " to " + vacationOutput + ".";

            // result is printed to the console

            Console.WriteLine(result);

            

            





           




      
        }
    }
}
