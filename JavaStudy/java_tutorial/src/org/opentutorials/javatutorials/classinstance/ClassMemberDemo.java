package org.opentutorials.javatutorials.classinstance;

class C1 { //Ŭ���� C1
	static int static_variable = 1;
	// Ŭ���� Static ���� ����
	
	int instance_variable = 2;
	// ��ü ���� �� �ν��Ͻ� ������ �����
	
	static void static_static() { // Static �޼ҵ�� Static ���� ����
		System.out.println("Static �޼ҵ� ����, Static ������ ����"+static_variable+"�̴�"); // Static �޼ҵ忡�� Ŭ������ Static ���� ���
	}
	
	static void static_instance() { // Static �޼ҵ�� �ν��Ͻ� ���� ����
		//Ŭ���� �޼ҵ忡���� �ν��Ͻ� ������ ���� �Ұ���.
		//System.out.println(instance_variable);
	}
	void instance_static() { // �ν��Ͻ� �޼ҵ�� Static ���� ����
		//�ν��Ͻ� �޼ҵ忡���� Ŭ���� ������ ���� �� �� �ִ�.
		System.out.println("�ν��Ͻ� �޼ҵ� ����, static ������ ����"+static_variable+"�̴�" );
	}
	void instance_instance() { // �ν��Ͻ� �޼ҵ�� �ν��Ͻ� ���� ����
		System.out.println("�ν��Ͻ� �޼ҵ� ����, instance ������ ����" +instance_variable+"�̴�");
	}

}

public class ClassMemberDemo{
	public static void main(String[] args) { //�����Լ�
		C1 c = new C1(); //C1������ ��ä c����
		
		//�ν��Ͻ��� �̿��ؼ� Static �޼ҵ忡 ����-> ����
		//�ν��Ͻ� �޼ҵ尡 Static ������ ���� ->����
		c.static_static();
		
		//�ν��Ͻ��� �̿��ؼ� Static �޼ҵ忡 ����->����
		//Static �޼ҵ尡 �ν��Ͻ� ������ ����->����
		c.static_instance();
		
		//�ν��Ͻ��� �̿��ؼ� �ν��Ͻ� �޼ҵ忡 ����->����
		//�ν��Ͻ� �޼ҵ尡 Ŭ���� ������ ����->����
		c.instance_static();
		
		//�ν��Ͻ��� �̿��ؼ� �ν��Ͻ� �޼ҵ忡 ����->����
		//�ν��Ͻ� �޼ҵ尡 �ν��Ͻ� ������ ����->����
		c.instance_instance();
		
		//Ŭ������ �̿��ؼ� Ŭ���� �޼ҵ忡 ����->����
		//Ŭ���� �޼ҵ尡 Ŭ���� ������ ����->����
		C1.static_static();
		
		//Ŭ������ �̿��ؼ� Ŭ���� �޼ҵ忡 ����->����
		//Ŭ���� �޼ҵ尡 �ν��Ͻ� ������ ����->����
		C1.static_instance();
		
		//Ŭ������ �̿��ؼ� �ν��Ͻ� �޼ҵ忡 ����->����
		//C1.instance_static();
		
		//Ŭ������ �̿��ؼ� �ν��Ͻ� �޼ҵ忡 ����->����
		//C1.instance_instance();
	}
}
