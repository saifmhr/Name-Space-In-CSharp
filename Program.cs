using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace Name_Space_In_CSharp
{
  class Program
    {
        static void Main()
        {
            PATA.ClassA.Print();
            PATB.ClassA.Print();



            //ClassA.Print();
            //ClassB.Print();
        }
    }
}

//namespace ProjectA
//{
//    namespace TeamA {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("Team A Print Method");
//            }
//        }
//    }
//}

//namespace ProjectA
//{
//    namespace TeamB
//    {
//        class ClassB
//        {
//            public static void Print()
//            {
//                Console.WriteLine("Team B Print Method");
//            }
//        }
//}

