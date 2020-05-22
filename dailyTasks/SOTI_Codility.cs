namespace dailyTasks
{
    public class SOTI_Codility
    {
        /*Example test:   (3, [1, 2, 3, 3, 1, 3, 1])
Output (stderr):

    Unhandled Exception:
System.IndexOutOfRangeException: Array index is out of range.
    at Solution.solution (Int32 M, System.Int32[] A) [0x00000] in <filename unknown>:0 
at SolutionWrapper.run (System.String input, System.String output) [0x00000] in <filename unknown>:0 
at SolutionWrapper.Main (System.String[] args) [0x00000] in <filename unknown>:0 
[ERROR] FATAL UNHANDLED EXCEPTION: System.IndexOutOfRangeException: Array index is out of range.
    at Solution.solution (Int32 M, System.Int32[] A) [0x00000] in <filename unknown>:0 
at SolutionWrapper.run (System.String input, System.String output) [0x00000] in <filename unknown>:0 
at SolutionWrapper.Main (System.String[] args) [0x00000] in <filename unknown>:0 
RUNTIME ERROR (tested program terminated with exit code 1)*/
        public static int solution_works(int M, int[] A)
        {
            int N = A.Length;
            int[] count = new int[M];
            for (int i = 0; i < M; i++)
                count[i] = 0;
            int maxOccurence = 1;
            int index = -1;
            for (int i = 0; i < N; i++)
            {
                if (count[A[i]] > 0)
                {
                    int tmp = count[A[i]];
                    if (tmp > maxOccurence)
                    {
                        maxOccurence = tmp;
                        index = A[i];
                    }

                    count[A[i]] = tmp + 1;
                }
                else
                {
                    count[A[i]] = 1;
                }
            }

            return count[index];
        }

        public static int sol(int X, int[] A)
        {
            int len = A.Length;
            int res = 0;
            int index = 0;
            int[] mask = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == X) mask[i] = 1;
                else mask[i] = 0;
            }

            for (int j = 0; j < A.Length; j++)
            {
                if (mask[j] != mask[len - 1])
                {
                    index = len;
                    res++;
                }
            }

            if (res == 0) return A.Length - 1;
            return res;
        }

        /*public static void Main(string[] args)
        {
            var A = new int[] {5,5,1,7,2,3,5};
            int m = 4;
            
            
            Console.WriteLine("Input  : " + String.Join(",", A));
           // Console.WriteLine("Result : " + String.Join(",", B));
            Console.ReadLine();


        }*/
    }
}