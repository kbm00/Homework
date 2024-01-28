using System.ComponentModel.Design;

namespace SortHomework
{
    internal class Sort 
    {
      public static void SelectionSort(IList<int> list)
      {
         for (int i =0; i < list.Count; i++) 
            {
                int minIndex = i;

                for (int j = i+1; j< list.Count; j++) 
                {
                    if (list[minIndex] > list[j])
                    
                        minIndex = j;
                    
                }
                Swap(list, i, minIndex);
         }
      }

     public static void InsertionSort(IList<int> list)
     {
       for (int i = 0; i < list.Count; i++)
       {
          for (int j = i; j >= 1; j--)
          {
            if (list[j] > list[j - 1])
                 break;

            Swap(list, j, j - 1);
                 
          }
        }
     }

     public static void MergeSort(IList<int> list, int start, int end)
     {
            if (start == end) 
                return;
            int mid = (start + end) / 2;
            MergeSort(list, start, mid);
            MergeSort(list, mid + 1, end);
            Merge(list, start, mid, end);
           
        

      }

     public static void Merge(IList<int> list,int start,int mid,int end)
        {
            List<int> sortList = new List<int>();
            int leftIndex = start;
            int rightIndex = mid + 1;

            while( leftIndex <= mid && rightIndex <= end )
            {

                if (list[leftIndex] < list[rightIndex])
                {
                    sortList.Add(list[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    sortList.Add(list[rightIndex]);
                    rightIndex++;
                }
            }

            if(leftIndex > mid)
            {
                for(int i= rightIndex; i <= end; i++)
                {
                    sortList.Add(list[i]);
                }
            }
            else
            {
                for(int i = leftIndex; i <= mid; i++)
                {
                    sortList.Add(list[i]);
                }
            }

            for(int i =0; i< sortList.Count; i++)
            {
                list[start+i] = sortList[i];
            }
        }

     public static void BubbleSort(IList<int> list)
     {
         for (int i = 0; i < list.Count; i++)
         {
             for( int j = 1; j < list.Count; j++)
             {
                    if (list[j] < list[j - 1])                  
                    Swap(list, j, j - 1);    
             }
         } 
     }


        public static void QuickSort(IList<int> list, int start, int end)
        {
            if (start >= end)
                return;

            int pivot = start;
            int left = pivot + 1;
            int right = end;

            while( left <= right)
            {
                while ( list[left] <= list[pivot] && left <right)
                {
                    left++;
                }
                while (list[right] > list[pivot] && left <= right)
                {
                    right++;
                } 
            }
            if (left < right)
            {
                Swap(list, left, right);
            }
            else
            {
                Swap(list, pivot, right);
            }

            Quick
             

        }
      private static void Swap(IList<int> list, int left, int right)
      {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;

      }

    } 
    
    
    internal class Program
    {
  
        static void Main(string[] args)
        {
            Random random = new Random();
            int count = 10;

            List<int> selectList = new List<int>();
            List<int> insertionList = new List<int>();
            List<int> bubbleList = new List<int>();
            List<int> mergeList = new List<int>();

            Console.WriteLine("랜덤 데이터 : ");
            for( int i = 0; i < count; i++)
            {
                int rand = random.Next() % 100;
                Console.Write($"{rand,3}");

                
                selectList.Add(rand);
                insertionList.Add(rand);
                bubbleList.Add(rand);
                mergeList.Add(rand);
                
            }
            Console.WriteLine();



            Console.WriteLine("선택 정렬 : ");
            Sort.SelectionSort(selectList);
            foreach( int i in selectList)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();


            Console.WriteLine("삽입 정렬 : ");
            Sort.InsertionSort(insertionList);
            foreach( int i in insertionList)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();
             
           
            Console.WriteLine("병합 정렬 : ");
            Sort.MergeSort(mergeList,0, mergeList.Count -1);
            foreach(int i in mergeList)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();


            Console.WriteLine("버블 정렬 : ");
            Sort.BubbleSort(bubbleList);
            foreach (int i in bubbleList)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();
        }
    }
}
