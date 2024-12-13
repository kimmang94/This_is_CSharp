namespace This_is_CSharp_23
{
    internal class Program
    {
        enum DialogResult
        {
            YES,
            NO,
            CANCEL,
            COFIRM,
            OK
        }
        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.COFIRM);
            Console.WriteLine(result == DialogResult.OK);
        }
    }
}
