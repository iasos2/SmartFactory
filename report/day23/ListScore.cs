using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace StringPrint22_1
{
    internal class Program
    {
        static int[] InputScore(int[] arr)
        {
            int total = 0;
            for(int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                total += arr[i];
            }
            arr[3] = total;
            return arr;
        }
        static void OutPutScore(int[] arr)
        {
            Console.WriteLine($"총점 : {arr[3]}");
            Console.WriteLine($"평균 : {arr[3] / 3.0:F2}");
        }
        static void Main(string[] args)
        {
            int[] score = new int[4];
            InputScore(score);
            OutPutScore(score);
            
        } 
    }
}
