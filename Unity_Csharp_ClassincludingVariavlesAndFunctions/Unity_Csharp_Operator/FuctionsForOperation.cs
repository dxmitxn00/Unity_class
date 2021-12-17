using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp_Operator
{
    class FuctionsForOperation
    {
        // 산술 연산

        // 덧셈
        static public int Sum(int a, int b)
        {
            return a + b; // Sum 함수는 정수 두개를 입력받아 정수형으로 반환(return)받음
        }

        // 뺄셈
        static public int Sub(int a, int b)
        {
            return a - b;
        }

        // 나눗셈
        static public int Div(int a, int b)
        {
            return a / b;
        }
        // 곱셈
        static public int Mul(int a, int b)
        {
            return a * b;
        }
        // 나머지
        static public int Mod(int a, int b)
        {
            return a % b;
        }

        // 증감 연산

        // 증가연산
        static public int Increase(int a)
        {
            return a++;
        }

        // 감소연산
        static public int Decrease(int a)
        {
            return a--;
        }


        // 관계 연산

        // 같음 비교
        static public bool IsSame(int a, int b)
        {
            return a == b;
        }

        // 다름 비교
        static public bool IsDifferent(int a, int b)
        {
            return a != b;

        }
    }
}


/* 클래스 하나당 C# 스크립트를 하나씩 만든 것이 가독성 좋음*/