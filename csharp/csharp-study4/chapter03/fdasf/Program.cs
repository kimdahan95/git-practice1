namespace ConsoleApp1;

class Program
{
    // 문제: 로또 프로그램 만들기
    // 로또 프로그램의 조건
    //   (1) 1 ~ 45까지 랜덤한 숫자 6자리를 출력
    //   (2) 숫자 6개는 같은 숫자가 나올 수 없다.

    // 예시
    //   생성된 로또 번호: 5 6 7 19 44 1
    //   프로그램 종료
    static void Main(string[] args)
    {
     
        int count = 1;
        while (count <= 6)
        {
            int[] lottoNumber = new int[6];
            Random random = new Random();
            int lotto = random.Next(1, 46);


            Console.Write("생성된 로또 번호");
            Console.WriteLine(lotto);
            count++;

        }
        Console.WriteLine("프로그램 종료");

    }
}
