using System;
using System.Xml.Linq;

namespace Arrays_Strings_1
{
    internal class Program
    {
        #region task1
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("enter text:");
        //    string word = Console.ReadLine();
        //    string[] arr = word.Split(new char[] { ',' });
        //    //string[] arr = word.Split(' ');
        //    ArrNum(arr);          
        //}
        //static void ArrNum(string[] arr)
        //{
        //    int numberOfChar = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        numberOfChar+=1;
        //    }
        //    Console.WriteLine("the number of letters in the word: " + numberOfChar);
        //}
        ////niyese sehv ishleyir :(
        #endregion

        #region task2
        //static void Main(string[] args)
        //{
        //    int[] nums = { 1, 2, 3, 4};
        //    SumOfNums(nums);
        //}
        //static void SumOfNums(int[] nums)
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        sum += item;
        //    }
        //    Console.WriteLine(sum);
        //}
        #endregion

        #region task3    
        //static void Main ( string[] args )
        //{
        //    string sentence = Console.ReadLine ();
        //    Sentence(sentence);
        //}
        //private static void Sentence(string sentence)
        //{
        //    string[] words = sentence.Split (' ');           
        //    if (words.Length == 0)
        //    { System.Console.WriteLine("Empty String"); }
        //    else if (words.Length >= 0)
        //    {
        //        for (int i = 0; i < words.Length; i++)
        //        {
        //            words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1);
        //        }
        //    }
        //    string upperwords = string.Join(" ", words);
        //    Console.WriteLine(upperwords);
        //}
        #endregion

        #region task4
        //static void Main(string[] args)
        //{
        //    //birinci usul:
        //    Console.WriteLine("integere cevireceyiniz ededi daxil edin:");
        //    string myInteger = Console.ReadLine();
        //    int.Parse(myInteger);
        //    Console.WriteLine(myInteger);
        //    Console.WriteLine("Double cevireceyiniz ededi daxil edin:");
        //    string myDouble = Console.ReadLine();
        //    double.Parse(myDouble);
        //    Console.WriteLine(myDouble);

        //    //ikinci usul:
        //    Console.WriteLine("integere cevireceyiniz ededi daxil edin:");
        //    int.TryParse(Console.ReadLine(), out var myInteger1);
        //    Console.WriteLine("doublea cevireceyiniz ededi daxil edin:");
        //    double.TryParse(Console.ReadLine(), out var myDouble1);
        //}             
        #endregion

        #region task5        
        //static void Main(string[] args)
        //{
        //    string[] strNums = {"1,2,3,4"};
        //    int[] arrNums = strNums.Split(',');

        //    Result(arrNums);
        //}
        //static void Result(int[] arrNums)
        //{
        //    int sum = 0;
        //    foreach (var nums in arrNums)
        //    {
        //        sum += nums;
        //    }
        //    int result = sum / arrNums.Length;
        //    Console.WriteLine(result);
        //}
        ////alinmadi bu tapsiriq
        #endregion

        #region task6
        //static void Main(string[] args) 
        //{
        //    string[] strings = { "Emil", "Shefige", "Adil", "Elmira", "Faig", "Samir", "Izzet" };
        //    Names(strings);
        //}
        //static void Names(string[] strings)
        //{
        //    int num = 0;
        //    foreach (string items in strings)
        //    {
        //        if (strings.Length>0)
        //        {
        //            for (int i = 0; i < items.Length; i++)
        //            {
        //                if (strings[i].Contains("e"))
        //                {
        //                    num++;
        //                }
        //            }
        //        }                            
        //    }
        //    Console.WriteLine(num);
        //}
        #endregion

        #region task7
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("enter number");
        //    int.TryParse(Console.ReadLine(), out var num);
        //    Result(num);
        //}

        //private static void Result(int num)
        //{
        //    string EvenOrOdd = (num % 2 == 0) ? "even" : "odd";
        //    Console.WriteLine(EvenOrOdd);
        //}
        #endregion

        #region task8
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("enter sentence");
        //    string sentence = Console.ReadLine();
        //    numsOfVowels(sentence);
        //}
        //static void numsOfVowels(string sentence)
        //{
        //    string[] vowels = { "a", "e", "i", "o", "u", "y" };
        //    int count = 0;
        //    for(int i = 0; i < sentence.Length; i++)
        //    {
        //        if (sentence.Contains(vowels[i]))
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine($"Number of vowels : {count} , I didn't count the Azerbaijani vowel letters");
        //}
        #endregion

       
    }
}
