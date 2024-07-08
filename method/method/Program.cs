using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240213class
{
    public class myclass
    {
        static void Run()
        {
            Console.WriteLine("myclass Run method");
        }
    }
    class MyFirstClass
    {
        static void StaticMethod() => Console.WriteLine("정적 메서드");
        //클래스 공용 pyhon => x
        void InstanceMethod() => Console.WriteLine("인스턴스 메서드");
        //객체가 호출하는 메서드 python => self.x

        void p(int a, int b) => Console.WriteLine(a + b);

        void m(int a, int b) => Console.WriteLine(a - b);

        void d(float a, float b) => Console.WriteLine(a / b);

        void mul(int a, int b) => Console.WriteLine(a * b);

        static void Main()
        {
            MyFirstClass.StaticMethod();
            //MyFirstClass.InstanceMethod(); 인스턴스를 통해 접근 가능
            MyFirstClass myFirstClass = new MyFirstClass();
            myFirstClass.InstanceMethod();
            //MyFirstClass.InstanceMethod(); => static이 안붙은건 한번호출해서 변수지정해서 사용해야함?--->

            //숫자 두개를 입력 받아 연산하는 더하기 빼기 나누기 곱하기 함수를 만들고 ---- 사칙연산4개함수

            //인스턴스를 통해서만 사용가능하도록 구성 --- void 타입으로

            //Main 안에서 자유롭게 사칙연산 함수 호출

            //결과 출력

            //Console.ReadLine() C#에서 인풋
            //함수 더하기/빼기/나누기/곱하기(a,b) ------ 
            myFirstClass.p(1, 2);
            myFirstClass.m(3, 5);
            myFirstClass.d(75, 15);
            myFirstClass.mul(7, 9);
            //MyFirstClass.p(); : 클래스를 통한 접근 불가(static메서드가 아니기 때문에)
            //static이 붙은 정적 메서드는 클래스명.메서드()로 호출 : 정적 멤버, 공유 멤버
            //static이 붙지않은 메서드는 인스턴스.메서드()로 호출 : 인스턴스 멤버




        }
    }
}

