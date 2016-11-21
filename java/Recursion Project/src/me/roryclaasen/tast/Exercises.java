package me.roryclaasen.tast;

public class Exercises {

	public int factorial(int x) {
		if (x == 0) return 1;
		return x * factorial(x - 1);
	}

	public int snookerBallTriangle(int side) {
		if (side == 0) return 0;
		return side + snookerBallTriangle(side - 1);
	}

	public void chopText(String string) {
		System.out.println(string);
		if (string.length() > 1) {
			chopText(string.substring(0, string.length() - 1));
		}
		System.out.println(string);
	}

	public void b(int number) {
		if (number == 0 || number == 1) System.out.println(number);
		else {
			b(number / 2);
			System.out.println(number % 2);
		}
	}

	public int fibonacci(int n) {
		if (n < 0) return 0;
		if (n == 0) return 1;
		return fibonacci(n - 1) + fibonacci(n - 2);
	}

	public boolean isPalindromic(String string) {
		string = string.toLowerCase();
		if (string.length() == 0 || string.length() == 1) return true;
		char one = string.charAt(0);
		char two = string.charAt(string.length() - 1);
		if (one == two) return isPalindromic(string.substring(1, string.length() - 1));
		return false;
	}
}
