using System;
class HelloWorld {
  static void Main() {
        string[] input = Console.ReadLine().Split(" ");
        int num1 = int.Parse(input[0]);
        int num2 = int.Parse(input[1]);
        int num3 = int.Parse(input[2]);
        int num4 = int.Parse(input[3]);
        int min = num1;
        
        if(num2 - 0 < min)
            min = num2;
        if(num3 - num1 < min)
            min = num3 - num1;
        if(num4 - num2 < min)
            min = num4 - num2;
            
        Console.Write(min);
  }
}