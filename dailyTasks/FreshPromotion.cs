using System.Collections.Generic;
using System.Linq;

namespace dailyTasks
{
    public class t1 {
        public static int foo(List<string> codeList, List<string> shoppingCart)
        {
            int cartNum =0, codeNum = 0;
        
            while(cartNum< shoppingCart.Count && codeNum < codeList.Count)
            {
                var current = shoppingCart[cartNum];
            
                if((codeList[codeNum].Equals("anything") 
                    || codeList[codeNum].Equals(current)) 
                   && Order(shoppingCart, codeList, cartNum))
                {
                    cartNum += codeList[codeNum++].Count();
                }
                else
                    cartNum++;
            }
            return codeNum == codeList.Count ? 1: 0;
        }
    
        public static bool Order(List<string> order, List<string> cart,  int num)
        {
            foreach(var o in order)
            {
                if(num < cart.Count && (o.Equals("anything") || cart[num].Equals(o)))
                {
                    num++;
                }
                else
                    return false;
            }
            return true;
        }
    
    }
}

/*private static int freshPromotion(String[][] codeList, String[] shoppingCart) {
//        Start at 0 index for both the code list and shopping cart.
    int cartIdx = 0, codeIdx = 0;
    while (cartIdx < shoppingCart.length && codeIdx < codeList.length) {
        String cur = shoppingCart[cartIdx];
//            If the first fruit of the codeList is anything or if it matches the current fruit at the cart idx.
        if((codeList[codeIdx][0].equals("anything") || codeList[codeIdx][0].equals(cur)) 
           
           && hasOrder(shoppingCart, cartIdx, codeList[codeIdx])){
            cartIdx += codeList[codeIdx++].length;
        }else{
            cartIdx++;
        }
    }
//        If the all the codeList is present then return 1, else 0.
    return codeIdx == codeList.length ? 1 : 0;
}

private static boolean hasOrder(String[] shoppingCart, int idx, String[] order) {
//        Loop through the codeList to check if the fruits are in order.
    for (String s : order) {
        if (idx < shoppingCart.length && (s.equals("anything") || shoppingCart[idx].equals(s))){
            idx++;
        }else{
            return false;
        }
    }
    return true;*/
//}