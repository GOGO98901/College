package me.roryclaasen;

import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;

import me.roryclaasen.oop.DisplayForm;
import me.roryclaasen.oop.OopSystem;

public class Bootstrap {
	public static void main(String[] args) {
		try {
			UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
		} catch (ClassNotFoundException | InstantiationException | IllegalAccessException | UnsupportedLookAndFeelException e) {
			e.printStackTrace();
		}
		OopSystem system = new OopSystem();
		DisplayForm form = new DisplayForm(system, 600, 350);
		form.init();
		form.show();
	}
}
