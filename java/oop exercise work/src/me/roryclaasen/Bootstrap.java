package me.roryclaasen;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

import me.roryclaasen.oop.Employee;
import me.roryclaasen.oop.EmployeeHourly;
import me.roryclaasen.oop.EmployeeWeekly;
import me.roryclaasen.oop.Student;

public class Bootstrap {
	private static BufferedReader bReader;
	private static List<Student> students;
	private static List<Employee> employees;

	public static void main(String[] args) {
		bReader = new BufferedReader(new InputStreamReader(System.in));
		students = new ArrayList<Student>();
		employees = new ArrayList<Employee>();

		for (int i = 0; i < 5; i++) {
			System.out.println("\nEnter a student");
			addStudent();
		}
		System.out.println();
		for (Student s : students) {
			printStudent(s);
		}
		System.out.println("\nEnter an employee");
		addEmployee();
		System.out.println("\nEnter an employee");
		addEmployee();
		System.out.println();

		for (Employee e : employees) {
			printEmployee(e);
		}
	}

	private static void printEmployee(Employee e) {
		System.out.println("ID: " + e.getId());
		System.out.println("Title: " + e.getTitle());
		System.out.println("DoB: " + e.getBirth());
		System.out.println("pay: " + e.getPay());
	}

	private static void printStudent(Student student) {
		System.out.println("Name: " + student.getName());
		System.out.println("Student ID: " + student.getStudentID());
		System.out.println("Address: " + student.getAddress());
		System.out.println("Tutor: " + student.getTutor());
		System.out.println("Year: " + student.getYearGroup());
	}

	@SuppressWarnings("deprecation")
	private static void addEmployee() {
		long ID = getLong("Enter ID: ");
		String title = getString("Enter your title: ");
		int day = getInteger("enter day of birth: ");
		int month = getInteger("enter month of birth: ");
		int year = getInteger("enter year of birth: ");
		int type = -1;
		while (type != 0 && type != 1) {
			type = getInteger("enter type of employee (0) hourly, (1) weekly");
		}
		if (type == 0) employees.add(new EmployeeHourly(ID, new Date(year, month, day), title));
		if (type == 1) employees.add(new EmployeeWeekly(ID, new Date(year, month, day), title));
	}

	private static void addStudent() {
		long studentID = getLong("Enter your Student ID: ");
		String name = getString("Enter your name: ");
		String address = getString("Enter your address: ");
		String tutor = getString("Enter your tutor group: ");
		int year = getInteger("Enter your year group: ");
		students.add(new Student(studentID, name, address, tutor, year));
	}

	private static long getLong(String message) {
		String input = getString(message);
		try {
			long attempt = Long.parseLong(input);
			return attempt;
		} catch (Exception e) {
			return getLong(message);
		}
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
