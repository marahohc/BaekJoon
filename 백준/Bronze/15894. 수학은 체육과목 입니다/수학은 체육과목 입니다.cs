using System;
class HelloWorld {
  static void Main() {
        long input = long.Parse(Console.ReadLine());
        long result = 0;
        long sum = 0;
        long box = 0;
        for(int i = 0; i < input; i++)
        {
            box += i+1;
            sum += i;
        }
        result = box * 4 - (sum*4);
        Console.Write(result);
  }
}