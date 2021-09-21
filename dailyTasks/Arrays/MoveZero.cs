namespace dailyTasks.Arrays
{
    public class MoveZero
    {
        public void moveZeroes(int[] nums) 
        {
            int snowBallSize = 0; 
            for (int i=0;i<nums.Length;i++)
            {
                if (nums[i]==0){
                    snowBallSize++; 
                }
                else if (snowBallSize > 0)
                {    
                    nums[i-snowBallSize]=nums[i];
                    nums[i]=0;
                }
            }
        }
    }
}