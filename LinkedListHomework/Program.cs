﻿using System.Collections.Immutable;

namespace LinkedListHomework
{
    internal class Program
    {
       /* 요세푸스 순열 문제

        요세푸스 문제는 다음과 같다.
        1번부터 N번까지 N명의 사람이 원을 이루면서 앉아있고, 양의 정수 K(≤ N)가 주어진다.이제 순서대로 K번째 사람을 제거한다. 한 사람이 제거되면 남은 사람들로 이루어진 원을 따라 이 과정을 계속해 나간다. 이 과정은 N0명의 사람이 모두 제거될 때까지 계속된다. 원에서 사람들이 제거되는 순서를 (N, K)-요세푸스 순열이라고 한다.예를 들어 (7, 3)-요세푸스 순열은<3, 6, 2, 7, 5, 1, 4>이다.
        N과 K가 주어지면 (N, K)-요세푸스 순열을 구하는 프로그램을 작성하시오. */

        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            int n = 7;
            int k = 3;


            for (int i =1; i <= n; i++)
            {
                linkedList.AddFirst(i);
            }

             while(linkedList.Count > 0);
            {
                for(int i=1 ; i<k; i++)
                {
                    LinkedListNode<int> node = linkedList.First;
                    if( i== k)
                    {
                        linkedList.Remove(node);
                        Console.Write($"{node.Value} ");
                    }
                    else
                    {
                        linkedList.Remove(node);
                        linkedList.AddLast(node);
                    }
                }
            }
            
            

           
            

           
            


              
            
        }
    }
}





/*internal class Program                                                       
 * 사용자의 입력으로 숫자를 입력 받아서 (마이너스도 허용)
음수는 앞에 추가하고, 양수는 뒤에 추가하여
음수&양수를 반으로 나누는 연결리스트 구현
입력 받을 때마다 처음부터 끝까지 출력 진행
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            while (true)
            {
                Console.Write("숫자를 입력하세요 : ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    linkedList.AddFirst(num);
                }
                else if (num > 0)
                {
                    linkedList.AddLast(num);
                }
                else
                {
                    Console.WriteLine("0은 제외됩니다\n");
                }

                Console.Write("\n입력 받은 숫자는 : ");
                foreach (int value in linkedList)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine("\n");
            }
        }
    }*/

