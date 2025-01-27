#include<bits/stdc++.h>
using namespace std;

void BubbleSort(int arr[],int n){
    //9,4,
    for(int i=0;i<n;i++){
        int isSwapped=0;
        for(int j=0;j<n-i-1;j++)
        {
             if(arr[j]>arr[j+1]){
                swap(arr[i],arr[j]);
                isSwapped=1;
             }   
        }

    }
}
void Display(int arr[],int n){
        cout<<" Array is: ";

        for(int i=0;i<n;i++){
        // std::cin>>ele;
        cout<<arr[i]<<" ";
    }
}
int main(){

    int arr[10]={90,3,1,5,7,2,8,9,0,11};
    int n=sizeof(arr)/sizeof(arr[0]);
    Display(arr,n);
    BubbleSort(arr ,n);
    Display(arr,n) ;
    return 0;

}