namespace dailyTasks.Yandex
{
    /*B. Последовательно идущие единицы
Ограничение времени	1 секунда
Ограничение памяти	64Mb
Ввод	стандартный ввод или input.txt
Вывод	стандартный вывод или output.txt
Требуется найти в бинарном векторе самую длинную последовательность единиц и вывести её длину.

Желательно получить решение, работающее за линейное время и при этом проходящее по входному массиву только один раз.

Формат ввода
Первая строка входного файла содержит одно число n, n ≤ 10000. Каждая из следующих n строк содержит ровно одно число — очередной элемент массива.

Формат вывода
Выходной файл должен содержать единственное число — длину самой длинной последовательности единиц во входном массиве.*/
    public class onesequence
    {
        public static int UnitSequence(int[] nums, int currentCase)
        {
            int best = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    currentCase++;
                    if (best < currentCase) best = currentCase;
                }
                else currentCase = 0;
            }
            return best;
        }
        /*static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int result = UnitSequence(array, 0);

            Console.WriteLine(result);
            Console.ReadLine();
        }*/
        
    }
}