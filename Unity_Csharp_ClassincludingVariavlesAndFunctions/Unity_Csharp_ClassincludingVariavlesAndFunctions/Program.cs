using System;

namespace Unity_Csharp_ClassincludingVariavlesAndFunctions // 클래스에 포함된 변수와 함수
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Person
    {
        int age;
        float height;
        bool isFemale;
        char genderChar;
        string name;

        // 함수 : 입력 -> 함수기능 -> 출력
        void SayAllInfo()
        {
            SayAge();
            SayHeight();
            SayIsFemale();
            SayGenderChar();
            SayName();
        }
        void SayAge()
        {
            Console.WriteLine(age); // 출력문 = Console.WriteLine();
        }
        void SayHeight()
        {
            Console.WriteLine(height);
        }
        void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }
        void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }
        void SayName()
        {
            Console.WriteLine(name);
        }
        
    }
}

/* Camel Case
 * class, function, namespace, using 등은 대문자로 이름 써줌
 * 변수는 소문자로 시작한다.
 * 단어가 바뀔 대 첫 문자는 대문자로 한다.
 * 
 * 줄임말은 되도록 사용하지 않는다.
 * 이름을 보았을 때 어떤 기능이나 목적인지 알 수 있도록 선정한다.
 * 애매하거나 복잡한 내용은 주석을 달아준다.
 */