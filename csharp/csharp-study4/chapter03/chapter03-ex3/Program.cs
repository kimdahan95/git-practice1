using System.Reflection;

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        //while 무한 루프
        //while (true)
        //{
        //    Console.WriteLine("무한루프입니다");

        //    break;   // while문을 빠져나가는 코드
        //}

        //문제 : 사용자가 종료를 원할 때 까지 반복
        // Q.사용자로부터 숫자를 계속 입력받고, 그 숫자를 출력합니다.
        //   사용자가 "exit"를 입력할 때까지 반복합니다.
        // 예시
        // 숫자를 입력하세요 (종료하려면 'exit' 입력) : 12
        // 입력한 숫자 : 12
        // 숫자를 입력하세요 (종료하려면 'exit' 입력) : 36
        // 입력한 숫자 : 36
        // 숫자를 입력하세요 (종료하려면 'exit' 입력) : 48
        // 입력한 숫자 : 48
        // 숫자를 입력하세요 (종료하려면 'exit' 입력) : exit
        // 프로그램을 종료합니다.
        
        string input;
        

        while (true)
        {
            Console.WriteLine("숫자를 입력하세요.");
            input = Console.ReadLine();

            

            if(input == "exit")
            {
                Console.WriteLine("프로그램을 종료합니다.");
                break;
            }
            Console.WriteLine($"입력한숫자 : {input}");  // $ < 변수를 사용 가능
            Console.WriteLine("입력한숫자 : {input}");
        }


    }
}