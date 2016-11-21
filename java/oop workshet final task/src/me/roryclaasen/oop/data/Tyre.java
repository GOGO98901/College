package me.roryclaasen.oop.data;

public class Tyre {

	public enum TyreCode {
		T100(36.0), T110(38.0), PL10(39.99), PL20(49.99), PL30(59.99);
		private double price;

		TyreCode(double price) {
			this.price = price;
		}

		public double getPrice() {
			return price;
		}
	}

	private int leftInStock;
	private TyreCode code;
	private double price;

	public Tyre(int leftInStock, TyreCode code, double price) {
		this.leftInStock = leftInStock;
		this.code = code;
		this.price = price;
	}

	public double getPrice() {
		return price;
	}

	public int getLeftInStock() {
		return leftInStock;
	}

	public void setLeftInStock(int leftInStock) {
		this.leftInStock = leftInStock;
	}

	public void addTyresInStock(int more) {
		this.leftInStock += more;
	}

	public void removeTyresInStock(int less) {
		this.leftInStock -= less;
	}

	public TyreCode getCode() {
		return code;
	}
}
