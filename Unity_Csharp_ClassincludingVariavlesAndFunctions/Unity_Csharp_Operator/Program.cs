using System;

namespace Unity_Csharp_Operator
{
    class Program
    {
        static int a = 14; // 메인에서 쓸 변수, 메인함수가 static이어서 변수도 static이어야함
        static int b = 5;
        static int c;
        static void Main(string[] args)
        {
            /* 산술 연산
             : 더하기, 빼기, 나누기, 곱하기, 나머지*/

            // 더하기
            c = FuctionsForOperation.Sum(a,b);
            Console.WriteLine(c); // Console.Write는 다 붙어서 나옴, LIne을 붙이면 한줄 밑으로

            // 빼기
            c = a - b;
            Console.WriteLine(c);

            // 나누기 - 정수를 나누기하면 결과값에서 소수점은 버림(나머지를 버림)
            c = a / b;
            Console.WriteLine(c);

            // 곱하기
            c = a * b;
            Console.WriteLine(c);

            // 나머지;
            c = a % b;
            Console.WriteLine(c);



            /* 증감 연산
             : 증가 연산자, 감소 연산자*/

            // 증가연산
            c++; // c = c + 1;
            Console.WriteLine(c);

            // 감소연산
            c--; // c = c - 1;
            Console.WriteLine(c);


            /* 관계 연산
             : 같음, 다름, 크기 비교 연산
              ㄴ> 관계 연산의 결과가 참이면 true, 거짓이면 false를 반환*/

            // 같음 비교
            Console.WriteLine(a == b);

            // 다름비교
            Console.WriteLine(a != b);

            // 크다
            Console.WriteLine(a > b);

            // 작다
            Console.WriteLine(a < b);

            // 크거나 같다
            Console.WriteLine(a >= b);

            // 작거나 같다
            Console.WriteLine(a <= b);



            /* 대입 연산
             : 더해서, 빼서, 나누어서, 곱해서, 나머지를 대입*/
            c = 20;
            Console.WriteLine($"Last C value : {c}");

            // 더해서 대입
            c += b; // c = c + b;
            Console.WriteLine(c);

            // 빼서 대입
            c -= b; // c = c - b;
            Console.WriteLine(c);

            // 나누어서 대입
            c /= b; // c = c / b;
            Console.WriteLine(c);

            // 곱해서 대입
            c *= b; // c = c * b;
            Console.WriteLine(c);

            // 나머지를 대입
            c %= b; // c = c % b;
            Console.WriteLine(c);



            /*논리 연산
             : 양측의 피연산자들을 비교해서 연산 수행
              ㄴ> or, and, xor, not*/
            bool A = true;
            bool B = false;

            // or : a 와 b 둘 중 하나라도 true 이면 true 반환
            Console.WriteLine(A | B);

            // and : a 와 b 둘다 true 일 때만 true 반환
            Console.WriteLine(A & B);

            // xor : a 와 b 둘 중에 하나만  true 일 때 true 반환
            Console.WriteLine(A ^ B);

            // not : a 의 반대 부호 반환 ( true 이면 false, false 이면 true 반환)
            Console.WriteLine(!A);




            /* 조건부 논리 연산
             : 왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지 말지 판단 후에 연산*/

            // or 조건부 논리 연산 : 만약 A가 true 이면 B의 값에 관계없이 결과값이 true 이므로 연산을 하지 않고 A 값을 반환함
            Console.WriteLine(A || B);

            // and 조건부 논리 연산 : 만약 A가 false 이면 B의 값에 관계없이 결과값이 false 이므로 연산을 하지 않고 A 값을 반환함
            Console.WriteLine(A && B);



            /* 비트 연산
             : 데이터를 효율적으로 관리하기 위함
              ㄴ> or, and, xor, not, shift-left, shift-right*/
            int howManyBitYouWantToShift = 1;
            // or
            Console.WriteLine(a | b);

            // and
            Console.WriteLine(a & b);

            // xor
            Console.WriteLine(a ^ b);

            // not
            Console.WriteLine(~a);

            //shift-left
            Console.WriteLine(a << howManyBitYouWantToShift); // 숫자 쓰는 거 만큼 왼쪽으로 땡김

            //shift-right
            Console.WriteLine(a >> howManyBitYouWantToShift);
        }
    }

    // FSM Finite State Machine 유한 상태머신 ( 상태의 개수가 정해진 머신 )
    // 클래스의 상태에 따라 다른 동작을 하기 위해 사용
          // FSM 예시) 플레이어에게 귀환하기 라는 기능이 있는데 플레이어 상태(FSM)가 쉬고있음, 피격당한상태, 공격하고있는상태 등 상태 변화에 따른 행동들
    [Flags]
    public enum e_FSM
    {
        IDLE = 0,
        STATE_1 = 1 << 0, // 피격당한 상태
        STATE_2 = 1 << 1, // 공격중인 상태
        STATE_3 = 1 << 2, // 등등 상태들
        STATE_4 = 1 << 3,
    }
}


/*1217 배울거
1. 연산자
2. 연산자 사용을 위한 클래스
3. 배열

- 연산자
  : 수학적인 연산을 하기 위한 부호 ( + - * / 등 )

*/