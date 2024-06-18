// See https://aka.ms/new-console-template for more information

/*********************************************************|
| Given a list of numbers and a number k, return whether  |
| any two numbers from the list add up to k.              |
|                                                         |
| For example, given [10, 15, 3, 7] and k of 17, return   |
| true since 10 + 7 is 17.                                |
|                                                         |
| Bonus: Can you do this in one pass?                     |
|*********************************************************/

// list = [6,7,8,9,11,12,14,15,10]
// number = 19

bool IsAddUpCorrect(int[] list, int number)
{
    int[] ints = new int[list.Length];
    for (int i = 0; i < list.Length; i++)
    {
        ints[i] = number - list[i];
        foreach (var item in ints)
        {
            if (item == list[i]){
                return true;
            }
        }
    }
    return false;
}

Console.WriteLine(IsAddUpCorrect([6,7,8,9,11,12,14,15,10],19));