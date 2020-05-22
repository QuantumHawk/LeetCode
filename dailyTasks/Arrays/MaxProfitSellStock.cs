using System;

namespace dailyTasks.Arrays
{
    /**
 122. Best Time to Buy and Sell Stock II
 https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
 Say you have an array for which the ith element is the price of a given stock on day i.
 Design an algorithm to find the maximum profit. You may complete as many transactions as you like
 (ie, buy one and sell one share of the stock multiple times).
 However, you may not engage in multiple transactions at the same time
 (ie, you must sell the stock before you buy again).
 */
    public class MaxProfitSellStock
    {
        // looking for the local minimums and maximums
        public int maxProfit1(int[] prices) {
            int profit = 0;
            if (prices.Length<2) return profit;
            if (prices.Length==2) {
                profit = prices[1]-prices[0];
                if (profit > 0) return profit;
                else return 0;
            }
            int min = -1;
            for (int i=0; i<prices.Length; i++) {
                //local minimum in the first day;
                if (i==0 && prices[i]<=prices[i+1]) min=prices[i];
                // local maximum in the last day;
                else if (i==prices.Length-1 && prices[i]>=prices[i-1] && min != -1) {
                    profit += prices[i]-min;
                    min = 0;
                }
                // local minimum or maximum in the middle
                else if (i>0 && i<prices.Length-1){
                    if (prices[i]<=prices[i-1] && prices[i] <= prices[i+1]) {
                        min = prices[i];
                    } else if (prices[i]>=prices[i-1] && prices[i] >= prices[i+1] && min != -1) {
                        profit += prices[i]-min;
                        min = -1;
                    }
                }
            }
            return profit;
        }

        // EASY SOLUTION every-day buy-sell solution
        public int maxProfit(int[] prices) {
            int profit = 0;
            for (int i=0; i<prices.Length-1; i++) {
                profit += Math.Max(prices[i+1]-prices[i], 0);
            }
            return profit;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            //int[] nums = {6,5,5,7,9,9,6,4,3,5,7,6};
            int[] nums = {2,1,2,0,1};
            int profit = s.maxProfit(nums);
            System.out.print(profit);
        }
    }*/
}