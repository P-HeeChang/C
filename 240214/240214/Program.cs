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
*/

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
        private static string acount;
        public 은행(string name)
        {
            this.name = name;//이름
            date = DateTime.Now.ToShortDateString();//생성일
            잔액 = 0;

        }
        private static void acountmaker()
        {
            lastnum++;
            acount = bankcode + "-" + string.Format("{0:d2}", randnum) + "-" + string.Format("{0:d4}", lastnum);
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
        */

    
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
            acountmaker();
            Console.WriteLine(은행.acount);
        }
    }

}

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




