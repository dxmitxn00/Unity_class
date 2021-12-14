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

/* 객체 선정 : 사람
 * 
 * 추상화 : 사람의 특징과 정보요약(나이, 키, 성별문자, 이름 등)
 * 
 * 클래스화(설계도제작) : 추상화에 열거된 특징, 요소들의 형태를 정의해줌
 *    ㄴ> 변수 "나이"는 정수형, 변수 "키"는 실수형 등등(클래스 Person에 해당)
 *    
 * 객체화 : 설계도로 객체를 만든다, 찍어낸다.
 *    ㄴ> 객체 : 어떤 동작이나 능력을 가진 클래스로 만들어진 사물/개념
 * 
 * 인스턴스화 : 클래스로 생성한 객체를 메모리에 할당해준다.
 *    ㄴ> 인스턴스 : 메모리에 할당된 객체
 */

