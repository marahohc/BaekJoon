using System;
class HelloWorld {
  static void Main() {
        int[] x = new int[3];
        int[] y = new int[3];
        int tempx = 0;
        int tempy = 0;
        for(int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            int num1 = int.Parse(input[0]);
            int num2 = int.Parse(input[1]);
            
            x[i] = num1;
            y[i] = num2;
        }
        tempx = x[0];
        if(x[1] != tempx)
        {
            if(x[1] != x[2])
            {
                tempx = x[1];
            }
        }
        else
        {
            tempx = x[2];
        }
        tempy = y[0];
        if(y[1] != tempy)
        {
            if(y[1] != y[2])
            {
                tempy = y[1];
            }
        }
        else
        {
            tempy = y[2];
        }
        Console.Write(tempx +" "+ tempy);
  }
}