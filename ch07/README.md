# ch07 class
4/4
Class_Intor
- null�� �̿��Ͽ� �� ������ GC ����

Class_ReferenceParameter
- �⺻ : �޸𸮸� ���� ����
- ref : ���� �޸𸮸� ����Ŵ
- out : �����

Employee_PrivateMember
- ������ class �ɹ� �� �ż��� ����

Class_Constructor
- �̿� ������ ȣ��
	- public Date() : this(2022, 1, 1) {}
	- this() : ������ �߿��� �̿� ���� ���·� ���ڸ� �޴� �����ڸ� ȣ��

Class_Destructor
- ���� �����
	- using System.IO;
	- FileStream src;

Struct1
- ����ü
	- stack �� ����(Ŭ������ heap)
		- �ӵ��� ����
	- ����Ʈ �����ڴ� ����� �����Ұ�
	- �����ڴ� �κ� �ʱ�ȭ�� ������� ����
	- new�� �Ҵ���� ���� ����ü ���� ���Ұ�
- DateTime������ ����
	- DateTime.Parse("2022-04-01")

Class1_ReadOnly
- const(���)�� ���� �Ҵ� �Ұ�
- readonly�� �����ƿ��� �ʵ� ���� ����

Employee_Static
- static : ������ ���׸�Ʈ�� �޸� �Ҵ�
- ȣ�� ���� : ���� ������ > ���� �żҵ�
- ������
	- ���� ������ : ��ü�� ó�� ������ �� new �ϱ� �� �ѹ��� ����
	- �Ϲ� ������ : ��ü�� ������ ������ ����
- ���� �ɹ�
	- ��ü���� ����
	- ���� �����ڿ��� �ʱ�ȭ
- ���� �żҵ�
	- ��ü ������ ������� ȣ�� ����

Employee_DeepCopy
- DeepCopy() ����

Nested_Class
- class ��ø
	- ��ø�� Ŭ���� �ż���� ����Ŭ������ private �ɹ��� �ٷ� ���� ����

Bank_Class.cs & BankNain.cs
- ���� ��Ȱ
- Bank_Class.cs
	- namespace Bank
- BankNain.cs
	- using Bank;

BaseAndDrived
- ������ ���
- ����� ���� �θ� �Ű����� �� �żҵ� ȣ�� ����

InheritanceConstructor
- �Ļ�Ŭ������ ȣ�� �Ҷ� ��� Ŭ���� �����ڸ� ���� ȣ��
- this() ������ : ���� Ŭ������ �̿������� ȣ��
- base() ������ : ��� Ŭ������ �����ڸ� ȣ��

BaseAndDrived2
- ��� Ŭ������ �ɹ� ���� ȣ��
	- base.[����]

ObjectTypeCast
- ��� Ŭ���� �żҵ�� �Ļ�Ŭ���� �żҵ� ������ ȣ�� ����
- method override
	- �Ļ�Ŭ���� ��ü�� �����Ǹ� ��� Ŭ���� �������̵� �� �ż���� ������
- UpCast
	- �Ļ�Ŭ���� ��ü�� ��� Ŭ���� ��ü ������ ���ԵǸ� ��� Ŭ���� �ż��尡 ȣ���
- is ������
	- ��ü�� �ش� ���Ŀ� �ش��ϴ����� �˻��Ͽ� �� ����� bool ������ ��ȯ
- as ������
	- ����ȭ�� �����ϰ�, �����ϸ� null ���� ��ȯ
	

Virtual_Class
- ��� Ŭ���� �ż��� : public virtual void Name()
	- virtual : �����Լ� Ű����
- �Ļ� Ŭ���� �ż���
	- override Ű����
		- ���� ���ε�
		- public override void Name()
		- ��� Ŭ���� ��ü ������ ���Ե� �Ļ� Ŭ���� ��ü���� �Ļ� Ŭ���� �ż��� ȣ�� ����
	- new ������
		- public new void Name()
		- ��� Ŭ���� ��ü ������ ���Ե� �Ļ� Ŭ���� ��ü���� ��� Ŭ���� �ż��� ȣ�� ����