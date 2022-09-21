public class Solution {
 
       public   int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums.Length == 0) return new int[] { };
        else if (k == 1 ) return nums;
        
        else
        {
            List<int> max = new List<int>();
              
            List<int> order = new List<int>();
            order.Add(0);
            int slidingwindow = 0;
            for (int startIndex = 0; startIndex < nums.Length; startIndex++)
            {
              
                if (order.Count>0 )// index is outside window 
                {  
                    int index = order[0];
                    if ( index <= (startIndex - k))
                      order.RemoveAt(0);
                 
                }
                if (order.Count == 0)
                {
                    order.Add(startIndex);
                   // Console.WriteLine("smaller=  " + order.Peek());
                    slidingwindow++;
                }
                else if (nums[startIndex] >= nums[order[0]])
                {
                    slidingwindow++;
                    order = new List<int>();
                    order.Add(startIndex);
                }

                else
                {
                while(nums[startIndex] > nums[order.Last()])
                    {
                    order.RemoveAt(order.Count-1);
                    if(order.Count ==0 )break ; 
                    }
                    slidingwindow++;
                    order.Add(startIndex);
                   // Console.WriteLine("bigger =  " + order.Peek());
                }

                if (slidingwindow == k)
                {

                  //  Console.WriteLine("res  add = " + nums[order.Peek()]);
                    max.Add(nums[order[0]]);
                    slidingwindow--;
                }



            }


            return max.ToArray();
        }
    }
         }