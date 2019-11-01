using System;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your GPA: ");
            decimal.TryParse(Console.ReadLine(), out decimal enteredGPA);
            Console.Write("Enter your admission test score: ");
            int.TryParse(Console.ReadLine(), out int enteredScore);

            if ((enteredGPA < 3.0M && enteredScore >= 80) || (enteredGPA >= 3.0M && enteredScore >= 60))
            {
                Console.WriteLine("Accept");
            } else {
                Console.WriteLine("Reject");
            }
        }
    }
}
