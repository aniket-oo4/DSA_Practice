using System;
using System.Collections.Generic;
class P2
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        while(T>0)
        {
            
            string[] input = Console.ReadLine().Split();
            int[] arr = Array.ConvertAll(input, int.Parse);
            int n=arr[0];
            int k=arr[1];
            // Console.WriteLine("n="+n+" k="+k);  
            string [] inputArrString=Console.ReadLine().Split();
            int[] b=Array.ConvertAll(inputArrString,int.Parse);
 
            Dictionary<int ,int> dictFrequency=new Dictionary<int, int>();
            for(int i=0;i<n;i++)
            {
                if(dictFrequency.ContainsKey(b[i]))
                {
                    dictFrequency[b[i]]++;
                }
                else
                {
                    dictFrequency.Add(b[i],1);
                }
            }
            if(k==0 )
            {
                Console.WriteLine(dictFrequency.Count);
            }
            else{                
                int maxKey=GetMaximum(dictFrequency);
                int minKey=GetMinimum(dictFrequency);
                
                while(k > 0)
                {
                    if (!dictFrequency.ContainsKey(minKey) || dictFrequency[minKey] == 0)
                    {
                        minKey = GetMinimum(dictFrequency);
                    }
                    dictFrequency[minKey]--;
                    if (dictFrequency[minKey] == 0)
                    {
                        dictFrequency.Remove(minKey);
                    }
                    k--;
                }
               int count=0;
               foreach(KeyValuePair<int,int> kvp in dictFrequency)
               {
                 if(kvp.Value!=0)
                 {
                    count++;
                 }
               }
               Console.WriteLine(count>0?count:1);
 
            }            
 
 
            T--;
        }
    }
 
    public static int GetMaximum( Dictionary<int,int> dict)
    {
        int maxValue=-1;
        int maxKey=-1;
        foreach(KeyValuePair<int,int> kvp in dict)
        {
            if(kvp.Value>maxValue)
            {
                maxKey=kvp.Key;
                maxValue=kvp.Value;
            }
        }
        return maxKey;
    }
    public static int GetMinimum( Dictionary<int,int> dict)
    {
       
        int minKey=GetMaximum(dict);
        int minValue=dict[minKey];
        foreach(KeyValuePair<int,int> kvp in dict)
        {
            if(kvp.Value<minValue && kvp.Value!=0)
            {
                minKey=kvp.Key;
                minValue=kvp.Value;
            }
        }
        return minKey;
    }
    
}