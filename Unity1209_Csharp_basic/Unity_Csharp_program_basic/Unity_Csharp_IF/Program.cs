using System;

namespace Unity_Csharp_IF
{
    class Program
    { 
        static bool doPrint = true; // 변수나 함수는 클래스 안에서만 선언해야함
        static void Main(string[] args)
        {
            if (doPrint == true)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}