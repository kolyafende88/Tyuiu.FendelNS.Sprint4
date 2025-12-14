using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FendelNS.Sprint4.Task7.V4.Lib
{
    public class DataService : ISprint4Task7V4
    {
        public int Calculate(int n, int m, string value)
        {
         
            int[,] matrix = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                 
                    matrix[i, j] = value[index] - '0'; 
                    index++;
                }
            }

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0) 
                    {
                        sum += matrix[i, j]; 
                    }
                }
            }

            return sum;
        }
    }
}