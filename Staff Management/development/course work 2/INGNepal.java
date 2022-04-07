
/**
 * @author Bijay Bharati
 * @version 0.01
 */
import java.awt.event.*;
import javax.swing.*;
import java.util.*;
import java.awt.*;

public class INGNepal implements ActionListener {
    ArrayList<StaffHire> staffList = new ArrayList<StaffHire>();

    JFrame frm;

    JLabel lblTitleFT, lblVacancyNumberFT, lblDesignationFT, lblJobTypeFT, lblSalaryFT, lblWorkingHoursFT, lblTitle2FT,
            lblVacancyNumber2FT, lblStaffNameFT, lblQualificationFT, lblAppointedByFT, lblJoiningDateFT,

            lblTitlePT, lblVacancyNumberPT, lblDesignationPT, lblJobTypePT, lblWorkingHoursPT, lblShiftPT,
            lblWagePerHrPT, lblTitle2PT, lblVacancyNumber2PT, lblStaffNamePT, lblQualificationPT, lblAppointedByPT,
            lblJoiningDatePT,

            lblTerminationVacancy;

    JTextField txtVacancyNumberFT, txtDesignationFT, txtSalaryFT, txtWorkingHoursFT, txtVacancyNumber2FT,
            txtStaffNameFT, txtQualificationFT, txtAppointedByFT, txtJoiningDateFT,

            txtVacancyNumberPT, txtDesignationPT, txtWorkingHoursPT, txtWagePerHrPT, txtVacancyNumber2PT,
            txtStaffNamePT, txtQualificationPT, txtAppointedByPT, txtJoiningDatePT,

            txtTerminationVacancy;

    JComboBox cmbJobTypeFT, cmbJobTypePT, cmbShiftPT;

    JButton btnAddVacancyFT, btnAppointStaffFT, btnAddVacancyPT, btnAppointStaffPT, btnDisplay, btnClear, btnTerminate;

    int vacancyNumber;
    double salary;
    double workingHour;
    String jobType;
    String designation;
    String staffName;
    String joinedOn;
    String qualification;
    String appointedBy;
    double wagePerHr;
    String shift;
    int terminationVacancy;
    boolean joined;
    boolean vacancyInUse;
    boolean terminated;

    public static void main(String[] args) {
        INGNepal form = new INGNepal();
        form.staffHireForm();
    }

    public void staffHireForm() {
        frm = new JFrame("Staff Hire");         //Frame for GUI where all the buttons, labels, text fields etx will be added
        frm.setSize(755, 535);
        frm.setLayout(null);
        frm.setVisible(true);
        frm.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        ///////////////////////////////////FULL TIME//////////////////////////////////////////////////
        lblTitleFT = new JLabel("Vacancy Full Time");     
        lblTitleFT.setBounds(295, 10, 300, 20);
        lblTitleFT.setFont(new Font("Helvetica", Font.PLAIN, 18));  
        frm.add(lblTitleFT);

        lblVacancyNumberFT = new JLabel("Vacancy Number:");
        lblVacancyNumberFT.setBounds(10, 40, 100, 20);
        lblVacancyNumberFT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblVacancyNumberFT);

        txtVacancyNumberFT = new JTextField();
        txtVacancyNumberFT.setBounds(115, 40, 150, 20);
        frm.add(txtVacancyNumberFT);

        lblDesignationFT = new JLabel("Designation:");
        lblDesignationFT.setBounds(270, 40, 100, 20);
        lblDesignationFT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblDesignationFT);

        txtDesignationFT = new JTextField();
        txtDesignationFT.setBounds(360, 40, 150, 20);
        frm.add(txtDesignationFT);

        lblJobTypeFT = new JLabel("Job Type:");
        lblJobTypeFT.setBounds(515, 40, 100, 20);
        lblJobTypeFT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblJobTypeFT);

        String jobTypeFT[] = { "Temporary", "Permanent" };
        cmbJobTypeFT = new JComboBox(jobTypeFT);
        cmbJobTypeFT.setBounds(575, 40, 150, 20);
        frm.add(cmbJobTypeFT);

        lblSalaryFT = new JLabel("Salary:");
        lblSalaryFT.setBounds(10, 75, 100, 20);
        lblSalaryFT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblSalaryFT);

        txtSalaryFT = new JTextField();
        txtSalaryFT.setBounds(115, 75, 150, 20);
        frm.add(txtSalaryFT);

        lblWorkingHoursFT = new JLabel("Working Hours:");
        lblWorkingHoursFT.setBounds(270, 75, 100, 20);
        lblWorkingHoursFT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblWorkingHoursFT);

        txtWorkingHoursFT = new JTextField();
        txtWorkingHoursFT.setBounds(360, 75, 150, 20);
        frm.add(txtWorkingHoursFT);

        btnAddVacancyFT = new JButton("Add Vacancy");
        btnAddVacancyFT.setBounds(515, 70, 210, 25);
        frm.add(btnAddVacancyFT);
        btnAddVacancyFT.addActionListener(this);
        ///////////////////////////////////FULL TIME//////////////////////////////////////////////////
        lblTitle2FT = new JLabel("Employee Full Time");
        lblTitle2FT.setBounds(295, 100, 300, 20);
        lblTitle2FT.setFont(new Font("Helvetica", Font.PLAIN, 18));
        frm.add(lblTitle2FT);

        lblVacancyNumber2FT = new JLabel("Vacancy Number:");
        lblVacancyNumber2FT.setBounds(10, 130, 100, 20);
        lblVacancyNumber2FT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblVacancyNumber2FT);

        txtVacancyNumber2FT = new JTextField();
        txtVacancyNumber2FT.setBounds(115, 130, 150, 20);
        frm.add(txtVacancyNumber2FT);

        lblStaffNameFT = new JLabel("Staff Name:");
        lblStaffNameFT.setBounds(270, 130, 100, 20);
        lblStaffNameFT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblStaffNameFT);

        txtStaffNameFT = new JTextField();
        txtStaffNameFT.setBounds(360, 130, 150, 20);
        frm.add(txtStaffNameFT);

        lblJoiningDateFT = new JLabel("Joined on:");
        lblJoiningDateFT.setBounds(515, 130, 100, 20);
        lblJoiningDateFT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblJoiningDateFT);

        txtJoiningDateFT = new JTextField();
        txtJoiningDateFT.setBounds(575, 130, 150, 20);
        frm.add(txtJoiningDateFT);

        lblQualificationFT = new JLabel("Qualification:");
        lblQualificationFT.setBounds(10, 165, 100, 20);
        lblQualificationFT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblQualificationFT);

        txtQualificationFT = new JTextField();
        txtQualificationFT.setBounds(115, 165, 150, 20);
        frm.add(txtQualificationFT);

        lblAppointedByFT = new JLabel("Appointed By:");
        lblAppointedByFT.setBounds(270, 165, 100, 20);
        lblAppointedByFT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblAppointedByFT);

        txtAppointedByFT = new JTextField();
        txtAppointedByFT.setBounds(360, 165, 150, 20);
        frm.add(txtAppointedByFT);

        btnAppointStaffFT = new JButton("Appoint Staff");
        btnAppointStaffFT.setBounds(515, 160, 210, 25);
        frm.add(btnAppointStaffFT);
        btnAppointStaffFT.addActionListener(this);
        ///////////////////////////////////FULL TIME//////////////////////////////////////////////////
        ///////////////////////////////////PART TIME//////////////////////////////////////////////////
        lblTitlePT = new JLabel("Vacancy Part Time");
        lblTitlePT.setBounds(295, 190, 300, 20);
        lblTitlePT.setFont(new Font("Helvetica", Font.PLAIN, 18));
        frm.add(lblTitlePT);

        lblVacancyNumberPT = new JLabel("Vacancy Number:");
        lblVacancyNumberPT.setBounds(10, 220, 100, 20);
        lblVacancyNumberPT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblVacancyNumberPT);

        txtVacancyNumberPT = new JTextField();
        txtVacancyNumberPT.setBounds(115, 220, 150, 20);
        frm.add(txtVacancyNumberPT);

        lblDesignationPT = new JLabel("Designation:");
        lblDesignationPT.setBounds(270, 220, 100, 20);
        lblDesignationPT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblDesignationPT);

        txtDesignationPT = new JTextField();
        txtDesignationPT.setBounds(360, 220, 150, 20);
        frm.add(txtDesignationPT);

        lblJobTypePT = new JLabel("Job Type:");
        lblJobTypePT.setBounds(515, 220, 100, 20);
        lblJobTypePT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblJobTypePT);

        String jobTypePT[] = { "Temporary", "Permanent" };
        cmbJobTypePT = new JComboBox(jobTypePT);
        cmbJobTypePT.setBounds(575, 220, 150, 20);
        frm.add(cmbJobTypePT);

        lblWorkingHoursPT = new JLabel("Working Hours:");
        lblWorkingHoursPT.setBounds(10, 255, 100, 20);
        lblWorkingHoursPT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblWorkingHoursPT);

        txtWorkingHoursPT = new JTextField();
        txtWorkingHoursPT.setBounds(115, 255, 150, 20);
        frm.add(txtWorkingHoursPT);

        lblWagePerHrPT = new JLabel("Wage Per Hour:");
        lblWagePerHrPT.setBounds(270, 255, 100, 20);
        lblWagePerHrPT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblWagePerHrPT);

        txtWagePerHrPT = new JTextField();
        txtWagePerHrPT.setBounds(360, 255, 150, 20);
        frm.add(txtWagePerHrPT);

        lblShiftPT = new JLabel("Shift:");
        lblShiftPT.setBounds(515, 255, 100, 20);
        lblShiftPT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblShiftPT);

        String shiftPT[] = { "Morning", "Day", "Evening" };
        cmbShiftPT = new JComboBox(shiftPT);
        cmbShiftPT.setBounds(575, 255, 150, 20);
        frm.add(cmbShiftPT);

        btnAddVacancyPT = new JButton("Add Vacancy");
        btnAddVacancyPT.setBounds(270, 290, 210, 25);
        frm.add(btnAddVacancyPT);
        btnAddVacancyPT.addActionListener(this);
        ///////////////////////////////////PART TIME//////////////////////////////////////////////////
        lblTitle2PT = new JLabel("Employee Part Time");
        lblTitle2PT.setBounds(295, 330, 300, 20);
        lblTitle2PT.setFont(new Font("Helvetica", Font.PLAIN, 18));
        frm.add(lblTitle2PT);

        lblVacancyNumber2PT = new JLabel("Vacancy Number:");
        lblVacancyNumber2PT.setBounds(10, 360, 100, 20);
        lblVacancyNumber2PT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblVacancyNumber2PT);

        txtVacancyNumber2PT = new JTextField();
        txtVacancyNumber2PT.setBounds(115, 360, 150, 20);
        frm.add(txtVacancyNumber2PT);

        lblStaffNamePT = new JLabel("Staff Name:");
        lblStaffNamePT.setBounds(270, 360, 100, 20);
        lblStaffNamePT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblStaffNamePT);

        txtStaffNamePT = new JTextField();
        txtStaffNamePT.setBounds(360, 360, 150, 20);
        frm.add(txtStaffNamePT);

        lblJoiningDatePT = new JLabel("Joined on:");
        lblJoiningDatePT.setBounds(515, 360, 100, 20);
        lblJoiningDatePT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblJoiningDatePT);

        txtJoiningDatePT = new JTextField();
        txtJoiningDatePT.setBounds(575, 360, 150, 20);
        frm.add(txtJoiningDatePT);

        lblQualificationPT = new JLabel("Qualification:");
        lblQualificationPT.setBounds(10, 395, 100, 20);
        lblQualificationPT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblQualificationPT);

        txtQualificationPT = new JTextField();
        txtQualificationPT.setBounds(115, 395, 150, 20);
        frm.add(txtQualificationPT);

        lblAppointedByPT = new JLabel("Appointed By:");
        lblAppointedByPT.setBounds(270, 395, 100, 20);
        lblAppointedByPT.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblAppointedByPT);

        txtAppointedByPT = new JTextField();
        txtAppointedByPT.setBounds(360, 395, 150, 20);
        frm.add(txtAppointedByPT);

        btnAppointStaffPT = new JButton("Appoint Staff");
        btnAppointStaffPT.setBounds(515, 390, 210, 25);
        frm.add(btnAppointStaffPT);
        btnAppointStaffPT.addActionListener(this);
        ///////////////////////////////////PART TIME//////////////////////////////////////////////////
        ///////////////////////////////////DISPLAY CLEAR TERMINATE////////////////////////////////////
        btnDisplay = new JButton("Display");
        btnDisplay.setBounds(25, 430, 210, 50);
        frm.add(btnDisplay);
        btnDisplay.addActionListener(this);

        btnClear = new JButton("Clear");
        btnClear.setBounds(275, 430, 210, 50);
        frm.add(btnClear);
        btnClear.addActionListener(this);

        lblTerminationVacancy = new JLabel("TerminationVac:");
        lblTerminationVacancy.setBounds(515, 430, 100, 20);
        lblTerminationVacancy.setFont(new Font("sans", Font.PLAIN, 12));
        frm.add(lblTerminationVacancy);

        txtTerminationVacancy = new JTextField();
        txtTerminationVacancy.setBounds(610, 430, 115, 20);
        frm.add(txtTerminationVacancy);

        btnTerminate = new JButton("Terminate");
        btnTerminate.setBounds(515, 455, 210, 25);
        frm.add(btnTerminate);
        btnTerminate.addActionListener(this);
        ///////////////////////////////////DISPLAY CLEAR TERMINATE/////////////////////////////////////
    }

    public void actionPerformed(ActionEvent click) {

        if (click.getSource() == btnClear) {
            txtVacancyNumberFT.setText("");
            txtDesignationFT.setText("");
            txtSalaryFT.setText("");
            txtWorkingHoursFT.setText("");
            txtVacancyNumber2FT.setText("");
            txtStaffNameFT.setText("");
            txtQualificationFT.setText("");
            txtAppointedByFT.setText("");
            txtJoiningDateFT.setText("");
            txtVacancyNumberPT.setText("");
            txtDesignationPT.setText("");
            txtWorkingHoursPT.setText("");
            txtWagePerHrPT.setText("");
            txtVacancyNumber2PT.setText("");
            txtStaffNamePT.setText("");
            txtQualificationPT.setText("");
            txtAppointedByPT.setText("");
            txtJoiningDatePT.setText("");
            txtTerminationVacancy.setText("");
            cmbJobTypeFT.setSelectedIndex(0);
            cmbJobTypePT.setSelectedIndex(0);
            cmbShiftPT.setSelectedIndex(0);
        }

        if (click.getSource() == btnAddVacancyFT) {
            try {
                // extracting values
                vacancyNumber = Integer.parseInt(txtVacancyNumberFT.getText());// parse int because we extract the value
                                                          // as String from the form
                designation = txtDesignationFT.getText();
                jobType = (cmbJobTypeFT.getSelectedItem()).toString();
                salary = Double.parseDouble(txtSalaryFT.getText());
                workingHour = Double.parseDouble(txtWorkingHoursFT.getText());
                vacancyInUse = false;
                // checking if vacancy number is already in use or not
                if (designation.equals("")) {
                    JOptionPane.showMessageDialog(frm, "Make sure to input proper values in all the fields.");
                } else {
                    for (StaffHire obj : staffList) {
                        if (obj.getVacancyNumber() == vacancyNumber) {
                            vacancyInUse = true;
                            break;
                        }
                    }
                    if (vacancyInUse == false) {
                        FullTimeStaffHire obj = new FullTimeStaffHire(vacancyNumber, designation, jobType, salary,
                                workingHour);
                        staffList.add(obj);
                        JOptionPane.showMessageDialog(frm,
                                "Vacancy " + vacancyNumber + " added Total: " + staffList.size());
                    } else {
                        JOptionPane.showMessageDialog(frm,
                                "Vacancy " + vacancyNumber + " already in use Total: " + staffList.size());
                    }
                }
            } catch (Exception exp) {
                JOptionPane.showMessageDialog(frm, "Make sure to input proper values in all the fields.");
            }
        }

        if (click.getSource() == btnAppointStaffFT) {
            try {
                vacancyNumber = Integer.parseInt(txtVacancyNumber2FT.getText());
                staffName = txtStaffNameFT.getText();
                joinedOn = txtJoiningDateFT.getText();
                qualification = txtQualificationFT.getText();
                appointedBy = txtAppointedByFT.getText();
                joined = false;
                vacancyInUse = false;
                // staffList is an object of StaffHire
                if (staffName.equals("") || joinedOn.equals("") || qualification.equals("") || appointedBy.equals("")) {
                 JOptionPane.showMessageDialog(frm, "Make sure to input proper values in all the fields.");
                } else {
                    for (StaffHire obj : staffList) {
                        if (obj.getVacancyNumber() == vacancyNumber) {
                            vacancyInUse = true; // vacancyInUse is set to true if vacancy number is already in the
                                        //  vacancy number is already in the list
                            if (obj instanceof FullTimeStaffHire) {// instanceof is used to check if the boject belongs
                                                  // to FullTimeStaffHire
                                FullTimeStaffHire call = (FullTimeStaffHire) obj; // typecasting to object of
                                                         // FullTimeStaffHire to call method
                                                        // to hire staff
                                if (call.getJoined(joined) == true) {
                                    JOptionPane.showMessageDialog(frm, "Staff has been already hired");
                                } else {
                                    call.hireFullTimeStaff(staffName, joinedOn, qualification, appointedBy);
                                    JOptionPane.showMessageDialog(frm, "Staff successfully appointed.");
                                    break;
                                }
                            } else {
                                JOptionPane.showMessageDialog(frm, "Vacancy " + vacancyNumber
                                        + " belongs to PART TIME, use a vacancy that belongs to FULL TIME");
                            }
                        }
                    }
                    if (!vacancyInUse) {
                        JOptionPane.showMessageDialog(frm, "The vacancy you provided does not exist, try again");
                    }
                }
            } catch (Exception exp1) {
                JOptionPane.showMessageDialog(frm, "Make sure to input proper values in all the fields.");
            }
        }

        if (click.getSource() == btnAddVacancyPT) {
            try {
                vacancyNumber = Integer.parseInt(txtVacancyNumberPT.getText());
                designation = txtDesignationPT.getText();
                jobType = (cmbJobTypePT.getSelectedItem()).toString();
                workingHour = Double.parseDouble(txtWorkingHoursPT.getText());
                wagePerHr = Double.parseDouble(txtWagePerHrPT.getText());
                shift = (cmbShiftPT.getSelectedItem()).toString();
                vacancyInUse = false;
                if (designation.equals("")) {
                    JOptionPane.showMessageDialog(frm, "Make sure to input proper values in all the fields.");
                } else {
                    for (StaffHire obj : staffList) {
                        if (obj.getVacancyNumber() == vacancyNumber) {
                            vacancyInUse = true;
                            break;
                        }
                    }
                    if (vacancyInUse == false) {
                        PartTimeStaffHire obj = new PartTimeStaffHire(vacancyNumber, designation, jobType, workingHour,
                                wagePerHr, shift);
                        staffList.add(obj);
                        JOptionPane.showMessageDialog(frm,
                                "Vacancy " + vacancyNumber + " added Total: " + staffList.size());
                    } else {
                        JOptionPane.showMessageDialog(frm,
                                "Vacancy " + vacancyNumber + " already in use Total: " + staffList.size());
                    }
                }
            } catch (Exception exp2) {
                JOptionPane.showMessageDialog(frm, "Make sure to input proper values in all the fields.");
            }
        }

        if (click.getSource() == btnAppointStaffPT) {
            try {
                vacancyNumber = Integer.parseInt(txtVacancyNumber2PT.getText());
                staffName = txtStaffNamePT.getText();
                joinedOn = txtJoiningDatePT.getText();
                qualification = txtQualificationPT.getText();
                appointedBy = txtAppointedByPT.getText();
                joined = false;
                vacancyInUse = false;
                if (staffName.equals("") || joinedOn.equals("") || qualification.equals("") || appointedBy.equals("")) {
                    JOptionPane.showMessageDialog(frm, "Make sure to input proper values in all the fields.");
                } else {
                    for (StaffHire obj : staffList) {
                        if (obj.getVacancyNumber() == vacancyNumber) {
                            vacancyInUse = true;
                            if (obj instanceof PartTimeStaffHire) {
                                PartTimeStaffHire call = (PartTimeStaffHire) obj;
                                if (call.getJoined(joined) == true) {
                                    JOptionPane.showMessageDialog(frm, "Staff has been already hired");
                                } else {
                                    call.hirePartTimeStaff(staffName, joinedOn, qualification, appointedBy);
                                    JOptionPane.showMessageDialog(frm, "Staff successfully appointed.");
                                    break;
                                }
                            } else {
                                JOptionPane.showMessageDialog(frm, "Vacancy " + vacancyNumber
                                        + " belongs to FULL TIME, use a vacancy that belongs to PART TIME");
                            }
                        }
                    }
                    if (!vacancyInUse) {
                        JOptionPane.showMessageDialog(frm, "The vacancy you provided does not exist, try again");
                    }
                }
            } catch (Exception exp3) {
                JOptionPane.showMessageDialog(frm, "Make sure to input proper values in all the fields.");
            }
        }

        if (click.getSource() == btnTerminate) {
            try {
                terminationVacancy = Integer.parseInt(txtTerminationVacancy.getText());
                joined = true;
                terminated = false;
                vacancyInUse = false;
                for (StaffHire obj : staffList) {
                    if (obj.getVacancyNumber() == terminationVacancy) {
                        vacancyInUse = true;

                        if (obj instanceof PartTimeStaffHire) {
                            PartTimeStaffHire call = (PartTimeStaffHire) obj;
                            if (call.getTerminated(terminated) == false && call.getJoined(joined) == true) {//a staff who has joined but not terminated can be
                                                                                                            //terminated
                                call.terminateStaff();
                                JOptionPane.showMessageDialog(frm, "Staff terminated");
                            } else {
                                JOptionPane.showMessageDialog(frm,
                                        "No staff has been hired to Vacancy " + terminationVacancy
                                        + " or does not belong to PART TIME or has been terminated ");
                            }
                        } else {
                            JOptionPane.showMessageDialog(frm, "No staff has been hired to Vacancy "
                                    + terminationVacancy + " or does not belong to PART TIME or has been terminated ");
                        }
                    }
                }
                if (!vacancyInUse) {
                    JOptionPane.showMessageDialog(frm, "The vacancy you provided does not exist, try again");
                }
            } catch (Exception exp4) {
                JOptionPane.showMessageDialog(frm, "Make sure to input proper values in all the fields.");
            }
        }

        if (click.getSource() == btnDisplay) {
            if (staffList.size() == 0) {
                JOptionPane.showMessageDialog(frm, "No data to show");
            } else {
                for (StaffHire obj : staffList) {
                    if (obj instanceof FullTimeStaffHire) {
                        System.out.println("*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*");
                        System.out.println("\n" + "Full Time Staff Details" + "\n");
                        System.out.println("*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*");
                        FullTimeStaffHire call = (FullTimeStaffHire) obj;
                        call.displayInfo();
                    }
                    if (obj instanceof PartTimeStaffHire) {
                        System.out.println("*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*");
                        System.out.println("\n" + "Part Time Staff Details" + "\n");
                        System.out.println("*_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*");
                        PartTimeStaffHire call = (PartTimeStaffHire) obj;
                        call.displayInfo();
                    }
                }
            }
        }
    }
}