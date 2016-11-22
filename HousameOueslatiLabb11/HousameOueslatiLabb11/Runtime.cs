using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static HousameOueslatiLabb11.Delegates;

namespace HousameOueslatiLabb11
{
    public delegate void PrintMessage();
    class Runtime
    {
        event PrintMessage NumberPuttedIn1;
        event PrintMessage NumberPuttedIn2;
        event PrintMessage NumberPuttedIn3;
        public int input;
        public void Start()
        {
            NumberPuttedIn1 += new PrintMessage(NumberIsEven);
            NumberPuttedIn2 += new PrintMessage(NumberIsDivisableByThree);
            NumberPuttedIn3 += new PrintMessage(NumberIsPrime);

            AnalyzeNumber isEven = NumberFilter.IsEven;
            AnalyzeNumber isDivisableByThree = NumberFilter.IsDivisableByThree;
            AnalyzeNumber isPrimeNumber = NumberFilter.IsPrimeNumber;

            input = InputController();
            if (isEven(input))
                NumberPuttedIn1?.Invoke();
            if (isDivisableByThree(input))
                NumberPuttedIn2?.Invoke();
            if (isPrimeNumber(input))
                NumberPuttedIn3?.Invoke();
            else
                Console.WriteLine("Nothing");




        }

        //void OnNumberPuttedIn()
        //{

        //    NumberPuttedIn?.Invoke();
        //}

        public void NumberIsEven()
        {
            Console.WriteLine("The number {0} is even", input);
        }

        public void NumberIsDivisableByThree()
        {
            Console.WriteLine("The number {0} is divisable by three", input);
        }

        public void NumberIsPrime()
        {
            Console.WriteLine("The number {0} is prime number", input);
        }


        int InputController()
        {
            Console.Clear();
            int num = 0;
            Console.Write("Write the number: ");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Make sure that you put in a number");
                Thread.Sleep(1000);
                InputController();

            };
            return num;
        }

    }
}
