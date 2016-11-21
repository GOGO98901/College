package me.roryclaasen.oop;

import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.util.Date;
import java.util.Properties;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.text.PlainDocument;

import me.roryclaasen.oop.data.Tyre;
import me.roryclaasen.oop.swing.DateLabelFormatter;
import me.roryclaasen.oop.swing.TextFieldIntFilter;

import org.jdatepicker.impl.JDatePanelImpl;
import org.jdatepicker.impl.JDatePickerImpl;
import org.jdatepicker.impl.UtilDateModel;

public class DisplayForm {
	private OopSystem system;
	private JFrame frame;

	private JTextField fieldCarReg;
	private JTextField fieldNoTyres;
	private JComboBox<Tyre.TyreCode> comboTyreCode, comboTyreType;
	private JDatePickerImpl datePicker;

	private JButton btnRecord;
	private JLabel lblTotalCost, lblTyreInStockNumber, lblTyrePriceValue;

	public DisplayForm(OopSystem system, int width, int height) {
		this.system = system;

		Dimension size = new Dimension(width, height);
		this.frame = new JFrame();
		this.frame.setMinimumSize(size);
		this.frame.setPreferredSize(size);
		this.frame.setResizable(false);
		this.frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.frame.pack();
		this.frame.setLocationRelativeTo(null);
		this.frame.setTitle("A specialist tyre company fits tyres.");
	}

	public void init() {
		frame.setLayout(null);
		int lblX = 10;
		int lblHeight = 25;
		int lblWidth = (int) (frame.getContentPane().getWidth() * 0.2);

		JLabel lblCarReg = new JLabel("Car Registration:");
		lblCarReg.setBounds(lblX, 10, lblWidth, 20);
		frame.add(lblCarReg);

		fieldCarReg = new JTextField();
		fieldCarReg.setBounds(lblCarReg.getX() + lblCarReg.getWidth() + 10, lblCarReg.getY(), lblWidth, lblHeight);
		frame.add(fieldCarReg);

		JLabel lblTyreCode = new JLabel("Tyre Code:");
		lblTyreCode.setBounds(lblX, lblCarReg.getY() + lblCarReg.getHeight() + 10, lblWidth, lblHeight);
		frame.add(lblTyreCode);

		comboTyreCode = new JComboBox<Tyre.TyreCode>(Tyre.TyreCode.values());
		comboTyreCode.setBounds(lblTyreCode.getX() + lblTyreCode.getWidth() + 10, lblTyreCode.getY(), lblWidth, lblHeight);
		frame.add(comboTyreCode);

		JLabel lblNoTyres = new JLabel("Number of Tyres:");
		lblNoTyres.setBounds(lblX, lblTyreCode.getY() + lblTyreCode.getHeight() + 10, lblWidth, lblHeight);
		frame.add(lblNoTyres);

		fieldNoTyres = new JTextField();
		fieldNoTyres.setBounds(lblNoTyres.getX() + lblNoTyres.getWidth() + 10, lblNoTyres.getY(), lblWidth, lblHeight);
		((PlainDocument) fieldNoTyres.getDocument()).setDocumentFilter(new TextFieldIntFilter());
		fieldNoTyres.getDocument().addDocumentListener(new DocumentListener() {
			public void changedUpdate(DocumentEvent e) {
				workOutCost();
			}

			public void removeUpdate(DocumentEvent e) {
				workOutCost();
			}

			public void insertUpdate(DocumentEvent e) {
				workOutCost();
			}
		});
		frame.add(fieldNoTyres);

		JLabel lblDate = new JLabel("Date of fitting:");
		lblDate.setBounds(lblX, lblNoTyres.getY() + lblNoTyres.getHeight() + 10, lblWidth, lblHeight);
		frame.add(lblDate);

		UtilDateModel model = new UtilDateModel();
		model.setValue(new Date());
		Properties props = new Properties();
		try {
			props.load(DisplayForm.class.getClassLoader().getResourceAsStream("org/jdatepicker/i18n/Text.properties"));
		} catch (IOException e) {
		}
		JDatePanelImpl datePanel = new JDatePanelImpl(model, props);
		datePicker = new JDatePickerImpl(datePanel, new DateLabelFormatter());
		datePicker.setBounds(lblDate.getX() + lblDate.getWidth() + 10, lblDate.getY(), lblWidth, lblHeight);
		frame.add(datePicker);

		btnRecord = new JButton();
		btnRecord.setText("Record Fitting");
		btnRecord.setBounds((lblX + lblWidth) * 2 + 20, 10, lblWidth, lblHeight);
		btnRecord.addActionListener(new ActionListener() {
			@SuppressWarnings("deprecation")
			@Override
			public void actionPerformed(ActionEvent e) {
				if (system.newFitting(fieldCarReg.getText(), (Tyre.TyreCode) comboTyreCode.getSelectedItem(), Integer.parseInt(fieldNoTyres.getText()), (Date) datePicker.getModel().getValue())) {
					fieldCarReg.setText("");
					fieldNoTyres.setText("0");
					Date date = new Date();
					datePicker.getModel().setDate(date.getDate(), date.getMonth(), date.getDay());
					updateTyreDetails();
				}
			}
		});
		frame.add(btnRecord);

		JLabel lblTotalCostPre = new JLabel("Total Cost:");
		lblTotalCostPre.setBounds(btnRecord.getX(), btnRecord.getY() + lblHeight + 20, btnRecord.getWidth() / 2, lblHeight);
		frame.add(lblTotalCostPre);

		lblTotalCost = new JLabel();
		lblTotalCost.setBounds(lblTotalCostPre.getX() + lblTotalCostPre.getWidth(), lblTotalCostPre.getY(), lblTotalCostPre.getWidth() * 2, lblHeight);
		frame.add(lblTotalCost);

		JLabel lblTyreType = new JLabel("Tyre type");
		lblTyreType.setBounds(lblX, lblNoTyres.getY() + (lblNoTyres.getHeight() * 4), lblNoTyres.getWidth(), lblHeight);
		frame.add(lblTyreType);

		comboTyreType = new JComboBox<Tyre.TyreCode>(Tyre.TyreCode.values());
		comboTyreType.setBounds(lblTyreType.getX() + lblTyreType.getWidth() + 10, lblTyreType.getY(), lblWidth, lblHeight);
		comboTyreType.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				updateTyreDetails();
			}
		});
		frame.add(comboTyreType);

		JLabel lblTyreInStock = new JLabel("Number in stock");
		lblTyreInStock.setBounds(lblX, lblTyreType.getY() + lblTyreType.getHeight() + 10, lblTyreType.getWidth(), lblHeight);
		frame.add(lblTyreInStock);

		lblTyreInStockNumber = new JLabel("0");
		lblTyreInStockNumber.setBounds(lblTyreInStock.getX() + lblTyreInStock.getWidth() + 10, lblTyreInStock.getY(), lblWidth, lblHeight);
		frame.add(lblTyreInStockNumber);

		JLabel lblTyrePrice = new JLabel("Price");
		lblTyrePrice.setBounds(lblX, lblTyreInStock.getY() + lblTyreInStock.getHeight() + 10, lblTyreInStock.getWidth(), lblHeight);
		frame.add(lblTyrePrice);

		lblTyrePriceValue = new JLabel("£0");
		lblTyrePriceValue.setBounds(lblTyrePrice.getX() + lblTyrePrice.getWidth() + 10, lblTyrePrice.getY(), lblWidth, lblHeight);
		frame.add(lblTyrePriceValue);

		JButton btnAddTyres = new JButton();
		btnAddTyres.setText("Add 10 tyres");
		btnAddTyres.setBounds((lblX + lblWidth) * 2 + 20, lblTyreType.getY(), lblWidth, lblHeight);
		btnAddTyres.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				system.addTyre((Tyre.TyreCode) comboTyreType.getSelectedItem(), 10);
				updateTyreDetails();
			}
		});
		frame.add(btnAddTyres);
		workOutCost();
		updateTyreDetails();
	}

	private void updateTyreDetails() {
		Tyre.TyreCode tyre = (Tyre.TyreCode) comboTyreType.getSelectedItem();
		if (tyre != null) {
			lblTyreInStockNumber.setText("" + system.getTyre(tyre).getLeftInStock());
			lblTyrePriceValue.setText("£" + tyre.getPrice());
		}
	}

	private void workOutCost() {
		Tyre.TyreCode tyre = (Tyre.TyreCode) comboTyreCode.getSelectedItem();
		if (tyre != null) {
			int noTyres = 0;
			try {
				noTyres = Integer.parseInt(fieldNoTyres.getText());
			} catch (Exception e) {
			}
			double price = tyre.getPrice() * noTyres;
			lblTotalCost.setText("£" + price);
			// System.out.println("Total cost £" + price);
		}
	}

	public void show() {
		frame.setVisible(true);
	}
}
