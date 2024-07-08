using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyClass 
{
    public static void MyMthod() 
    {
        Console.WriteLine("클래스메서드");
    }
    //현재 이 클래스에는 public 키워드가 붙어있음
    //이 클래스 내부 MyMthod 도 public 이 붙어있음
    //클래스를 public 으로 설정했기에 외부에서 접근 가능(public=공용)
    //public 을 엑세스(접근)한정자라고 함
    //대부분 클래스와 메서드를 public 을 작성하는 것을 기본으로 함
    //public을 작성하지 않으면 internal로 작동
}
class ClassDescription 
{
    static void Main()
    {
        MyClass.MyMthod();
    }
}


