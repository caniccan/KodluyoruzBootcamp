using System;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    Grade Calculator                                  Letter Grade Average      
               ===========================                         ==========================   
                 *  first quiz   : %10                             AA: 90-100       CC: 65-74
                 *  second quiz  : %10                             BA: 85-89        DC: 60-64
                 *  midterm exam : %30                             BB: 80-84        DD: 55-59
                 *  final exam   : %50                             CB: 75-79        FD: 50-54
                                                                           FF: 0-49             
            */
            double firstQuiz, secondQuiz, midtermExam, finalExam ;
            
            GradeCalculator:
            try
            {
                Console.Write("First quiz result : ");
                firstQuiz = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Second quiz result : ");
                secondQuiz = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Midterm exam result : ");                   //we check the value inputs with try-catch
                midtermExam = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Final exam result : ");
                finalExam = Convert.ToUInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("you have entered an incorrect value, Let's try it again");
                goto GradeCalculator;
            }

            double totalPoint = 0;
            totalPoint +=Convert.ToDouble((firstQuiz/10)+(secondQuiz/10)+(midtermExam*30/100)+(finalExam*50/100));  //we calculate grade avarage 
            string letterGrade ;

            if (totalPoint<50) 
                letterGrade = "FF";
            else if (totalPoint<55)  
                letterGrade = "FD";           
            else if (totalPoint < 60)
                letterGrade = "DD";           
            else if (totalPoint < 65)           
                letterGrade = "DC";                         //we calculate letter grade from total point
            else if (totalPoint < 75)
                letterGrade = "CC";
            else if (totalPoint < 80)
                letterGrade = "CB";
            else if (totalPoint < 85)
                letterGrade = "BB";
            else if (totalPoint < 90)
                letterGrade = "BA";
            else
                letterGrade = "AA";

            Console.WriteLine($"Your grade average : {totalPoint} , your letter grade : {letterGrade} ");
        }
    }
}
