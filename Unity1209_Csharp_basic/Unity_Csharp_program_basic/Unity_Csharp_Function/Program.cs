using System;

namespace Unity_Csharp_Function
{
    class Program
    {
        static bool doPrintHelloWorld = true;
        static bool doPrintSomething = true;
        static void Main(string[] args)
        {
            // 함수 호출 시 함수이름(); 형태로 호출한다.
            if(doPrintHelloWorld == true)
            {
                PrintHelloWorld();
            }
            // parameter : 함수 호출 시 입력 변수
            string something = "Unity Hola!";
            if(doPrintSomething == true)
            {
                PrintSomething(something); //함수 선언할 때 인자를 넣어야한다고  적어놓고 인자를 안적으면 오류뜸
            }
          
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void PrintSomething(string something)
        {
            Console.WriteLine(something);
        }
    }

}
