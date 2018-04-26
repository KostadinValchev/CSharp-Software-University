namespace Mankind
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var studentInfo =
                    Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var workerInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var studentFirstName = studentInfo[0];
                var studentLastName = studentInfo[1];
                var facultyNumber = studentInfo[2];

                var workerFirstName = workerInfo[0];
                var workerLastName = workerInfo[1];
                var salary = decimal.Parse(workerInfo[2]);
                var workingHoures = double.Parse(workerInfo[3]);


                Student student = new Student(studentFirstName, studentLastName, facultyNumber);
                Worker worker = new Worker(workerFirstName, workerLastName, salary, workingHoures);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
