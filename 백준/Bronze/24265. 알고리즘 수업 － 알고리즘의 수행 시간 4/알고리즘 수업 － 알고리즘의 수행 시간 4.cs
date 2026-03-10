using System;
class HelloWorld {
  static void Main() {
      long num = int.Parse(Console.ReadLine());
      
      long count =0 ;
      for(int i = 1; i < num; i++)
      {
          count+=i;
      }
      Console.WriteLine(count);
      Console.WriteLine(2);
  }
} 