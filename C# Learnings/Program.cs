#region C# 12
using Name = string;
using Age = int;
using NumberArray = int[];
using NumberList = System.Collections.Generic.List<int>;
using Point = (int x, int y);
using System.Runtime.CompilerServices;

// collection expression.
// Collection expression is a concise syntax for creating and initializing the arrays, lists, and other collection types. It replaces the curly braces into square braces.
/*
int[] array1 = new int[] { 1, 2, 3 };
int[] array2 = { 1, 2, 3 };
int[] array3 = [1, 2, 3];

List<int> list1 = new List<int>() { 11, 12, 13 };
List<int> list2 = new() { 11, 12, 13 };
List<int> list3 = [11, 12, 13];

// we can merge arrays and collection type by using spread operator.
int[] merge = [.. array1];
int[] merge1 = [.. array1, .. list1];
int[] merge2 = [.. array1, 6, 7, 8, .. list1];

for (int i = 0; i < merge2.Length; i++)
{
    Console.WriteLine(merge2[i]);
}
*/

// primary constructor
// primary constructors were introduced to simplifying the class and struct by declaring constructor parameters with class defination.
/*
Person person = new("Hamid", 26);
person.DisplayInfo();
Employee employee = new("Hamid", 26, "Software Engineer");
employee.DisplayInfo();

public class Person(string name, int age)
{
    public void DisplayInfo()
    {
        Console.WriteLine($"Name is {name} and age is {age}.");
    }
}
public class Employee(string name, int age, string designation) : Person(name, age)
{
    public string Designation { get; set; } = designation;
}
*/
///////////////////////////////
/////// Alias any type. ///////
///////////////////////////////
// In this feature, we can assign alias to any type by using the using directive. This enhances the code readablity and type complexity.
/*
Person1 person1 = new("Hamid", 26);
person1.DisplayInfo();
person1.DisplayNumberArray([1, 2, 3]);
person1.DisplayNumberList([1, 2, 3]);
person1.DisplayTuple((10, 20));
public class Person1(Name name, Age age)
{
    public void DisplayInfo()
    {
        Console.WriteLine($"Name is {name} and age is {age}.");
    }

    // alias for collection.
    public void DisplayNumberArray(NumberArray numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine($"Array Number: {number}");
        }
    }
    public void DisplayNumberList(NumberList numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine($"List Number: {number}");
        }
    }
    // alias for tuples.
    public void DisplayTuple(Point point)
    {
        Console.WriteLine($"x: {point.x}, y: {point.y}");
    }
}
*/
////////////////////////////
/////// Interceptor. ///////
////////////////////////////
/*
Person person = new();
person.DisplayInfo("Hamid");
person.DisplayInfo("Hamza");
person.DisplayInfo("Hassan");

public class Person
{
    public void DisplayInfo(string name)
    {
        Console.WriteLine($"Name: {name}");
    }
}
// Interceptor Definition
public static class InfoInterceptor
{
    [InterceptsLocation("Program.cs", line: 96, character: 8)]
    public static int Add(int a, int b)
    {
        Console.WriteLine("Intercepted Call!");
        return a + b + 1; // Modified behavior
    }
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
sealed class InterceptsLocationAttribute(string filePath, int line, int character) : Attribute
{
}
*/
//////////////////////////////
/////// Inline Arrays. ///////
//////////////////////////////

Top10NumberStruct numbers = new();

for (int i = 0; i < 10; i++)
{
    numbers[i] = i;
}


foreach (var number in numbers)
{
    Console.WriteLine($"Number: {number}");
}

[InlineArray(10)]
public struct Top10NumberStruct
{
    public int _element;
}

// limitation
// 1)- We can't use InlineArray on class.
// 2)- We can't perform Linq operations in InlineArray.
// 3)- We only use inline array in struct, and after creating the instance, we can retrieve values by index or in foreach loop.


#endregion
