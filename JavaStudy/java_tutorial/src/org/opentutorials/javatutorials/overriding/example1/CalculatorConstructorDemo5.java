package org.opentutorials.javatutorials.overriding.example1;

class Calculator{
	int left, right, avg;
	
	public void setOprands(int left, int right) {
		this.left = left;
		this.right = right;
	}
	
	public void sum() {
		System.out.println(this.left + this.right);
	}
	public int avg() {
		return (this.left + this.right)/2;
	}
}

class SubstractionableCalculator extends Calculator{
	
	  public void sum() { System.out.println("overriding excute." + (this.left +
	  this.right)); }
	 
	public void substract() {
		System.out.println(this.left - this.right);
	}
	public void printavg() {
		System.out.println(super.avg());
	}
}

public class CalculatorConstructorDemo5{
	
	public static void main(String[] args) {
		SubstractionableCalculator c1 = new SubstractionableCalculator(); // 기본 생성자가 instance 생성,동시에 초기화
		c1.setOprands(10, 20);
		c1.sum();
		c1.substract();
		c1.printavg();
	}

}
