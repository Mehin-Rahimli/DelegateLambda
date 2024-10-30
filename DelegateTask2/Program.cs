namespace DelegateTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();
            exams.Add(new Exam { Subject = "Physics", ExamDuration = 2, StartDate = DateTime.Parse("2024,10,30,11:00:00") });
            exams.Add(new Exam { Subject = "Chemistry", ExamDuration = 3, StartDate = DateTime.Parse("2024,10,30,11:00:00") });
            exams.Add(new Exam { Subject = "History", ExamDuration = 2, StartDate = DateTime.Parse("2024,10,29 12:00:00") });
            exams.Add(new Exam { Subject = "Biology", ExamDuration = 2, StartDate = DateTime.Now });
            exams.Add(new Exam { Subject = "Math", ExamDuration = 3, StartDate = DateTime.Parse("2024,10,30 12:00:00") });


            DateTime oneweekago = DateTime.Now.AddDays(-7);
            List<Exam> ExamInLastWeek = exams.Where(e => e.StartDate >= oneweekago).ToList();
            Console.WriteLine("Son 1 hefte erzinde olan imtahan:");
            ExamInLastWeek.ForEach(e => Console.WriteLine($"Subject:{e.Subject}  ,exam duration:{e.ExamDuration}"));

            List<Exam> MoreThan2Hours = exams.Where(e => e.ExamDuration > 2).ToList();
            Console.WriteLine("\n2 saatdan cox ceken imtahan:");
            MoreThan2Hours.ForEach(e => Console.WriteLine($"Subject:{e.Subject}  ,Exam duration{e.ExamDuration}"));

            List<Exam> ContinuousExams = exams.Where(e => e.StartDate <= DateTime.Now && e.EndDate >= DateTime.Now).ToList();
            Console.WriteLine("\nDavam eden imtahan:");
            ContinuousExams.ForEach(e => Console.WriteLine($"\nSubject:{e.Subject}  ,Exam duration:{e.ExamDuration}"));
        }
    }
}
