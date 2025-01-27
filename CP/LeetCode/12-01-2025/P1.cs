using System;
using System.Collection.Generic;//System. Collection. Generic
class P1{

public static void Main(string [] args )
{
    // 1,2 ,3 ,4
    // 5,6 ,7 ,8
    // 9,10,11,12 
    ---> // [1,3,8,6,9,11]
   var input =new [][] int{ {1,2,3},{4,5,6},{7,8,9}};
   
   var ans=ZigzagTraversal(input);
   foreach(var element in ans){
    Console.Write(" "+element);
   }
     
   
   }
   

 public List<int> ZigzagTraversal(int[][] grid) {
    // 1,2 ,3 ,4
    // 5,6 ,7 ,8
    // 9,10,11,12    
   int counter=0;
   int m=grid.Length;
   int n=grid[0].Length;
   List<int> result=new List<int>();
   for(int i=0;i<m;i++){
    if(counter<n){
      while(counter<n)
        {
            result.Add(grid[i][counter]);
            counter=counter+1;
            counter+=2;
        }
    }
    else{
          while(counter>=0)
        {
            result.Add(grid[i][counter]);
            counter=counter+1;
            counter-=2;
        }
    }

        if(counter>n){
            if((counter+1)-n ==2){ counter=n-1};
            else{
                counter=n-2;
            }
        }
        else if(counter<0)
        {
        if(counter==-1){
            counter=0;
        }
        else if {counter=1};
        }
        

   }

  return result;

 }


}


   
