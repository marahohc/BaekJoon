using System;
class HelloWorld {
  static void Main() {
        int input = int.Parse(Console.ReadLine());
        int xmax = -10001; 
        int xmin = 10001;
        int ymax = -10001;
        int ymin = 10001;
        
        
        for(int i = 0; i < input; i++)
        {
            string[] s_input = Console.ReadLine().Split(" ");
            
            int x = int.Parse(s_input[0]);
            int y = int.Parse(s_input[1]);
            
            if(xmax < x)
            {
                xmax = x;
            }
            if(xmin > x)
            {
                xmin = x;
            }
            if(ymax < y)
            {
                ymax = y;
            }
            if(ymin > y)
            {
                ymin = y;
            }
        }
        if(input == 1)
        {
            Console.Write("0");
            return;
        }
        Console.Write((xmax - xmin)*(ymax - ymin));
        
  }
}