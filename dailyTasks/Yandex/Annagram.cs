namespace dailyTasks.Yandex
{
    /*E. Анаграммы
Ограничение времени	1 секунда
Ограничение памяти	20Mb
Ввод	стандартный ввод или input.txt
Вывод	стандартный вывод или output.txt
Даны две строки, состоящие из строчных латинских букв. Требуется определить, являются ли эти строки анаграммами, т. е. отличаются ли они только порядком следования символов.

Формат ввода
Входной файл содержит две строки строчных латинских символов, каждая не длиннее 100 000 символов. Строки разделяются символом перевода строки.

Формат вывода
Выходной файл должен содержать единицу, если строки являются анаграммами, и ноль в противном случае.

*/
    public class Annagram
    {
        public static int Check(string word1, string word2)
        {
            if(word1.Length != word2.Length) return 0;
            
            int[] freq = new int[26];
            for(int i=0; i<word1.Length; i++)
                freq[word1[i]-'a']++;
            for(int i=0; i<word2.Length; i++)
            {
                if(freq[word2[i]-'a']==0) return 0;
                freq[word2[i]-'a']--;
            }  
            return 1;
           
        }

        /*static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            Console.WriteLine(Check(word1, word2));
        }*/
    }
}