package me.roryclaasen.oop;

import java.util.Date;

public class EmployeeWeekly extends Employee {

	public EmployeeWeekly(long id, Date birth, String title) {
		super(id, birth, title);
	}

	@Override
	protected void workOutPay() {
		pay = 7.2 * 8;
	}
}
