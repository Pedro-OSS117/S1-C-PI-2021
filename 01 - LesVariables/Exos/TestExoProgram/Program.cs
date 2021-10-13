using System;

namespace TestExoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int division = 5 / 3;
            Console.WriteLine("division : " + division);
            int result  = 3 + division;
            Console.WriteLine("result : " + result);

            int operand1 = 5;
            int operand2 = 2;
            float divisionFloat = (float)operand1 / operand2; 
            Console.WriteLine("divisionFloat : " + divisionFloat);

            double d50 = 1.0f;
            long value = 1520;
            divisionFloat = value;

            double d2 = 1.0f;
        }
    }
}
