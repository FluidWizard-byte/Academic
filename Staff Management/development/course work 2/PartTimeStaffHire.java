/**
 * @author Bijay Bharati
 * @version 0.01               
 */
public class PartTimeStaffHire extends StaffHire {
    private double workingHour;
    private double wagesPerHour;
    private String staffName;
    private String joiningDate;
    private String qualification;
    private String appointedBy;
    private String shifts;
    private boolean joined;
    private boolean terminated;
    
    // Creating constructor. Constructor is also a type of method.

    public PartTimeStaffHire(int vacancyNumber, String designation, String jobType, double workingHour, double wagesPerHour, String shifts) {
        super(vacancyNumber, designation, jobType);// Super is a reference variable which in this case refers to the mentioned variables in StaffHire.
        this.workingHour = workingHour;
        this.wagesPerHour = wagesPerHour;
        this.shifts = shifts;
        staffName = "";
        joiningDate = "";
        qualification = "";
        appointedBy = "";
        joined = false;
        terminated = false;
    }
    
    // Accessor and Mutator (get and set) methods for different values.

    public double getWorkingHour() {
        return this.workingHour;
    }

    public void setWorkingHour(double workingHour) {
        this.workingHour = workingHour;
    }

    public double getWagesPerHour() {
        return this.wagesPerHour;
    }

    public void setWagesPerHour(double wagesPerHour) {
        this.wagesPerHour = wagesPerHour;
    }

    public String getShifts() {
        return this.shifts;
    }

    public void setShifts(String shifts) {
        this.shifts = shifts;
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
    
    public boolean getTerminated(boolean terminated) {
        return this.terminated;
    }

    public void setTerminated(boolean terminated) {
        this.joined = terminated;
    }

    public String shiftsUpdate(String updatedShift) {
        if (joined == true) {
            System.out.println("\n" + "The shifts are set and the staff has joined");
        } else {
            this.shifts = updatedShift;
        }
        return updatedShift; // Since the method is not void, a value must be returned, in this case it is the updated shift.
    }
    
    // Method to hire staff. first we check if the staff is hired, if not then the details are updated and joined is changed to true and terminated false.

    public void hirePartTimeStaff(String hiredStaffName, String hireDate, String hiredStaffQualification, String hiredBy) {
        if (joined == true) {
            System.out.println("\n" + "The staff has already joined");
            System.out.println("Name of staff: " + getStaffName());
            System.out.println(getStaffName() + "'s joining date: " + getJoiningDate());
        } else {
            this.staffName = hiredStaffName;
            this.joiningDate = hireDate;
            this.qualification = hiredStaffQualification;
            this.appointedBy = hiredBy;
            joined = true;
            terminated = false;
        }
    }
    
    //Method to terminate staff.If terminated is false then this method will set all values empty and change joined to false and terminated true.

    public void terminateStaff() {
        if (terminated == true) {
            System.out.println("\n" + "The staff has already been terminated");
        } else {
            this.staffName = "";
            this.joiningDate = "";
            this.qualification = "";
            this.appointedBy = "";
            joined = false;
            terminated = true;
        }

    }

    public void displayInfo() {
        System.out.println("\n" + "The details of the job are:");
        super.displayInfo();// Using super to invoke a method from parent class StaffHire.
        if (joined == true) {
            System.out.println("\n" + "The details of the staff are: " + "\n");
            System.out.println("The name of the staff is: " + getStaffName());
            System.out.println(getStaffName() + "'s wage per hour is: " + getWagesPerHour());
            System.out.println(getStaffName() + "'s working hours are: " + getWorkingHour());
            System.out.println(getStaffName() + " joined in: " + getJoiningDate());
            System.out.println(getStaffName() + "'s qualifications are: " + getQualification());
            System.out.println(getStaffName() + " was appointed by: " + getAppointedBy());
            System.out.println(getStaffName() + "'s income per day is: " + (getWorkingHour() * getWagesPerHour()));
        } else {
            System.out.println("\n" + "No staff has been hired for the job.");
        }
    }
}