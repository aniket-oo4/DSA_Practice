using System;
class MergeSortEx{

// Merge Sort  is Dive and   sort and merge --> take O(n log n)
/// <summary>
/// 
/// its first divides 
/// step 1 :   calculate mid   (low+high )/2;
/// step 2 :   sort Left half MergeSort(arr, low, mid);
/// step 3 : sort right half  MergeSort(arr ,mid+! ,high)
/// step 4 : Merge Both of them by using extra space of O(n)  for sorting 
///     --> took left = low  , and right =mid+1 
///     --> do while left<=mid , and right < =high
///         --> compare values arr[left ] <=arr[right ] 
///                 -->sorted.push(arr[left]) left++
///             if arr[right]<arr[left]
///                ---> sorted.push(arr[right]) right++;
///     
///          push remaining of both sides to array () left and right till mid and high 
///   
///   step 5 : replace those index values between range of low to high with sorted values 
///          took i=low  // the posion where we are currently on  suppose 2 
///             arr[i] =sorted[i-low]; 2-2 =0 sorted[0] - if ++k 3-2= 1 sorted[1] arr[3]=sorted[1];
/// 
///   used recusrion to sort the issue 
///   
/// finally 
/// Time Complexity : O(n log n) // for input 16  --n takes  16 * log₂16  (2⁴) hence --> 4  ---> 16*4 ==> 64 
/// space Complexity : O(n)  // for sorted[] at worst took n space for hypothetica; array 
/// </summary>
/// <param name="args"></param>


// public static void Main(String  []args)
//   {            //0,1,2,3,4  --5
//      int [] arr={1,4,2,3,0}; 
//      Console.WriteLine("\n Before sorting :");
//           Display(arr);
//      MergeSort(ref arr,0,arr.Length-1);
//      Console.WriteLine("\n After sorting :");
//      Display(arr);
    
//   }
//   public static void Display(int [] arr){

//      foreach(var element in arr){
// 	Console.Write(element +" ");  
//      }
//   }

// public static  void MergeSort(ref int [] arr ,int low ,int high)
//   {
//      if(low==high)
//      {
//         System.Console.WriteLine(  "hello ");
//         //  Display(arr);
//         return;
//      } 
//      int mid=(low+high)/2;
//     //  Display(arr);
//      MergeSort(ref arr,low,mid);
//      MergeSort(ref arr ,mid+1,high); 
     
       
//      MergeArray(ref arr,low,mid,high);	
//      return ;
//   }

// public static void MergeArray(ref int []arr,int low,int mid ,int high)
// {
//     int [] sorted=new int[arr.Length];
//     int left=low , right =mid+1,i=0;    

//      while(left<=mid && right<=high)
//      {     
//        if(arr[left]<=arr[right])
// 	    {
//           sorted[i]=arr[left];
// 	    left++;
//         }
// 	else
//         {
//           sorted[i]=arr[right];
// 	     right++;
// 	    }	  
   
//       i++;     
//      }
      
//      while(left<=mid)
// 	{
//         sorted[i]=arr[left];
// 	    left++;	
//         i++;
// 	}
    
//     while(right<=high)
//         {
//           sorted[i]=arr[right];
// 	     right++; 
//          i++;         
//         }
//     //  Display(arr);

//     for(int k=low;k<=high;k++)
//         {
//           arr[k]=sorted[k-low];  // replacing the arr[kth ] with sorted part  MErge sort sorts the divied parts then merges   
//         }
// }

public static void Main(String [] args) 
  {
    int [] arr={3,2,5,2,67,1,8,0};
    Console.WriteLine("\nArray Before Sorting :");
    Display(arr);  
    MergeSort(ref arr,0,arr.Length-1);
    Console.WriteLine("\nArray After Sorting :");
    Display(arr);  
       Console.ReadKey();
  }

public static void  Display(int [] arr)
  {
    foreach(var ele in arr)
     { 
       Console.Write(ele +" ");
     }
  }

public static void  MergeSort(ref int []arr,int low , int high)
 {
   if(low==high) return;
   
   int mid=(low+high)/2;
   MergeSort(ref arr, low,mid);
   MergeSort(ref arr ,mid+1,high);

   MergeArray(ref arr ,low ,mid , high);   

 }

public static void MergeArray(ref int [] arr, int low ,int mid ,int high)
 {
    int left=low,right=mid+1;
    int []sorted =new int [arr.Length];
    int current=0;
   
    while(left<=mid &&right <=high)
     {
       if(arr[left]<=arr[right])
	   {
   	    sorted[current]=arr[left];
	    left++;
	   }
       else
	   {
   	    sorted[current]=arr[right];
	    right++;
	   }
       current++;
     }
    
    while(left<=mid)
     {
      sorted[current]=arr[left];
      left++;
      current++;
     }
    while(right<=high)
     {
      sorted[current]=arr[right];
      right++;
      current++;
     }
  

   for(int i=low;i<=high;i++)
    {
      arr[i]=sorted[i-low];// 2-2=0    
    }
  
 }

 



}