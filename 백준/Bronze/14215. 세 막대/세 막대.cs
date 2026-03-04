using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
      string[] input = Console.ReadLine().Split(" ");
      List<int> num = new List<int>();
      int max = 0;
      for(int i = 0; i < 3; i++)
      {
          if(int.Parse(input[i]) > max)
          {
              if(max != 0)
              {
                  num.Add(max);
              }
              max = int.Parse(input[i]);
          }
          else
          {
              num.Add(int.Parse(input[i]));
          }
      }
      while(max >= num[0] + num[1])
      {
          max-=1;
      }
      
      Console.Write(num[0] + num[1] + max);
  }
}