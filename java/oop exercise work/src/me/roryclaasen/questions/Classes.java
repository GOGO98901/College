package me.roryclaasen.questions;

import java.awt.Color;
import java.util.Date;

public class Classes {
	public class Suite {
		private enum TableType table;
		private enum ChairType chair;
		private int numberOfChairs;
		
		public String displayDetails(){}
	}
	public class Table{
		private TableType type;
		private int size;
		private Color color;
	}
	public class Chair{
		private ChairType type;
		private Color color;
	}

	public class Member {
		private String surname, firstname;
		private long telephoneNumber;
		private int hadicap;

		public Member(String surname, String firstname, long telephoneNumber, int hadicap) {
			this.surname = surname;
			this.firstname = firstname;
			this.telephoneNumber = telephoneNumber;
			this.hadicap = hadicap;
		}

		public String getSurname() {
			return surname;
		}

		public void setSurname(String surname) {
			this.surname = surname;
		}

		public String getFirstname() {
			return firstname;
		}

		public void setFirstname(String firstname) {
			this.firstname = firstname;
		}

		public long getTelephoneNumber() {
			return telephoneNumber;
		}

		public void setTelephoneNumber(long telephoneNumber) {
			this.telephoneNumber = telephoneNumber;
		}

		public int getHadicap() {
			return hadicap;
		}

		public void setHadicap(int hadicap) {
			this.hadicap = hadicap;
		}
	}

	protected abstract class StockItem {
		protected String title;
		protected Date onLoan, dateAcquired;

		public StockItem(String title, Date onLoan, Date dateAcquired) {
			this.title = title;
			this.onLoan = onLoan;
			this.dateAcquired = dateAcquired;
		}

		public void setLoan(Date loan) {
			this.onLoan = loan;
		}

		public abstract String displayDetails();
	}

	public class BookItem extends StockItem {
		private String author, isbn;

		public BookItem(String title, Date onLoan, Date dateAcquired, String author, String isbn) {
			super(title, onLoan, dateAcquired);
			this.author = author;
			this.isbn = isbn;
		}

		@Override
		public String displayDetails() {
			String data = getClass().getSimpleName() + "[" + title;
			data += "," + onLoan + "," + dateAcquired;
			data += "," + author + "," + isbn + "]";
			System.out.println(data);
			return data;
		}
	}

	public class CDItem extends StockItem {
		private String artist;
		private long playingTime;

		public CDItem(String title, Date onLoan, Date dateAcquired, String artist, long playingTime) {
			super(title, onLoan, dateAcquired);
			this.artist = artist;
			this.playingTime = playingTime;
		}

		@Override
		public String displayDetails() {
			String data = getClass().getSimpleName() + "[" + title;
			data += "," + onLoan + "," + dateAcquired;
			data += "," + artist + "," + playingTime + "]";
			System.out.println(data);
			return data;
		}
	}
}
