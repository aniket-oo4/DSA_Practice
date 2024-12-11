namespace HashMaps_V6
{
    internal class Program
    {

        //Hashin methods for Dictionary <map >
        /*
         *  there are three methods which are come into picture when we called out word hashing on list of data we can create hsah by using following 3 method s
         *  1. Division method --> element/something  eg / 2/10 =2  the index will be 2  <-- Most of the time this method will be used 
         *  2.  Folding method
         *  3. mod Square method 
         * */
        static void Main(string[] args)
        { // before starting this file please go to problem2.cs cause i used advanced concept of hashing directly here before array hashing here only read first intro then go to problem2 then jump here 
            Console.WriteLine("Hello, World!");
            // Hashing  is nothing but the precalculations   prestoring and retriving whenever required 
            /*  1. Dictionary<TKey, TValue> -- unordered_map int c++
            A Dictionary is implemented as a hash table in C#. 
            It allows fast lookups, insertions, and deletions with an average time complexity of O(1) for most operations.
            However, in the worst case (e.g., hash collisions), the time complexity can degrade to O(n)  // collision means  if the hash values is common for all the input values 
            // we calculates hashindex by using hashing methods such as division method ,  which is as follows
            input ==> , 1,2,3,4,5,6,7,822,34,55,66,77,83,45,
            then , method will be   returns the index as  n%10 
                if n=2 =return 2  , stored it on index 2 , for 22=> 2 stored on index 2 in sorted order in the form of linked list or other datatyp 
            hashindex --> group of values 
            0
            1 -->1
            2 -->2-->22-->822
            3 -->3 -->83
            4 -->4 -->34 
            5 -->5-->45--> 55 (order is sorted here as per user requirement you can store in any manner )
            6--> 6-->66
            7-->7

            if we search for 822 then do as 
                822%10 =2  go to dict[2] then search the number 822 on that index it reduces the time complexity to o (1) from o(n) 

            in worst case situation as  follows -->
                the hashing method will return common index for all the inputs 
                such as 8,88,238,18,2198,3328 
                then here it is  the collision happens 
                1
            2
            3
            4
            5
            6
            7
            8->8-->18-->88-->238-->2198-->3328   in this case the time complexity will be  o(n);

            methods of dictionnary -->
            Operation	                Time Complexity     	    Space Complexity
            Add(key, value)	:           O(1) (amortized)	        O(n)
            Remove(key)	                (1)  :(amortized)	        O(n)
            ContainsKey(key)	        O(1) (amortized)	        O(n)
            ContainsValue(value)	    O(n)	                    O(n)
            TryGetValue(key, out value)	O(1) (amortized)	        O(n)
            Indexer (this[key])	        O(1) (amortized)	        O(n)
            Clear()                 	O(n)	                    O(n)
            Count (getter)	            O(1)	                    O(1)
            Keys (getter)	            O(1)	                    O(n)
            Values (getter)	            O(1)	                    O(n)
            ToArray()	                O(n)	                    O(n)
            CopyTo(array, index)	    O(n)	                    O(n)            
            */
            // dictObj.Values.Max() //Min() // return minimum , or maximum among all the valuees stored in that dict
            /*
         prorperties of Dictionary 
            Property	Description	Data Type	                                                Usage Example
            Count	    Gets the number of key-value pairs contained in the Dictionary.	        int	int count = myDict.Count;
            Comparer	Gets the IEqualityComparer<TKey> used to determine equality of keys.	IEqualityComparer<TKey>	var comparer = myDict.  Comparer;
            Keys	    Gets a collection containing the keys in the Dictionary.	            ICollection<TKey>	var keys = myDict.Keys;
            Values	    Gets a collection containing the values in the Dictionary.	            ICollection<TValue>	var values = myDict.Values;
            */
            //Example 


            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];  // always keep in mind we cannot declare the array above the size of 10^6 inside Main  if we declare 10^6+1 then it become segmentation fault ,
                                     // cause compiler does not allow to allocate that much memory in main method 
                                     // If array is declared Globally then it can be allowcated memory 
            int[] arr2 = new int[(int)1e8]; // 1e8 is nothing but  10^8;
            Console.WriteLine($"arr2 length :{arr2.Length}");
            Dictionary<int, int> numbersFrequencyMap = new Dictionary<int, int>();
            Console.WriteLine(  $"Enter  {n}  numbers (press enter after each element .)");
             for(int i = 0; i < n; i++)  // inserting o(n)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());

                // Precomputation of frequencies -->
                if (numbersFrequencyMap.ContainsKey(arr[i]))
                {
                    numbersFrequencyMap[arr[i]]+= 1;
                }
                else
                 {
                    numbersFrequencyMap.Add(arr[i], 1); // be carefull while initializing the frequency it must always start with 1 not 0 
                 }
                }

            Console.WriteLine("How many numbers,Frequency  you want to find in array :");
            int T = Convert.ToInt32(Console.ReadLine());
            while (T>0) 
            {
                Console.WriteLine($"Enter    number To Search frequency  (press enter after each element .) : ");
                int num = Convert.ToInt32(Console.ReadLine());
                 if(numbersFrequencyMap.ContainsKey(num))  // fetching o(1) ,sc=o(n)
                {
                    Console.WriteLine($"Frequency of number :{num}: {numbersFrequencyMap[num]}");  //accessing o(1)
                }
                else
                {
                    Console.WriteLine($"Frequency of number :{num}: 0");
                }
                T -= 1;
            }




            //----------------------------------
            /*
             * --> When you got TLE time limit exceeded then and then only use SortedDictionary 
             * 2. SortedDictionary<TKey, TValue>  -- map in c++ which stores data in sorting order based on  on keys  all operations time complexities are o(log n) 
             * most of the cases we use unordered map aka Dictionary because of its lower time complexity  for larger data set 
                    A SortedDictionary is implemented as a Red-Black Tree (a type of balanced binary search tree). It keeps the keys in sorted order, which means operations that depend on ordering (e.g., Min, Max, First, Last) are more expensive than in a Dictionary, but it ensures the keys are always sorted.
                    
                    Operations and Time Complexities:
                    Operation	                    Time Complexity	Space Complexity
                    Add(key, value)	                O(log n)	        O(n)
                    Remove(key)	                    O(log n)	        O(n)
                    ContainsKey(key)	            O(log n)	        O(n)
                    ContainsValue(value)	        O(n)	            O(n)
                    TryGetValue(key, out value) 	O(log n)	        O(n)
                    Indexer (this[key])	            O(log n)	        O(n)
                    Clear()	                        O(n)	            O(n)
                    Count (getter)	                O(1)	            O(1)
                    Keys (getter)	                O(1)	            O(n)
                    Values (getter)	                O(1)	            O(n)
                    ToArray()	                    O(n)	            O(n)
                    CopyTo(array, index)	        O(n)	            O(n)
                    Min (getter)	                O(log n)	        O(1)
                    Max (getter)	                O(log n)	        O(1)
             * */
        }
    }
}
