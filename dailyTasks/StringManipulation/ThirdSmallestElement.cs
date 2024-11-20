using System;

namespace dailyTasks.StringManipulation
{
    public class ThirdSmallestElement
    {
        public static void ThirdSmallestElementInArray(int[] arrA)
        {
            if (arrA.Length < 3)
            {
                Console.WriteLine("Invalid Input, array size is less than 3");
                return;
            }

            int first = int.MaxValue;
            int second = int.MaxValue;
            int third = int.MaxValue;

            foreach (var current in arrA)
            {
                if (current < first)
                {
                    third = second;
                    second = first;
                    first = current;
                }
                else if (current < second)
                {
                    third = second;
                    second = current;
                }
                else if (current < third)
                {
                    third = current;
                }
            }

            Console.WriteLine("Third smallest element is: " + third);
        }

        /*public static void Main(string[] args)
        {
            int[] arrA = { 6, 8, 1, 9, 2, 10 };
            ThirdSmallestElementInArray(arrA);
        }*/
    }
}

/*public class ThirdSmallestElement {

    public static void thirdSmallestElement(int [] arrA){

        if(arrA.length<3){
            System.out.println("Invalid Input, array size is less than 3");
        }

        int first=Integer.MAX_VALUE;
        int second=Integer.MAX_VALUE;
        int third = Integer.MAX_VALUE;

        for (int i = 0; i <arrA.length ; i++) {
            int current = arrA[i];
            if(first>current){
                third = second;
                second = first;
                first = current;
            }else if(second>current){
                third = second;
                second = current;
            }else if(third>current){
                third=current;
            }
        }
        System.out.println("Third smallest element is: " + third);
    }

    public static void main(String[] args) {
        int [] arrA = new int [] { 6, 8, 1, 9, 2, 10};
        thirdSmallestElement(arrA);
    }
}


public class MinimumCopyPasteDP {
    public int find(int number){
        int res = 0;
        for(int i=2;i<=number;i++){
            while(number%i == 0){ //check if problem can be broken into smaller problem
                res+= i; //if yes then add no of smaller problems to result. If number = 25  i = 5 then 5*5 = 25 so add 5 to results
                number=number/i; // create smaller problem
            }
        }
        return res;
    }

    public static void main(String[] args) {
        MinimumCopyPasteDP m = new MinimumCopyPasteDP();
        int n = 50;
        System.out.println("Minimum Operations: " + m.find(n));

    }
}*/