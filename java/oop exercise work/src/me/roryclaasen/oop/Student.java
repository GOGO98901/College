package me.roryclaasen.oop;

public class Student {
	private long studentID;
	private String name, address, tutor;
	private int yearGroup;

	public Student(long studentID, String name, String address, String tutor, int yearGroup) {
		this.studentID = studentID;
		this.name = name;
		this.address = address;
		this.tutor = tutor;
		this.yearGroup = yearGroup;
	}

	public long getStudentID() {
		return studentID;
	}

	public void setStudentID(long studentID) {
		this.studentID = studentID;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public String getTutor() {
		return tutor;
	}

	public void setTutor(String tutor) {
		this.tutor = tutor;
	}

	public int getYearGroup() {
		return yearGroup;
	}

	public void setYearGroup(int yearGroup) {
		this.yearGroup = yearGroup;
	}
}
