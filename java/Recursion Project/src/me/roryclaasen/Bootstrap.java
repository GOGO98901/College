package me.roryclaasen;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import me.roryclaasen.tast.Exercises;

public class Bootstrap {
	private static BufferedReader bReader = new BufferedReader(new InputStreamReader(System.in));

	public static void main(String[] args) {
		Exercises ex = new Exercises();
		System.out.println(ex.factorial(6));
		System.out.println();

		System.out.println(ex.snookerBallTriangle(getInteger("How many Snooker Balls are there? ")));
		System.out.println();

		ex.chopText("The following procedure successively removes a letter from the end of a string.");
		System.out.println();

		ex.b(10);
		System.out.println();

		ex.b(15);
		System.out.println();

		ex.b(127);
		System.out.println();

		ex.b(256);
		System.out.println();

		for (int n = 0; n < 20; n++) {
			System.out.println(ex.fibonacci(n));
		}
		System.out.println();

		System.out.println("RaceCar -> " + ex.isPalindromic("RaceCar"));
		System.out.println("Race Car -> " + ex.isPalindromic("Race Car"));
		System.out.println("Stressed -> " + ex.isPalindromic("Stressed"));
		System.out.println("Kayak -> " + ex.isPalindromic("Kayak"));
	}

	private static int getInteger(String message) {
		String input = getString(message);
		try {
			int attempt = Integer.parseInt(input);
			return attempt;
		} catch (Exception e) {
			return getInteger(message);
		}
	}

	private static String getString(String message) {
		System.out.print(message);
		String input;
		try {
			input = bReader.readLine();
			return input;
		} catch (IOException e) {
			// e.printStackTrace();
			return "";
		}
	}
}
