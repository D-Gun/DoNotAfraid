package org.opentutorials.javatutorials.eclipse;

public class Helloworld {

	public static void main(String[] args) {
		int i = 6;
		int limit = 10;
		String output = "";
		while(i < limit){
			output += i;
			i++;	
		}
		System.out.println(output);
	}

}
