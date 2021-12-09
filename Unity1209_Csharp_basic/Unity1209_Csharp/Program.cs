// using 키워드:
// 뭔가를 사용하겠다고 선언하는 키워드

// using은 언제 쓰나 :
//    C#의 경우 1. 네임스페이스 정의할 때
//              ㄴ> 만약 Unity1 이라는 namespace의 클래스 등 정보를 가져와 쓰고 싶을 때
//                     =>  using Unity1 이라고 최상단에 적음

//              2. 우선순위가 차순위인 함수 호출할 때
//              ㄴ>Unity에서 물리엔진 다루는 키워드 = UnityEngine.Physics, 그냥 Unity.Physics은 다른 역할
//                     => 두가지 중 UnityEngine.Physics가 우선순위
//                   두 네임스페이스 모두 Raycast()라는 함수 포함
//                   내가 Unity.Physics.Raycast()를 쓰고 싶을 때 그냥 RayCast()를 호출하면 UnityEngine.Physics가 호출됨
//                   using FayCast =  Unity.Physics.RayCast; 라고 하면 Unity.Physics.RayCast가 호출됨
using System;
// System이라는 namespace를 쓰겠다.

// namespace 키워드 :
// 클래스 간의 멤버 이름 충돌을 방지하기 위함 
namespace Unity1209_program
{   // Program class
    // 모든 프로젝트는 처음 실행파일(.exe)을 통해 실행될 때에
    // Main() 함수를 실행하며
    // C#에서는 Main()함수조차도 객체지향컨셉에 맞게 Program이라는 클래스 안에 선언되어있음
 
    class Program
    {
        // static 키워드 :
        // static(정적) dynamic(동적)의 반대 개념 키워드
        // static은 상황에 따라 메모리에 할당할 수 없는 성질
        // dynamic은 상황, 조건에 따라 메모리에 할당할 수 있는 성질
        // Main 함수는 Static으로 정의도었으므로 하나만 존재할 수 있다.
        // class에 static이 붙으면 class에 딸린 모든 변수나 함수도 static 이어야함

        // void 자료형 :
        // 반환값이 없다.
        // 함수의 기본 형태 - 입력 -> 기능수행 -> 출력
        //    void 반환 함수- 입력(없을 수도 있음) -> 기능수행

        // args :
        // arguments = 인자, 인수
        // 함수에서 받을 입력
        // 표기방법 - 함수이름(자료형 인자이름)
        static void Main(string[] args)
        {  
            // Console 클래스 :
            // System.Console 인데 using System으로 System namespace를 불러왔기때문에 System.이 없어도 System의 Console 클래스를 불러온다.
            Console.WriteLine("Hello World!");
        }
    }
}
