﻿using System;

// Orc 객체를 10마리 만들고 오크들의 인스턴스는 Orc타입 배열에 넣어준다.
// 각 오크의 이름은 "오크0"부터 "오크9"까지
// 각 오크에게 isResting 의 값을 아무거나 넣어준다.(true나 false 중 아무거나)
// 각 오크가 쉬고 있는지 확인해서 쉬고있다면 점프하도록 한다.

namespace Unity_Csharp_ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc[] arr_Orc = new Orc[10]; // 길이값 10의 Orc타입의 배열을 선언
            int length = arr_Orc.Length;

            for (int i = 0; i < length; i++)
            {
                arr_Orc[i] = new Orc(); // 길이가 10인 Orc타입의 배열의 i번째 공간에 오크타입 객체를 생성하여 넣어준다.
                arr_Orc[i].name = $"오크{i}";
                arr_Orc[i].isResting = GetRandomBool();

            }

            for (int i = 0; i < length; i++)
            {
                if (i < 5)
                {
                    if (arr_Orc[i].isResting)
                    {
                        arr_Orc[i].Jump();
                    }
                }
            }
            static bool GetRandomBool()
            {
                Random rand = new Random();
                bool value = Convert.ToBoolean(rand.Next(0, 2));
                return value;
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

            public void Jump()
            {
                Console.WriteLine($"{name}(이)가 점프했다. \n");
            }
            public void Smash()
            {
                Console.WriteLine($"{name}(이)가 휘두르기 공격을 했다. \n");
            }
        }
    }
}



/* Collection
  : 동적 데이터 타입
  - List, Dictionary, Stack, Queue*/