using System;

namespace Array_species
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 2, 7, 9, 16, 26, 34, 34, 34, 34 };
            ////int result = Array.BinarySearch(arr, 16);
            ////Console.WriteLine(result);
            //int[] arr1 = new int[10];
            ////arr.CopyTo(arr1,0);
            ////foreach (int item in arr1)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //bool result = Array.Exists(arr, x => x == 90);
            ////Console.WriteLine(result);
            //int find = Array.Find(arr, x => x == 26);
            ////Console.WriteLine(find);
            //int[] findarr = Array.FindAll(arr, x => x == 34);
            ////    foreach (var itemm in findarr)
            ////{
            ////    Console.WriteLine(itemm);
            ////}
            //int index = Array.LastIndexOf(arr, 34);
            ////Console.WriteLine(index);


            ////Array.Resize(ref arr, arr.Length+1);

            ////arr[arr.Length - 1] = 30;
            ////foreach (var item in arr)

            ////{
            ////    Console.WriteLine(item);
            ////}
            string  sentence =  "bU tasKI methoDla yAzmAliSiz" ;

            string newSentence = sentence.Replace("bU tasKI methoDla yAzmAliSiz", "Bu Taski Methodla Yazmalisiz");

            Console.WriteLine(newSentence);
            
            
           

             
        }

    }
}
