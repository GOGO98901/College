package me.roryclaasen.oop.data;

import java.util.Date;


public class Fitting {
	private String carReg;
	private Tyre.TyreCode tyre;
	private int noTyres;
	private Date date;

	public Fitting(String carReg, Tyre.TyreCode code, int noTyres, Date date) {
		this.carReg = carReg;
		this.tyre = code;
		this.noTyres = noTyres;
		this.date = date;
	}

	public String getCarReg() {
		return carReg;
	}

	public Tyre.TyreCode getTyre() {
		return tyre;
	}

	public int getNoTyres() {
		return noTyres;
	}

	public Date getDate() {
		return date;
	}

	@Override
	public String toString() {
		return getClass().getSimpleName() + "[" + carReg + ", " + date + ", " + tyre + ", tyres=" + noTyres + "]";
	}
}
