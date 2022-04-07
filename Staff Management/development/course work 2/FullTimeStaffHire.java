/**
 * @author Bijay Bharati
 * @version 0.01
 */
public class FullTimeStaffHire extends StaffHire {
    private double salary;
    private double workingHour;
    private String staffName;
    private String joiningDate;
    private String qualification;
    private String appointedBy;
    private boolean joined;
    
    // Creating constructor. Constructor is also a type of method.
    
    public FullTimeStaffHire(int vacancyNumber, String designation, String jobType, double salary, double workingHour) {
        super(vacancyNumber, designation, jobType);// Super is a reference variable which in this case refers to the mentioned variables in StaffHire.      
        this.salary = salary;
        this.workingHour = workingHour;
        staffName = "";
        joiningDate = "";
        qualification = "";
        appointedBy = "";
        joined = false;
    }

    // Accessor and Mutator (get and set) methods for different values.
    
    public double getSalary() {
        return this.salary;
    }

    public void setSalary(double salary) {
        this.salary = salary;
    }

    public double getWorkingHour() {
        return this.workingHour;
    }

    public void setWorkingHour(double workingHour) {
        this.workingHour = workingHour;
    }

    public String getStaffName() {
        return this.staffName;
    }

    public void setStaffName(String staffName) {
        this.staffName = staffName;
    }

    public String getJoiningDate() {
        return this.joiningDate;
    }

    public void setJoiningDate(String joiningDate) {
        this.joiningDate = joiningDate;
    }

    public String getQualification() {
        return this.qualification;
    }

    public void setQualification(String qualification) {
        this.qualification = qualification;
    }

    public String getAppointedBy() {
        return this.appointedBy;
    }

    public void setAppointedBy(String appointedBy) {
        this.appointedBy = appointedBy;
    }
    
    public boolean getJoined(boolean joined) {
        return this.joined;
    }

    public void setJoined(boolean joined) {
        this.joined = joined;
    }

    // Method to update salary and return the updated value.
    
    public double salaryUpdate(double updatedSalary) {
        if (joined == true) {
            System.out.println("\n"+"The salary is already set and the staff has joined.");
        } else {
            this.salary = updatedSalary;

        }
        return updatedSalary; // Since the method is not void, a value must be returned, in this case it is the updated salary.
    }

    public double workingHourUpdate(double updatedWorkingHour) {
        
            this.workingHour = updatedWorkingHour;
        
        return updatedWorkingHour;
    }

    // Method to hire staff. first we check if the staff is hired, if not then the details are updated and joined is changed to true.
    
    public void hireFullTimeStaff(String hiredStaffName, String hireDate, String hiredStaffQualification, String hiredBy) {
        if (joined==true) {
            System.out.println("\n"+"The staff has already joined");
            System.out.println("Name of staff: " + getStaffName());
            System.out.println(getStaffName() + "'s joining date: " + getJoiningDate());
        } else {
            this.staffName = hiredStaffName;
            this.joiningDate = hireDate;
            this.qualification = hiredStaffQualification;
            this.appointedBy = hiredBy;
            joined = true;
        }
    }

    public void displayInfo() {
        System.out.println("\n"+"The details of the job are:");
        super.displayInfo(); // Using super to invoke a method from parent class StaffHire.
        if (joined==true) {
            System.out.println("\n"+"The details of the staff are: "+"\n");
            System.out.println("The name of the staff is: " + getStaffName());
            System.out.println(getStaffName() + "'s salary is: " + getSalary());
            System.out.println(getStaffName() + "'s working hours are: " + getWorkingHour());
            System.out.println(getStaffName() + " joined in: " + getJoiningDate());
            System.out.println(getStaffName() + "'s qualifications are: " + getQualification());
            System.out.println(getStaffName() + " was appointed by: " + getAppointedBy());
        } else {
            System.out.println("\n"+"No staff has been hired for the job.");
        }
    }
}