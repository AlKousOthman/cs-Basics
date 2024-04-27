namespace cs_Basics
{
    public class Program
    {
        static void Main(string[] args)
        {

            // C#
            // TASK 1
            string name = "Othman";
            int age = 24;
            double accountBalance = 22.5;
            bool graduate = false;

            Console.WriteLine($"My name is {name}, and i am {age} yaers old, and i have {accountBalance}kd in my account");
            Console.WriteLine(graduate);

            // TASK 2

            int number = 5;

            double result = Convert.ToDouble(number);

            // BONUS 1
            char email = '@';
            Console.WriteLine(email);

            // C# VARIABLES
            // TASK 1

            string studentName = "Othman";

            double gradePointAverage = 3.29;

            string favoriteSubject = "System Analysis";
            Console.WriteLine($"My name is {studentName}, and my gpa is {gradePointAverage}, and my favorite subject is {favoriteSubject}");

            // TASK 2
            double width = 5.5;
            double height = 3.2;
            double area = width * height;
            Console.WriteLine(area);

            // BONUS 2
            const int myConst = 15;
            Console.WriteLine(myConst);


        }
    }
}
