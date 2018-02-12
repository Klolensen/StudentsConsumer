using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsConsumer.StudentService;

namespace StudentsConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new StudentService.Service1Client())
            {
                client.AddStudent("Kevin Jensen", "Program", "E202");
                Console.WriteLine(client.GetAllStudent().Length);
                foreach (var student in client.GetAllStudent())
                {
                    Console.WriteLine(student);
                }
                
            }

            //using (var client = new StudentService.Service1Client())
            //{   
            //    client.AddStudent("Kevin Jensen", "Program" , "E202");
            //    string student = client.FindStudents("Kevin Jensen");
            //    Console.WriteLine(student);
            //    client.EditStudent("Kevin Jensen", "John Doe", "Technology", "E202");
            //    Console.WriteLine(client.FindStudents("John Doe"));
            //    client.RemoveStudent("John Doe");
            //    Console.WriteLine(client.GetAllStudent().Length);
            //}
            Console.ReadKey();
        }
    }
}
