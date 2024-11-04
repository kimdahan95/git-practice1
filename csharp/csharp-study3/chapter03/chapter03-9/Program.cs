using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1;

    class Program
{
    static void Main(string[] args)
    {
        //문제 : AND, OR 혼합 조건
        //Q.다음 조건을 모두 만족할 경우 " 모든 조건 충족"을 출력 아닐 경우 "조건 불충족"
        // age 18이상 60이하
        // isHealthy가 true이거나 haslnsurance가 true
        short age = 35;
        bool isHealthy = false;
        bool haslnsurance = true;
        string result;
        if((18<= age && 60>=age) && isHealthy && haslnsurance)
        {
            result = "모든 조건 충족";
        }
        else
        {
            result = "조건 불충족";
        }
        Console.WriteLine(result);

        //문제2 : 논리연산자를 사용한 비밀번호 확인
        //Q. 사용자가 입력한 password와 confirmPassword가 모두 일치하고
        //길이가 8이상일때 "비밀번호 설정 완료"를 출력하시오.
        // cf) 길이는 Length값을 이용   ex) password.Length
        string password = "secure123";
        string confirmPassword = "secure123";
        int length = password.Length;
        bool result2 = (password == confirmPassword);
        string res;
        if (result2 && 8<=length)
        {
            res = "비밀번호 설정 완료";
        }
        else
        {
            res = "비밀번호 설정 불가";
        }
        Console.WriteLine(res);

        //문제3. Null 체크와 단축 평가
        //Q.변수 userName이 null이 아니고, 길이가 5이상일 경우 "유효한 사용자 이름"을 출력하시오.
        string userName = null;
        if (userName != null && 5 <= userName.Length)
            Console.WriteLine("유효한 사용자 이름");
        else
        {
            Console.WriteLine("유효하지않음");
        }


        //문제4. 배열 길이와 단축 평가
        //Q.배열 numbers가 null이 아니고, 길이가 3 이상일 경우 배열의 세번째 요소를 출력하시오.
        int[] numbers = { 1, 2, 3, 4, 5 };
        if (numbers != null && numbers.Length >= 3)
            Console.WriteLine(numbers[2]);
    }
}