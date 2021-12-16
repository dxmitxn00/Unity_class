using System;

namespace Unity_Csharp_Class_Object_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            // 객체 생성
            // new 키워드 : new 클래스이름 (); -> 객체 생성하는 법
            new AA(); // 생성자 : 클래스이름과 똑같은 함수, 객체를 생성함
                      // 객체를 생성했는데 안쓰는 것 같다고 판단하면 프로그램이 알아서 지움 -> 소멸자가 필요없음

            // 인스턴스화 : 메모리 공간에 객체를 할당시킨다. !!!이해잘해야함!!!
            // AA타입의 변수a에 new AA()로 생성된 객체가 할당되었다.
            // 이제 new AA()로 생성된 객체가 필요할 때마다
            // 변수a를 통해서 new AA()로 생성된 객체에 접근할 수 있게 되었다.
            // 그리고 이렇게 되었을 때 new AA()로 생성된 객체를 인스턴스라고 한다.
            AA a = new AA();
        }
    }
    // 클래스(설계도)
    public class AA
    {
      
    }
}
