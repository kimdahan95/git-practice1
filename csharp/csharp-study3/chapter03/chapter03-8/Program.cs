﻿using System;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //제어문
        //1.if문
        /*여러줄 주석
         * if(조건문(관계연산자 혹은 논리연산자))
         *    구문;
         *    
         *    조건문이 true이면 '구문'을 실행 false이면 구문을 실행하지 않음
         *    
         *    if(조건문(관계연산자 혹은 논리연산자)) 구문;
         *    if문에 중괄호{}가 없는 경우 1개만(only) 적는것이 가능
         *    if문에 중괄호{}가 없는 경우 구문을 1개이상의 구문이 실행
         */
        //프로그램내용 :3의 배수일 경우에 '3의 배수'출력이 되는 프로그램 생성
        int a = 5;
        int b = 6;
        if (a % 3 == 0)  // false
            Console.WriteLine("a는 3의 배수");

        if ((b % 3 == 0) && (b % 2 == 0)) //true
        {
            Console.WriteLine("b는 2의 배수");
            Console.WriteLine("b는 3의 배수"); // 중괄호가 없으면 무조건 실행
        }
        if ((6 % 3) == 0)
        {
            Console.WriteLine("6은 3의 배수");
            Console.WriteLine("연산결과 끝!");
        }
        //value변수의 값과 if문으로 짝수 홀수 구분해서 출력하기
        long value = 20000000000;
        if (value % 2 == 0)  //true일 경우 실행
        {
            Console.WriteLine("value는 2의 배수");
            Console.WriteLine("따라서 value는 짝수");
        }
        else                 //false일 경우 실행
        {
            Console.WriteLine("values는 홀수");
        }

        //else if 사용하기
        if (value <= 255) Console.WriteLine("byte로 변환이 가능");
        else if (value <= 65535) Console.WriteLine("ushort로 변환이 가능");
        else if (value <= 2100000000) Console.WriteLine("int로 변환이 가능");
        else Console.WriteLine("long타입");

        //삼항 연산자
        //문법 : (조건식) ? 표현식1 : 표현식2
        //설명 : 조선식이 true이면 '표현식1'을 실행하고 false이면 '표현식2'을 실행
        int value2 = 5;
        string result;
        if(value2 % 2 == 0)
        {
            result = "짝수";
        }
        else
        {
            result = "홀수";
        }
        Console.WriteLine(result);

        //위의 코드를 삼항연산자로 변환
        string result2 = (value2 % 2 == 0) ? "짝수" : "홀수";
        Console.WriteLine(result2);

        //문제1. 변수 age가 20이상이고 hasLicense가 true일 경우 '운전가능'을 출력 false일 경우 '운전불가'출력
        int age = 10;
        bool hasLicense = true;
        string result3;
        if (age >= 20 && hasLicense)
        {
            result3 = "운전가능";
        }
        else
        {
            result3 = "운전불가";
        }
        Console.WriteLine(result3);

        //문제2. 아래 변수 isWeekend와 isHoliday 중 하나라도 true일경우 '쉬는날입니다' 를 출력
        //                                                   false일경우 '일하는 날입니다'를 출력
        bool isWeekend = false;
        bool isHoliday = true;
        string result4;
        if((isWeekend || isHoliday))
        {
            result4 = "쉬는날입니다";
        }
        else
        {
            result4 = "일하는 날입니다";
        }
        Console.WriteLine(result4);
  


    }
}