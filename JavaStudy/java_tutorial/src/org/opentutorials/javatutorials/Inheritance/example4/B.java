package org.opentutorials.javatutorials.Inheritance.example4;
class C extends A {//inheritance class A
	void pB() {//override
		System.out.println("pC print");
	}
}

public class B{
	
	public static void main(String[] args) {
		C c1 =  new C();
		c1.pA();
		c1.pB();//overridden result
	}
}
