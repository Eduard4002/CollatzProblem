using System;

namespace CollatzProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;
            while(goAgain){
                bool isOne = false;
                long numberToStart = 0, count = 0;
                Console.Write("Enter a number to start with: ");
                numberToStart = long.Parse(Console.ReadLine());
                Console.WriteLine("");
                long currentNumber = numberToStart;
                while(isOne == false){
                    //To make sure we dont get stuck in a infinitive loop
                    if(currentNumber == 1) isOne = true;
                    Console.WriteLine($"Current Number: " + currentNumber);
                    //number is even, divide by 2
                    if(currentNumber % 2 == 0){
                        currentNumber /= 2;
                        //number is odd, multiply by 3 and add 1
                    }else if(currentNumber % 2 != 0){
                        currentNumber = 3 * currentNumber + 1;
                    }
                    //increase count
                    count++;
                }
                Console.WriteLine($"Process finished : Went through {count} counts");
                Console.WriteLine("Would you like to go again? [Y:N]");
                string temp = Console.ReadLine();
                Console.WriteLine("");
                if(temp == "N" || temp == "n"){
                    goAgain = false;
                }
            
            }
            Console.ReadLine();
            return;
        }
    }
}
            
    

