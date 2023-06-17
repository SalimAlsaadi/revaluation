using System.Diagnostics.CodeAnalysis;

namespace revaluation
{
    internal class Program
    {
       
        static void Main(string[] args)
        {


            SearchNumber srch = new SearchNumber();
            
            Console.WriteLine(srch.searchNumFromArry());

            int[] arr = { 4, 7, 3, 5, 1, 10, 90, 8 };

           
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1] )
                    {
                        int temp;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        
                      

                    }
                    
                }
                
                   

            }

           for(int i=0; i<arr.Length; i++)
            {
               // Console.WriteLine(arr[i]);
            }


        }
    }
}