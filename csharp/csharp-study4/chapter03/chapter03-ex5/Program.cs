﻿using System.Reflection;

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
       //랜덤한 숫자 출력하기
       Random random = new Random();

        //int rndNumber = random.Next(1,100);
        //Console.WriteLine(rndNumber);  // 1 ~ 99 사이의 무작위 숫자가 출력

        // rndNumber = random.Next(3, 8); // 3 ~ 7 사이의 무작위 숫자가 출력
        // Console.WriteLine(rndNumber);

        // 문제 : (1)랜덤한 값이 1~20까지 지정을 합니다.
        //        (2)3 ~ 7 사이인 경우 '3 ~ 7 사이 입니다' 라고 출력
        //        (3)만약 숫자가 5이면 "프로그램을 종료합니다." 출력

        //예시
        //랜덤 숫자 8
        //랜덤 숫자 20
        //랜덤 숫자 6 , "3 ~ 7 사이 입니다."
        //랜덤 숫자 8
        //랜덤 숫자 5
        //랜덤을 6번 돌렸을 때 5가 나왔습니다.
        //프로그랩을 종료합니다.

        int rndNumber = random.Next(1, 21);
        

        int count = 0;
        
        while (true)
        {
            
            rndNumber = random.Next(1, 21);
            Console.WriteLine(rndNumber);
            count += 1;

            if (rndNumber == 5)
            {
                
                Console.WriteLine($"랜덤을 {count}번 돌렸을 때 5가 나왔습니다.");
                Console.WriteLine("프로그램을 종료합니다.");
                break;
            }
            if(rndNumber >=3 && rndNumber <= 7)
            {
                Console.WriteLine("3 ~ 7 사이 입니다.");
                continue;
            }
            
        }
    }


}
