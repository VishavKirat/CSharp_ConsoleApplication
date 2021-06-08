// nullable data type can be intergrated with any existing data type like int, array, strubg etc.
// The real ques. is why do we need a nullable type? : Suppose I ask you do you want to hire me?
//You answer may be YES or NO - Right..... but what if you don't want to answer what to do in that case?
// Nullable type comes in to rescue.

using System;

class Nullable
{
    static void Main()
    {
        //bool hireMe = null; // thsi throws an error as "true" or "false" can be the only correct answer here
        bool? hireMe = false; // so you have literally decided not to answer

        //string answer = hireMe; // This will throw an error as a nullable value cant' be assigned to a non-nullable value.
        //string answer = hireMe ?? "Lol";

        if (hireMe == true) // this is eqivalent to hireMe.Value as .Value throughs the other value of nullable object 
        {
            Console.WriteLine("Thnak you!!");
        }
        else if (!hireMe.Value) // this is equivalent to hireMe == false
        {
            Console.WriteLine("Yours loss");
        }
        else {
            Console.WriteLine(" I hate when you don't answer");

        }
    }
}