using System;

namespace proj9Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int N = 1;
            int[] vect = new int[N];
            int[,] matriz;
            int s = 1;
            int T = 1;
            int T2 = 1;
            int T3 = 1;
            int cont = 0;

            while(s != 0)
            {


                N = int.Parse(Console.ReadLine());
                if (N > 0)
                {
                    s = N;
                }
                else
                {
                    N = s;
                    s = 0;
                }
               

            }
            int M = 1;

            matriz = new int[N, N];

            while(M < N + 1)
            {
                for (int i = 0; i < M; i++)
                {
                    
                    for (int j = 0; j < M; j++)
                    {
                        
                        if (i == j)
                        {
                            T = 1;
                            matriz[i, j] = T;
                            T3 = 2;
                            T2 = 2;


                        }    
                        
                        if(cont == 0)
                        {
                            T2 = 2;
                        }

                         if(i > j  )
                        {
                            
                            
                            matriz[i, j] = T2;
                            T2++;
                            cont++;
                        }
                        else if(j > i)
                        {
                            
                           
                            matriz[i, j] = T2;
                            T2++;
                            
                        }

                        
                        


                    }

                    cont = 0;
                    T2 = 1;
                    
                    


                }

                
                for (int i = 0; i < M; i++)
                {

                    for (int j = 0; j < M; j++)
                    {

                        Console.Write(matriz[i, j] + " ");

                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                M++;

            }


        
        }
    }
}
