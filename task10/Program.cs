using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            //verilmis ededler siyahisindan cut ededlerden ibaret array deuzelden proqram

            Console.WriteLine("ededlerin sayini daxil edin:");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            Console.WriteLine("ededleri daxil edin:");
            
            int[] numbers = new int[num];
            int count = 0;
            
           
            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
                
            }

            int[] numcut = new int [count];
            int j = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numcut[j] = numbers[i];
                    j++;

                }
            }
            Console.WriteLine("cut ededler arrayi:");
            foreach(var item in numcut)
            {
                Console.WriteLine(item);
            }


        }
    }
}
