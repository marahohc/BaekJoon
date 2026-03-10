using System;
class HelloWorld {
  static void Main() {
      long num = int.Parse(Console.ReadLine());
      long count = 0;
      
      count = ((num *(num-1)*(num-2) / 6));
      Console.WriteLine(count);
      Console.WriteLine(3);
  }
} 