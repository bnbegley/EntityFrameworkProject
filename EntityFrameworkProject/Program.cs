using EntityFrameworkProject.Models;
using System;
using System.Linq;

namespace EntityFrameworkProject {
    class Program {
        static void Main(string[] args) {
            var context = new AppDbContext();

            //var students = context.Students
            //    .Where(s=> s.GPA >= 3.0)
            //    .OrderByDescending(s => s.Lastname)
            //    .ToArray();

            // var students = context.Students.OrderBy(s => s.Firstname).ToList();

            var studentAverageSAT = context.Students
                .Average(s => s.SAT);

            Console.WriteLine($"The average SAT score is {studentAverageSAT}");




            //foreach(var student in studentAverageSAT) {
            // Console.WriteLine($"{student.Firstname} {student.Lastname} {student.SAT}");
            // }
        }

    }
}
