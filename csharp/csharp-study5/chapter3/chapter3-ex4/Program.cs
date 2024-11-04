namespace ConsoleApp1;

class Program
{
    // 문제: 문자열 배열에서 길이가 4 이상인 문자열 출력
    //   Q: 아래과 같은 문자열 배열이 주어졌을 때,
    //      foreach문을 사용하여 길이가 4 이상인 문자열을 출력하세요.
    static void Main(string[] args)
    {
        string[] words = { "cat", "dog", "elephant", "lion", "tiger" };
        foreach(string a in words)
        {
            if (a.Length > 3)
            {
                Console.Write(" " + a);
            }
        }

        Console.WriteLine();

        // 문제2 : 배열의 최대값 찾기
        //     Q : 아래와 같은 정수 배열이 주어졌을 때,
        //         foreach문, if문을 사용하여 최대값을 찾아 출력하세요.
        int[] numbers = { 34, 67, 23, 89, 12, 56 };
        int max = numbers.Max();    // 최대값
        int min = numbers.Min();    // 최소값
     
        
        foreach (int i in numbers)
        {
            if(i == max)
            {
                Console.WriteLine(i);
            }
            
        }

        int max1 = numbers[0];
        foreach(int number in numbers)
        {
            if(number > max1)
            {
                max1 = number;
            }
        }
        Console.WriteLine(max1) ;

    }
}