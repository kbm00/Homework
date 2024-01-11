namespace _20240111.ListHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");
            int number = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < number + 1; i++)
            {
                list.Add($"{i}번째 데이터");
            }
            list.RemoveAt(0); 

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
