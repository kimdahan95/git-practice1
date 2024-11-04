using System;
using System.Reflection;

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        //문제 : 비밀번호 맞추기 문제
        // Q.  사용자로부터 비밀번호를 입력받고, 비밀번호가 맞을 때까지 계속 입력을 요청하는
        //     프로그램을 작성하세요. 비밀번호가 맞으면 "비밀번호가 올바릅니다".를 출력하고 종료
        //     정답 비밀번호는 "password123"입니다.

        // 예시 : 비밀번호를 입력하세요 : abc
        //        비밀번호가 틀렸습니다. 다시 시도하세요
        //        비밀번호를 입력하세요 : 24fd
        //        비밀번호가 틀렸습니다. 다시 시도하세요
        //        비밀번호를 입력하세요 : password123
        //        비밀번호가 올바릅니다.
        //        프로그램 종료

        string correctPassword = "password123";
       
        string userinput = "";
        

           
        



        while (userinput != correctPassword)
        {
            Console.WriteLine("비밀번호를 입력하세요.");
            userinput = Console.ReadLine();


            if (userinput != correctPassword)
                Console.WriteLine("비밀번호가 틀립니다.");

            else Console.WriteLine("비밀번호가 맞습니다.");

        }
        
       
    }
}