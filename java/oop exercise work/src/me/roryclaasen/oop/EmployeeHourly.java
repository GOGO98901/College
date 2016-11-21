package me.roryclaasen.oop;

import java.util.Date;

public class EmployeeHourly extends Employee {

	public EmployeeHourly(long id, Date birth, String title) {
		super(id, birth, title);
	}

	@Override
	protected void workOutPay() {
		pay = 5.6 * 7;
	}
}
