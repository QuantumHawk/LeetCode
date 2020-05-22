/*using System.Collections;

namespace dailyTasks
{
    public class Heap
    {
        public class minHeap
        {
            public int size, position;
            public int[] minHeapArray;

            public minHeap(int size)
            {
                this.size = size;
                minHeapArray=new int[size];
                position = 0;
            }

            public override string ToString()
            {
                string res = "";
                for (int i = 1; i < minHeapArray.Length; i++)
                {
                     res = " " + minHeapArray[i];
                }

                return res;

            }
            public void bubbleUp()
            {
                int pos = position - 1;
                while (pos > 0 && mH[pos / 2] > mH[pos])
                {
                    int y = mH[pos];
                    mH[pos] = mH[pos / 2];
                    mH[pos / 2] = y;
                    pos = pos / 2;
                }
            }
            public int extractMin()
            {
                int min = mH[1];
                mH[1] = mH[position - 1];
                mH[position - 1] = 0;
                position--;
                sinkDown(1);
                return min;
            }

            public void sinkDown(int k)
            {
                int a = mH[k];
                int smallest = k;
                if (2 * k < position && mH[smallest] > mH[2 * k])
                {
                    smallest = 2 * k;
                }
                if (2 * k + 1 < position && mH[smallest] > mH[2 * k + 1])
                {
                    smallest = 2 * k + 1;
                }
                if (smallest != k)
                {
                    swap(k, smallest);
                    sinkDown(smallest);
                }

            }
            public void swap(int a, int b)
            {
                //System.out.println("swappinh" + mH[a] + " and " + mH[b]);
                int temp = mH[a];
                mH[a] = mH[b];
                mH[b] = temp;
            }


            public void Add(int x)
            {
                if (position == 0)
                {
                    minHeapArray[position + 1] = x;
                    position = 2;
                }
                else {
                    minHeapArray[position++] = x;
                    bubbleUp();
                }
            }
            public void Fill(int[] array)
            {
                if (array.Length > 0)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        
                    }
                }
            }
            
        }

        public void example()
        {
            int[] arrA = new int[] {3, 2, 1, 7, 8, 4, 10, 16, 12};
            Console.WriteLine("Original Array : ");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("  " + arrA[i]);
            }

            minHeap m = new minHeap(arrA.Length);
            Console.Write("\nMin-Heap : ");
            m.createHeap(arrA);
            m.display();
            Console.WriteLine("\nExtract Min :");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("  " + m.extractMin());
            }
        }

        public static void Main()
        {
            //min Heap
            minHeap mh = new minHeap(2000);
            mh.example();
        }
    }
}*/