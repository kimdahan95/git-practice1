using System.Reflection;

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        // 문제 : 사용자로부터 양의 정수 n을 입력받고, 1부터 n까지의 모든 홀수를 출력하는
        //        프로그램을 while문을 사용하여 작성하세요.

        Console.Write("양의 정수 n을 입력하세요");
        Console.Write("");
        int n = int.Parse(Console.ReadLine()); // 문자를 숫자로

        int i = 1;
             
              
        while (i <= n)
        {
            if (i % 2 != 0) // 2로 나누었을 때 0이 아니면 홀수
                Console.Write(i + "\t");
                
            
            i++;
        }
        

    }
}