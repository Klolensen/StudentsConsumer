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
            using (Service1Client client = new Service1Client())
            {
                client.AddStudent("Kevin Jensen", "Program", "E202");
                Console.WriteLine(client.GetAllStudent().Length);
                Console.WriteLine(client.FindStudents("Kevin Jensen"));
                client.RemoveStudent("Kevin Jensen");
            }

            using (Service1Client client = new Service1Client())
            {
                client.RemoveStudent("Kevin Jensen");
                client.RemoveStudent("John Doe");
                client.AddStudent("Kevin Jensen", "Program", "E202");
                client.EditStudent("Kevin Jensen", "John Doe", "Technology", "E202");
                List<string> list = new List<string>(client.GetAllStudent());
                foreach (string student in list)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine(client.FindStudents("John Doe"));
            }
            Console.ReadKey();
        }
    }
}
