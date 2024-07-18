// See https://aka.ms/new-console-template for more information


//int[] arr = { 1, 3, 5, 2, 6, 7 };
//string[] s_arr = { "10", "32", "1", "8"};

//Array.Sort(arr);
//Console.WriteLine("Sorted array : " + string.Join(", ", arr));

//Array.Reverse(arr);
//Console.WriteLine("Revuersed array : " +string.Join(", ", arr));

//Array.Sort(s_arr);
//Console.WriteLine("Sorted array : " + string.Join(", ", s_arr)); //string은 사전 순

//int[] i_arr = Array.ConvertAll(s_arr, int.Parse);
//Console.WriteLine("Converted int array" + string.Join(",", i_arr));
//Array.Sort(i_arr);
//Console.WriteLine("Sorted Array : " + string.Join(",", i_arr));

//int[] arr2 = { 1, 3, 5, 2, 6, 7, 10 };
//int[] arr3 = arr2.OrderBy(x => x).ToArray();

//int[] intArr = { 3, 1, 2 };
//string[] strArr = Array.ConvertAll(intArr, x => x.ToString());
//Console.WriteLine("strArr: " + string.Join(", ", strArr));





//[실습] int[] intArr = { 3, 1, 2 };
//ConvertAll을 이용하여 2배로 키운 값을 가지는 string [] 를 만들어라!
int[] intsArr = { 3, 1, 2 };
string[] strsArr = Array.ConvertAll(intsArr, x => (x*2).ToString());
Console.WriteLine("strsArr: " + string.Join(", ", strsArr));