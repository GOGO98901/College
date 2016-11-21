package me.roryclaasen.oop;

import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import me.roryclaasen.oop.data.Fitting;
import me.roryclaasen.oop.data.Tyre;


public class OopSystem {
	
	public static final int STARTING_TYRES = 10;

	private Map<Tyre.TyreCode, Tyre> tyres = new HashMap<Tyre.TyreCode, Tyre>();

	private List<Fitting> fittings = new ArrayList<Fitting>();

	public OopSystem() {
		for (Tyre.TyreCode tyre : Tyre.TyreCode.values()) {
			newTyre(tyre, STARTING_TYRES);
		}
	}

	private void newTyre(Tyre.TyreCode code, int stock) {
		tyres.put(code, new Tyre(stock, code, code.getPrice()));
	}

	public boolean newFitting(String carReg, Tyre.TyreCode code, int quantity, Date date) {
		if (canRemoveTyre(code, quantity)) {
			Fitting fitting = new Fitting(carReg, code, quantity, date);
			fittings.add(fitting);
			System.out.println("Added new " + fitting.toString());
			removeTyre(code, quantity);
			return true;
		}
		System.out.println("Not enough tyres");
		return false;
	}

	public void addTyre(Tyre.TyreCode code, int quantity) {
		Tyre tyre = tyres.get(code);
		if (tyre != null) tyre.addTyresInStock(quantity);
	}

	public boolean canRemoveTyre(Tyre.TyreCode code, int quantity) {
		Tyre tyre = tyres.get(code);
		if (tyre == null) return false;
		if (tyre.getLeftInStock() - quantity < 0) return false;
		return true;
	}

	public void removeTyre(Tyre.TyreCode code, int quantity) {
		Tyre tyre = tyres.get(code);
		if (tyre != null) tyre.removeTyresInStock(quantity);
	}

	public Tyre getTyre(Tyre.TyreCode code) {
		return tyres.get(code);
	}
}
