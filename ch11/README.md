# ch11

GenericCalass_intro
- 자료구하기!!!

Generic_Class_Indexer

Generic_Method
- class templete을 설개할 때 형식 제약
	- where T : struct
		- 값형식
		- stack에 저장
	- where T : class
		- 참조형식

ArrayList
- C++ STL과 유사
- 헤더추가 : using System.Collections;
- 생성 : ArrayList list = new ArrayList();
- 입력 : list.Add(3.14);
- 해당 값 삭제 : list.Remove(3.14);
- index 삭제 : list.RemoveAt(1);
- ArrayList 길이 : list.Count
- object
	- ArrayList는 불분명한 type을 가지므로 object type 사용
	- 속도가 느림

Generic_List
- 자료형 고정으로 형변환에 따른 속도가 개선됨
- 생성 : List<int> list2 = new List<int>();
- 자료값 찾기 : list2.Contains(N)
- 정렬 : list2.Sort();

Generic_Stack
- 생성 : Stack<int> stack = new Stack<int>();
- 삽입 : stack.Push(1);
- 반환 : stack.Pop()

Generic_Queue
- 생성 : Queue<int> queue = new Queue<int>();
- 삽입 : queue.Enqueue(1);
- 반환 : queue.Dequeue()

HashTable
- key와 value로 이뤄진 데이터
- 데이터 타입이 안정해져있어서 Boxing-UnBoxing이 이뤄짐
- 생성 : Hashtable nameHT = new Hashtable();
- 입력 : nameHT.Add("이몽룡", 2700000);
- 삭제 : nameHT.Remove("이몽룡");
- key 여부 확인 : nameHT.ContainsKey("이몽룡tt")
- IDictionaryEnumerator myEnum = HList.GetEnumerator();
	- IDictionaryEnumerator : 인터페이스에서 제공해주는 집합 타입
	- GetEnumerator() : 컬렉션에서 반복하는 반복자를 반환
- key 또는 value만 반환
	- 타입이 없어서 열거자(ICollection) 사용 필수
	- ICollection myKey = nameHT.Keys;
	- ICollection myValue = nameHT.Values;

Generic_Dictionary
- 일반화이므로 타입이 정해져 있음
- HashTable보다 속도가 빠름
- key-value 출력
	- 모두 출력
		- foreach (var item in name1)
		- Console.Write("{0}, ", item);
	- 구분하여 출력
		- foreach (KeyValuePair<string, string> tmp in name1)
		- Console.WriteLine(tmp.Key, tmp.Value);

myPersonDll
- c# dll 파일 생성
myPerson
- dll 파일 활용
myDll
- c++ dll 파일 생성