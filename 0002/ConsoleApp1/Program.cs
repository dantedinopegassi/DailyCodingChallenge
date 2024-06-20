// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

/********************************************************************|
| Given an array of integers, return a new array such that each      |
| element at index i of the new array is the product of all the      |
| numbers in the original array except the one at i.                 |
|                                                                    |
| For example, if our input was [1, 2, 3, 4, 5], the expected        | 
| output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], |
| the expected output would be [2, 3, 6].                            |
|                                                                    |
| Follow-up: what if you can't use division?                         |
|********************************************************************/

// list = [6,7,8,9,11,12,14,15,10]

long[] FactorialArrayDupe(int[] list)
{
    long[] thing = new long[list.Length];
    long total = 1;
    for (int i = 0; i < list.Length; i++)
    {
        total *= list[i];
    }
    for (int i = 0; i < list.Length; i++)
    {
        thing[i] = total/list[i];
    }
    return thing;
}

long[] result = FactorialArrayDupe([6,7,8,9,11,12,14,15,10]);
StringBuilder stringcito = new StringBuilder();
foreach(var item in result){
    stringcito.Append("[" + item.ToString() + "] ");
}

Console.WriteLine(stringcito);