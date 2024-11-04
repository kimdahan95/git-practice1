﻿using System.Reflection;

namespace ConsoleApp1;
class Program
{
    // 문제 : 3의 배수 합 구하기(기회 제한)
    //    Q : 사용자로부터 0 이상의 숫자를 입력받아 3의 배수의 합을 계산하는 프로그램을 작성하시오.
    //        조건은 다음과 같습니다.
    //        (1) 사용자는 최대 10번의 입력 기회를 갖습니다 (while 사용)
    //        (2) 3의 배수가 아닌 경우 "3의 배수만 합산됩니다."를 출력하고 다음 입력을 받습니다.(contunue 사용)
    //        (3) 사용자가 -1을 입력하면 반복을 종료합니다 (break 사용)
    //        (4) 10번의 입력 기회가 끝나면 최종 합을 출력하고 한 줄 띄워서 '프로그램 종료'라는것도 출력
    static void Main(string[] args)
    {
        //(n % 3 == 0)
        int chance = 1;
        int n = 1;
        int sum = 0;
        
        Console.WriteLine("3의 배수 합 구하기");

        int input;

        while (chance < 11)
        {
            Console.WriteLine("숫자를 입력하시오.");
            input = int.Parse(Console.ReadLine());
            if (input == -1)
            {
                break;
            }
            if(input % 3 != 0)
            {
                Console.WriteLine("3의 배수만 합산됩니다.");
                continue;
            }



            chance++;
            

            sum = sum + input;
        }
        
        Console.WriteLine(sum);
        Console.WriteLine("프로그램 종료");

    }


}
