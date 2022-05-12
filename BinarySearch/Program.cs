// See https://aka.ms/new-console-template for more information


namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------Welcome To Binary Search Tree--------");
            Console.WriteLine();
            BinarySearchTree<int> bST = new BinarySearchTree<int>(56);
            bST.Insert(30);
            bST.Insert(70);
            bST.Display();
            
            Console.Read();
        }
    }
}