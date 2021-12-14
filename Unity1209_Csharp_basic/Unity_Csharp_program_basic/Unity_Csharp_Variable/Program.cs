using System;

namespace Unity_Csharp_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Person
    {
        // bit = 한자리 이진수 ( 0과 1, 정보처리의 최소단위)
        // 1byte + 8bit (컴퓨터 CPU 데이터 처리 최소단위)
        // 4byte = 8bit * 4 = 32bit
        // 4byte로 표현할 수 있는 숫자의 범위 - > 2^32
        int age; // 정수형 (4byte)
        float height; // 실수형 (4byte)
        bool isFemale; // 논리형(참과 거짓) (1byte)
        char genderChar; // 문자형 (2byte)
        string name; // 문자열 (문자갯수 * 2byte)
    }
}
