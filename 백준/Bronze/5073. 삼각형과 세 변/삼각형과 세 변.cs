using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    List<int> arc = new List<int>();

    int sum = 0;
    int max = 0;
    
    while(true)
    {
        string[] inputs = Console.ReadLine().Split(" ");
        for(int i = 0; i < 3; i++)
        {
            arc.Add(int.Parse(inputs[i]));
            sum+= arc[i];
            if(arc[i] > max)
                max = arc[i];
        }
        if(sum == 0)
        {
            return;
        }
        sum-=max;
        if(sum <= max)
        {
            Console.WriteLine("Invalid");
        }
        else if(arc[0] == arc[1]) 
        {
            if(arc[0] == arc[2] && arc[1] == arc[2])
            {
                Console.WriteLine("Equilateral");
            }
            else if(arc[0] != arc[2])
            {
                Console.WriteLine("Isosceles");
            }
        }
        else if(arc[0] == arc[2] || arc[1] == arc[2])
        {
            Console.WriteLine("Isosceles");
        }
        else
        {
            Console.WriteLine("Scalene");
        }
        arc.Clear();
        sum = 0;
        max = 0;
    }
  }
}