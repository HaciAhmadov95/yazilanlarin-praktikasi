
//Task1

//static string ReverseStr(string str)
//{
//    string result = string .Empty;

//    for (int i = str.Length -1;i  >= 0; i--)
//    {
//        result += str[i]
//    }
//    return result;  
//}


//Console.WriteLine(ReverseStr("Haci");




//Task2



//static string UpperStringFirstChar(string str)
//{
//    string name = char.ToUpper(str[0]) + str.Substring(1);
//    return name;
//}

//Console.WriteLine(UpperStringFirstChar("sarvan"));



//Task3


//static string UpperStringFirstChar(string str) => char.ToUpper(str[0]) + str.Substring(1);


//Console.WriteLine(UpperStringFirstChar("sarvan"));



//Task4


// static string FirstElementToUpper(string str)
//{
//    char[] charArray = str.ToCharArray();

//    string firstchar = charArray[0].ToString().ToUpper();
//    charArray[0] = Convert.ToChar(firstchar);

//    string result = string.Empty;
//    foreach (char item in charArray)
//    {
//        result += item;
//    }

//    return result;
//}


//Console.WriteLine(FirstElementToUpper("meryem"));



//Task5





//  using System.Text;

//StringBuilder stringBuilder = new StringBuilder("Azer");

//stringBuilder.Append ("baycan");

//Console.WriteLine(stringBuilder);



//Task6



//int[] nums = {1,2,3,4,5,6,7};

//var result = nums.Sum(x => x);

//Console.WriteLine(result);


//Task7

//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

//var result = nums.Rank;

//Console.WriteLine(result);


//Task8


//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

//Array.Sort(nums);

//foreach (int i in nums)
//{
//    Console.WriteLine(i);
//}


//Task9



//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

//Array.Reverse(nums);


//foreach (int i in nums)
//{
//    Console.WriteLine(i);
//}



//Task10


//int[] nums = { 10, 2, 3, 4, 5, 6, 10, 11, 12, 12 };

//int[] newArr = { 1, 2, 3, 7 };

//int count = newArr.Length;

//Array.Resize(ref newArr,nums.Length + newArr.Length);

//nums.CopyTo(newArr,count);

//foreach (var item  in newArr)
//{
//    Console.WriteLine(item);
//}



//Task11

//static int[] CopyToArray(int[] destination , int[] source)
//{
//    int destinationLength = destination.Length;

//    Array.Resize(ref destination, source.Length + destination.Length);

//    source.CopyTo(destination,destinationLength );

//    return destination;




//}

//int[] arr1 = { 2, 3, 4, 5 };

//int[] arr2 = { 100, 200, 300 };

//var result = CopyToArray (arr2 , arr1);

//foreach ( var item in result)
//{
//    Console.WriteLine(item);
//}



//Task12





//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

//var result = Array.Exists(nums, x => x == 1);


//Console.WriteLine(result);


//Task13


//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

//var result =Array.Find(nums,x => x == 1);   

//Console.WriteLine(result);

//var result = Array.FindAll(nums,x => x == 1);

//Console.WriteLine(result);

//var result = Array.FindIndex(nums,x => x == 1);

//Console.WriteLine(result);




//Task 14


//int[] arr = new int[2];

//Array.Fill(arr, 2);

//foreach (int i in arr)
//{
//    Console.WriteLine(i);
//}



//Task15


//int[] numbers = {1,2,3,4,5};

//var result =numbers.OrderBy(x => x);

//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}


//Task16

//int[] numbers = { 1, 2, 3, 4, 5 };

//var result = numbers.FirstOrDefault(x => x == 1);

//Console.WriteLine(result);


////Task17

//int[] numbers = { 1, 2, 3, 4, 5 };

//var result  = numbers.Where(x => x % 2 == 0);

//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}



////Task18

//using ConsoleApp1;



//Student stu1 = new Student();
//stu1.name = "Haci";
//Console.WriteLine(stu1.name);


////Student stu2 = new Student();
////stu2.name = "Ali";

//Console.WriteLine(stu2);