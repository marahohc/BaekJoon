using System;
class HelloWorld {
  static void Main() {
      string[] inputs = Console.ReadLine().Split(" ");
      int N = int.Parse(inputs[0]);
      int M = int.Parse(inputs[1]);
      int appro = 0;
      
      string[] nums = Console.ReadLine().Split(" ");
      int[] num = new int[N];
      for(int i = 0; i < nums.Length; i++)
      {
          num[i] = int.Parse(nums[i]);
      }
      
      for(int i = 0; i < N-2; i++)
      {
          for(int j = i+1; j < N-1; j++)
          {
              for(int k = j+1; k < N; k++)
              {
                  if(M - appro >= M-(num[i]+num[j]+num[k]) && (num[i]+num[j]+num[k]) <= M)
                  {
                      appro = num[i]+num[j]+num[k];
                      if(appro == M)
                      {
                          Console.Write(appro);
                          return;
                      }
                  }
              }
          }
      }
      Console.Write(appro);
  }
}