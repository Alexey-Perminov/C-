// int n = 10;
// int[] array = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
// int i = 0;

// while(i < n)
// {
//     if(array[i] % 2 == 0)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     i = i + 1;
// }


int[] array = { 1, 2, 3, 5, 6, 7, 8, 9, 6, 3, 16, 18 ,100 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
