using System;
namespace BST{
    public class Node {
        public int key;
        public Node left,right;
        public Node(int item)
        {
            key=item;
            left=right=null;
        }
    }
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root=null;
        }
    public void insert(Node newNode)
    {
        this.root= insertRecord(this.root, newNode);
    }
    public Node insertRecord(Node root,Node newNode)
        {
           if(root==null){
            root=newNode; 
            return root;           
           }
           if(newNode.key<root.key)
           {
            root=insertRecord(root.left,newNode);
           }  
           else {
            root=insertRecord(root.right,newNode);
           }
           return root;
        }

    }


    class Program
    {

        public static void Main(String [] args )
        {
            BinarySearchTree bst=new BinarySearchTree();
            Node newNode=new Node(2);
            bst.insert(newNode);
            Node newNode2=new Node(1);
            bst.insert(newNode);
            Node newNode3=new Node(3);
            bst.insert(newNode);
        }
    }
}
