using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace HashMaps_V6
{
    internal class Problem2
    {

        // using array for storing hash 
        // if we are given  a string which contains a sequence of characters  such as "abddauerwwadb"
        // Q-> we need to find out the occurence of every word in the following string 
        /// not using Dictioanry  by using array hash 
        /// 
        // Solution --> create array of size 26 cause there are total 26 alphabets  ,  and store the frequency of  alphabets on the index 0-25 as a-z lowercase 
        // then  give  then 
        public static void Main(String[] args)
        {

            Console.WriteLine("Enter your string ::");
            string  str = Console.ReadLine();
            int[] arr = new int[26]; // in  case for all the unicode characters use new int [256]  to store all the unicode chars and  keep there index as it is there ascii codes 
            // always use array hashing for the character hash  because of there will not be more than 256 characters 
            // for integer hashing use another  better ways cause array had limited storage capacity  it only stotres the numbers  till 10^7  , it will not take 10^8 9 12 3and so on 
            // thats why to solve this problem languages introduced concepts of collection -java,c#, stl -c++ 
            //cpp= map, unordered_map , c# = sortedDictionary , Dictionary 
            for(int i = 0; i < str.Length-1; i++)
            {
                //arr[GetHash(str[i])] = arr[GetHash(str[i])]>0? arr[GetHash(str[i])]: Count(str, str[i],i);
                //or
                arr[str[i]-'a'] = arr[str[i] - 'a'] > 0 ? arr[str[i] - 'a'] : Count(str, str[i], i);
            }
            Console.WriteLine("Enter for  how many character values you want to get the frequencyb :");
            int T = Convert.ToInt32(Console.ReadLine());
            while (T > 0)
            {
                char searchValue =Console.ReadLine()[0];// use Console.ReadKey().KeyChar;
                Console.WriteLine($"Frequency of character{searchValue} is :{arr[GetHash(searchValue)]}");
                T--;
            }

        }
        public static int Count(string str,char ch,int i)
        {
            int cnt = 0;
            for(; i < str.Length; i++)
            {
                if (str[i] == ch) { cnt++; }
            }
            return cnt;
        }
        public static int GetHash(char ch)
        {
            return  (int)ch- (int)'a'; // always remember subtract the 'a'  from any character the  input character be always on geater side;
        }
        
    }
}
