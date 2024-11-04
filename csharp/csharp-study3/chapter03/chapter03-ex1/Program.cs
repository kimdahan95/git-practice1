namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.프로그램 시작");
        Console.WriteLine("2.설정 변경");
        Console.WriteLine("3.프로그램 종료");
        ConsoleKeyInfo ketInfo = Console.ReadKey();  //사용자의 키보드 입력을 받은 문자를 처리
        Console.WriteLine(); //줄바꿈
                             //입력받은 문자 출력
        Console.WriteLine("입력한 값" + ketInfo.KeyChar); //사용자 키보드 입력한 거 출력

        //문제 : 숫자 키 입력 받아 요일 출력
        // Q. 사용자로부터 1에서 7 사이의 숫자를 Console.ReadKey() 로 입력받아 숫자에 맞는 요일 출력
        /*1.월요일
         * 2.화요일
         * 3.수요일
         * 4.목요일
         * 5.금요일
         * 6.토요일
         * 7.일요일
         * 그 외의 숫자가 입력되면 "잘못된 입력" 출력
         */
        //switch (ketInfo.KeyChar)
        //{
        //    case '1':
        //        Console.WriteLine("월요일");
        //        break;
        //    case '2':
        //        Console.WriteLine("화요일");
        //        break;
        //    case '3':
        //        Console.WriteLine("수요일");
        //        break;
        //    case '4':
        //        Console.WriteLine("목요일");
        //        break;
        //    case '5':
        //        Console.WriteLine("금요일");
        //        break;
        //    case '6':
        //        Console.WriteLine("토요일");
        //        break;
        //    case '7':
        //        Console.WriteLine("일요일");
        //        break;
        //    default:
        //        Console.WriteLine("잘못된 입력");
        //        break;
        //}
        //문자->숫자
        //int keyDigit = int.Parse(ketInfo.KeyChar.ToString());
        //switch (keyDigit)
        //{
        //    case 1:
        //        Console.WriteLine("월요일");
        //        break;
        //    case 2:
        //        Console.WriteLine("화요일");
        //        break;
        //    case 3:
        //        Console.WriteLine("수요일");
        //        break;
        //    case 4:
        //        Console.WriteLine("목요일");
        //        break;
        //    case 5:
        //        Console.WriteLine("금요일");
        //        break;
        //    case 6:
        //        Console.WriteLine("토요일");
        //        break;
        //    case 7:
        //        Console.WriteLine("일요일");
        //        break;
        //    default:
        //        Console.WriteLine("잘못된 입력");
        //        break;
        //}
        ////숫자 -> 문자 or 문자열
        //string keyStr1 = keyDigit.ToString();   //문자열
        //Console.WriteLine("keyStr1"+keyStr1);
        //char keyChar1 = keyDigit.ToString()[0]; //문자
        //Console.WriteLine("keyChar1" + keyChar1);




        //문제 : 간단한 메뉴 선택
        // Q.사용자에게 간단만 메뉴를 보여주고, Console.ReadKey()를 이용하여 메뉴를 선택하게 한 후 해당 동작을 수행
        /* 메뉴 :
         * 1.프로그램 시작
         * 2.설정 변경
         * 3.프로그램 종료
         * 사용자가 숫자 키 (1,2,3)를 누르면 각 동작에 맞는 메시지를 출력
         * 
         */

        switch (ketInfo.KeyChar)
        {
            case '1':
                Console.WriteLine("1.프로그램 시작");
                break;
            case '2':
                Console.WriteLine("2.설정 변경");
                break;
            case '3':
                Console.WriteLine("3.프로그램 종료");
                break;
            default:
                Console.WriteLine("잘못된 입력");
                break;

        }

    }
}
    