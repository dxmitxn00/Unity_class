using System;

namespace Unity_Csharp_StaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc(); // orc1은 Orc에 대한 인스턴스 / orc1을 통해 Orc를 참조할 수 있음
            orc1.name = "오크";       //ㄴ> 인스턴스화: 객체를 메모리에 할당하는 것
            orc1.height = 240.0f;

            Orc.typeName = "오크 타입 설계도"; // tyName이 static으로 지정해서 orc1을 통해서 접근할 수 없음, 바로 Orc로 접근가능
            Orc.SayTypeName();
        }
    }

    class Orc
    {
        public string name;
        public float height;
        public float weight;
        public int age;
        public char genderchar;
        public bool isResting;

        public void OrcInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(height);
            Console.WriteLine(weight);
            Console.WriteLine(age);
            Console.WriteLine(genderchar);
            Console.WriteLine(isResting);
            Console.WriteLine("\n");
        }

        static public string typeName;
        
        static public void SayTypeName()
        {
            Console.WriteLine(typeName);
        }

        public void Jump()
        {
            Console.WriteLine($"{name}(이)가 점프했다. \n");
        }
        public void Smash()
        {
            Console.WriteLine($"{name}(이)가 휘두르기 공격을 했다. \n");
        }

    }

    static class Person
    {

    }
}

/* static 키워드 : 정적 성질을 부여하는 키워드
 *    - 정적 : 메모리에 할당 불가능
 *    - 동적 : 메모리 할당이 가능
 * 
 * static은 정적이라 인스턴스화 불가능
 * static 함수도 마찬가지
 * 
 * static class를 쓰는 이유
 *    : 객체를 찍어내는 것이 아닌 정보, 기능, 개념등 유일 필요 정보를 담고있는 class가 필요할 때 쓰임
 *    ex) 포탈 존 위치
 *    
 * !!!!static의 멤버(변수와 함수)는 객체 단위로 접근할 수가 없음
 *     static으로 정의된 클래스는 인스턴스화가 불가능!!!!
 *     
 * static 함수에서는 static 변수만 쓸 수 있음
 */