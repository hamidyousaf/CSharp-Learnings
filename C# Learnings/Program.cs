﻿
#region C# 12
// collection expression.
// Collection expression is a concise syntax for creating and initializing the arrays, lists, and other collection types. It replaces the curly braces into square braces.
int[] array1 = new int[] {1, 2, 3};
int[] array2 = {1, 2, 3};
int[] array3 = [1, 2, 3];

List<int> list1 = new List<int>() { 11, 12, 13};
List<int> list2 = new () { 11, 12, 13 };
List<int> list3 = [11, 12, 13 ];

// we can merge arrays and collection type by using spread operator.
int[] merge = [.. array1];
int[] merge1 = [.. array1, ..list1];
int[] merge2 = [.. array1, 6, 7, 8, ..list1];

for (int i = 0; i < merge2.Length; i++)
{
    Console.WriteLine(merge2[i]);
}

#endregion