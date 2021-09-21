using System;
using System.Collections.Generic;
using System.Linq;

namespace dailyTasks
{
    //This problem has its origins in a children's game for learning about division, remainders and fractions. 
    //Teachers have schoolchildren sit in a circle, and the person who starts the game says the number "1." 
    //Each student in the circle has a turn to say the next number in a pattern.
    //The catch is: for all numbers that are divisible by three, the player should say "foo." 
    //For any number divisible by five, the player should say "bar." Numbers divisible by both become "Foobar."
    //For example, a typical round of Foobar would start as follows:
    //1, 2, Foo, 4, Bar, Foo, 7, 8, Foo, Bar, 11, Foo, 13, 14, Foobar, 16, 17, Foo, 19, Bar, Foo, 22, 23, Foo, Bar, 26, Foo, 28, 29, Foobar, 31, 32, Foo, 34, Bar, Foo, ...
    //In this problem, you should write a program to play the Foobar game and display n elements of the Foobar pattern!

    public static class FooBar
    {
        public static IEnumerable<string> foobar(IEnumerable<int> nums)
        {
            /*foreach (var num in nums)
            {
                var res = (num % 3 ==0 && num % 5 ==0) ? "FooBar" : (num % 3 ==0 ) ? "Foo" : (num % 5  ==0 ) ? "Bar" : num.ToString();
                yield return res;
            }*/
            return nums.Select( num => (num % 3 == 0 && num % 5 == 0) ? "FooBar" :
                (num % 3 == 0) ? "Foo" :
                (num % 5 == 0) ? "Bar" : num.ToString());
        }
    }

    /*public static class FB
    {
        public static void Main(string[] args)
        {

            List<int> arr = new List<int>() { 1, 2, 3 };

            foreach (var s in FooBar.foobar(arr))
            {
                Console.WriteLine(s);
            }
        }
    }*/
    
    //на счет задачи про Api - нужно помнить что нужна проверка на ошибки,
    //обратить внимание на структуру которая используется для поиска
    //парный ключ лучше хотя бы тайпл а не массив
    //помнить из чего состоит словарь
    //использование concurentDictionary
    //ссылочное поле для lock должно быть static т.е. singleton и как быстрее осуществить поиск по городам 
}