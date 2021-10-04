using System;
using System.Collections.Generic;
using System.Linq;

namespace dailyTasks
{
	public class ByteDance
	{
		/*
		
		    Implement the RandomizedSet class:
	
			RandomizedSet() Initializes the RandomizedSet object.
			bool insert(int val) Inserts an item val into the set if not present. Returns true if the item was not present, false otherwise.
			bool remove(int val) Removes an item val from the set if present. Returns true if the item was present, false otherwise.
			int getRandom() Returns a random element from the current set of elements (it's guaranteed that at least one element 
			exists when this method is called). Each element must have the same probability of being returned.
			You must implement the functions of the class such that each function works in average O(1) time complexity.
	
			Explanation
			RandomizedSet randomizedSet = new RandomizedSet();
			randomizedSet.insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
			randomizedSet.remove(2); // Returns false as 2 does not exist in the set.
			randomizedSet.insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
			randomizedSet.getRandom(); // getRandom() should return either 1 or 2 randomly.
			randomizedSet.remove(1); // Removes 1 from the set, returns true. Set now contains [2].
			randomizedSet.insert(2); // 2 was already in the set, so return false.
			randomizedSet.getRandom(); // Since 2 is the only number in the set, getRandom() will always return 2.
	*/

		public class RandomizedSet
		{

			Dictionary<int, int> dict;

			/** Initialize your data structure here. */
			public RandomizedSet()
			{
				dict = new Dictionary<int, int>();
			}

			/** Inserts a value to the set. Returns true if the set did not already
     * contain the specified element.
     */
			public bool Insert(int val)
			{
				if (!dict.TryGetValue(val, out var v))
				{
					dict.Add(val, val);
					return true;
				}

				return false;
			}

			/** Removes a value from the set. Returns true if the set contained the specified
     * element.
     */
			public bool Remove(int val)
			{
				if (dict.TryGetValue(val, out var v))
				{
					dict.Remove(val);
					return true;
				}

				return false;

			}

			/** Get a random element from the set.
    1,2,3,4....
		2,5,6,10*/
			public int GetRandom()
			{
				//todo ArgumentOutException
				//try catch
				var r = new Random();
				int i = r.Next(0, dict.Count-1); //[1,1],[2,10],11
				var val = dict.ElementAt(i).Value;
				return val;

			}
		}

		/**
		 * Your RandomizedSet object will be instantiated and called as such:
		 * RandomizedSet obj = new RandomizedSet();
		 * bool param_1 = obj.Insert(val);
		 * bool param_2 = obj.Remove(val);
		 * int param_3 = obj.GetRandom();
		 */
	}

	public static class Solutuin
	{
		public static void Main(string[] arg)
		{
			var randomizedSet = new ByteDance.RandomizedSet();
			var t =randomizedSet.Insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
			var t1 = randomizedSet.Remove(2); // Returns false as 2 does not exist in the set.
			var t2 = randomizedSet.Insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
			var t3 =randomizedSet.GetRandom(); // getRandom() should return either 1 or 2 randomly.
			var t4 =randomizedSet.Remove(1); // Removes 1 from the set, returns true. Set now contains [2].
			var t5 = randomizedSet.Insert(2); // 2 was already in the set, so return false.
			var t6 = randomizedSet.GetRandom();
		}
	}
}