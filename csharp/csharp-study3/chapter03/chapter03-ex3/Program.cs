using System;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //Console.ReadKey();   // 문자 1개만 입력받을 수 있도록 대기
        //Console.ReadLine 사용예제
        //string input1 = Console.ReadLine();    // 문자가 1개이상을 입력 받을 수 있도록 대기
        //Console.WriteLine("입력한 값 :" +'\t'+ input1);

        //int number = int.Parse(input1); // input1문자열을 숫자로 변형
        //Console.WriteLine("입력한 값" + input1);
        Console.WriteLine("첫번째 숫자를 입력하세요:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("두번째 숫자를 입력하세요:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("연산자를 입력하세요(+ , - , * , / :");
        ConsoleKeyInfo operationKey = Console.ReadKey();
        Console.WriteLine(); // 줄바꿈

        
        int num;
        switch(operationKey.KeyChar)
        {
            case '+':
                num = num1 + num2;
                Console.WriteLine(num);
                break;
            case '-':
                num = num1 - num2;
                Console.WriteLine(num);
                break;
            case '*':
                num = num1 * num2;
                Console.WriteLine(num);
                break;
            case '/':
                if (num2 == 0)
                    Console.WriteLine("0으로 나누기x");
                else
                {
                    num = num1 / num2;
                    Console.WriteLine(num);
                }
                break;
        } 
       
        
       


    }
}