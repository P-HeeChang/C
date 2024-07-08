using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//delegate 대리자
//대리자는 매개변수 목록 및 반환 형식이 있는 메서드를 참조해서 나타내는 형식이다.
//함수 기능을 대신 호출하는 개념으로 사용된다.

//대리자는 delegate 키워드를 사용해서 만들 수 있다.
//대리자는 함수 자체를 하나의 데이터로 보고 다른 메서드를 실행하는 기능이다.
//한 번에 메서드 하나 이상을 대신해서 호출할 수 있다. 이상?

//메서드의 매개변수로 대리자 변수(개체)를 넘길 수 있다.
//대리자를 사용하여 함수의 매개변수로 함수 자체를 전달할 수 있다.
//대리자는 동일한 메서드 시그니처를 갖는 메서드 참조를 담는 그릇 역할
//대리자를 사용하면 함수를 모아 놓았다가 나중에 실행하거나 실행을 취소할 수 있다.

//예시

//SayDelegate say = Hi; //함수를 데이터로 보고 say 라는 식별자의 대리자 개체에 hi 지정
//say(); //hi 라는 함수의 호출을 대리자 say 를 통해 호출 가능, 대리자를 통한 함수 호출
//위 코드처럼 이미 있는 함수(hi)를 대신 호출하는 개념이 대리자의 목적이다. 
//대리자 변수(==식별자) = new 대리자(메서드이름);----1개등록
//대리자 변수(==식별자) += new 대리자(메서드이름); 형태로 사용 가능------누적(여러개)등록


//이벤트
//이벤트는 특정 상황이 발생할 때 객체 또는 클래스에서 알림을 제공할 수 있도록 하는 멤버로,
//버튼 클릭, 마우스 오버 등 같은  이벤트 기반 프로그래밍에 사용되는 개념
//콘솔앱은 마우스클릭X
//데스크톱 앱 / 웹 / 윈도우 앱 에서 자주 사용한다.
//evnet 키워드를 사용한다.

//사건 사고 등 의미 : 프로그래밍에서는 함수 실행 되는 결과를 의미
//이벤트 : 클릭과 마우스오버 같은 동작 자체
//이벤트 처리기 : 특정 이벤트를 담당하기 위해 만든 메서드


//이벤트와 대리자를 사용해서 메서드 등록 및 호출하기
//대리자는 이벤트를 위한 중간 단계이다.
//이벤트는 메서드 여러 개를 등록한 후 실행시키는 역할
//운영체제 레벨에서 마우스 및 키보드 등 장치와 연동할 때 이벤트를 사용한다.




//클래스 - 부분 클래스 partial class 분할 클래스
//클래스의 기능이 많아 클래스 규모가 커지면 클래스를 나눌 수 있음.
//분할 클래스 방식으로 역할 분담 가능
//컴파일시 하나의 클래스로 처리됨  -- 조립?
//분할클래스들을 클래스명이 동일해야함.








namespace _240214
{
    /*
    class ConstructorParameter 
    {
        static void Main() 
        {
        
        }
    }
    */

    /*
    public class ButtonClass//이벤트생성방법--커스텀가능
    {
        public delegate void EventHandler();//이벤트핸들러라는 대리자 생성
        public event EventHandler Click;//클릭이라는 이름의 이벤트 생성, event 키워드와 대리자 형식을 함께 사용

        public void OnClick() //Click 이벤트에 등록된 메서드(함수)가 있다면 이벤트가 호출되는 함수
        {
            if (Click != null) // 이벤트에 함수가 등록되어있는지 검사 
            {
                Click();
            }
        }
    }
    class ConstructorParameter
    {

        static void Main()
        {
            ButtonClass btn = new ButtonClass();//위 buttonclass의 인스턴스 생성
            btn.Click += Hi1;// btn 인스턴스의 click 이벤트에 함수 등록
            btn.Click += Hi2;
            btn.OnClick();//btn 인스턴스의 OnClick함수 호출

        }
        static void Hi1() => Console.WriteLine("hi1호출");
        static void Hi2() => Console.WriteLine("hi2호출");
    }
    */
    /*


    class ConstructorParameter
    { 
        delegate void SayPointer();  //delegate 키워드를 사용해서 void SayPointer() 로 매개변수
        //및 반환 값이 없는 메서드를 대신 호출하는 대리자를 생성한 코드

        static void Hello() => Console.WriteLine("dele");
        //대리자에 담아 대신 호출할 hello 메서드 선언

        static void Main()
        {
            SayPointer saypointer = new SayPointer(Hello);  //호출(hello())이 아니라 이름(hello)만
            // saypointer 라는 식별자를 가진 SayPointer 인스턴스를 만들고 생성자 대신
            // 실행할 메서드 이름을 지정하는 방식으로 대리자 객체 생성
            //

            saypointer();        // 대리자 변수에 괄호를 붙여 호출 - 호출방식1
            saypointer.Invoke(); // 대리자에 invoke 함수를 통한 호출 - 호출방식2 - 명시적 호출
        }
    }
    */
    /*
    class ConstructorParameter
    {
        delegate void SayDelegate();

        static void Main()
        {
            SayDelegate say = delegate () //익명메서드 혹은 무명메서드 방식으로 delegate 지정
            {
                Console.WriteLine("delegate");
            };


            say(); // 호출

        }

    }
    */
    /*예제
    public class CarDriver 
    {
        public static void GoForward() => Console.WriteLine("앞");
        public static void GoBackward() => Console.WriteLine("뒤");
        public static void GoLeft() => Console.WriteLine("좌");
        public static void GoRight() => Console.WriteLine("우");

    }
    public class Insa 
    {
        public void Bye() => Console.WriteLine("잘가");
    }
    public delegate void GoHome();
    class ConstructorParameter
    {
        public delegate void Say();

        private static void Hello() { Console.WriteLine("Hello"); }
        private static void Hi() { Console.WriteLine("Hi"); }

        static void Main()
        {
            CarDriver.GoForward();
            CarDriver.GoBackward();
            CarDriver.GoLeft();
            CarDriver.GoRight();
            GoHome go = new GoHome(CarDriver.GoLeft); //클래스밖에있는 대리자
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoRight);//+=을통해 함수를 추가등록가능
            go -= new GoHome(CarDriver.GoRight);
            go -= new GoHome(CarDriver.GoRight);
            go -= new GoHome(CarDriver.GoRight);
            go -= new GoHome(CarDriver.GoRight);
            go -= new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoLeft);
            go();//호출하면 한번에 출력

            Say say;
            say = new Say(Hi);
            say += new Say(Hello);
            say();

            Insa insa = new Insa();
            Say say2 = new Say(insa.Bye);
            say2 += new Say(insa.Bye);
            say2();
        }
    } 
    */
    /*
    public class Print 
    {
        public static void Show(string message) { Console.WriteLine(message); }
    }
    class ConstructorParameter
    {
        public delegate void PrintDelegate(string message);
        public delegate void SumDelegate(int a, int b);
        public delegate void Lambda();
        public delegate int Lambda2(int i);
        static void Main()
        {
            Print.Show("매개변수텍스트");
            PrintDelegate pd = new PrintDelegate(Print.Show);
            pd("pd매개변수텍스트");

            PrintDelegate am = delegate (string message)
            {
                Console.WriteLine(message);
            };
            am("am익명함수 매개변수텍스트");

            SumDelegate sum = delegate (int a, int b) { Console.WriteLine(a+b); };
            sum(10,30);

            Lambda hi = () => Console.WriteLine("Lambda람다 호출"); // 람다 형식으로 함수 선언  -- 매개변수없을때()
            hi();

            Lambda2 square = x => x * x;   // 매개변수(x)와 반환(x*x)이 있는 람다식  ---- 매개변수있을때는 매개변수 지정 예시
            Console.WriteLine(square(3));

        }
    }
    */
    /*
    class ConstructorParameter
        {
            public delegate void Runner();

            static void Main() 
            {
                RunnerCall(new Runner(Go));
                RunnerCall(new Runner(Back));
            }
            static void RunnerCall(Runner runner) => runner(); //대리자를 매개변수로 전달

            static void Go() => Console.WriteLine("앞");

            static void Back() => Console.WriteLine("뒤");
        }
      */
}