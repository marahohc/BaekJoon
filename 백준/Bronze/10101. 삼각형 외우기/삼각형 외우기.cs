using System;
class HelloWorld {
  static void Main() {
    int[] arc = new int[3];
    int sum = 0;
    for(int i = 0; i < 3; i++)
    {
        int input = int.Parse(Console.ReadLine());
        arc[i] = input;
        sum+= input;
    }
    if(sum != 180)
    {
        Console.Write("Error");
        return;
    }
    if(arc[0] == arc[1]) 
    {
        if(arc[0] == arc[2] && arc[1] == arc[2])
        {
            Console.Write("Equilateral");
        }
        else if(arc[0] != arc[2])
        {
            Console.Write("Isosceles");
        }
    }
    else if(arc[0] == arc[2] || arc[1] == arc[2])
    {
        Console.Write("Isosceles");
    }
    else
    {
        Console.Write("Scalene");
    }
  }
}