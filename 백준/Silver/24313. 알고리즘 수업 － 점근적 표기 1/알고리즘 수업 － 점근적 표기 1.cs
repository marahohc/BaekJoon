using System;
class HelloWorld {
  static void Main() {
      string[] inputs = Console.ReadLine().Split(" ");
      int a1 = int.Parse(inputs[0]);
      int a0 = int.Parse(inputs[1]);
      
      int c = int.Parse(Console.ReadLine());
      int n0 = int.Parse(Console.ReadLine());
      
      if((a1*n0)+a0 > c*n0)
      {
          Console.Write(0);
      }
      else if(a1 > c)
      {
          Console.Write(0);
      }
      else
      {
          Console.Write(1);
      }
  }
}