using System;

namespace INClass_Loop_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfExams = 0;
            double totalOfExamScores = 0;
            string answer;

            do
            {
                Console.WriteLine("What is your exam score? >>");
                double score = Convert.ToDouble(Console.ReadLine());
                totalOfExamScores = totalOfExamScores + score;

                numberOfExams = numberOfExams + 1;

                Console.WriteLine("Do you have another exam score to enter? yes or no? >>");
                answer = Console.ReadLine();
            } while (answer == "yes");

            double averageExamScore = totalOfExamScores / numberOfExams;
            averageExamScore = averageExamScore / 100;
            Console.WriteLine($"Your average exam score is {averageExamScore.ToString("P")}");

        }
    }
}
