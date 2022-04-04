# ch07 class
4/4
Class_Intor
- null을 이용하여 더 빠르게 GC 진행

Class_ReferenceParameter
- 기본 : 메모리를 따로 받음
- ref : 같은 메모리를 가르킴
- out : 저장용

Employee_PrivateMember
- 간단한 class 맴버 및 매서드 구현

Class_Constructor
- 이웃 생성자 호출
	- public Date() : this(2022, 1, 1) {}
	- this() : 생성자 중에서 이와 같은 형태로 인자를 받는 생성자를 호출

Class_Destructor
- 파일 입출력
	- using System.IO;
	- FileStream src;

Struct1
- 구조체
	- stack 에 저장(클래스는 heap)
		- 속도가 빠름
	- 디폴트 생성자는 명시적 생성불가
	- 생성자는 부분 초기화를 허용하지 않음
	- new로 할당되지 않은 구조체 변수 사용불가
- DateTime형으로 변경
	- DateTime.Parse("2022-04-01")

Class1_ReadOnly
- const(상수)는 절대 할당 불가
- readonly는 생서아에서 필드 수정 가능

Employee_Static
- static : 데이터 세그먼트에 메모리 할당
- 호출 순서 : 정적 생성자 > 정적 매소드
- 생성자
	- 정적 생성자 : 객체가 처음 생성할 때 new 하기 전 한번만 실행
	- 일반 생성자 : 객체가 생성될 때마다 실행
- 정적 맴버
	- 객체마다 공유
	- 정적 생성자에서 초기화
- 정적 매소드
	- 객체 생성과 상관없이 호출 가능

Employee_DeepCopy
- DeepCopy() 생성

Nested_Class
- class 중첩
	- 중첩된 클래스 매서드는 상위클래스의 private 맴버에 바로 접근 가능

Bank_Class.cs & BankNain.cs
- 파일 분활
- Bank_Class.cs
	- namespace Bank
- BankNain.cs
	- using Bank;

BaseAndDrived
- 간단한 상속
- 상속을 통한 부모 매개변수 및 매소드 호출 진행

InheritanceConstructor
- 파생클래스를 호출 할때 기반 클래스 생성자를 먼저 호출
- this() 생성자 : 현재 클래스의 이웃생성자 호출
- base() 생성자 : 기반 클래스의 생성자를 호출

BaseAndDrived2
- 기반 클래스의 맴버 변수 호출
	- base.[변수]

ObjectTypeCast
- 기반 클래스 매소드는 파생클래스 매소드 내에서 호출 가능
- method override
	- 파생클래스 객체가 생성되면 기반 클래스 오버라이드 된 매서드는 가려짐
- UpCast
	- 파생클래스 객체가 기반 클래스 객체 변수에 대입되면 기반 클래스 매서드가 호출됨
- is 연산자
	- 객체가 해당 형식에 해당하는지를 검사하여 그 결과를 bool 값으로 반환
- as 연산자
	- 형변화를 진행하고, 실패하면 null 값을 반환
	

Virtual_Class
- 기반 클래스 매서드 : public virtual void Name()
	- virtual : 가상함수 키워드
- 파생 클래스 매서드
	- override 키워드
		- 동적 바인딩
		- public override void Name()
		- 기반 클래스 객체 변수에 대입된 파생 클래스 객체에서 파생 클래스 매서드 호출 진행
	- new 한정자
		- public new void Name()
		- 기반 클래스 객체 변수에 대입된 파생 클래스 객체에서 기반 클래스 매서드 호출 진행