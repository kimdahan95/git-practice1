using System.Reflection;

namespace ConsoleApp1;
class Program
{
    // 문제 : 숫자 맞추기 게임
    // Q. 1 ~ 50 사이의 무작위 숫자를 생성하고
    //    사용자가 그 숫자를 맞출 때까지 반복하는 게임을 작성하세요.
    //    조건은 다음과 같습니다.
    //    (1) 사용자가 맞출 때까지 반복해야 합니다.
    //    (2) 사용자가 숫자를 잘못 입력하면 "올바른 숫자를 입력하세요"를 출력하고 다시 입력을 받습니다.(continue 사용)
    //    (3) 사용자가 -1을 입력하면 게임을 종료합니다.(break 사용)
    //    (4) 만약 랜덤한 숫자가 사용자가 입력한 숫자보다 크면 "더 작은 숫자를 입력하세요"라고 출력
    //    (5) 만약 랜덤한 숫자가 사용자가 입력한 숫자보다 크면 "더 큰 숫자를 입력하세요"라고 출력

    //ㅇㅖ시 (랜덤숫자 26 가정)
    //1부터 50 사이의 숫자를 맞춰보세요 (종료하려면 -1 입력) : 10
    // 더 큰 숫자를 입력하세요.
    //1부터 50 사이의 숫자를 맞춰보세요 (종료하려면 -1 입력) : 30
    // 더 작은 숫자를 입력하세요
    //1부터 50 사이의 숫자를 맞춰보세요 (종료하려면 -1 입력) :
    static void Main(string[] args)
    {
        Random random = new Random();
        int targetNumber = random.Next(1,51); // 1 부터 50 사이의 무작위 숫자

        while (true)  // 맞출 때 까지 실행 , 맞추면 break문으로 빠져나오도록..
        {
            Console.WriteLine("1부터 50 사이의 숫자를 맞춰보세요.(종료하려면 -1 입력)");
            int num = int.Parse(Console.ReadLine());
            if (num == -1) 
            {
                break;
            }
            if(targetNumber == num)
            {
                Console.WriteLine("정답입니다, 프로그램을 종료합니다.");
                break;
            }
            if (targetNumber >= num)
            {
                Console.WriteLine("더 큰 숫자를 입력하세요.");
                
            }
            if (targetNumber <= num)
            {
                Console.WriteLine("더 작은 숫자를 입력하세요");
                
            }
        }

    }


}
