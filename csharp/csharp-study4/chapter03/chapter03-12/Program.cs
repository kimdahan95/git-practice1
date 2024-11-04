using System.Reflection;

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        //증감 연산자(++,--)
        //프로그래밍 언어의 변천사 순서 : C -> C++ -> C#
        // ++ : 피연산자의 값을 1을 증가
        // -- : 피연산자의 값을 1을 감소
        int n = 50;
        n++; // n = n + 1
        Console.WriteLine(n); // 51

        n--; // n = n - 1
        Console.WriteLine(n); // 50

        ++n; // n = n + 1
        Console.WriteLine(n); // 51

        --n; // n = n - 1
        Console.WriteLine(n); // 50

        Console.WriteLine("--------------------------------------");

        //증감연산자 실행 순서 파악  ( 증감연산자가 앞,뒤 차이에 따라 값이 다르게 나옴 앞에 나오면 증감 우선 )
        int n2 = 50;
        Console.WriteLine(n2++);  //50
        Console.WriteLine(n2++);  //51
        Console.WriteLine(n2);    //52

        int n3 = 50;
        Console.WriteLine(n3++);  //50
        Console.WriteLine(++n3);  //52
        Console.WriteLine(n3);    //52

        Console.WriteLine("--------------------------------------");
        n = 50;
        int result;
        result = n++; // result에 50을 대입한 후 값을 51로 증가, result의 값은 50
        // 1. result = n
        // 2. n = n + 1
        Console.WriteLine("result:" + result);
        Console.WriteLine("n4:" + n);

        n = 50;
        result = ++n; // n5의 값을 51로 증가시킨 후에 result에 값을 대입, result의 값은 51
        // 1. n = n + 1
        // 2. result = n
        Console.WriteLine("result:" + result);
        Console.WriteLine("n5:" + n);

        n = 50;
        result = n--; // result에 50을 대입한 후에 값을 49로 감소, result의 값은 50
        // 1. result =n
        // 2. n = n - 1
        Console.WriteLine("result:" + result);
        Console.WriteLine("n:" + n);

        n = 50;
        result = --n; // result에 49로 감소시킨 후에 result에 값을 대입, result의 값은 49
        // 1. n = n - 1
        // 2. result = n
        Console.WriteLine("result:" + result);
        Console.WriteLine("n:" + n);

        //증감 연산자가 먼저 나오면 먼저 계산 후 대입






    }
}