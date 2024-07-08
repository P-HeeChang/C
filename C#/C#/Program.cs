using System; //네임스페이스 선언부--import를 한거다.//using System; using static System.Console;
using static System.Math;
namespace HellowWorld//네임스페이스 지정
{

    class Program//클래스명 지정
    {
        static void Main()//함수선언
        {





            /*
            Console.WriteLine("Hello world");
            //실행문
            //소스코드의 컴파일
            //c#파일은 program.cs처럼 확장자가 cs임
            //컴파일 과정을 거치면 실행가능한 exe파일이 생성
            //윈도우가 아닌 환경이면 dll을 생성
            //C#은 컴파일 방식(빌드)이다.---컨트롤 쉬프트 B
            //1. 소스코드작성 2. 빌드 3. 프로그램실행---파이썬과 다르게 중간에 문제가있으면 실행자체가 안된다.
            //네임스페이스-클래스-함수
            //System.Console.WriteLine("Hello world");
            //네임스페이스.클래스.메서드()--모든사용을 이런식으로.
            //Main() 메서드의 의미:
            //C# 기본 구조에서 반드시 사용되는 Main() 메서드는
            //프로그램의 시작점을 의미
            //반드시 Main() 메서드가 있어야 함
            //Main() 메서드에서 프로그램을 시작하고 종료한다.
            //Main() 메서드가 2개면 프로그램 진입점이 2개라는 의미
            //따라서 오류발생
            //Main() 대소문자 구분
            //System 도 대문자로 시작
            //실행 단축키 : 컨트롤+F5
            //대부분의 기능이 파이썬과동일
            Console.WriteLine("자동줄\n\t\'\"바꿈");//자동 줄 바꿈
            Console.Write("줄바꿈X");//줄바꿈 X
            //이스케이프 코드 or 이스케이프 시퀀스
            //\n \t \' \"

            //문자포메팅
            Console.WriteLine("{0}", "Hello");
            Console.WriteLine("{1},{0}", "Hello","Hello2");//써있는 순서대로 들어간다.
            //변수 

            //C#에서 자주 사용하는 데이터 형식
            //int : 정수형 데이터 타입
            //long : 큰 정수형 데이터
            //string : 문자열
            //bool : 불타입
            //double : 실수형 데이터
            //object : C#애서 사용하는 모든데이터 형식을 담을수 있다.--사용자가 만든 클래스도 담을수있다.


            //식별자 규칙
            //첫 글자는 문자,숫자x , 길이는 255이하, 공백포함 불가, 키워드 사용불가,대소문자구분
            int number;
            number = 0;
            Console.WriteLine(number);

            //리터럴 사용
            //변수에는 직접 정수형 또는 문자열 값 저장 가능
            //리터럴이란 : 값 자체를 의미
            //널 리터럴 : null 리터럴 : 값을 가지지 않는 리터럴
            Console.WriteLine(1234);//정수 리터럴
            Console.WriteLine(3.14F);//실수 리터럴
            Console.WriteLine("A");//문자 리터럴--단일은 상관X
            Console.WriteLine("hellooooooooooo");//문자열 리터럴---문자열을 무조건 큰따옴표/오류발생함

            int num2 = (int)3.14;
            Console.WriteLine(num2);  //변수를 선언하고 바로초기화


            //형식이 같은 변수 여러개 동시 선언
            //데이터 형식 변수1, 변수2, 변수3


            int num_1, num_2, num_3;
            //num_1 = 100;
            //num_2 = 200;
            //num_3 = 300;
            //Console.WriteLine("{0}{1}{2}", num_1, num_2, num_3);
            //num_1=num_2=num_3=100; 오른쪽에서 부터
            //MyNum : 파스칼 표기
            //myNum : 캐멀
            //my_num : 스네이크  취향차이
            //변수 < - > 상수
            //변수 : 변할수있는
            //상수 : 고정값
            //constant : const 키워드 사용
            const int a = 200;
            Console.WriteLine(a);
            //a=300; //a는 정수형 상수로 선언되어 있어서 값을 바꿀수 없음.
            const int MAX = 200;
            Console.WriteLine(MAX);//이런식으로 상수는 대문자로 입력해주면 좋다.?


            //숫자
            //정수 _ 실수
            //부호가 있는 정수S _ 부호가 없는 정수U
            //부호가 있는: signed : +-부호가 있는 정수형=> 음수 양수 표현 가능
            //부호가 없는: unsigned : 부호없이 +만 다루는 정수형 데이터 타입
            //int 형식 = System,Int32 와 같다
            //변수 선언시 int 대신 System.Int32 로 선언 가능
            //using System을 해놓은 상태라면, System 생략하고 Int32로 선언가능
            //닷넷 형식 : System32.Int32
            //데이터형식 : int

            //부호가 있는 정수(+ , -) ---- -음수는  0을 포함하지 않아 범위가 1넓다
            //C# 표현 : 닷넷방식
            //1.sbyte : System.SByte 1bit-8
            //2.short : System.Int16 2bit-16
            //3.int : System.Int32   3bit-32
            //4.long : System.Int64  4bit-64


            //부호가 없는 정수(+)
            //C# 표현 : 닷넷방식
            //1.byte : System.Byte       1bit-8
            //2.ushort : System.UInt16   2bit-16
            //3.nint : System.UInt32     3bit-32
            //4.ulong : System.UInt64    4bit-64

            int min = -2147483648;
            int max = +2147483647;
            Console.WriteLine(min);
            Console.WriteLine(max);


            Console.WriteLine("32비트 int 최소 : {0}", int.MinValue);
            Console.WriteLine("32비트 int 최소 : {0}", int.MaxValue);
            Console.WriteLine("64비트 long 최소 : {0}", long.MinValue);
            Console.WriteLine("64비트 long 최소 : {0}", long.MaxValue);
            Console.WriteLine("64비트 ulong 최소 : {0}", ulong.MinValue);
            Console.WriteLine("64비트 ulong 최소 : {0}", ulong.MaxValue);


            float f = 3.14F;
            double d = 3.14D;
            decimal m = 3.14M;
            Console.WriteLine("{0},{1},{2}", f, d, m);
            string msg = "heloooooooooo";
            Console.WriteLine($"{msg}");

            //240116-오늘 총평 C#은 유교 언어임. 하나부터 열까지 다 틀이정해져있음.



            //문자데이터 형식 char
            //숫자 외에 데이터 형식 (bool, char , string 등)
            //C#에에서는 문자와 문자열을 구분
            //문자는 char 로 데이터 타입 정의
            //문자는 2바이트 공간에 문자 하나를 저장한다.
            //문자 데이터 선언에 작은 따옴표 사용
            //char c='c' 형태
            char c = 'c';
            Console.WriteLine(c);
            //2바이트 는 16비트 저장 공간을 의미
            //char 키워드로 선언되는 변수는 단일 유니코드 문자 저장
            //영문 및 한글 등 모든 언어 문자 표현 가능
            //단일 캐릭터 char 데이터 타입에는 문자 여러개 저장 불가
            //닷넷 형식으로는 System.Char 로 표현한다.
            System.Char cc = 'a';
            Console.WriteLine(cc);
            char kor = '가';
            char grade = 'A';
            Console.WriteLine(kor);
            Console.WriteLine(grade);
            //char 타입 변수에 문자를 하나 이상 지정할 경우
            //문자 리터럴에 문자가 너무 많다는 오류 발생.



            //문자열 데이터 형식 string
            //문자열을 반드시 "" 로 묶음
            //닷넷 형식으로는 System.String
            string name = "iot";
            System.String name2 = "iot";
            Console.WriteLine(name2);
            Console.WriteLine(name);
            //문자열 보간법---포매팅 방식 종류 
            Console.WriteLine($"{name2}");
            //String.Format() 함수 사용
            string msg1 = string.Format("{0}{1}", "아", "어");
            string msg2 = "String";
            Console.WriteLine("Message: {0}", msg2);
            Console.WriteLine("Message: "+msg2);//더하기연산
            Console.WriteLine($"Message: {msg2}");//보간법


            //bool
            //true false

            bool bin = true;
            bool bin2 = false;
            Console.WriteLine(bin);
            Console.WriteLine(bin2);


            Char ccc = 'A';
            Console.WriteLine(ccc);

            Console.ReadLine();//입력대기 input 과 동일
            Console.WriteLine(Console.ReadLine());
            //print(input()) 과 동일

            Console.Write("이름을 입력하세요");
            string namex = Console.ReadLine();
            Console.WriteLine("{0}을 입력함.",namex);

            //Console.Read() 메서드를 사용하면 콘솔에서
            //문자를 하나만 입력 받을 수 있다.
            //입력값은 문자에 해당하는 정수로 반환된다.
            //Convert.ToChar() 메서드를 사용해서 반환
            int aaa = Console.Read();
            Console.WriteLine(aaa);
            Console.WriteLine(Convert.ToChar(aaa));
            //A->65->A
            ------------------------------------------------------------------------------------------------------까지 적음.
            //형식 변환
            //Console.ReadLine() 메서드를 통해 콘솔에서 입력받은
            //데이터는 문자열
            //ReadLine()으로 입력받은 문자열을 형 변환

            //1.명시적 형변환

            //2.암시적 형변환

            //암시적 형 변환은 변환 형식이 안전하게 유지되고 데이터가
            //손실되지 않는다.

            int x1 = 123;
            long x2 = x1;
            //암시적 형변환 예---- //작은거를 큰거에 넣어도 바로 사용가능.

            long x3 = 123;
            int x4 =(int)x3;
            //명시적 형변환 ---- //큰거에서 작은거로 갈때는 큰데이터를 작은int 변환해줘야함.
            //형변환: 캐스팅
            //이 경우에서 (int)하지 않으면 데이터 손실 발생, 오류

            //Convert 클래스의 주요 메서드
            //1.ToString() : 숫자 데이터 형식을 문자열로
            //2.ToInt32() : 정수 형식으로
            //3.ToDouble() : 실수 형식으로
            //4.ToChar() : 문자 형식으로
            //ex)_ Convert.ToString()----숫자를 문자열로 형변환 하겠다.

            //int.Parse() 형변환

            string strnum = "1234";
            int y = int.Parse(strnum);
            Console.WriteLine(y);


            //GetType() 메서드
            int i = 1234;
            string ii = "안녕";
            char iii = 'c';
            double iiii = 3.14;
            Console.WriteLine(i.GetType());
            Console.WriteLine(ii.GetType());
            Console.WriteLine(iii.GetType());
            Console.WriteLine(iiii.GetType());
            //파이썬 type() 메서드 와 비슷하게 활용 -- 해당 데이터 타입 확인할때 사용
            //데이터 타입 확인 메서드


            //이진수 다루기
            Console.WriteLine(Convert.ToString(10, 2));
            //10진수 10을 2진수로 변환
            //이진수 표현 1010 ---앞자리에 있는 0은 생략
            Console.WriteLine(Convert.ToString(10, 2).PadLeft(8, '0'));//-----PadLeft=replace?
            //8칸 기준으로 이진수 문자열 출력 , 앞부분을 0으로 채움


            //바이트 선언
            byte b1 = 0b0010;
            Console.WriteLine(b1);// 출력하면 십진수 2 출력
            //소스코드에서는 기본적으로 십진수 단위로 자료가 처리된다.


            int bIn = 0b0001_0001;//자리수를 _ 사용하여 끊을수있음.
            Console.WriteLine(bIn);// 17 출력
            int dec = 1_000_000;
            Console.WriteLine(dec);
            int hex = 0xa0_B0_C0;//자리씩_
            Console.WriteLine(hex);

            //var 키워드로 암시적 형식의 변수 생성
            var num100 = 100; // 자동으로 파일형식을 지정해주는 키워드--자주사용할듯
            Console.WriteLine(num100);
            var strrrr = "안녕하세요";
            Console.WriteLine(strrrr);
            Console.WriteLine(num100.GetType());
            //Syetem.Int32 닷넷 형태의 데이터로 반환?

            //Readkey() 메서드
            //키보드에서 입력한 키를 알아내는 메서드 --
            Console.WriteLine("키보드입력");  //키보드로 입력 받고 데이터꺼내올때사용
            ConsoleKeyInfo cki = Console.ReadKey(true);
            Console.WriteLine(cki.Key);
            Console.WriteLine(cki.KeyChar);
            Console.WriteLine(cki.Modifiers);
            if (cki.Key == ConsoleKey.Q) ;
            {
                Console.WriteLine("Q를 눌렀다.");
            }

            //변수의 기본값을 default 키워드로 수정
            //변수를 선언 및 초기화할 때, 해당 변수의 데이터 형식으로
            //초기화를 한다.
            //초기화할  때 defult 키워드로 초기화 가능

            int xxx = default; // x; 아직 넣을값이 정해지지않았을때 사용
            bool bd = default;
            Console.WriteLine(xxx);
            Console.WriteLine(bd);


            //연산자
            // + - * / % 더하기 빼기 곱하기 나누기 나머지
            // 대입 산술 관계 비교 논리 증감 비트 시프트
            // 1개의 항을 연산하는 단항 연산자 ! not
            // 2개의 항을 연산하는 이항 연산자
            // 3개의 항을 연산하는 삼항 연산자

            //연산자와 피연산자

            int num1 = 1000;
            int number = num1 + 1233;//이항연산자 


            // 단항연산자 +
            int num2 = -8;
            num2 = +num2;//강제로 +8로 바뀜

            //(int) 변환 연산자


            //할당 연산자
            // = : 대입할당
            // += : a+=10 : a= a+10
            // -=   "
            // *=   "
            // /=   "
            // %=   "

            //증감연산자
            // ++ : 변수 값에 1더함
            // -- : 변수 값에 1뺌
            int m = 10;
            Console.WriteLine(m);
            m++;//1씩증가를 한다.
            Console.WriteLine(m);
            m--;//1씩 뺀다
            Console.WriteLine(m);


            Console.WriteLine(m++);
            Console.WriteLine(m);
            Console.WriteLine(m);

            //선 연산 후 대입 ++a 11 
            //선 대입 후 연산 a++ 10
            //전위 증감 연산  ++a 11
            //후위 증감 연산  a++ 10



            //관계 연산자 : 비교 연산자
            // <> <= >= == !=

            //논리 연산자
            //and or not
            //&& ||(쉬프트\) ! 
            //양쪽이 true 일때 true : and
            //양쪽 중 하나가 true 면 true : or
            //반대로 뒤집기 : not

            Console.WriteLine(true && true);
            Console.WriteLine(true || true);

            var i = 3;
            var j = 5;
            var r = false;
            r = (i == 3) && (j != 3);
            Console.WriteLine(r);//true
            r = (i != 3) || (j == 3);
            Console.WriteLine(r);//false


            //조건 연산자
            //조건 연산자는 조건에 따라 참일 때와 거짓일 때 결과를
            //다른게 반환한다.
            // ?: 형태로 사용 ----- ?앞에 식 true 일때 실행:false 일때 실행
            Console.WriteLine((5>3) ? "맞다" : "아니다");// if 문을 짧게 사용하는것


            //sizeof() 
            //sizeof(int) // 4 len?


            //if
            //if(조건식)
            //{
            //         실행문
            //     if(조건식) ---중첩할때
            //     {
            //          실행문
            //     }
            //}


            //if/ elif /else
            //if/ else if /else

            int aaa = 100;
            if (aaa > 100)
            {
                Console.WriteLine(aaa);
            }
            else if (aaa == 100)
            {
                Console.WriteLine(aaa);
            }
            else
            {
                Console.WriteLine(aaa);
            }


            // 사용자에게 문자를 입력받아서
            // 해당 문자에 대한 ascii 상  해당 문자의 숫자가
            // 10진수 숫자가
            // 100 보다 큰 문자라면 100보다 크다 라고 출력
            // 그렇지 않으면 입력 문자에 해당하는 숫자와 문자 출력
            // var 키워드 사용 금지--byte-short-int-long 등


            int user = Console.Read();//console.read = 정수로 반환

            if (user > 100)
            {
                Console.WriteLine("100 보다 큼");

            }
            else 
            {
                Console.WriteLine("{0},{1}",user,Convert.ToChar(user));
            }

            //switch 문
            //조건문
            // 실행문 다음에 항상 break 를 해줘야한다. 왜냐하면 다음케이스까지 출력?


            //switch (식)
            //{
            //  case 값1:
            //      실행문1
            //      break;

            //  case 값2:
            //      실행문2
            //      break;

            //  case 값3:
            //      실행문3
            //      break;
            //}

            int user1 = Console.Read();
            switch (user1)
            {
                case 65:
                    Console.WriteLine("A를 입력한것");
                    break;
                case 66:
                    Console.WriteLine("B를 입력한것");
                    break;
                case 67:
                    Console.WriteLine("C를 입력한것");
                    break;
                case 68:
                    Console.WriteLine("D를 입력한것");
                    break;
                default:
                    Console.WriteLine("해당X");
                    break;

            }

            //for 문
            //for(int i = 0; i<10;i++)
            //{
            //  실행문
            //}
            //i가 0부터 i가 10보다 작은 동안 매 바퀴 i 가 1씩 증가하면서 돈다.
            for (int k = 0; k < 10; k++)//for i in range(10) 과 같다 k*=1로쓰면 무한으로반복 거꾸로할때는 시작을 10 조건을 k>0 k--
            {
                Console.WriteLine(k);
            }

            //무한 루프
            //for(;;)
           

            //구구단
      
            for (int g = 1; g <=9; g++) //1. 첫번째 포문(1~9까지)이 1번 돌때 2번째 포문(1~9까지곱)은 9번 인데 2번째 포문이 돌때마다 곱하기 가로로 출력 어떻게?
            {
                for (int d = 2; d <=9; d++)
                {
                    Console.Write($"{d}*{g}={d*g, 2} ");
                }
                Console.WriteLine();
            }







            //while문
            //while(조건식)
            //{
            //      실행문;
            //}
            int count = 0;
            while (count < 3)//파이썬과 동일하게 참이 될때만 반복하니 조건을 걸어 횟수제한
            {
                Console.WriteLine("while 내부");
                count++;
            }

            //do while 문
            //do
            //{
            //  실행문;
            //}while(조건식);
            count = 0;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count != 0);

            //do while 문은 첫반복은 무조건 실행한다. 
            //조적식이 while이 뒤에 있기때문에 


            //foreach
            //배열이나 컬렉션 같은 요소를 여러개 담은 데이터 구조에
            //각 데이터가 들어있는 만큼 반복
            //파이썬의 for 문과 동일
            //foreach (항목 in 항목들)
            //{ 
            //  실행문
            //}


            //string[] 이름 ={} 문자열을 담는 배열 int[] 숫자를 담는 배열
            string[] names = { "C#", "python"};
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //break
            //countinue
            //동일



            //배열이란
            //동일한 데이터 형식을 갖는 데이터의 집합체
            //배열을 사용해서 여러 데이터를 모아서 관리 가능


            //컬렉션
            //colloection
            //c#에서 컬렉션은 배열,리스트,딕셔너리가 있다.

            //new 키워드는 객체를 새로 생성할 때 쓰는 키워드


            //1.배열
            var array = new string[] {"AAA","BBB","CCC" };
            foreach (string name in array)
            {
                Console.WriteLine(name);
            }


            //2.리스트
            var list = new List<string> {"L1","L2","L3" };
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }


            //3.딕셔너리
            var diction = new Dictionary<int, string> { { 0, "000" }, { 1, "111" }, { 2, "222" } };
            foreach (var name in diction)
            {
                Console.WriteLine(name.Key);
                Console.WriteLine(name.Value);
            }

           



            //배열        *은 리스트와 다른부분
            //순서가 있는 집합? 인덱스사용가능
            //각 요소는 인덱스로 접근
            //인덱스는 0부터
            //*배열은 데이터형식이 동일한 요소들을 포함
            //*배열 new 키워드로 생성가능
            //배열에서 값 하나는 요소element 혹은 항목item
            //반복문 foreach 와 조합
            //*필요한 요소의 수를 정해서 메모리를 적게 사용 가능


            string str1 = "c#9.0";
            Console.WriteLine(str1[0]);
            Console.WriteLine(str1[1]);
            Console.WriteLine(str1[2]);
            Console.WriteLine("ABC"[0]);

            //배열은 데이터 형식 이름 뒤에 [] 기호 를  사용해서 선언
            //타입[]변수명;
            
            //배열 선언 후 new 연산자(키워드)를 사용하여 배열의크기
            //만큼 메모리 영역을 잡을 수 있다.
          
            int[] numarr;
            numarr = new int[3];//위에 선언한 numarr 변수에 3칸짜리
            //정수 배열을 선언

            int[] arr2 = new int[5];

            //데이터형식[] 변수명 = new 데이터타입[칸]; 빌라 생성후 이름지어주기
            //칸수 이해못함 찾아볼것
            //1차원 배열
            int[] intnum = new int[10];
            
            foreach (int num in intnum)
            {
                intnum[int]
            }
            

            //배열의 요소: 첨자 하나를 가지는 배열
            //메모리 상 10개 공간이 잡힌다.
            //0부터 ~ 9까지 연속적으로 메모리 공간 잡힌다. ???? 
            /*
            intnum[0] = 100; //파이썬에서 딕셔너리 키:밸류 넣는거랑 비슷


            int idx = 1;
            int[] xxxxx = { 1, 2, 3 };//new 키워드 없이 배열 선언 및 초기화
            Console.WriteLine(xxxxx[idx]);
            Console.WriteLine(xxxxx[--idx]);
            

            //문제.1
            //5칸의 정수 배열을 new 로 생성하고
            //각 요소에 1~100 사이 임의 숫자 할당   ??
            //인덱스를 활용해서 배열에 저장되어있는
            //합과 평균을 소수점 2자리까지 출력
            /*
            int[] intnum1 = new int[5];
            intnum1[0] = 12;
            intnum1[1] = 25;
            intnum1[2] = 33;
            intnum1[3] = 47;
            intnum1[4] = 56;
           
            


            Console.WriteLine(intnum1[0]+ intnum1[1]+ intnum1[2]+ intnum1[3]+intnum1[4]); //합
        
            Console.WriteLine($"{((intnum1[0] + intnum1[1]+ intnum1[2]+ intnum1[3]+ intnum1[4])/5):0.00}"); //평균
            
            // 또 문제 어렵게 생각함 고쳐야함







            //문제.2
            //5칸 짜리 1차원 정수 배열을 선언하고
            //사용자에게 5번의 입력을 받아??? 
            //위 배열에 값을 할당한다.
            //배열에 저장된 값들의 총 합을 출력한다.

            int[] numarry = new int[5];
            int num_1 = Console.Read();


            //---------------------------하나도이해못함


            /*답. ----- 입력받을떄 원치않는 엔터가 주르륵들어가서 한번에 5번들어감
            char[] chararr = new char[5];
            for (int b = 0;b < chararr.Length;b++)
            {
                Console.WriteLine("입력");
                int inputValue = Console.Read();
                Console.ReadLine();// 엔터 들어가는걸 막아주는 라인
                chararr[b] = (char)inputValue;
               
            }
            Console.WriteLine("입력값");
            foreach (char c in chararr)
            {
                Console.WriteLine(c);
            }
        

            //xxxxx[0]=조회시
            //xxxxx[0]=대체할값 == 대입값바꿀때


            //다차원 배열 :
            //차원이 여러개
            //2차원 3차원 ~~~
            //데이터 형식[,] 배열이름; //2차원
            //데이터 형식[,,] 배열이름; //3차원
            //arr[0,0]--
            int[] arr1;//1차원
            int[,] arr2;//2차원
            int[,,] arr3;//3차원

            arr1 = new int[2] { 1, 2 };
            arr2 = new int[2, 2] { { 1, 2 }, { 3, 4, } };
            arr3 = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };







            char[,] arrchar = new char[2, 2];
            arrchar[0, 0] = 'A';
            arrchar[0, 1] = 'B';
            arrchar[1, 0] = 'C';
            arrchar[1, 1] = 'D';

            Console.WriteLine($"{arrchar[0, 0]}"); //표데이터 /데이터프레임 /엑셀

            */
















            //문제3-1)_
            //2차원배열 선언 및 초기화 문제
            //2x3짜리 2차원 배열을 선언하고 
            //2차원 배열 내부에 임의의 값을 할당
            //2차원 배열 내부에 배치된 요소 값을 전부 출력하는데
            //행 열 구조의 표 처럼 보이도록 출력??
            //












            /*



            char[,] arr2 = new char[2, 3];
            arr2[0, 0] = '가';
            arr2[0, 1] = '나';
            arr2[0, 2] = '다';
            arr2[1, 0] = '라';
            arr2[1, 1] = '마';
            arr2[1, 2] = '바';


            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(arr2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //i 한번돌때 j3번 출력?하고 끝날때 줄바꿈 i=0 i<2 i++/j=0 j<3 j++ 

            //문제3-2)_
            //Console.Read().ToString();--입력받은 문자 문자열로 바꾸는거

            //string 3차원배열 2x2x2를 선언하고
            //3차원배열에 모든 요소에 값을 할당
            //3차원 3중 for 사용해서 요소모두출력
            */

            /*
            string[,,] DM3 = new string[2, 2, 2];//맨앞이 층
            
            DM3[0, 0, 0] = "QWER\t";
            DM3[0, 0, 1] = "TYUI\t\n";
            //1호 2호?
            DM3[0, 1, 0] = "ASDF\t";
            DM3[0, 1, 1] = "GHJK\t\n";
            //
            DM3[1, 0, 0] = "OP[]\t";
            DM3[1, 0, 1] = "L;'/\t\n";
            //
            DM3[1, 1, 0] = "ZXCV\t";
            DM3[1, 1, 1] = "BNM,\t\n";


            for (int i = 0; i < 2; i++)//
            {
                for (int j = 0; j < 2; j++)//
                {
                    for (int k = 0; k < 2; k++)//
                    {
                        Console.Write(DM3[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }







            */

            /*
            string[,,] DM3 = new string[2, 2, 2];

            for (int i = 0; i < 2; i++)//
            {
                for (int j = 0; j < 2; j++)//
                {
                    for (int k = 0; k < 2; k++)//
                    {
                        Console.Write(DM3[i, j, k] = Convert.ToString(Console.Read()));
                        Console.ReadLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            */























            //가변 배열 :





         //---------------------------------------------------------------------2024/01/17




        }
    }
}
