using System;
namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //jagged Array is the array of arrays or simply we can say that the array containing array as an element .
            //unlike multidimensional arrays, each array inside a jagged array can be of different sizes.

            //syntax:  dataType[ ][ ] nameOfArray = new dataType[rows][ ];
            // declare jagged array

            int[ ][ ] jaggedArray = new int[2][ ];
            //[2][] - represents the number of elements (arrays) or rows inside the jagged array ie 2 elements as a array form

            jaggedArray[0]=new int[3];//setting size of first array element
            jaggedArray[1]=new int[2];//setting size of second array element

            //initilaize first element(array)
            // jaggedArray[0][0]=1;
            // jaggedArray[0][1]=2;
            // jaggedArray[0][2]=3;

            // //initilaize the second element(array)
            // jaggedArray[1][0]=12;
            // jaggedArray[1][1]=13;

            //the initialization of jagged array can also be done in one line like this 
            jaggedArray[0] =new int[]{1,2,3};//initialize the first array
            jaggedArray[1]=new int[]{4,5,6,7,8,9,10};//initialize the second array
        
            //accessing  jagged array elements. since there ie two rows
            for(int i=0;i<jaggedArray.Length;i++)//jaggedArray={{1,2,3},{4,5,6}}// i=2(0,1)since there are two elements inside array
            {
                for(int j=0;j<jaggedArray[i].Length;j++)// jaggedArray={{1,2,3},{4,5,6}} for i=0 ie index 0 there is an array({1,2,3}) so we have to traverse the elements of array at index 0 of jaggedArray.To get the size of array at index 0 we use jaggedArray[0].Length similarly for size of array at index1 we use jaggedArray[1].Length and so on
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
        }
    }
}
