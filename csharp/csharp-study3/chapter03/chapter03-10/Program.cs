using Microsoft.VisualBasic;
using System;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo ketInfo = Console.ReadKey();  //사용자의 키보드 입력을 받은 문자를 처리
        Console.WriteLine(); //줄바꿈
        //입력받은 문자 출력
        Console.WriteLine(ketInfo.KeyChar);



        //제어문
        //switch
        /*
         * switch(인스턴스)   인스턴스 : 변수이름
         * {
         *     case 상수식1;
         *     구문1;
         *     break;
         *     case 상수식2;
         *     구문2;
         *     break;
         *     .
         *     .
         *     .
         *     .
         *     default; //생략이 가능
         *     구문n;
         *     break;
         * 
         * }
         */

        char ch = 'M';
        switch (ch)
        {
            case 'M':
                Console.WriteLine("남성");
                break;
            case 'F':
                Console.WriteLine("여성");
                break;
            default:
                Console.WriteLine("알수없음");
                break;
        }
        // switch 에서 if 로 변환 하면
        // ---------------------------------------------------------
        if (ch == 'M')
            Console.WriteLine("남성");
        else if (ch == 'F')
            Console.WriteLine("여성");
        else Console.WriteLine("알 수 없음");

        string text = "C#";
        switch (text)
        {
            case "C#":
            case "VB.NET":
                Console.WriteLine(".NET 호환 언어");
                break;

            case "JAVA":
                Console.WriteLine("JVM 언어");
                break;

            default:
                Console.WriteLine("알수없음");
                break;
        }

        // switch 에서 if 로 변환
        string text1 = "C#";
        if (text1 == "C#" || text1 == "VB.NET")
            Console.WriteLine(".NET 호환 언어");
        else if (text1 == "JAVA")
            Console.WriteLine("JVM 언어");
        else
        {
            Console.WriteLine("알수없음");







        }
    }
}