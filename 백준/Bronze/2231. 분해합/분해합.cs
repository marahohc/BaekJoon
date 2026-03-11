using System;
class HelloWorld {
  static void Main() {
      int input = int.Parse(Console.ReadLine());
      int sum = 0;
      for(int i = 0; i < input; i++)
      {
          int j = i;
          sum += j;
          while(j > 0)
          {
              sum += j%10;
              j /= 10;
          }
          if(sum == input)
          {
              Console.Write(i);
              return;
          }
          sum = 0;
      }
      Console.Write(0);
  }
}