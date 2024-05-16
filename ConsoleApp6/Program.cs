
//#region Loop Statement
//// while (شرط)
////{
////statment
////}

//using System.Collections;

//int x = 5;
//while (x <= 10)
//{
//    Console.WriteLine(x);
//    x++;
//}
//Console.WriteLine("End of while");

//for (int i = 1; i <= 4; i++)
//{
//    Console.WriteLine("Enter name:" + i);
//    string name = Console.ReadLine();
//    Console.WriteLine($"Name  : {i} " + name);
//}
//Console.WriteLine("End of for");
//Console.WriteLine("Even");
//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(" Number:" + i);
//    }
//}

//Console.WriteLine("Even 2");
//for (int i = 2; i <= 10; i = i + 2)
//{

//    Console.WriteLine(" Number:" + i);

//}


//Console.WriteLine("Odd 1");
//for (int i = 1; i <= 10; i = i + 2)
//{

//    Console.WriteLine(" Number:" + i);

//}

//Console.WriteLine("odd 2");
//for (int i = 0; i <= 10; i++)
//{
//    if (i % 2 != 0)
//    {
//        Console.WriteLine(" Number:" + i);
//    }
//}

//Console.WriteLine("do while");
//int x1 = 5;
//do
//{
//    Console.WriteLine(x1);
//    x1++;
//} while (x1<=10);



//Console.WriteLine("Continue");
//for (int i = 1; i < 10; i++)
//{
//    if (i == 5)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

//Console.WriteLine("break");

//for (int i = 1; i < 10; i++)
//{
//    if (i == 5)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}


//#endregion

//#region ArraysList
//Console.WriteLine("Names");
//string[] names=new string[10];
//int[] num=new int[] {1,2,3,4,5,6,7,8,9,10};
//string result="";

//for (int i = 0; i < names.Length; i++)
//{
//    names[i] = Console.ReadLine();
//    result = result + " "+ names[i]+", ";
//}
// Console.WriteLine(result);
//Console.WriteLine("2D Array");
//int[,] n=new int[5, 2] { { 5, 8 }, { 3, 6 }, { 9, 2 }, { 8, 3 }, { 7,9} };

//for (int i = 0; i < 5; i++)
//{
//    for (int w = 0; w < 2; w++)
//    {
//        Console.WriteLine($" {i},{w} "  +  n[i,w]);
//    }

//}

//// Stack
//// push
//Console.WriteLine("Stack");
//Stack<string> empNames = new Stack<string>();
//empNames.Push("Ahmad");
//empNames.Push("Rami");
//empNames.Push("Sami");
//empNames.Push("Khalil");

//Console.WriteLine(empNames.Pop());
//Console.WriteLine(empNames.Pop());

//// Queue
//Console.WriteLine("Queue");
//Queue<string> emp = new Queue<string>();
//emp.Enqueue("Ahmad");
//emp.Enqueue("Rami");
//emp.Enqueue("Sami");
//emp.Enqueue("Khalil");

//Console.WriteLine(emp.Dequeue());

//Console.WriteLine("SortedList");
//SortedList<string, string> data = new SortedList<string, string>();
//data.Add("1", "Damra");
//data.Add("2", "Khalil");
//data.Add("3", "Damra");

//foreach (KeyValuePair<string, string> item in data)
//{
//    Console.WriteLine(item.Key + "," + item.Value);
//}
//#endregion


#region stringClass 

using ConsoleApp6;

string name1=Console.ReadLine().Trim();
string name2=Console.ReadLine();

Console.WriteLine(string.Concat(name1," ", name2));
Console.WriteLine(name1.Contains(name2)); 
Console.WriteLine(name1.StartsWith(name2)); 
Console.WriteLine(name1.EndsWith(name2)); 
Console.WriteLine(name1.Replace("ahmad","Rami")); 
 string[] splitingNames=  name1.Split(' ');
foreach (var item in splitingNames)
{
    Console.WriteLine(item);
}


#endregion



Employee<string> emp = new Employee<string>("Ahmad");
Employee<int> NoOfEmp = new Employee<int>(50);
emp.getData("");
NoOfEmp.getData(50);


Data.FullName = "Rami";
Data d = new Data();


int year = DateTime.Now.Year;

bool ddd = MyExtMethods.ThisYear(year, 2024);
Console.WriteLine(ddd);