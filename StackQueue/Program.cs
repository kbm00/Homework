namespace StackQueue
{
/*  <작업 프로세스>
3.배열로 각 작업이 몇시간이 걸리는지 있다.
예시 : [4, 4, 12, 10, 2, 10]

하루에 8시간씩 일할 수 있는 회사가 있음.
남는시간없이 주어진 일을 계속한다고 했을때.
각각의 작업이 끝나는 날짜를 결과 배열로 출력

int[] ProcessJob(int[] jobList) { }

    결과 : [1, 1, 3, 4, 4, 6]*/
    internal class Program
    {
        public const int WorkTime = 8;
        
        
        public static int[] ProcessJob(int[] jobList)
        {
            Queue<int> queue = new Queue<int>();
            int remainTime = 8;
            int day = 1;
            List<int> days = new List<int>();
           
            for(int i = 0; i < jobList.Length; i++) 
            {
                queue.Enqueue(jobList[i]);
            }

           while (queue.Count > 0)
            {
                int workTime = queue.Dequeue();
            while (true)
                {
                    if (workTime <= remainTime)
                    {
                        remainTime -= workTime;
                        days.Add(day);
                        break;
                    }
                    else
                    {
                        workTime -= remainTime;

                        day++;
                        remainTime = 8;
                    }
                }
                
            }
            return days.ToArray();
        }

         static void Main(string[] args)
        {
            int[] result = ProcessJob(new int[] { 4, 4, 12, 10, 2, 10 });
            foreach (int day in result)
            {
                Console.WriteLine(day);
            }
        }
    }
}






/*< 실습 >

1.아래와 같이 추가와 삭제가 순서대로 진행될 경우 스택, 큐의 출력 순서를 적어주자.(코딩없이)
꺼내기 마다 모두 출력 적어주자
1)추가(1, 2, 3, 4, 5), 모두 꺼내기 :  
스택 : 5, 4, 3, 2, 1
  큐 : 1, 2, 3, 4, 5
2)추가(1,2,3), 꺼내기(2번), 추가(4,5,6), 꺼내기(1번), 추가(7), 모두꺼내기 : 
 스택 :              3,2                         6                       7,5,4,1 
  큐 :               1,2                         3                       4,5,6,7
3)추가(3,2,1), 꺼내기(1번), 추가(6,5,4), 꺼내기(3번), 추가(9,8,7), 모두꺼내기 :
 스택 :                1                          4,5,6                      7,8,9,2,3 
   큐 :                3                          2,1,6                     5,4,9,8,7
4)추가(1,3,5), 꺼내기(1번), 추가(2,4,8), 꺼내기(2번), 추가(1, 3), 모두꺼내기 : 
 스택 :                5                          8,4                         3,1,2,3,1
   큐 :                1                          3,5                         2,4,8,1,3
5)추가(3,2,1), 꺼내기(2번), 추가(3,2,1), 꺼내기(2번), 추가(3,2,1), 모두꺼내기 : 
 스택 :               1,2                          1,2                          1,2,3,3,3
    큐 :              3,2                          1,3                          2,1,3,2,1


<괄호 검사기 구현>
괄호 : 괄호가 바르게 짝지어졌다는 것은 열렸으면 짝지어서 닫혀야 한다는 뜻

텍스트를 입력으로 받아서 괄호가 유효한지 판단하는 함수
bool IsOk(string text) {}

검사할 괄호 : [], {}, ()

예시 : () 완성, (() 미완성, [) 미완성, [[(){}]] 완성

   

internal class Program
    {
        public static bool IsOK(string text)
        {
                
          Stack<char> stack = new Stack<char>();


            foreach (char c in text)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == '{')
                {
                    stack.Push(c);
                }
                else if (c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                        return false;
                    char bracket = stack.Pop();
                    if ( bracket == '(')
                    {
                        
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == '}')
                {
                    if (stack.Count == 0)
                        return false;
                    char bracket = stack.Pop();
                    if (bracket == '{')
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == ']')
                {
                    if (stack.Count == 0)
                        return false;
                    char bracket = stack.Pop();
                    if (bracket == '[')
                    {

                    }
                    else
                    {
                        return false;
                    }          
                }
               
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }

         static void Main(string[] args)
        {
            do
            {
                string text = Console.ReadLine();
                Console.WriteLine(IsOK(text));
            } while (true);  
        }
    }


 */