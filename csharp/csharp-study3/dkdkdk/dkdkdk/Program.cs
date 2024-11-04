namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("알파벳 문자를 입력하세요");
        ConsoleKeyInfo charKey = Console.ReadKey();
        Console.WriteLine();

        char letter = charKey.KeyChar;

        switch (letter)
        {
            case 'a': case 'A':
                case 'i':
            case 'I':
            case 'u':
            case 'U':
            case 'o':
            case 'O':
            case 'e':
            case 'E': Console.WriteLine("모음입니다");break;
                default:
                if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
                    Console.WriteLine("자음입니다");
                else Console.WriteLine("잘못된 입력입니다");break ;

        }





    }
}