/*
1. What is is the third way of data type conversion? (only for numbers)
2. Difference between Parse and TryParse?
 */
using System;

class ConversionProgram {
    static void Main() {
        string str= "500"; // we have a variable of number value represented in string format
        int num = int.Parse(str); // int.Parse() -> this function only takes a string value as an argument and returns interger value
        Console.WriteLine(num);


        //Now what if the a string valie is aplhanumeric?
        string str1 = "100VT"; // this is not a whole number.
        //int num1 = int.Parse(str1);  // While will throw an exception error only when we build/run the program
        // Console.WriteLine(num1);

        // So how can we avoid getting a fatal error if we are trying to convert a string value to int/float but it's not a number?
        int result = 0;
        bool outcome = int.TryParse(str1, out result); //Now int.TryParse(arg1, arg2) -> takes two arguments and returns a boolean value > arg1: the variable to evaluate & arg2: where the value should be placed(if it's a number)  
        if (outcome)
        {
            Console.WriteLine(result);
        }
        else {
            Console.WriteLine("It's not a number");
        }
    }
}

//So this way we donot get any exception error if somehow the value parsed is not a number

// **** Thank you ****