using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex069 ex069 = new Ex069();
            ex069.Run();
        }

        public class Ex069
        {
            public void Run()
            {
                ArrayList arrStudent = new ArrayList();

                Student student = new Student();
                student.Id = "S001";
                student.Name = "홍길동";
                student.Depatment = "국어국문학과";
                student.Grade = 1;
                student.Age = 21;

                arrStudent.Add(student);

                for (int idx = 0; idx < arrStudent.Count; idx++)
                {
                    Console.WriteLine(((Student)arrStudent[idx]).Id);
                    Console.WriteLine(((Student)arrStudent[idx]).Name);
                    Console.WriteLine(((Student)arrStudent[idx]).Depatment);
                    Console.WriteLine(((Student)arrStudent[idx]).Grade);
                    Console.WriteLine(((Student)arrStudent[idx]).Age);
                }
            }

        }
    }
}
