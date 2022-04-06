using System;
using myPersonDll;

namespace myPerson
{
    class PersonMain
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.showDate();
        }
    }
}
/*
클래스 라이브러리 -> DLL 파일을 생성
콘솔 어플리케이션 -> EXE 파일을 생성

1. 클래스 라이브러리로 DLL 파일 생성
2. 콘솔 어플리케이션에서 'com 참조 추가'
3. 찾아보기를 통해 해당 DLL파일 추가
4. 솔루션 탐색기에서 종속성-어셈블리에 해당 DLL 파일 추가된 것 확인
5. using [DLL 파일명] 작성
 */

/* myPersonDll 내용
 using System;

namespace myPersonDll
{
    // default : internal
    // 현재는 public으로 설정
    public class Person
    {
        public void showDate()
        {
            Console.WriteLine("현재날짜 : {0} ", DateTime.Now);
        }
    }
}
 */