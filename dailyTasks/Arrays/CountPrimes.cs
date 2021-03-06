namespace dailyTasks.Arrays
{
    /**
 204. Count Primes
 https://leetcode.com/problems/count-primes/
 Count the number of prime numbers less than a non-negative number, n.
 https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes Решето Эратосфена
 https://ru.wikipedia.org/wiki/%D0%A0%D0%B5%D1%88%D0%B5%D1%82%D0%BE_%D0%AD%D1%80%D0%B0%D1%82%D0%BE%D1%81%D1%84%D0%B5%D0%BD%D0%B0
 https://en.wikipedia.org/wiki/Sieve_of_Atkin
 http://stackoverflow.com/questions/453793/which-is-the-fastest-algorithm-to-find-prime-numbers
 
Input: 10
Output: 4
Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
 */
    public class CountPrimes
    {
        // n - is not included
        public int countPrimes(int n) {
            // first index - 0, last index - n-1;
            bool[] arr = new bool[n];
            for(int i=2; i<n; i++) arr[i] = true;

            for(int p=2; p*p<n; p++) { // or p<=Math.sqrt(n)
                if (!arr[p]) continue;
                for (int i=p*p; i<n; i+=p) { // or i=p*p + i*p => i=p*(i+p), or for (int j = i * i; j < n; j += i)
                    arr[i] = false;
                }
            }
            int cnt=0;
            for (int i=2; i<n; i++)
                if (arr[i]) cnt++;
            return cnt;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            System.out.print(s.countPrimes(7));
        }
    }*/
}