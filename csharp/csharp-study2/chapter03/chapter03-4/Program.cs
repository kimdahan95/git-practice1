// 형(type) 변환(conversion)
// 1. 암시적 형 변환
// 2. 명시적 형 변환

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //암시적 형 변환
        byte b = 250;  // byte 데이터 범위  0 ~ 255
        short s = b;   // short 데이터 범위 -32,000 ~ 32,000
        Console.WriteLine(s);

        short s1 = 25000;
        byte b1 = (byte)s1; //명시적 형 변환  (숫자끼리)
        Console.WriteLine(b1);

        ushort u = 65; // 0 ~ 65,000
        // char 65는 A
        char c = (char)u;     // 0000 ~ FFFF(65,000)  < 정수형 -> 문자형 경우에는 명시적 형변환 허용>
        Console.WriteLine(c); // A

        byte byteValue = 10;
        char charValue = 'A';
        
        double doubleValue = (double)byteValue;
        //string str 1 = charValue; //암시적 형변환 예시
        string str2 = "abc";
        //charValue = str1;         //명시적 형변환 예시
    }
}