using System;

namespace dailyTasks
{
    public class Priority_Queue
    {

        public int size;
        public int[] mH;
        public int position;

        public Priority_Queue(int size)
        {
            this.size = size;
            mH = new int[size + 1];
            position = 0;
        }

        public void createHeap(int[] arrA)
        {
            if (arrA.Length > 0)
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    insert(arrA[i]);
                }
            }
        }

        public void display()
        {
            for (int i = 1; i < mH.Length; i++)
            {
                Console.Write(" " + mH[i]);
            }

            Console.Write("");
        }

        public void insert(int x)
        {
            if (position == 0)
            {
                mH[position + 1] = x;
                position = 2;
            }
            else
            {
                mH[position++] = x;
                bubbleUp();
            }
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
    }
}
