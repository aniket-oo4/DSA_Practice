using System;
using System.Collections.Generic;

/*
deletes all the vowels,
inserts a character "." before each consonant,
replaces all uppercase consonants with corresponding lowercase ones.
*/

class Program {
   public static void  Main(String [] args ){
			
			String input;
			input=Console.ReadLine();		
			Console.WriteLine(GetNewString(input));
			
		}
public static string GetNewString(string input)
	{
		HashSet<char> vowelSet=new HashSet<char> (){'a','e','i','o','u','y'};
		
		string output=""; 
		for(int i=0; i<input.Length;i++){
			if(!vowelSet.Contains(char.ToLower(input[i]))){
			        output+="."+char.ToLower(input[i]);
			}	
		}
			return output ;
	}

}

