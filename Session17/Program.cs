using Session17.Services.Abstractions;
using Session17.Services.Abstractions.Implimentations;
using System;

namespace Session17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ISendEmailService sendEmailService = new SendEmailService();
            //sendEmailService.SendEmail
            //    ("bahador567@gmail.com", "zahrabaniyaghob35@yahoo.com", "helo bahador test code", new string[0]);

            Repository repository = new Repository();
            //var result = repository.InsertStudent(new Models.StudentModel
            //{
            //    FirstName = "mohamad",
            //    LastName = "soleymani",
            //    BirthDate = Convert.ToDateTime("1980-11-23"),
            //    StudentNumber = "1498787458",
            //    RegisterDate = DateTime.Now,


            //});

            //Console.WriteLine($"The Result is :{result.ToString()} Status :{(int)result}");
            var data = repository.GetAll();
            Console.WriteLine($"Status :{data.Status.ToString()}");
            foreach (var item in data.List)
            {
                Console.WriteLine($"{item.Id}{item.FirstName} {item.LastName}{item.BirthDate}{item.StudentNumber}");
            }



        }
    }
}
