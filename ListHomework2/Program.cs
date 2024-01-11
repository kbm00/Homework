namespace ListHomework2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(5);
            list.Add(3);
            list.Add(9);
            list.Add(10);


            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                int num = int.Parse(Console.ReadLine());
                  
                if (list.IndexOf(num) == -1)
                {
                    list.Insert(num-1, num);
                    Console.WriteLine($"입력한{num}가 현재 리스트에 없으므로 추가합니다.");
                }

                else if (list.IndexOf(num) != -1)
                {
                    list.Remove(num);
                    Console.WriteLine($"입력한{num}가 현재 리스트에 있으므로 제거합니다.");
                }
                list.Sort();

                Console.Write("현재 리스트에 있는 숫자는 : ");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write($"{list[i]} ");
                }
                Console.WriteLine();
            }

        }

        
    }
    
}
