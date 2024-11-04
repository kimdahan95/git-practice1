// 실수형 기본 타입
// 1) float   -> 4byte  (2의 32승)
// 2) double  -> 8byte  (2의 64승)
// 3) decimal -> 16byte (2의 128승)

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        float f = 5.2f; // 기본적으로 소수점은 double ->  float으로 바꾸려면 숫자 마지막 뒤에 'f'를 넣어야 함
        double d = 10.5;
        decimal money = 200.099m;
        // $는 float를 쓰는게 좋음 최적화를 위해서

        //Console.WriteLine(f);
        //Console.WriteLine(d);
        //Console.WriteLine(money);

        byte age = 25; // byte로 하는게 best
        double height = 175.5; // double은 너무커서 flot으로 하는게 best

        Console.WriteLine(age);
        Console.WriteLine(height);

        long num = 300; //단위에 맞춰서 하는게 best
        float result = num + 100.5f;
        Console.WriteLine(result);
    }
}