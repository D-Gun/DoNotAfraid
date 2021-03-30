package org.opentutorials.javatutorials.classinstance;

class C1 { //클래스 C1
	static int static_variable = 1;
	// 클래스 Static 변수 선언
	
	int instance_variable = 2;
	// 객체 생성 시 인스턴스 변수로 선언됨
	
	static void static_static() { // Static 메소드로 Static 변수 접근
		System.out.println("Static 메소드 실행, Static 변수의 값은"+static_variable+"이다"); // Static 메소드에서 클래스의 Static 변수 출력
	}
	
	static void static_instance() { // Static 메소드로 인스턴스 변수 접근
		//클래스 메소드에서는 인스턴스 변수에 접근 불가함.
		//System.out.println(instance_variable);
	}
	void instance_static() { // 인스턴스 메소드로 Static 변수 접근
		//인스턴스 메소드에서는 클래스 변수에 접근 할 수 있다.
		System.out.println("인스턴스 메소드 실행, static 변수의 값은"+static_variable+"이다" );
	}
	void instance_instance() { // 인스턴스 메소드로 인스턴스 변수 접근
		System.out.println("인스턴스 메소드 실행, instance 변수의 값은" +instance_variable+"이다");
	}

}

public class ClassMemberDemo{
	public static void main(String[] args) { //메인함수
		C1 c = new C1(); //C1형식의 객채 c생성
		
		//인스턴스를 이용해서 Static 메소드에 접근-> 성공
		//인스턴스 메소드가 Static 변수에 접근 ->성공
		c.static_static();
		
		//인스턴스를 이용해서 Static 메소드에 접근->성공
		//Static 메소드가 인스턴스 변수에 접근->실패
		c.static_instance();
		
		//인스턴스를 이용해서 인스턴스 메소드에 접근->성공
		//인스턴스 메소드가 클래스 변수에 접근->성공
		c.instance_static();
		
		//인스턴스를 이용해서 인스턴스 메소드에 접근->성공
		//인스턴스 메소드가 인스턴스 변수에 접근->성공
		c.instance_instance();
		
		//클래스를 이용해서 클래스 메소드에 접근->성공
		//클래스 메소드가 클래스 변수에 접근->성공
		C1.static_static();
		
		//클래스를 이용해서 클래스 메소드에 접근->성공
		//클래스 메소드가 인스턴스 변수에 접근->실패
		C1.static_instance();
		
		//클래스를 이용해서 인스턴스 메소드에 접근->실패
		//C1.instance_static();
		
		//클래스를 이용해서 인스턴스 메소드에 접근->실패
		//C1.instance_instance();
	}
}
