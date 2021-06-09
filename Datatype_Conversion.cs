/*
Quess to ask before learning dataype conversions are:
1. What is Implicit and Explicit conversion?
2. When do we need Implicit and Explicit conversion?
3. What is Type Casting?
4. how to use .Net Classes?
5. what is the differnce between type casting and Convert class? > Type Cast does not throw the excetion error on exceeding the value limit where as Convert class does.
 */
using System;

class Program {
    static void Main() {
        int i = 100;
        float f = i; // *** Implicit conversion ***this does not throw error Why? > float is bigger than integer(stores more values) - No loss of data

        // int k = f; // this throws the exception error ** Implicit Conversion not possible** - loss of data
        int temp = (int)f; // ** Explicit Conversion ** Make sure it can't hold bigger values

        int temp1 = Convert.ToInt32(f); // **Explicit Conversion** Covert is a .Net class for data conversion has number of options to choose from

        Console.WriteLine(temp1);
    }

}

