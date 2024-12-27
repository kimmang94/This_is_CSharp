using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex067 ex067 = new Ex067();
            ex067.Run();
        }

        public class Ex067
        {
            public void Run()
            {
                Hashtable hst = new Hashtable();
                hst.Add("korea", "한국");
                hst.Add("japan", "일본");
                hst.Add("brazil", "브라질");
                hst.Add("china", "중국");
                hst.Add("america", "미국");
                hst.Add("spain", "스페인");

                while (true)
                {
                    Console.WriteLine("단어를 입력하세요(Q:종료) : ");
                    string word = Console.ReadLine().ToLower();

                    if (word == "q")
                    {
                        break;
                    }

                    if (hst.Contains(word))
                    {
                        Console.WriteLine("{0} : {1}", word, hst[word]);

                        Console.WriteLine("단어를 삭제할까요? (Y: 삭제 / N : 미삭제) :");
                        string deleteYN = Console.ReadLine();

                        if (deleteYN.ToUpper() == "Y")
                        {
                            hst.Remove(word);
                        }
                    }
                    else
                    {
                        Console.WriteLine("단어 검색결과가 없습니다. 사전에 추가할까요?");

                        string addYN = Console.ReadLine();

                        if (addYN.ToUpper() == "Y")
                        {
                            Console.Write("뜻을 입력하세요 :");
                            string value = Console.ReadLine();

                            hst.Add(word, value);
                        }
                    }
                }
            }
        }
    }
}
