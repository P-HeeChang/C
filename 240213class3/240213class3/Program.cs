using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClassName 
{
    public static void MemberName() 
    {
        Console.WriteLine("클래스의 멤버가 호출");
    }
}
public class ClassAndMember 
{
    public static void Main() 
    {
        ClassName.MemberName();
        Console.WriteLine(Environment.Version); //닷넷 버젼
        Console.WriteLine(Environment.OSVersion); // 운영체제 버젼
        Console.WriteLine(Environment.UserName); // 사용자 이름
        Console.WriteLine(Environment.CurrentDirectory); // 현재 폴더 Environment.CurrentDirectory로 현재폴더가져와서 뒤에 . 찍고 사용가능?
        Console.WriteLine(Environment.MachineName); // pc명
        //Environment.Exit(0);//닷넷 프레임워크에 내장된 클래스 Exit메서드를 통해 프로그램 강제 종료
        //시스템 환경변수



        Console.WriteLine("------------------------------------------");

        //Process.Start("Notepad.exe");//프로세스 관련 클래스 
        //Process.Start("Explorer.exe","https://naver.com"); //기본값이 크롬으로되어있어 크롬실행
        //exe 파일 실행 Start 함수

        //Random
        //난수 생성

        //Random random = new Random();
        //Console.WriteLine(random.Next()); // 임의의 정수를 얻음
        //Console.WriteLine(random.Next(5)); // 0~4 범위내에 임의의 수
        //Console.WriteLine(random.Next(1, 10));//1-9사이의 임의의 수
        //Console.WriteLine(random.NextDouble());//임의의 실수 반환 (0~1사이 실수?)
        //Console.WriteLine(random.Next(1,46));//1~45 사이의 임의의 수
        //특정 6개의 중복없는 당첨 번호를 지정해놓고
        //Random 클래스를 활용하여, 랜덤으로 뽑은 숫자6개와 동일한지 검사하는 코드 작성
        //Random으로 뽑은 숫자 6개는 중복되지 않아야 함.
        //Random 으로 뽑은 숫자는 배열에 담아서 관리함  new Array=[] 뭐였지??
        //중복 제외 처리 for 문 통해서 처리
        //중복이 나오면 for의 인덱스를 무효처리(중복제거)

        int[] array = new int[6];

        /* 1번시도
          for (int i = 0; i != 6; i++)   //array.length != 6??
         { 
             int rannum=random.Next(1, 46);
             int index=Array.IndexOf(array, rannum);

             if (index == -1)
             {
                 array[i] = rannum;
             }

             else
             {
                 i--;
                 continue;
             }


         }
        Console.WriteLine(array);
        */


        /*2번시도
        for (int i = 0; i != 6; i++)   //array.length != 6??
        {
            Random random = new Random();

            int rannum = random.Next(1, 46);

            for (int j=0; j<arr.Length; j++)
            { 
                int index = Array.IndexOf(arr, rannum);

                if (index == -1)
                {
                    arr[i] = rannum;
                }

                else if (arr.Length == 6)
                {
                    Console.WriteLine(arr);
                    break;
                }

                else
                {
                    continue;
                }
            }
         //3번째 시도
        Random rand = new Random();
        int randnum = rand.Next(1,10);
        for (int i = 0; i < 6; i++)
        {
            if (Array.IndexOf(array, randnum) == -1)
            {
                array[i] = randnum;
            }
            else 
            {
                --i;
            }
        }
       */
        {
            Console.WriteLine("6개 랜덤 숫자 중복 제거 생성");
            Random random = new Random();//random 클래스를 이용한 random 객체 생성
            int[] arr = new int[6];//6개의 임의의 숫자를 담을 빈 정수 배열 선언
            int temp = 0;//임시 값을 담을 temp 변수 선언
            for (int i = 0; i < 6; i++) // 6개의 난수를 배열에 넣는 것을 목적으로 6바퀴 for 문 구성
            {
                temp = random.Next(1, 46);//random 객체의 Next 함수로 1~45 중 하나의 숫자 랜덤 생성
                bool flag = false; // 중복 여부를 판단하기 위한 bool타입의 flag 변수 생성
                if (i > 0 && i < 6) // 위 for 문이 1~6사이 정상 범위 일대만 진입하는 조건
                {
                    for (int j = 0; j <= i; j++)//2중 for 문 j 를 0부터 i 까지 반복
                    {
                        if (arr[j] == temp) //임시로 뽑은 난수가 정수배열 arr 의 j 인덱스에 있는지 반복 검사
                        {
                            flag = true; //이미 있는 중복 숫자인 경우 flag를 true 로 전환
                        }
                    }
                }
                if (flag)//만약 flag 가 true 로 전환된 중복 상황이라면
                {
                    --i;//최상단 for 문의 인덱스를 1단계 롤백
                }
                else//중복이 아니라면 1번째 인덱스 자리에 temp 를 배치
                {
                    arr[i] = temp;
                }
            }
            for (int i = 0; i < 6; i++)//6개를 다채워넣은 배열 arr 를 순차 반복 출력
            {
                Console.WriteLine("{0}", arr[i]);//문자열 포메팅{0} 사용하여 출력
            }
            Console.WriteLine();//줄바꿈
        }
    }

}
    //엑세스한정자 public 외 다른 종류
    //private
    //internal(디폴트)
    //sealed




    //String : 가장 많이 사용하는 문자열 처리 관련 속성 메서드 제공 클래스
    //StringBuilder : 대용량 문자열 처리 관련 속성 및 메서드
    //Array : 배열관련 주요 메서드 및 속성




