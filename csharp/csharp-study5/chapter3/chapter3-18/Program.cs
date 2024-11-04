namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //////중첩 루프 (다중 for문)
        for (int i = 0; i < 3; i++)
        {
            Console.Write("i : " + i + " -> ");
            Console.Write("j : ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
        ////// 구구단

        for (int y = 1; y < 10; y++)

        {

            for (int x = 2; x < 10; x++)

            {

                Console.Write($" {x} * {y} = {x * y}" + "\t");


            }
            Console.WriteLine();

        }

        //// 정사각형 별 패턴
        ////   Q. 사용자가 입력한 숫자 n을 기준으로 n x n 정사각형의 별 패턴을 출력하세요.
        ////      이중 for문을 사용하여 별을 출력하세요.
        //// 예시1: 정사각형의 크기를 입력하세요: 4
        ////       ****
        ////       ****
        ////       ****
        ////       ****
        //// 예시2: 정사각형의 크기를 입력하세요: 3
        ////       ***
        ////       ***
        ////       ***
        //// 예시1: 정사각형의 크기를 입력하세요: 2
        ////       **
        ////       **
        Console.WriteLine("정사각형의 크기를 입력하세요:");
        int n = int.Parse(Console.ReadLine());

        for (int s = 0; s < n; s++)
        {
            for (int w = 0; w < n; w++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        //// 이중 for문 이용해서 아래와 같이 출력
        //// 1 + 1 = 2   1 + 2 = 3   1 + 3 = 4   1 + 4 = 5
        //// 2 + 1 = 3   2 + 2 = 4   2 + 3 = 5   2 + 4 = 6
        //// 3 + 1 = 4   3 + 2 = 5   3 + 3 = 6   3 + 4 = 7
        //// 4 + 1 = 5   4 + 2 = 6   4 + 3 = 7   4 + 4 = 8


        Console.WriteLine("숫자를 입력하세요 :");
        int z = int.Parse(Console.ReadLine());
        for (int o=1; o<=z; o++)
        {
            for(int p=1; p<=z; p++)
            {
                Console.Write($"{o}+{p}={o + p}"+"\t");
            }
            Console.WriteLine();
        }
    }
}