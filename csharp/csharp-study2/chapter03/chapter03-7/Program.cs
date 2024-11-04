namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        //제어문(Control Statement)
        //0. 관계 및 논리연산자
        //-관계연산자 : >(크다),>=(크거나 같다),<=(작거나 같다),<(작다),==(같다),!=(다르다)
        bool result = 10 > 20; // bool 참 , 거짓
        Console.WriteLine(result);     //False
        bool result2 = 10 < 20;
        Console.WriteLine(result2);    //Ture
        bool rev1 = 1000 > 20000;
        Console.WriteLine(rev1);
        bool rev2 = 1000 < 20000;
        Console.WriteLine(rev2);

        int value1 = 6;
        int n1 = value1 % 3;
        bool result3 = (n1 == 0);
        Console.WriteLine(result3);    //True

        //-논리연산자 : &&(AND), ||(OR), !(NOT)
        // AND(%%) : A AND B , AND연산자는 A와 B의 논리값이 하나라도 FALSE이면 결과는 FALSE
        // OR(||)  : A OR  B , OR연산자는 A와 B의 논리값이 하나라도 TRUE이면 결과는 TRUE
        int value2 = 10;
        int n3 = value2 % 3;  // 1
        int n4 = value2 % 5;  // 0
        bool orResult1 = (n3 == 0||n4==0);        // false || true -> True  
        Console.WriteLine("value는 3의 배수이거나 5의 배수이면" + orResult1);
        bool andResult1 = (n3 == 0 && n4 == 0);   // false && true -> false
        Console.WriteLine("value는 3의 배수이고 5의 배수이면" + andResult1);  
        bool notResult1 =!(n3 == 0);              // !false -> True
        Console.WriteLine("value는 3의 배수가 아님" + notResult1);            

        int n11 = 6;
        int n12 = 10;
        bool result11 = (n11 % 3 == 0 || n12 % 3 == 0); // 6은 3의 배수이거나 10의 3의 배수이면 true
        Console.WriteLine("n11 또는 n12 3의 배수" + result11);  // true
        bool result12 = (n11 % 3 == 0 && n12 % 3 == 0);
        Console.WriteLine("n11 이고 n12 3의 배수" + result12);  // false

        //문제1. 다음 조건을 만족하는 논리 연산을 사용하여맞으면 'true'출력 틀리면 'false'
        // 조건 : 변수 age가 70 이상이고 hasLicense가 true일 경우 'true' 틀리면 'false'
        int age = 40;
        bool hasLicense = true;
        bool res1 = (age >= 70);
        bool res11 = (res1 && hasLicense);
        Console.WriteLine(res11);

        //문제2. 아래 변수 isWeekend와 isHoliday 중 하나라도 true일 경우 true를 출력 아니면 false출력
        bool isWeekend = false;
        bool isHoliday = true;
        bool res22 = (isWeekend || isHoliday);
        Console.WriteLine(res22);

        //문제3. 아래 변수를 사용하여 조건을 만족할 때 true 아니면 false
        //temperature 20이상 30이하
        //isRainy는 false
        int temperature = 25;
        bool isRainy = false;
        bool res33 = (30 >= temperature && 20 <= temperature);
        Console.WriteLine(res33 && isRainy);

    }
}