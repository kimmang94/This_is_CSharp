﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using This_is_CSharp_93;

namespace This_is_CSharp_94
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex094 ex094 = new Ex094();
            ex094.Run();
        }

        public class Ex094
        {
            public void Run()
            {
                List<Student> students = new List<Student>()
            {
                new Student { Id = "S001", Name = "Dexter", Grade = 3, Major = "Software" },
                new Student { Id = "D001", Name = "Ellin", Grade = 3, Major = "Design" },
                new Student { Id = "S002", Name = "Jeffrey", Grade = 4, Major = "Software" },
                new Student { Id = "D002", Name = "Sienna", Grade = 4, Major = "Design" },
                new Student { Id = "S003", Name = "Pil", Grade = 4, Major = "Software" },
                new Student { Id = "S006", Name = "Clint", Grade = 3, Major = "Software" },
                new Student { Id = "S004", Name = "Khan", Grade = 2, Major = "Software" },
                new Student { Id = "A001", Name = "Mike", Grade = 2, Major = "Advertisement" },
                new Student { Id = "S005", Name = "Sven", Grade = 2, Major = "Software" },
                new Student { Id = "T001", Name = "Peter", Grade = 1, Major = "Teater" },
            };

                students.Where(
                    s => s.Grade == 1 || s.Grade == 3).ToList().ForEach(s => Console.WriteLine(s.Name));
            }
        }
    }
}
