using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*
namespace _240214 ----- 클래스
{
    
    namespace Y{
        //중첩 되어 있는 네임스페이스 내부 코드
        public class YY 
        {
            public void YYY() => Console.WriteLine("YYY");
        }
    }
    namespace X {
        //중첩 되어 있는 네임스페이스 내부 코드
        public class YY 
        {
            public void YYX() => Console.WriteLine("YYX");
        }
    }
    //System, System.Text 등 using 으로 불러온 것 들이 네임스페이스임.
    //네임스페이스를 만드는 이유는 프로그램 규모가 커질 때 클래스 이름 중복 등 충돌 방지 목적
    //네임스페이스를 다르게 만들면 동일한 클래스를 하나의 프로젝트에서 사용할 수 있다.
    //---> 이름(네임스페이스)만 다르면 같은기능 여러개?(클래스)를 하나의 프로젝트에서 사용가능
    //서로 관련있는 기능 클래스 , 구조체 , 열거형 등을 묶는 개념
    //클래스 이름 중복 방지
    //클래스 계층형 구조 형성
    //네임스페이스는 모듈의 의미와 비슷

    //namespace 네임스페이스명 으로 네임스페이스 구간 작성
    //클래스와 마찬가지로 첫 글자는 대문자로 작성
    //네임스페이스 구간은 중첩될 수 있음.


    //C#에서의 사용자 정의 클래스를 통한 인스턴스 생성시 // public 공용--다른클래스에서 꺼내쓰기위함
    //new 키워드를 사용한다.
    /*
    public class Counter 
    {
        public void GetCount() //GetCount 는 static이 지정되지 않은 인스턴스 멤버 형태임.   인스턴스 멤버(인스턴스로 호출) <=> 클래스 멤버(클래스로 호출)
            //인스턴스 멤버는 인스턴스를 통해 접근 가능을 의미.
        {
            Console.WriteLine("count100");
        }
    }
    class ObjectNote 
    {
        static void Main()
        {
            Counter counter=new Counter(); //인스턴스 생성 부분 new 키워드 사용
            counter.GetCount(); //인스턴스를 통한 GetCount 메서드 호출
            //Counter.GetCount(); //클래스를 통한 접근 불가 : static이 아님.
        }
    }
    public class myMath
    {
        public void sum(int x, int y) 
        {
            int sum = x+ y;
            Console.WriteLine(sum);
        }
    }

class pro 
{
    void Main() 
    {
        //myMath mymath = new myMath;
        var mymath = new myMath; // var 키워드로 식별자 선언하는 방식 : 익명 형식
        //혹은 무명 형식

        mymath.sum(3, 4);
        int[] x =new int[3]; //int로 만들수있지만 var 로도 만들수있다 var[] x= new int[3];

        //정적 멤버와 인스턴스 멤버
        //클래스 내에 선언되는 모든 멤버는 위 2가지 유형 중 하나이다.
        //정적 멤버이거나 인스턴스 멤버이거나
        //선언시 static 키워드를 붙이면 정적 멤버
        //static 이 없으면 인스턴스 멤버
        //static 키워드가 붙은 멤버에 접근시 클래스이름.멤버이름;
        //인스턴스 멤버 접근시 인스턴스명.멤버이름;   -----익숙해지려면 연습필요할거같음

                 //O 정적 클래스 [함수,변수] 
        //static[
                 //X 인스턴스 [함수,변수]--python class에서 self

        //static 이 붙은 변수는 클래스 변수라고 하고
        //static 이 붙지 않은 변수는 인스턴스 변수라고 함.
        //static 은 공유의 의미


    }
}
public class Category 
{
    public void Print(int i) => Console.WriteLine(i);
}
class ClassArray 
{
    static void Main() 
    {
        Category[] category = new Category[3]; //카테고리라는 클래스로 구성된 배열
        category[0] = new Category();//카테고리라는 클래스도 데이터타입 중 하나로 취급
        category[1] = new Category();//해당 배열에는 카테고리클래스의 인스턴스를 넣을 수 있다.
        category[2] = new Category();

        for (int i = 0; i < category.Length; i++) 
        {
            category[i].Print(i);
            Console.WriteLine(category[i].ToString());
        }
    }
}

}
*/

/*예제1 -- 네임스페이스
namespace A 
{
    public class Car
    {
        public void Go() => Console.WriteLine("A네임스페이스의 Car의 Go");
    }    
}

namespace B 
{
    public class Car 
    {
        public void Go() => Console.WriteLine("B네임스페이스의 Car의 Go");
    }
}
class NamespaceNote 
{
    static void Main() 
    {
        A.Car acar = new A.Car();  //네임스페이스 A에 있는 class Car 를 통해 만든 인스턴스
        B.Car bcar = new B.Car();  //B 네임스페이스의 class Car 를 통한 인스턴스 생성
        acar.Go();
        bcar.Go();//네임스페이스가 적용되어 있는 클래스를 사용할때 : 네임스페이스명.클래스 형태로 사용 --  네임스페이스==모듈명? 패키지?
    }
}
*/

/*예제2 --- 전역변수 / 지역변수
using Korea.Seoul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using In = Korea.Incheon;
//위방식은 파이썬에서 import Math as m 이런식으로 별칭 지어주는거(짧게 불러서 쓰기 위함)

namespace Korea
{
    namespace Seoul 
    {
        public class Car
        {
            public void Run() => Console.WriteLine("서울 car run");
        }
    }
    namespace Incheon 
    {
        public class Car
        { 
            public void Run() => Console.WriteLine("인천 car run");
        }
    }

}
namespace NamespaceDescription 
{
    class NamespaceDescription
    {
        static void Main() 
        {
            Korea.Seoul.Car s = new Korea.Seoul.Car();
            s.Run();
            Korea.Incheon.Car i = new Korea.Incheon.Car();
            i.Run();

            Car seoul = new Car();// using Korea.Seoul
            seoul.Run();
            In.Car ic = new In.Car();//using In = Korea.Incheon
            ic.Run();
        }
    }
}
*/

/*
class Scope 
{
    static string globalV = "전역변수"; // 전역 변수 혹은 필드라고 표현
    static void Main() 
    {
        string localV = "지역변수";
        Console.WriteLine(localV);//지역변수 출력
        Console.WriteLine(globalV);//전역변수 출력
        Test();//함수를 통한 전역변수 출력   
        // 같은클래스내에 있는 함수는 바로호출가능 -- Scope.Test 가 아니라 Test로 호출가능
    }
    static void Test() => Console.WriteLine(globalV); // 전역 출력 함수    
}
*/


/*예제3--필드
//필드 : 클래스의 부품 역할 , 클래스의 내부 상태 값 저장 용도의 변수 등
//클래스 내에 선언된 변수 또는 배열 등을 C#에서 필드라고 표현한다.
//필드는 대부분 private 엑세스 한정자를 사용한다.
//클래스 내에서 데이터를 담는 역할
//필드는 개체의 상태를 저장한다.

//필드는 선언 후 초기화하지 않아도 자동으로 초기화된다. ??
//int 형 같은 경우는 0으로 초기화, string 은 String.Empty(공백," ") 로 초기화 bool 타입 은 false 로 초기화 , obj필드 null 값으로 초기화, 실수형식은 0.0
//-----> 모든타입이 bool타입 false 형태로 초기화???


//지역변수와 전역변수
//C#에서 변수 선언시 Main() 메서드 같은 메서드 내에서 선언하거나 메서드 밖에서 선언이 가능하다.
//메서드 내에서 선언된 변수 또는 배열 등을 지역 변수라고 함.
//메서드 밖에서 선언된 변수 또는 배열 : 전역 변수라고함
//C# 에서는 전역 변수라는 용어를 사용하지 않고 메서드와 동일하게 엑세스 한정자를 붙여 필드라고 함.


//지역변수 : 메서드가 종료되면 변수는 자동 소멸
//전역변수(필드) : 메서드 내부가 아닌 클래스 내에 선언된 변수
//C#에서 필드는 변수와 마찬가지로 주로 소문자로 식별자 이름 시작 -- 그냥변수쓰듯이 int x = ~~??


//필드의 종류

//변수 형식의 필드 : 지역 변수와 마찬가지로 값을 대입하여 사용 가능
//상수 형식의 필드 : 필드와 비슷하지만 값을 한번 초기화 하면 다시 값을 바꿀 수 없음.
//읽기전용 필드 : readonly 키워드를 붙이는 읽기 전용 필드도 상수 필드와 비슷한 역할 , 상수와 차이점 : 초기화 시키지 않아도 됨
//배열 형식의 필드 : 배열을 필드레벨로 올린 개념 , 값을 여러개 저장 가능
//개체 필드 : object 외 여러 개체를 담는 필드

//public static int intNum : 정적인 정수 필드
//public string str : 인스턴스 형식의 문자 필드
//public int num : 인스턴스 정수 필드


//private : 현재 클래스내에서 사용 O 외부에서 진입 X 감춤 --- 필드는 대부분 private
//public : 현재 클래스내에서 사용 O 외부에 공개 --- 상황봐서 공개되야하면 public
//protected : 현재 클래스내에서 사용 O 상속 받은 대상만 접근 가능  // 부모자식 구조면 접근가능




class Say 
{
    private string message = "안녕하세요."; //엑세스 접근 한정자?
    public string message2 = "안녕하세요.";
    public void Hi(string a) 
    {
        //string message = "123"; 전역변수보다 지역변수가위에 있으면 지역변수를 우선
        Console.WriteLine(message);
        //this.message = "반갑습니다.";//this 키워드로 자신 클래스(say) 인스턴스인 개체 내부에 선언된 message 필드로 접근
        this.message = a;
        Console.WriteLine(message);
       

    }

}
class Fieldinitializer 
{
    static void Main() 
    {
        Say say = new Say();
        say.Hi("반갑습니다.2");
        //say.message //프라이빗으로 감춰놨기때문에 밖에서는 접근 불가
        say.message2 = "";
    }
}

//퍼블릭(공개) <=> 프라이빗(비공개) //  스태틱O(정적/클래스에서사용) <=>스태틱X(인스턴스에서사용)
class Schedule 
{
    private string[] weekDays = { "월", "화", "수", "목", "금", "토", "일" }; //배열 필드
    public void PrintWeekDays() //밖에서 호출하기위해 public
    {
        foreach(string day in weekDays) 
        {
            Console.WriteLine(day);
        }
        Console.WriteLine();
    }
    public static void XX()
    {
        Console.WriteLine("XXXXXXXX");

    }
    public void XXX() 
    {
        Console.WriteLine("XXXXX");
    }
}
class FieldArray 
{
    static void Main() 
    {
        Schedule schedule = new Schedule();
        schedule.PrintWeekDays();
    }
}
*/

//C# 생성자 함수
//C#에서 생성자는 클래스에서 맨 먼저 호출되는 메서드로, 클래스 기본값 등을 설정한다.
//개체를 생성하면서 하고자하는 코드를 작성하는 부분(초기화 작업)
//생성자는 생성자 메서드라고도 함.
//생성자 함수의 이름은 클래스의 이름과 동일하게 작성한다.
//생성자 함수는 여러개가 선언될 수 있음.
//생성자를 여러개 만드는 경우 : 생성자마다 매개변수를 다르게 설정하여 여러개 만들 수 있음.
//메서드가 오버로드되는 것 처럼 생성자도 오버로드 됨.
//생성자 함수는 void 를 포함한 반환값을 가지지 않는다.
//public 생성자함수명 으로 작성

/*
class Car 
{
    public Car() //생성자?
    {
        Console.WriteLine("생성자함수 호출");
    }
    static void Main()
    {
        var car = new Car(); // 인스턴스가 생성될 때 자동으로 생성자 호출 실행
        Console.WriteLine("11111111");
    }
}


public class Dog 
{
    private string name;
    public Dog(string name) //매개변수가 있는 생성자
    {
        this.name = name;
    }
    public string Cry() 
    {
        return name + "cry";
    }
}
class pro
{
    static void Main()
    {
        Dog dog1 = new Dog("1번강아지");//인스턴스 생성시 매개변수 전달해야 함.
        dog1.Cry();

        Dog dog2 = new Dog("2번강아지");
        dog2.Cry();
    }
}
*/
/*
namespace ConstructorParameter 
{
    class My 
    {
        //private object target;
        private string _name;                            //
        private int _age;                               //  <= private 인스턴스 필드
        private string _description="ddddddddd";       //


        public static string _x = "x";      // <= 공용 필드 = 클래스 필드
                                            // 공용(클래스) 생성자함수를 통해 값 변경가능 ?? < = > 개별(인스턴스) 인스턴스마다 새로 갱신하여 생성자함수를 통해 변경불가???




        public string pname { get; set; }

        //public string pname { get; set; } = "초기값";//초기값 설정 가능
        //public string pname { get; private set; } = "초기값"; //set에 private 선언시 읽기전용 프로퍼티
        //pname 이라는 프로퍼티에만
        
        public string pname             // public string pname {get; set;}
        {
            get
            {
                return _name; //return  을 항상 사용         //get 의 사용법은 필드를 리턴 해주는식으로???
            }
            set
            {
                _name = "프로퍼티를 통한 이름 set";//get set 에도 if 문 사용가능   ------생성자로  인스턴스 생성 get set으로 검사?
            }
        }  //프로퍼티  //"public 반환형식 프로퍼티명 {get; set;}" 형식으로 사용
        //위 pname 프로퍼티는 get 을 통해 프로퍼티값을 조회할 수 있고
        //set 을 통해 프로퍼티값을 할당할 수 있음.
        //프로퍼티도 static 이 없기 때문에 인스턴스 마다 분리
        //외부에 공개되는 필드라고 여김?
        //set 을 세터 get 을 게터로 표현 가능?
        

        
        public My(string name,int age)  //클래스명과 함수명을 동일하게 지정하면 생성자함수? 
        {
            this._name = name;          //매개변수를 통한 필드의 변수지정?
            this._age = age;
            this._description = name;
            _x = name;
        }
        public My() 
        {
            Console.WriteLine("생성자 호출"); 
        }
        public void PrintMy() 
        {
            Console.WriteLine(this._name,this._age);//위에서 지정한 변수를 출력
        }
        public void PrintMy2()
        {
            Console.WriteLine(this._description);
            Console.WriteLine(_x);
        }
    }
    class ConstructorParameter 
    {
        static void Main() 
        {
            My myinfo = new My("AAA",222);//
            myinfo.PrintMy();
            My my = new My();
            my.PrintMy2();
            my.pname = "프로퍼티"; //set 과정
            Console.WriteLine(my.pname);//get 과정
            myinfo.pname = "프로퍼티2";//set
            Console.WriteLine(myinfo.pname);//get
            Console.WriteLine(my.pname);

        }
    }
}
//   퍼블릭(공개) <=> 프라이빗(비공개)
//   프로퍼티(공개) <=> 필드(비공개)  
//   스태틱O(정적/클래스가 사용) <=>스태틱X(인스턴스가 사용)
//   set에 private 선언시 읽기전용 프로퍼티  
*/

/* 계좌 만들기 1차시도
namespace ConstructorParameter 
{
    class mybank
    {
        private int 잔액 = 0;
        int lastnum = 0001;
        public mybank(string name)//이름 계좌
        {

            
            
            
        }
        public void MakeAcount()
        {
            int rannum = new Random().Next(0, 100);
            var acount = 1111 + "-" + rannum + "-" + lastnum;
            //int[] acountlist = 중복검사?
            lastnum++;
        }
        public void 입금() 
        {
           int 입금 = Convert.ToInt16(Console.ReadLine());
            잔액 += 입금;
        }
        public void 출금()
        {
           int 출금 = Convert.ToInt16(Console.ReadLine());
            if (잔액 < 출금)
            {
                Console.WriteLine("잔액부족");
            }
            else 
            {
                잔액 -= 출금;
            }
        }

        public void 잔액조회()
        {
            Console.WriteLine(잔액);    
        }


    }


}
*/

/* 2차시도 약간 감잡음
namespace makebank 
{
    public class 내은행//은행총괄 클래스
    {
        private string name;
        private string date;
        private int acount;
        private string bank;
        private static int bankcode = 1111;
        private static int lastnum = 1;
        private string[] acountlist;

        public 내은행(string name)//생성자함수
        {
            this.name = name;
            bank = "mybank";
            date = DateTime.Now.ToShortDateString();
            acount = 0;


            

        }
        class lastacountnum
        {

        }
        /*
        public static class makeacount() 
        {
            int randnum = new Random().Next(1, 100);

            var acount = 내은행.bankcode + randnum + string.Format("{0:d4}", lastnum);
            lastnum++;

            //아닌거같음
        }
         
        static void Main() 
        {

        }
    }
    



}


namespace makebank 
{
    class 은행
    {
        private string name;
        private string date;

        private static int 잔액;//잔액용


        //계좌번호
        private static int lastnum;
        private static int bankcode = 1111;
        private static int randnum = new Random().Next(1, 100);
        private static string account;
        public 은행(string name)
        {
            this.name = name;//이름
            date = DateTime.Now.ToShortDateString();//생성일
            잔액 = 0;

        }
        private static void accountmaker()
        {
            lastnum++;
            account = bankcode + "-" + string.Format("{0:d2}", randnum) + "-" + string.Format("{0:d4}", lastnum);
            return;
        }
        /*
        public void makeacount()
        {
            public static int bankcode = 1111;
        public static string 계좌번호;

        lastnum = 1;
        string 계좌번호 = bankcode + randnum + string.Format("{0:d4}", lastnum);
        lastnum++;
        }
        

    
        public static void 입금(string 계좌번호, int 입금액)//계좌번호도 조회
        {
            잔액 += 입금액;
        }
        public static void 출금(string 계좌번호,int 출금액)//계좌번호도 조회
        {
            if (잔액 < 출금액)
            {
                Console.WriteLine("잔액부족");
            }
            else
            {
                잔액 -= 출금액;
            }
        }

        public static void 잔액조회()//계좌번호로 조회하게
        {
            Console.WriteLine(잔액);
        }

        static void Main()
        {
            accountmaker();
            Console.WriteLine(은행.account);
        }
    }

}
*/

//틀 = 클래스 / 만들때 세팅하는건 생성자로  / 행위 = 메서드 / 변수 = 필요하면  ---  클래스 전혀 이해못함

//은행-계좌-이름-
//틀 1. 은행업무 총괄 2.생성자 3. 계좌생성  





//문제1. 메서드 = 함수 / 클래스                                        
//클래스 필드, 인스턴스 필드 , 프로퍼티의 get , 프로퍼티의 set ,
//메서드 , 생성자를 포함하는 클래스 구조 만들기


//계좌 클래스 만들기

//공개:?
//비공개:?

//필드
//행위 = 메서드(함수) 1.입금 2. 출금 3. 잔액조회 4. 계좌번호 생성은 생성자이나 내부 랜덤요소는 메서드?
//

//잔액 필드 

//입금++   잔액 조회후 잔액++;

//출금--   잔액 조회후 가능하면 잔액-- 불가능하면 경고출력?

//잔액조회 잔액


// 생성자

//계좌번호 필드
//-- (10자리 - bank코드인스턴스? 앞4자리 은행코드 1111 /다음2자리 랜덤으로 / 클래스 : 다음4자리는 0001부터 순차증가 예시:1111-랜덤-0001~9999)

//예금주 필드 (이름)o

//은행명 필드 (mybank) 디폴트값으로 지정

//통장개설일 필드 (date 객체 활용해서 인스턴스 생성 시점으로 자동 배치 [연/월/일])



//송금(상대방 은행 과 계좌 번호를 입력 해서 송금)--인스턴스간 교류//타클래스에서 관리








//-----------------------------------------------------------------------------------------------        240215















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



//클래스의 상속
//클래스 간 부모 자식 관계를 설정해서 상속 가능
//상속은 부모클래스에 정의된 기능을 다시 사용하거나 확장 / 수정하여 자식 클래스를 만드는 것
//상속하는 방법
//public class A
//{
//  A클래스의 코드
//}

//public class B : A
//{
//  A 를 상속받은 B클래스의 코드
//}


//System.Object 클래스는 닷넷 모든 클래스의 부모 클래스이다.
//새롭게 만드는 모든 클래스는 System.Object 클래스를 상속받아 만드는 것

//기본 base 클래스 : 부모클래스를 의미

//파생 derived 클래스 : 다른 클래스의 자식 클래스가 되는 클래스를 파생 클래스라고 함.
//혹은 sub 클래스라고 함

//부모클래스와 자식클래스
// 콜론 : 기호로 상속 관계를 지정하면 부모 클래스의 public 멤버들을 자식 클래스에서 그대로 물려받아 사용 가능.
// protected 도 사용가능 ----(클래스내부와 상속받은 자식만 접근가능?)


//this 키워드 (파이썬 self)
//클래스 내에서 this는 자신을 의미하고,
//this() : 자신의 생성자를 나타냄


//base 키워드
//base 는 자신의 부모클래스를 의미
//base() : 부모클래스의 생성자를 나타냄


//------------------------------------------------------------------------ 집에서 볼것 오버로드 오버라이딩




















namespace _240215
{
    public class ParentClass : Object
    {
        public ParentClass(string Message) => Console.WriteLine(Message);
        protected void Print1() => Console.WriteLine("부모클래스의 함수");
    }
    public class ChildClass : ParentClass //부모를 상속받았기에 매개변수를 넣어줘야하는데 없어서 오류발생-----부모클래스의 생성자를 생각하고 만들어야함
    {
        public ChildClass(string Message) : base(Message) { }  // 자식의 매개변수에 부모 생성자의 매개변수를 받아오겠다???
        public void Print2()=>base.Print1();  //public void 이걸사용하면 =>이걸 호출하겠다 
    }
    class Demo 
    {
        static void Main() 
        {
            string msg = "매개변수";
            var child =new ChildClass(msg);


/*            ParentClass p = new ParentClass("생성자매개변수 텍스트");
            Console.WriteLine(p.ToString());
*/
     /*       ChildClass c = new ChildClass();
            c.Print2();*/
            //ParentClass.Print1();  : Protected 로 되어 있는 멤버는 외부 클래스에서 접근 불가

        }
    }




    /*class Parent
    {
        public void AA() => Console.WriteLine("Parent_AA");
        public override string ToString() // 부모클래스의 함수를 덮어쓰기 override  --- 부모클래스의 함수를 수정해서 사용할때 사용??
        {
            return "부모클래스tostring";
        }
    }
    class Child:Parent 
    {
        public void BB() => Console.WriteLine("Child_BB");
        public override string ToString()
        {
            return "자식클래스tostring";
        }
    }
    class Demo
    {
        static void Main()
        {
            var child = new Child();
            Console.WriteLine(child);
            child.AA();
            child.BB();
        }
    }
    */

    /*
       public partial class Person
       {
           public string Name { get; set; }
           public int age { get; set; }


       }
       public partial class Person 
       {
           public void Print() => Console.WriteLine($"{Name}:{age}");
       }
       class PartialClass 
       {
           static void Main() 
           {
               Person person = new Person();
               person.Name = "학생1";
               person.age = 10;
               person.Print();
           }
       }
    */

    /*
    class PartialClassDemo 
    {
        static void Main()
        {
            var hello = new Hello();
            hello.Hi();
            hello.Bye();//인스턴스 생성 후 두 개로 나뉜 partial 클래스 내부 멤버에 접근 가능
            //부분 클래스(분할 클래스)를 사용하여 CS파일 하나 또는 하나 이상에서 이름이 동일한 클래스 개발 가능   ----------namespace도 동일해야하는거같음.
        }
    }
    */

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



