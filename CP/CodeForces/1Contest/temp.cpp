#include <bits/stdc++.h>

using namespace std;
int main(){

// cout<<"Hello world"<<endl;    
vector<int> v;  //List in c# and python

int n;
cout<<"enter how many number s you want to insert in vector L"<<endl;
cin>>n;
for(int i=0;i<n;i++)
{
    cout<<"Enter element sfor "<<i<<"th index "<<"\n";
    int element ;
    cin>>element;
  v.push_back(element);

}
cout<<"Displaying outputs :::"<<"\n";
for(auto ele : v){

    cout<<ele<<" ";
}
//-----------------------
map<int,int>m; //sorted dictionary in python and c#
unordered_map<int,int>um;  // in c# and python dictionary
um.insert({1,2});
cout<<um.at(1)<<endl;


// Stack in C#
stack<int>s; 
s.push(1); // Push element onto stack
s.emplace(2); // Push element onto stack
cout << s.top() << endl; // Access top element
s.pop(); // Remove top element
cout << s.empty() << endl; // Check if stack is empty
cout << s.size() << endl; // Get size of stack
stack<int> s2;
s.swap(s2); // Swap contents with another stack
    return 0;
}