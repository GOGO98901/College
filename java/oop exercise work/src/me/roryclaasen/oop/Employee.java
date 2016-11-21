package me.roryclaasen.oop;

import java.util.Date;

public abstract class Employee {
	private long id;
	private Date birth;
	private String title;

	protected double pay;

	public Employee(long id, Date birth, String title) {
		this.id = id;
		this.birth = birth;
		this.title = title;
	}

	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public Date getBirth() {
		return birth;
	}

	public void setBirth(Date birth) {
		this.birth = birth;
	}

	public String getTitle() {
		return title;
	}

	public void setTitle(String title) {
		this.title = title;
	}

	protected abstract void workOutPay();

	public double getPay() {
		workOutPay();
		return pay;
	}
}
