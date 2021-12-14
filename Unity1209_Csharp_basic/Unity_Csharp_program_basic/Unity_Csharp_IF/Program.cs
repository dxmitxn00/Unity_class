using System;

namespace Unity_Csharp_IF
{
    class Program
    {
        static bool condition1; // 변수나 함수는 클래스 안에서만 선언해야함
        static bool condition2 = true;
        static bool condition3;
        static void Main(string[] args)
        {
           // 만약에 소괄호 안의 내용이 참이면 중괄호 안의 내용을 실행한다.
           /*if (조건1)
            {
                조건1이 참일 때 실행할 내용
            }
           else if(조건2)
            {
                조건1이 거짓이고 조건2가 참일 때 실행할 내용
            }
           else if(조건3)
            {
                조건1,2가 거짓이고 조건3이 참일 때 실행할 내용
            }
            else
            {
                모든 조건들이 거짓일 때 실행할 내용
            }*/
           if (condition1)
            {
                Console.WriteLine("조건1이 참");
            }
           else if(condition2)
            {
                Console.WriteLine("조건1이 거짓, 조건2가 참");
            }
           else if(condition3)
            {
                Console.WriteLine("조건1과 2가 거짓, 조건3이 참");
            }
           else
            {
                Console.WriteLine("조건 모두가 다 거짓");
            }
           // bool 자료형은 아무 값도 넣어주지 않으면 무조건 False임
           // 한 bit에 값이 없을 경우 0이고 그 중에 하나라도 1이면 True가 나옴
        }
    }
}