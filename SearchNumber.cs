
using System;

namespace revaluation
{
    class SearchNumber
    {

        int check;

        public int searchNumFromArry()

        {
           
            int[] searching = { 1, 3, 4, 5, 7, 8, 10, 90 };
            
            Console.WriteLine("enter number ");
            string stringNum = Console.ReadLine();
            int integerNum = int.Parse(stringNum);

            check = Array.IndexOf(searching, integerNum);//this function to find index of item inside array. if user enter item that not found in array the retun will be -1.
            if (check == 0)
            {
                //Console.WriteLine("print -1");
            }

            else
            {

            }

            return check;
        }
    }
}
