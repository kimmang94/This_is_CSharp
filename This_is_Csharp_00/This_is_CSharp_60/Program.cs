﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex060 ex060 = new Ex060();
            ex060.Run();
        }

        public class Ex060
        {
            public void Run()
            {
                int[][] gradeOfStudent =
                {
                    new int[] { 100, 98, 95 },
                    new int[] { 90, 100, 100 },
                    new int[] { 88, 92, 98 }
                };

                for (int idx_i = 0; idx_i < gradeOfStudent.Length; idx_i++)
                {
                    for (int idx_j = 0; idx_j < gradeOfStudent[idx_i].Length; idx_j++)
                    {
                        Console.WriteLine("{0}번째 학생의 {1}번째 과목 성적 : {2}", (idx_i + 1), (idx_j + 1), gradeOfStudent[idx_i][idx_j]);
                    }
                }
            }
        }
    }
}
