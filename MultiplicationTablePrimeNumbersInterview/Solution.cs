
namespace MultiplicationTablePrimeNumbersInterview
{
    public static class Solution
    {
        public static List<int> GetPrimeNumbers(int num)
        {
            var listOfPrime = new List<int>();
            var count = 2;
            //num + 1 : Prime number creation
            while (listOfPrime.Count < num + 1)
            {
                if (IsPrimeNumber(count))
                {
                    listOfPrime.Add(count);
                }
                count++;
            }
            return listOfPrime;
        }

        public static List<int> PrintGrid(int num)
        {
            var gridList = new List<int>();

            if (CheckValidNumber(num))
            {
                var rows = GetPrimeNumbers(num);
                var columns = rows;                

                Console.Write("     ");

                foreach (int columnNum in columns)
                {
                    Console.Write(" {0,-3} ", columnNum);
                }
                Console.Write("\n\n");
                foreach (int rowNum in rows)
                {
                    Console.Write("{0,-3}| ", rowNum);
                    foreach (int columnNum in columns)
                    {
                        Console.Write(" {0,-3} ", columnNum * rowNum);
                        gridList.Add(columnNum * rowNum);
                    }
                    Console.Write("\n\n");
                }
            }
            
            return gridList;
        }

        public static bool CheckValidNumber(int num) => num > 0;        

        public static bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
