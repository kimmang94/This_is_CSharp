namespace This_is_CSharp_28
{
    internal class Program
    {
        /*
         * IndexOf() : 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치 찾기
         * LastIndexOf() : 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 뒤에서 부터 찾는다.
         * StartsWith() : 현재 문자열이 지정된 문자열로 시작하는지를 평가
         * EndsWith() : 현재 문자열이 지정된 문자열로 끝나는지를 평가
         * Contains() : 현재 문자열이 지정된 문자열을 포함하는지를 평가
         * Replace() : 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환
         * 
         */
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            // IndexOf()
            Console.WriteLine("IndexOf 'Good : {0}", greeting.IndexOf("Good"));
            Console.WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            // LastIndexOf()
            Console.WriteLine("LastIndexOf 'Good' : {0}", greeting.StartsWith("Good"));
            Console.WriteLine("LastIndexOf 'Morning' : {0}", greeting.StartsWith("Morning"));

            //EndsWith()
            Console.WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            Console.WriteLine("EndsWith 'Morning : {0}", greeting.EndsWith("Morning"));

            //Contains()
            Console.WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            Console.WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            //Replace()
            Console.WriteLine("REplaced 'Morning with 'Evening : {0}", greeting.Replace("Morning", "Evening"));
        }
    }
}
