using System;

namespace Unity_Csharp_InstantiationOfClass // 클래스의 객체화
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // 점 연산자(도트 연산자)
            // 클래스의 멤버에 접근할 때 사용, namespace 안의 클래스에 접근할 때 사용
            // ex) System.Console.WriteLine
            person1.age = 40; // 정수형 - 숫자입력
            person1.height = 223.4f; // 실수형 - 숫자 뒤에 f 추가 입력
            person1.isFemale = false; // 논리형은 true 또는 false
            person1.genderChar = '남'; // 문자형은 '' 작은 따옴표 안에 단일 문자
            person1.name = "김아무개"; // 문자열형은 "" 큰 따옴표 안에 다중 문자

            person1.SayAllInfo();

            Person person2 = new Person();
            person2.age = 80;
            person2.height = 123.4f;
            person2.isFemale = true; 
            person2.genderChar = '여';
            person2.name = "이아무개";
                  
            person2.SayName();
        }
    }
    class Person
    {
        // 접근제한자(자료형 앞에 위치함/ 아무것도 안적혀 있으면 기본적으로 private임)
        // ㄴ> public, private, protected
        // public : 다른 클래스에서도 접근이 가능함
        // private : 다른 클래스에서 접근이 불가능함
        // protected : 상속자만 접근이 가능함

        public int age;
        public float height;
        public bool isFemale;
        public char genderChar;
        public string name;

        public void SayAllInfo()
        {
            SayAge();
            SayHeight();
            SayIsFemale();
            SayGenderChar();
            SayName();
        }
        public void SayAge()
        {
            Console.WriteLine(age);
        }
        public void SayHeight()
        {
            Console.WriteLine(height);
        }
        public void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }
        public void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }
        public void SayName()
        {
            Console.WriteLine(name);
        }

    }
}
