#include<bits/stdc++.h>
using namespace std;
string PerformOperation(string &str ){
    int n=str.size();
	set<char> vowelSet= set<char>();
	vowelSet={'a','e','i','o','u','y'};
	string ans="";
	for(int i=0;i<n;i++)
		{
			if(vowelSet.find(tolower(str[i])) ==vowelSet.end())
			{
				ans+=".";
				ans+=tolower(str[i]);
			}
		}
 
	return ans;
}

int main(){
    string str;
cin>>str;
string ans=PerformOperation(str);
cout<<ans<<"\n";
return 0;
}



















