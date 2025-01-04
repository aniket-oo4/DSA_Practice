/*

Queries  [][] ==constist of Queries    ie range array of Index Ranges 
  Q[i]={start, end };  Q[][]={ {1,2},{0,1}};

we are having  ARRay of word  each index Consist of word   

Input: words = ["aba","bcb","ece","aa","e"], 
queries = [[0,2],[1,4],[1,1]]

observations 
word can be single char ==true 
word cannot be empty string 
 length of string is >1 && <40 
 words are only in  lowercase 
 sum of words. length !>3*10^5
 
 
 ---
 Queries[io].Length Always 2  hence can direct use  q[i][0] and  q[i][1]
 Queries[] .Lenght  <=10^5 
Words. Length  <=10^5

left <=right  can be 0 also 
 
 left  always small or equa not greater 
				 0		1		2	 3   4   5
 Input: words = ["aba","bcb","ece","aa","e","uab"], 
queries = [[0,2],[1,4],[1,1],[3,5]]

expected ans[]
ans.Length== Queries.Length
ans={2,3,0,2}
'

user prefix sum to solve this following quesion 

write method to know does word isVowel then store this count on additional array to 

vowelCnt[]={1,1,2,3,4,4}
	so if left=0  and right =3 then 
	get ans as  
	if(le
	ft& right !=0){
		
	}
	vowelCnt[right]-vowelCnt[left ]==  3-1 =2  +1

*/


using System;
using System.Collections.Generic;
class LC2559{
public static void Main(string []args)
{
int[][] queries = new int[][]
{
    new int[] {0, 2},
    new int[] {1, 4},
    new int[] {1, 1}
};

string[] words = new string[] {"aba", "bcb", "ece", "aa", "e"};
int[] ans = VowelStrings(words, queries);
  Console.WriteLine("Answer :");
  Console.Write("[");
  foreach(var element in ans )
  {
    Console.Write(" "+element+",");

  }
  Console.Write("]");
}

public static  int []VowelStrings (String [] words, int [][] queries)
{
	int [] ans=new int [queries.Length];
	int [] vowelCnt = new int [words.Length];
	HashSet <char> charSet =new HashSet<char>(){'a','e','i','o','u'};

	for(int i=0;i<=words.Length-1;i++)
	{
		if(sIsVowelString(words[i],charSet))
		{
			vowelCnt[i]= i==0?1:vowelCnt[i-1]+1;
		}
		else
		{
		    vowelCnt[i]= i==0?0:vowelCnt[i-1];
		}

	}

	for(int i=0;i<=queries.Length-1; i++)
	{
		// if(queries[i][0] == queries[i][1] )
		// {
			// if(queries[i][0]==0)
			// {
			// 	ans[i]=vowelCnt[0];
			// }
			// else
			// {
			// 	ans[i]=vowelCnt[queries[i][0]]-vowelCnt[(queries[i][0]) -1];
			// }



		// }
		// else
		// {

		// 	int right =vowelCnt[queries[i][1]];
		// 	int left=vowelCnt[queries[i][0]];
		// 	int range=right-left;
		// 	ans[i]=  (right==0 && left==0 )? 0 :range+1;
		// }
        	int right =queries[i][1];
			int left=queries[i][0];
			int sum=vowelCnt[right]-(left==0?0:vowelCnt[left-1]);
			ans[i]=  sum;

            //  prefixSum[currentQuery[1]] -
            //     (currentQuery[0] == 0 ? 0 : prefixSum[currentQuery[0] - 1]);

	}

	return ans ;
}
public static bool sIsVowelString(string str ,HashSet <char> charSet){

	if(str.Length!=0){
	  if (str.Length==1)
	  {
		  if(charSet.Contains(str[0]))
		  {
			  return true ;
		  }
		  else
		  {
		      return false ;
	      }

	  }
	  else
	  {
		  if(charSet.Contains(str[0]) && charSet.Contains(str[str.Length-1]))
		  {
			  return true ;
		  }
		  else
		  {
			  return false ;
		  }
	  }

	}
    return false ;

}



}