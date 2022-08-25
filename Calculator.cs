using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatR
{
    class Calculator
    {

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }

        public void GetInputs()
        {
            Console.WriteLine("Type 1st number: ");
            FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation(+,-,*,/,%): ");
            Operation = Console.ReadLine();
            Console.WriteLine("Type 2nd number: ");
            SecondNumber = int.Parse(Console.ReadLine());

        }

        public bool IsFirstNumberPositive()
        {
            return FirstNumber >= 0;
        }

        public void CompareInputs()
        {
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("1st number is greater than 2nd number");

            }
            else if (FirstNumber == SecondNumber)
            {
                Console.WriteLine("numbers are equal");

            }
            else
            {
                Console.WriteLine("1st number is less than 2nd number");
            }
        }
        public string Calculate()
        {
            return Operation switch
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                "%" => $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}",
                _ => "Operation is not found"
            };
            // switch (Operation)
            // {
            //     case "+":
            //         return $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}";
            //         break;
            //     case "-":
            //         return $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}";
            //         break;
            //     case "*":
            //         return $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}";
            //         break;
            //     case "/":
            //         return $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}";
            //         break;
            //     case "%":
            //         return $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}";
            //         break;
            //     default: return "Operation is not found";
            //             break;
            // }
            // return Operation;

        }

        public void PrintEvenNumbers()
        {
            int counter = 2;
            while (counter < FirstNumber)
            {
                Console.WriteLine(counter);
                counter+=2;
            }

        }

        public void MultiplicationTable()
        {
            for (int iterator = 1; iterator <= 10; iterator++)
            {
                for (int innerIterator = 1; innerIterator <= 10; innerIterator++)
                {
                    Console.WriteLine($"{iterator} * {innerIterator} = {iterator * innerIterator}");
                }

            }
        }
    }
}
