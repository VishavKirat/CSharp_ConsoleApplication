/*
1. Why using Arrays in the first place? > Strong typed 
2. Can you change the size of the array after intializing it? - disadvantages
*/
using System;
class Program {
    static void Main(){
        int[] num = new int[6]; // This is how you create a an array of 6 strong typed elements > Strongly typed here is used because of "int"
        num[0] = 10; // Array indices starts with '0'
        num[1] = 34;
        num[2] = 40;
        num[5] = 73;
        //num[4] = "Hello"; // not a number
        //num[11] = 56; // No compile time error but gets an error while run time.
        Console.WriteLine(num[0] + num[1] + num[2]); 
    }

}