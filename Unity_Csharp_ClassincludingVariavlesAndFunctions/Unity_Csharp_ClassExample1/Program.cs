using System;

namespace Unity_Csharp_ClassExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc(); // 객체 만들고 인스턴스화 시킴

            orc1.name = "상급 오크";
            orc1.height = 240.2f;
            orc1.weight = 200.0f;
            orc1.age = 140;
            orc1.genderchar = '남';
            orc1.isResting = false;

            Orc orc2 = new Orc();

            orc2.name = "하급 오크";
            orc2.height = 140.4f;
            orc2.weight = 120.0f;
            orc2.age = 60;
            orc2.genderchar = '여';
            orc2.isResting = true;


            //orc1.OrcInfo(); // 오크1 정보
            //orc2.OrcInfo(); // 오크2 정보
            if (orc1.isResting == false)
            {
                Console.WriteLine($"{orc1.name}(은)는 바쁘다.\n");
            }
            else
            {
                orc1.Jump();
                orc1.Smash();
            }

            if (orc2.isResting == false)
            {
                Console.WriteLine($"{orc2.name}(은)는 바쁘다.\n");
            }
            else
            {
                orc2.Jump();
                orc2.Smash();
            }

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

        /*public void OrcDoing()
        {
            if (isResting == false)
            {
                Console.WriteLine($"{name}(이)가 바쁘다.\n");
                //Console.WriteLine(name + "(이)가 바쁘다. \n");
            }
            else
            {
                Jump();
                Smash();
            }
        }*/

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
