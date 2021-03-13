using System;

namespace First_Non_Repeating_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string problem;

            Console.WriteLine("Enter a string and the output will be the first non-repeating character:");
            problem = Console.ReadLine();


            Solve(problem);
        }

        public static void Solve(string problem)
        {

            bool foundIt = false;
            bool[] letters = new bool[problem.Length];

            for(int i =0;i<problem.Length;i++)
            {
                for(int j=0;j<problem.Length;j++)
                {
                    if(problem[i] == problem[j])
                    {
                        if(i == j)
                        {
                            continue;
                        }
                        else{
                            letters[i] = true;
                        }
                    }
                }
            }

            for(int i=0;i<letters.Length;i++)
            {
                if(letters[i]==false)
                {
                    Console.WriteLine(problem[i]);
                    foundIt = true;
                    return;
                }
            }

            if(foundIt == false)
            {
                Console.WriteLine("No non-reapting character");
            }
            

        }
    }
}
