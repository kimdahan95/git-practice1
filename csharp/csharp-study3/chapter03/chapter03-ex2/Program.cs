﻿using System;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.월요일");
        Console.WriteLine("2.화요일");
        Console.WriteLine("3.수요일");
        Console.WriteLine("4.목요일");
        Console.WriteLine("5.금요일");
        Console.WriteLine("6.토요일");
        Console.WriteLine("7.일요일");
        ConsoleKeyInfo ketInfo = Console.ReadKey();  //사용자의 키보드 입력을 받은 문자를 처리
     Console.WriteLine(); //줄바꿈
                          //입력받은 문자 출력
     //Console.WriteLine("입력한 값" + ketInfo.KeyChar);

        switch (ketInfo.KeyChar)
        {
            case '1':Console.WriteLine("월요일");break;
            case '2':Console.WriteLine("화요일");break;
            case '3':Console.WriteLine("수요일");break;
            case '4':Console.WriteLine("목요일");break;
            case '5':Console.WriteLine("금요일");break;
            case '6':Console.WriteLine("토요일");break;
            case '7':Console.WriteLine("일요일");break;
            default:Console.WriteLine("잘못된 입력");break;

        }


    }
}